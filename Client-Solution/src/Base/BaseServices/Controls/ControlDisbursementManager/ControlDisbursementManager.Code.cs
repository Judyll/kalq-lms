using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace BaseServices.Control
{
    public delegate void ControlDisbursementManagerDateTimePickerValueChanged();
    public delegate void ControlDisbursementManagerRadioButtonCheckedChanged();

    partial class ControlDisbursementManager
    {
        #region Class Data Member Declaration
        public event ControlDisbursementManagerDateTimePickerValueChanged OnDateStartValueChanged;
        public event ControlDisbursementManagerDateTimePickerValueChanged OnDateEndValueChanged;
        public event ControlDisbursementManagerRadioButtonCheckedChanged OnIssuedVoucherCheckChanged;
        public event ControlDisbursementManagerRadioButtonCheckedChanged OnCanceledVoucherCheckChanged;
        #endregion 

        #region Class Properties Declaration
        public DateTimePicker DateStartDateTimePicker
        {
            get { return this.dtpDateStart; }            
        }

        public DateTimePicker DateEndDateTimePicker
        {
            get { return this.dtpDateEnd; }
        }

        public CheckBox IncludeDateCheckedBox
        {
            get { return this.chkIncludeDate; }
        }

        private Boolean _isCanceled = false;
        public Boolean IsCanceled
        {
            get { return _isCanceled; }
        }
        #endregion

        #region Class Constructors
        public ControlDisbursementManager()
        {
            this.InitializeComponent();

            this.dtpDateStart.ValueChanged += new EventHandler(dtpDateStartValueChanged);
            this.dtpDateEnd.ValueChanged += new EventHandler(dtpDateEndValueChanged);
            this.chkIncludeDate.CheckedChanged += new EventHandler(chkIncludeDateCheckedChanged);
            this.rdbCanceledVoucher.CheckedChanged += new EventHandler(rdbCanceledVoucherCheckedChanged);
            this.rdbIssuedVoucher.CheckedChanged += new EventHandler(rdbIssuedVoucherCheckedChanged);
        }
        #endregion

        #region Class Event Void Procedures
        //################################CLASS ControlManager EVENTS########################################
        //event is raised when the class is loaded
        protected override void ClassLoad(object sender, EventArgs e)
        {
            base.ClassLoad(sender, e);

            _maxHeight = this.Size.Height;
        }//------------------------
        //################################END CLASS ControlManager EVENTS#####################################

        //###################################DATETIMEPICKER dtpDateStart EVENTS############################################
        //event is raised when the contrl value is changed
        private void dtpDateStartValueChanged(object sender, EventArgs e)
        {
            ControlDisbursementManagerDateTimePickerValueChanged ev = OnDateStartValueChanged;

            if (ev != null)
            {
                OnDateStartValueChanged();
            }
        }//--------------------
        //###################################END DATETIMEPICKER dtpDateStart EVENTS############################################

        //###################################DATETIMEPICKER dtpDateEnd EVENTS############################################
        //event is raised when the contrl value is changed
        private void dtpDateEndValueChanged(object sender, EventArgs e)
        {
            ControlDisbursementManagerDateTimePickerValueChanged ev = OnDateEndValueChanged;

            if (ev != null)
            {
                OnDateEndValueChanged();
            }
        }//--------------------
        //###################################END DATETIMEPICKER dtpDateEnd EVENTS############################################

        //###################################CHECKBOX chkIncludeDate EVENTS############################################
        //event is raised when the contrl value is changed
        private void chkIncludeDateCheckedChanged(object sender, EventArgs e)
        {
            if (this.chkIncludeDate.Checked)
            {
                this.dtpDateStart.Enabled = this.dtpDateEnd.Enabled = true;
            }
            else
            {
                this.dtpDateStart.Enabled = this.dtpDateEnd.Enabled = false;
            }
        }//------------------------
        //###################################END CHECKBOX chkIncludeDate EVENTS############################################

        //###################################RADIOBUTTON rdbIsCanceled EVENTS############################################
       //event is raised when the checked state is changed
        private void rdbCanceledVoucherCheckedChanged(object sender, EventArgs e)
        {
            _isCanceled = this.rdbCanceledVoucher.Checked;

            ControlDisbursementManagerRadioButtonCheckedChanged ev = OnCanceledVoucherCheckChanged;

            if (ev != null)
            {
                OnCanceledVoucherCheckChanged();
            }
        }//-----------------------
        //###################################END RADIOBUTTON rdbIssuedVoucher EVENTS############################################

        //###################################RADIOBUTTON rdbIsIssuedVoucher EVENTS############################################
        //event is raised when the checked state is changed
        private void rdbIssuedVoucherCheckedChanged(object sender, EventArgs e)
        {
            ControlDisbursementManagerRadioButtonCheckedChanged ev = OnIssuedVoucherCheckChanged;

            if (ev != null)
            {
                OnIssuedVoucherCheckChanged();
            }
        }//--------------------------
        //###################################END RADIOBUTTON rdbIsIssuedVoucher EVENTS############################################
        #endregion

        #region Programmer's Defined Void Procedures
        //this procedure will set date start
        public void SetDateStart(DateTime dateStart)
        {
            this.dtpDateStart.Value = dateStart;
        }//-------------------

        //this procedure will set date end
        public void SetDateEnd(DateTime dateEnd)
        {
            this.dtpDateEnd.Value = dateEnd;
        }//-------------------
        #endregion

    }
}
