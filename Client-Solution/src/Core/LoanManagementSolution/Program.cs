using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data;
using System.Diagnostics;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace LoanManagementSolution
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Looking for running instance
            Process runningInstance = ProcessInstance.GetRunningInstance();

            //if (runningInstance != null)
            //{
            //    BaseServices.ProcStatic.ShowErrorDialog("Loan Management System is already running.", "Error");
            //}
            //else
            //{
                //sets the user information
                CommonExchange.SysAccess userInfo = new CommonExchange.SysAccess();
                //--------------------------

                try
                {
                    //registers the tcp channel
                    TcpChannel channel = new TcpChannel();
                    ChannelServices.RegisterChannel(channel, false);
                    //--------------------------

                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);

                    Int32 startIndex = 1;

                    if (startIndex == 1)
                    {
                        Boolean hasAccess = false;

                        using (SystemLogIn frmLogIn = new SystemLogIn())
                        {
                            frmLogIn.ShowDialog();

                            if (frmLogIn.HasAccess)
                            {
                                hasAccess = true;
                                userInfo = frmLogIn.UserInformation;
                            }
                        }

                        if (hasAccess)
                        {
                            Application.Run(new LMSManager(userInfo));
                        }
                    }
                    else if (startIndex == 2)
                    {
                        //gets the user information
                        using (RemoteClient.RemCntAdministratorManager remClient = new RemoteClient.RemCntAdministratorManager())
                        {
                            Int32 userAccess = 1;

                            if (userAccess == 1)
                            {
                                userInfo.UserName = "AdminAccess";
                                userInfo.Password = "?@ssw0rd";
                            }

                            Boolean isExpired = false;

                            if (remClient.AuthenticateSystemUser(ref userInfo, ref isExpired))
                            {
                                userInfo.NetworkInformation = BaseServices.ProcStatic.GetNetworkInformation();

                                Int32 process = 1;

                                if (process == 1)
                                {
                                    try
                                    {
                                        Application.Run(new LMSManager(userInfo));
                                    }
                                    catch (Exception ex)
                                    {
                                        BaseServices.ProcStatic.ShowErrorDialog(ex.Message, "Error Loading");
                                    }
                                }
                            }
                        }//-------------------------
                    }
                }
                catch (Exception err)
                {
                    BaseServices.ProcStatic.ShowErrorDialog(err.Message, "System Error");
                }
                finally
                {
                    Application.Exit();
                }
            //}
        }
    }
}