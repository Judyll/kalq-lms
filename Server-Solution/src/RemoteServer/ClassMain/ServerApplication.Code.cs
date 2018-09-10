using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Windows.Forms;

namespace RemoteServer
{
    partial class ServerApplication
    {
        #region Class General Variable Declarations
        private Boolean _isClosed = false;
        #endregion

        #region Class Constructor
        public ServerApplication()
        {
            InitializeComponent();

            //register an event handler
            this.Load += new EventHandler(ClassLoad);
            this.FormClosing += new FormClosingEventHandler(ClassClosing);
            this.KeyUp += new KeyEventHandler(ClassKeyUp);
            //----------------------------------
        }
        #endregion

        #region Class Event Void Procedures
        //###############################CLASS CFBMain EVENTS#########################################################
        //event is raised when the class is loaded
        private void ClassLoad(object sender, EventArgs e)
        {
            this.lblVersion.Text = "Version " + Application.ProductVersion;

            //creates an instance of the channel
            TcpChannel channel = new TcpChannel(6080);
            ChannelServices.RegisterChannel(channel, false);
            //-----------------------------

            //register the classes
            this.RegRemSrvBinaryUpdater();
            this.RegRemSrvAdministratorManager();
            this.RegRemSrvBaseManager();
            this.RegRemSrvMemberManager();
            this.RegRemSrvLoanManager();
            this.RegRemSrvCashieringManager();
            this.RegRemSrvAccountingManager();
            //-----------------------

        } //--------------------------------

        //event is raised when the class is closing
        private void ClassClosing(object sender, FormClosingEventArgs e)
        {
            if (!_isClosed)
            {
                e.Cancel = true;
            }
        } //------------------------------

        //event is raised when the key is up
        private void ClassKeyUp(object sender, KeyEventArgs e)
        {
            if ((e.Shift == true && e.Control == true &&
                e.Alt == true && e.KeyCode == Keys.F10))
            {
                _isClosed = true;
                this.Close();
            }
            else
            {
                e.Handled = true;
            }
        }
        //###############################END CLASS CFBMain EVENTS######################################################
        #endregion

        #region Programmer-Defined Void Procedures

        //this procedure registeres the RemSrvBinaryUpdater Class
        private void RegRemSrvBinaryUpdater()
        {
            //register as an available service --> Class: RemSrvBinaryUpdater Method: SelectLMSBinaries
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvBinaryUpdater), "SelectLMSBinaries",
                WellKnownObjectMode.SingleCall);
            //-----------------------------

        } //------------------------------------------

        //this procedure registers the RemSrvAdministratorManager Class
        private void RegRemSrvAdministratorManager()
        {
            //register as an available service --> Class: RemSrvAdministratorManager Method: InsertSystemUserInfo
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvAdministratorManager), "InsertSystemUserInfo",
                WellKnownObjectMode.SingleCall);
            //-----------------------------

            //register as an available service --> Class: RemSrvAdministratorManager Method: UpdateSystemUserInfo
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvAdministratorManager), "UpdateSystemUserInfo",
                WellKnownObjectMode.SingleCall);
            //-----------------------------

            //register as an available service --> Class: RemSrvAdministratorManager Method: SelectBySystemUserIDSystemUserInfo
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvAdministratorManager), "SelectBySystemUserIDSystemUserInfo",
                WellKnownObjectMode.SingleCall);
            //-----------------------------

            //register as an available service --> Class: RemSrvAdministratorManager Method: SelectBySysIDPersonSystemUserInfo
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvAdministratorManager), "SelectBySysIDPersonSystemUserInfo",
                WellKnownObjectMode.SingleCall);
            //-----------------------------

            //register as an available service --> Class: RemSrvAdministratorManager Method: SelectSystemUserInfo
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvAdministratorManager), "SelectSystemUserInfo",
                WellKnownObjectMode.SingleCall);
            //-----------------------------

            //register as an available service --> Class: RemSrvAdministratorManager Method: AuthenticateSystemUser
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvAdministratorManager), "AuthenticateSystemUser",
                WellKnownObjectMode.SingleCall);
            //-----------------------------

            //register as an available service --> Class: RemSrvAdministratorManager Method: SelectTransactionLog
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvAdministratorManager), "SelectTransactionLog",
                WellKnownObjectMode.SingleCall);
            //-----------------------------

            //register as an available service --> Class: RemSrvAdministratorManager Method: IsExistsNameSystemUserInformation
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvAdministratorManager), "IsExistsNameSystemUserInformation",
                WellKnownObjectMode.SingleCall);
            //-----------------------------

            //register as an available service --> Class: RemSrvAdministratorManager Method: GetDataSetForAdministrator
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvAdministratorManager), "GetDataSetForAdministrator",
                WellKnownObjectMode.SingleCall);
            //-----------------------------

        } //-----------------------------------

        //this procedure registers the RemSrvBaseManager Class
        private void RegRemSrvBaseManager()
        {
            //register as an available service --> Class: RemSrvBaseManager Method: InsertOfficeEmployerInformation
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvBaseManager), "InsertOfficeEmployerInformation",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvBaseManager Method: UpdateOfficeEmployerInformation
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvBaseManager), "UpdateOfficeEmployerInformation",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvBaseManager Method: DeleteOfficeEmployerInformation
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvBaseManager), "DeleteOfficeEmployerInformation",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvBaseManager Method: InsertUpdatePersonInformation
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvBaseManager), "InsertUpdatePersonInformation",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvBaseManager Method: InsertUpdatePersonInformationNoAuthenticate
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvBaseManager), "InsertUpdatePersonInformationNoAuthenticate",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvBaseManager Method: InsertUpdateDeletePersonDocument
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvBaseManager), "InsertUpdateDeletePersonDocument",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvBaseManager Method: SelectOfficeEmployerInformation
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvBaseManager), "SelectOfficeEmployerInformation",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvBaseManager Method: SelectPersonInformation
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvBaseManager), "SelectPersonInformation",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvBaseManager Method: SelectBySysIDPersonInformation
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvBaseManager), "SelectBySysIDPersonInformation",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvBaseManager Method: SelectBySysIDPersonInformationNoAuthenticate
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvBaseManager), "SelectBySysIDPersonInformationNoAuthenticate",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvBaseManager Method: SelectBySysIDPersonListPersonDocument
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvBaseManager), "SelectBySysIDPersonListPersonDocument",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvBaseManager Method: GetServerDateTime
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvBaseManager), "GetServerDateTime",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvBaseManager Method: GetServerDateTimeNoAuthenticate
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvBaseManager), "GetServerDateTimeNoAuthenticate",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvBaseManager Method: IsExistsNameOfficeEmployerInformation
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvBaseManager), "IsExistsNameOfficeEmployerInformation",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvBaseManager Method: IsExistsAcronymOfficeEmployerInformation
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvBaseManager), "IsExistsAcronymOfficeEmployerInformation",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvBaseManager Method: IsExistsSysIDPersonMemberCollectorInformation
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvBaseManager), "IsExistsSysIDPersonMemberCollectorInformation",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvBaseManager Method: IsExistsSysIDPersonOriginalNamePersonDocument
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvBaseManager), "IsExistsSysIDPersonOriginalNamePersonDocument",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvBaseManager Method: GetDataSetForBaseManager
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvBaseManager), "GetDataSetForBaseManager",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

        } //-----------------------------------

        //this procedure registers the RemSrvMemberManager Class
        private void RegRemSrvMemberManager()
        {
            //register as an available service --> Class: RemSrvMemberManager Method: InsertMemberInformation
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvMemberManager), "InsertMemberInformation",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvMemberManager Method: UpdateMemberInformation
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvMemberManager), "UpdateMemberInformation",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvMemberManager Method: InsertCollectorInformation
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvMemberManager), "InsertCollectorInformation",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvMemberManager Method: UpdateCollectorInformation
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvMemberManager), "UpdateCollectorInformation",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvMemberManager Method: SelectCountForMemberIDMemberInformation
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvMemberManager), "SelectCountForMemberIDMemberInformation",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvMemberManager Method: SelectMemberInformation
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvMemberManager), "SelectMemberInformation",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvMemberManager Method: SelectCollectorInformation
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvMemberManager), "SelectCollectorInformation",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvMemberManager Method: SelectByQueryStringMemberEmployeeInformation
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvMemberManager), "SelectByQueryStringMemberEmployeeInformation",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvMemberManager Method: SelectByMemberIDMemberInformation
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvMemberManager), "SelectByMemberIDMemberInformation",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvMemberManager Method: SelectBySysIDPersonMemberInformation
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvMemberManager), "SelectBySysIDPersonMemberInformation",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvMemberManager Method: SelectByEmployeeIDCollectorInformation
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvMemberManager), "SelectByEmployeeIDCollectorInformation",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvMemberManager Method: SelectBySysIDPersonCollectorInformation
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvMemberManager), "SelectBySysIDPersonCollectorInformation",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvMemberManager Method: IsExistsMemberIDMemberInformation
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvMemberManager), "IsExistsMemberIDMemberInformation",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvMemberManager Method: GetDataSetForMemberManager
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvMemberManager), "GetDataSetForMemberManager",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 
            
        } //---------------------------------

        //this procedure registers the RemSrvLoanManager Class
        private void RegRemSrvLoanManager()
        {
            //register as an available service --> Class: RemSrvLoanManager Method: InsertRegularLoanInformation
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvLoanManager), "InsertRegularLoanInformation",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvLoanManager Method: UpdateRegularLoanInformation
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvLoanManager), "UpdateRegularLoanInformation",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvLoanManager Method: DeleteRegularLoanInformation
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvLoanManager), "DeleteRegularLoanInformation",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvLoanManager Method: InsertUpdateDeleteRegularLoanDocument
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvLoanManager), "InsertUpdateDeleteRegularLoanDocument",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvLoanManager Method: InsertCollateralInformation
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvLoanManager), "InsertCollateralInformation",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvLoanManager Method: UpdateCollateralInformation
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvLoanManager), "UpdateCollateralInformation",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvLoanManager Method: DeleteCollateralInformation
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvLoanManager), "DeleteCollateralInformation",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvLoanManager Method: InsertDeleteRegularLoanCollateral
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvLoanManager), "InsertDeleteRegularLoanCollateral",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvLoanManager Method: InsertUpdateDeleteRegularLoanCoMaker
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvLoanManager), "InsertUpdateDeleteRegularLoanCoMaker",
                WellKnownObjectMode.SingleCall);
                //----------------------------- 

                //register as an available service --> Class: RemSrvLoanManager Method: InsertUpdateDeleteRegularLoanAmortization
                RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvLoanManager), "InsertUpdateDeleteRegularLoanAmortization",
                    WellKnownObjectMode.SingleCall);
                //----------------------------- 

            //register as an available service --> Class: RemSrvLoanManager Method: SelectCountForAccountNoRegularLoanInformation
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvLoanManager), "SelectCountForAccountNoRegularLoanInformation",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvLoanManager Method: SelectBySysIDMemberListRegularLoanInformation
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvLoanManager), "SelectBySysIDMemberListRegularLoanInformation",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvLoanManager Method: SelectBySysIDRegularLoanInformation
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvLoanManager), "SelectBySysIDRegularLoanInformation",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvLoanManager Method: SelectBySysIDRegularListRegularLoanDocument
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvLoanManager), "SelectBySysIDRegularListRegularLoanDocument",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvLoanManager Method: SelectCollateralInformation
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvLoanManager), "SelectCollateralInformation",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvLoanManager Method: SelectBySysIDRegularListRegularLoanCollateral
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvLoanManager), "SelectBySysIDRegularListRegularLoanCollateral",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvLoanManager Method: SelectBySysIDRegularListRegularLoanCoMaker
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvLoanManager), "SelectBySysIDRegularListRegularLoanCoMaker",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvLoanManager Method: IsExistsAccountNoRegularLoanInformation
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvLoanManager), "IsExistsAccountNoRegularLoanInformation",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvLoanManager Method: IsExistsSysIDRegularOriginalNameRegularLoanDocument
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvLoanManager), "IsExistsSysIDRegularOriginalNameRegularLoanDocument",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvLoanManager Method: IsExistsPaymentDateFromToGracePeriodRegularLoanAmortization
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvLoanManager), 
                "IsExistsPaymentDateFromToGracePeriodRegularLoanAmortization", WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvLoanManager Method: IsExistsChargeRegularLoanCharges
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvLoanManager),
                "IsExistsChargeRegularLoanCharges", WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvLoanManager Method: IsExistsChargeRegularLoanAdditions
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvLoanManager),
                "IsExistsChargeRegularLoanAdditions", WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvLoanManager Method: GetDataSetForLoanManager
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvLoanManager),
                "GetDataSetForLoanManager", WellKnownObjectMode.SingleCall);
            //----------------------------- 

        } //---------------------------------

        //this procedure registers the RemSrvCashieringManager Class
        private void RegRemSrvCashieringManager()
        {
            //register as an available service --> Class: RemSrvCashieringManager Method: InsertBreakdownBankDeposit
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvCashieringManager), "InsertBreakdownBankDeposit",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvCashieringManager Method: UpdateBreakdownBankDeposit
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvCashieringManager), "UpdateBreakdownBankDeposit",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvCashieringManager Method: DeleteBreakdownBankDeposit
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvCashieringManager), "DeleteBreakdownBankDeposit",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvCashieringManager Method: InsertMiscellaneousIncome
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvCashieringManager), "InsertMiscellaneousIncome",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvCashieringManager Method: UpdateMiscellaneousIncome
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvCashieringManager), "UpdateMiscellaneousIncome",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvCashieringManager Method: DeleteMiscellaneousIncome
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvCashieringManager), "DeleteMiscellaneousIncome",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvCashieringManager Method: InsertInHouseHospitalizationCredit
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvCashieringManager), "InsertInHouseHospitalizationCredit",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvCashieringManager Method: UpdateInHouseHospitalizationCredit
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvCashieringManager), "UpdateInHouseHospitalizationCredit",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvCashieringManager Method: DeleteInHouseHospitalizationCredit
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvCashieringManager), "DeleteInHouseHospitalizationCredit",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvCashieringManager Method: InsertUpdateDeleteInHouseHospitalizationCredit
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvCashieringManager), "InsertUpdateDeleteInHouseHospitalizationCredit",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvCashieringManager Method: InsertShareCapitalCredit
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvCashieringManager), "InsertShareCapitalCredit",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvCashieringManager Method: UpdateShareCapitalCredit
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvCashieringManager), "UpdateShareCapitalCredit",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvCashieringManager Method: DeleteShareCapitalCredit
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvCashieringManager), "DeleteShareCapitalCredit",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvCashieringManager Method: InsertUpdateDeleteShareCapitalCredit
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvCashieringManager), "InsertUpdateDeleteShareCapitalCredit",
                WellKnownObjectMode.SingleCall);
            //-----------------------------

            //register as an available service --> Class: RemSrvCashieringManager Method: InsertMemberEquityCredit
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvCashieringManager), "InsertMemberEquityCredit",
                WellKnownObjectMode.SingleCall);
            //-----------------------------

            //register as an available service --> Class: RemSrvCashieringManager Method: UpdateMemberEquityCredit
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvCashieringManager), "UpdateMemberEquityCredit",
                WellKnownObjectMode.SingleCall);
            //-----------------------------

            //register as an available service --> Class: RemSrvCashieringManager Method: DeleteMemberEquityCredit
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvCashieringManager), "DeleteMemberEquityCredit",
                WellKnownObjectMode.SingleCall);
            //-----------------------------

            //register as an available service --> Class: RemSrvCashieringManager Method: InsertRegularLoanPayments
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvCashieringManager), "InsertRegularLoanPayments",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvCashieringManager Method: UpdateRegularLoanPayments
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvCashieringManager), "UpdateRegularLoanPayments",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvCashieringManager Method: DeleteRegularLoanPayments
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvCashieringManager), "DeleteRegularLoanPayments",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvCashieringManager Method: InsertUpdateDeleteRegularLoanPayments
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvCashieringManager), "InsertUpdateDeleteRegularLoanPayments",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvCashieringManager Method: InsertUpdateShareCapitalInformation
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvCashieringManager), "InsertUpdateShareCapitalInformation",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvCashieringManager Method: InsertUpdateInHouseHospitalizationInformation
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvCashieringManager), "InsertUpdateInHouseHospitalizationInformation",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvCashieringManager Method: InsertHospitalizationIncludeCoverage
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvCashieringManager), "InsertHospitalizationIncludeCoverage",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvCashieringManager Method: UpdateHospitalizationIncludeCoverage
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvCashieringManager), "UpdateHospitalizationIncludeCoverage",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvCashieringManager Method: DeleteHospitalizationIncludeCoverage
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvCashieringManager), "DeleteHospitalizationIncludeCoverage",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvCashieringManager Method: InsertHospitalizationExcludeCoverage
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvCashieringManager), "InsertHospitalizationExcludeCoverage",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvCashieringManager Method: UpdateHospitalizationExcludeCoverage
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvCashieringManager), "UpdateHospitalizationExcludeCoverage",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvCashieringManager Method: DeleteHospitalizationExcludeCoverage
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvCashieringManager), "DeleteHospitalizationExcludeCoverage",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvCashieringManager Method: InsertInHouseHospitalizationDebit
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvCashieringManager), "InsertInHouseHospitalizationDebit",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvCashieringManager Method: UpdateInHouseHospitalizationDebit
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvCashieringManager), "UpdateInHouseHospitalizationDebit",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvCashieringManager Method: DeleteInHouseHospitalizationDebit
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvCashieringManager), "DeleteInHouseHospitalizationDebit",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvCashieringManager Method: InsertUpdateDeleteHospitalizationDocument
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvCashieringManager), "InsertUpdateDeleteHospitalizationDocument",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvCashieringManager 
            //Method: SelectCountForCertificateNoInHouseHospitalizationInformation
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvCashieringManager),
                "SelectCountForCertificateNoInHouseHospitalizationInformation", WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvCashieringManager 
            //Method: SelectByMemberSysIDListDateStartEndForBillingStatementMemberServices
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvCashieringManager),
                "SelectByMemberSysIDListDateStartEndForBillingStatementMemberServices", WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvCashieringManager 
            //Method: SelectByDateStartEndCashReceiptsDetailedPaymentsCreditsMiscellaneousIncome
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvCashieringManager), 
                "SelectByDateStartEndCashReceiptsDetailedPaymentsCreditsMiscellaneousIncome", WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvCashieringManager 
            //Method: SelectByDateStartEndCashReceiptsSummarizedPaymentsCreditsMiscellaneousIncome
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvCashieringManager),
                "SelectByDateStartEndCashReceiptsSummarizedPaymentsCreditsMiscellaneousIncome", WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvCashieringManager Method: SelectByDateStartEndCashReceiptsDetailedBreakdownBankDeposit
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvCashieringManager),
                "SelectByDateStartEndCashReceiptsDetailedBreakdownBankDeposit", WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvCashieringManager Method: SelectByDateStartEndCashReceiptsSummarizedBreakdownBankDeposit
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvCashieringManager),
                "SelectByDateStartEndCashReceiptsSummarizedBreakdownBankDeposit", WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvCashieringManager Method: SelectByQueryStringDateStartEndMiscellaneousIncome
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvCashieringManager), 
                "SelectByQueryStringDateStartEndMiscellaneousIncome", WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvCashieringManager Method: SelectBySysIDMemberListInHouseHospitalizationCredit
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvCashieringManager), 
                "SelectBySysIDMemberListInHouseHospitalizationCredit", WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvCashieringManager Method: SelectBySysIDMemberListShareCapitalCredit
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvCashieringManager), "SelectBySysIDMemberListShareCapitalCredit",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvCashieringManager Method: SelectBySysIDMemberListMemberEquityCredit
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvCashieringManager), "SelectBySysIDMemberListMemberEquityCredit",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvCashieringManager Method: SelectBySysIDRegularListRegularLoanPayments
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvCashieringManager), "SelectBySysIDRegularListRegularLoanPayments",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvCashieringManager Method: SelectBySysIDMemberListShareCapitalInformation
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvCashieringManager), "SelectBySysIDMemberListShareCapitalInformation",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvCashieringManager Method: SelectBySysIDMemberListInHouseHospitalizationInformation
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvCashieringManager),
                "SelectBySysIDMemberListInHouseHospitalizationInformation", WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvCashieringManager Method: SelectHospitalizationIncludeCoverage
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvCashieringManager), "SelectHospitalizationIncludeCoverage", 
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvCashieringManager Method: SelectHospitalizationExcludeCoverage
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvCashieringManager), "SelectHospitalizationExcludeCoverage", 
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvCashieringManager Method: SelectBySysIDMemberListInHouseHospitalizationDebit
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvCashieringManager), 
                "SelectBySysIDMemberListInHouseHospitalizationDebit", WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvCashieringManager Method: SelectBySysIDInHouseHospitalizationDebit
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvCashieringManager),
                "SelectBySysIDInHouseHospitalizationDebit", WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvCashieringManager Method: SelectBySysIDInHouseDebitListHospitalizationDocument
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvCashieringManager),
                "SelectBySysIDInHouseDebitListHospitalizationDocument", WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvCashieringManager Method: SelectBySysIDMemberRegularLoanTypeIDListSummaryLoanPayments
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvCashieringManager),
                "SelectBySysIDMemberRegularLoanTypeIDListSummaryLoanPayments", WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvCashieringManager Method: IsExistsSysIDInHouseDebitOriginalNameHospitalizationDocument
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvCashieringManager), 
                "IsExistsSysIDInHouseDebitOriginalNameHospitalizationDocument", WellKnownObjectMode.SingleCall); 
            //----------------------------- 

        } //---------------------------------

        //this procedure registers the RemSrvAccountingManager class
        private void RegRemSrvAccountingManager()
        {
            //register as an available service --> Class: RemSrvAccountingManager Method: InsertChartOfAccounts
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvAccountingManager), "InsertChartOfAccounts",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvAccountingManager Method: UpdateChartOfAccounts
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvAccountingManager), "UpdateChartOfAccounts",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvAccountingManager Method: InsertBankInformation
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvAccountingManager), "InsertBankInformation",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvAccountingManager Method: UpdateBankInformation
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvAccountingManager), "UpdateBankInformation",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvAccountingManager Method: InsertDisbursementVoucherInformation
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvAccountingManager), "InsertDisbursementVoucherInformation",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvAccountingManager Method: UpdateDisbursementVoucherInformation
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvAccountingManager), "UpdateDisbursementVoucherInformation",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvAccountingManager Method: DeleteDisbursementVoucherInformation
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvAccountingManager), "DeleteDisbursementVoucherInformation",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvAccountingManager Method: SelectChartOfAccounts
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvAccountingManager), "SelectChartOfAccounts",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvAccountingManager Method: SelectBySysIDAccountChartOfAccounts
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvAccountingManager), "SelectBySysIDAccountChartOfAccounts",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvAccountingManager Method: SelectBankInformation
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvAccountingManager), "SelectBankInformation",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvAccountingManager Method: SelectByQueryStringDateStartEndDisbursementVoucherInformation
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvAccountingManager), 
                "SelectByQueryStringDateStartEndDisbursementVoucherInformation", WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvAccountingManager Method: SelectBySysIDVoucherDisbursementVoucherInformation
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvAccountingManager),
                "SelectBySysIDVoucherDisbursementVoucherInformation", WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvAccountingManager Method: SelectByQueryStringForDisbursementPayeeDisbursementVoucherInformation
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvAccountingManager),
                "SelectByQueryStringForDisbursementPayeeDisbursementVoucherInformation", WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvAccountingManager Method: IsValidCategoryBySummaryAccountChartOfAccount
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvAccountingManager), "IsValidCategoryBySummaryAccountChartOfAccount",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvAccountingManager Method: IsExistsAccountCodeChartOfAccount
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvAccountingManager), "IsExistsAccountCodeChartOfAccount",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvAccountingManager Method: IsExistsBankNameAccountNumberBankInformation
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvAccountingManager), "IsExistsBankNameAccountNumberBankInformation",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvAccountingManager Method: IsExistsBankCheckNoDisbursementVoucherInformation
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvAccountingManager), "IsExistsBankCheckNoDisbursementVoucherInformation",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

            //register as an available service --> Class: RemSrvAccountingManager Method: GetDataSetForAccounting
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServerLib.RemSrvAccountingManager), "GetDataSetForAccounting",
                WellKnownObjectMode.SingleCall);
            //----------------------------- 

        } //------------------------------------------        

        #endregion 

    }
}
