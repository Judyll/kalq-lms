using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace DisbursementVoucherServices
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                //registers the tcp channel
                TcpChannel channel = new TcpChannel();
                ChannelServices.RegisterChannel(channel, false);
                //--------------------------               

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                //gets the user information
                using (RemoteClient.RemCntAdministratorManager remClient = new RemoteClient.RemCntAdministratorManager())
                {
                    //sets the user information
                    CommonExchange.SysAccess userInfo = new CommonExchange.SysAccess();
                    //--------------------------

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

                        Int32 process = 2;

                        if (process == 1)
                        {
                            DisbursementVoucherLogic disbursementManager = new DisbursementVoucherLogic(userInfo);

                            Application.Run(new DisbursementVoucher(userInfo, disbursementManager));
                        }
                        else if (process == 2)
                        {
                            Application.Run(new DisbursementManager(userInfo));
                        }
                        else if (process == 3)
                        {
                            DisbursementVoucherLogic disbursementManager = new DisbursementVoucherLogic(userInfo);

                            Application.Run(new DisbursementVoucherRecord(userInfo, disbursementManager));
                        }
                    }
                }//-------------------------
            }
            catch (Exception err)
            {
                BaseServices.ProcStatic.ShowErrorDialog(err.Message, "System Error");
            }
            finally
            {
                Application.Exit();
            }
        }
    }
}