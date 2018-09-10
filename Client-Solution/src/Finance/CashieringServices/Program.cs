using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace CashieringServices
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

                    //if (userAccess == 1)
                    //{
                    //    userInfo.UserName = "AdminAccess";
                    //    userInfo.Password = "?@ssw0rd";
                    //}

                    Boolean isExpired = false;

                    if (remClient.AuthenticateSystemUser(ref userInfo, ref isExpired))
                    {
                        userInfo.NetworkInformation = BaseServices.ProcStatic.GetNetworkInformation();

                        //Int32 process = 1;

                        //if (process == 1)
                        //{
                        //    try
                        //    {
                        //        Application.Run(new CashieringManager(userInfo));
                        //    }
                        //    catch (Exception ex)
                        //    {
                        //        BaseServices.ProcStatic.ShowErrorDialog(ex.Message, "Error Loading");
                        //    }
                        //}
                        //else if (process == 2)
                        //{
                        //    try
                        //    {
                        //        CashieringLogic cashieringManager = new CashieringLogic(userInfo);

                        //        BaseServices.BaseServicesLogic.ReceiptDate = DateTime.Parse(cashieringManager.ServerDateTime).ToShortDateString() + " 12:00:00 AM";

                        //        Application.Run(new MiscellaneousIncome(userInfo, cashieringManager));
                        //    }
                        //    catch (Exception ex)
                        //    {
                        //        BaseServices.ProcStatic.ShowErrorDialog(ex.Message, "Error Loading");
                        //    }
                        //}
                        //else if (process == 3)
                        //{
                        //    try
                        //    {
                        //        CashieringLogic cashieringManager = new CashieringLogic(userInfo);

                        //        BaseServices.BaseServicesLogic.ReceiptDate = DateTime.Parse(cashieringManager.ServerDateTime).ToShortDateString() + " 12:00:00 AM";

                        //        Application.Run(new CashReceiptReportControl(userInfo, cashieringManager));
                        //    }
                        //    catch (Exception ex)
                        //    {
                        //        BaseServices.ProcStatic.ShowErrorDialog(ex.Message, "Error Loading");
                        //    }
                        //}
                        //else if (process == 4)
                        //{
                        //    try
                        //    {
                        //        CashieringLogic cashieringManager = new CashieringLogic(userInfo);

                        //        Application.Run(new RegularLoanMultiplePayment(userInfo, cashieringManager));
                        //    }
                        //    catch (Exception ex)
                        //    {
                        //        BaseServices.ProcStatic.ShowErrorDialog(ex.Message, "Error Loading");
                        //    }
                        //}

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