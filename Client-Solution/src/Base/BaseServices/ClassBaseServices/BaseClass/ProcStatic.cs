using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Net;
using System.Net.NetworkInformation;

namespace BaseServices
{
    public partial class ProcStatic
    {
        #region Programmer-Defined Void Procedures

        //this procedure sets the dataview headers
        public static void SetDataGridViewColumns(DataGridView dgvBase, Boolean useSize)
        {
            Int32 width = 0;

            //general datagridview settings
            dgvBase.ReadOnly = true;
            dgvBase.MultiSelect = false;
            //----------------------

            foreach (DataGridViewColumn column in dgvBase.Columns)
            {
                //general column settings
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
                //----------------------------

                //individual column setting
                switch (column.HeaderText)
                {
                    case "beneficiary_reference_id":
                        column.HeaderText = "System ID";
                        column.Width = 150;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "office_employer_id":
                        column.HeaderText = "System ID";
                        column.Width = 150;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "sysid_member":
                        column.HeaderText = "System ID";
                        column.Width = 150;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "member_id":
                        column.HeaderText = "Member ID";
                        column.Width = 150;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "sysid_person":
                        column.HeaderText = "System ID";
                        column.Width = 150;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "sysid_loancharges":
                        column.HeaderText = "System ID";
                        column.Width = 150;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "sysid_loanadditions":
                        column.HeaderText = "System ID";
                        column.Width = 150;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "sysid_regular":
                        column.HeaderText = "System ID";
                        column.Width = 150;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "sysid_collateral":
                        column.HeaderText = "System ID";
                        column.Width = 150;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "comaker_id":
                        column.HeaderText = "System ID";
                        column.Width = 150;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "other_creditor_id":
                        column.HeaderText = "System ID";
                        column.Width = 150;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "sysid_share":
                        column.HeaderText = "System ID";
                        column.Width = 150;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "sysid_includecoverage":
                        column.HeaderText = "System ID";
                        column.Width = 150;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "amortization_id":
                        column.HeaderText = "System ID";
                        column.Width = 150;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight;
                        break;
                    case "sysid_excludecoverage":
                        column.HeaderText = "System ID";
                        column.Width = 150;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "sysid_inhousedebit":
                        column.HeaderText = "System ID";
                        column.Width = 150;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "transaction_id":
                        column.HeaderText = "System ID";
                        column.Width = 90;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "member_employee_id":
                        column.HeaderText = "Member/Employee ID";
                        column.Width = 150;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "person_name":
                        column.HeaderText = "Name";
                        column.Width = 250;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                        break;
                    case "person_name_forzeen":
                        column.HeaderText = "Name";
                        column.Width = 300;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                        column.Frozen = true;
                        break;
                    case "member_name":
                        column.HeaderText = "Name";
                        column.Width = 300;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                        break;
                    case "comaker_name":
                        column.HeaderText = "Co-Maker Name";
                        column.Width = 300;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                        break;
                    case "system_user_name":
                        column.HeaderText = "User Name";
                        column.Width = 200;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                        break;
                    case "user_name":
                        column.HeaderText = "Complete Name";
                        column.Width = 200;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                        column.Frozen = true;
                        break;
                    case "relationship_description":
                        column.HeaderText = "Relationship Description";
                        column.Width = 300;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                        break;
                    case "present_address":
                        column.HeaderText = "Present Address";
                        column.Width = 150;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                        break;
                    case "home_address":
                        column.HeaderText = "Home Address";
                        column.Width = 150;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                        break;
                    case "home_phone_nos":
                        column.HeaderText = "Home Phone No.";
                        column.Width = 150;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                        break;
                    case "birthdate":
                        column.HeaderText = "BirthDate";
                        column.Width = 150;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "present_phone_nos":
                        column.HeaderText = "Present Phone No.";
                        column.Width = 150;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                        break;
                    case "office_employer_name":
                        column.HeaderText = "Office Name";
                        column.Width = 250;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                        break;
                    case "office_employer_acronym":
                        column.HeaderText = "Office Acronym";
                        column.Width = 150;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "office_employer_address":
                        column.HeaderText = "Office Address";
                        column.Width = 150;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                        break;
                    case "office_employer_phone_nos":
                        column.HeaderText = "Office Phone No.";
                        column.Width = 150;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                        break;
                    case "life_status_code_code_description":
                        column.HeaderText = "Life Status";
                        column.Width = 100;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                        break;
                    case "gender_code_code_description":
                        column.HeaderText = "Gender";
                        column.Width = 100;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                        break;
                    case "occupation":
                        column.HeaderText = "Occupation";
                        column.Width = 100;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                        break;
                    case "acronym":
                        column.HeaderText = "Acronym";
                        column.Width = 100;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "account_no":
                        column.HeaderText = "Account No.";
                        column.Width = 150;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "loan_amount":
                        column.HeaderText = "Amount";
                        column.Width = 100;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        column.Frozen = true;
                        break;
                    case "net_assistance_amount":
                        column.HeaderText = "Assistance Amount";
                        column.Width = 150;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        break;
                    case "purpose_of_loan":
                        column.HeaderText = "Purpose of Loan";
                        column.Width = 300;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                        break;
                    case "loan_terms":
                        column.HeaderText = "Loan Terms";
                        column.Width = 100;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "interest_rate":
                        column.HeaderText = "Interest Rate";
                        column.Width = 100;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        break;
                    case "is_still_a_spouce":
                        column.HeaderText = "Is Still A Spouce";
                        column.Width = 100;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                        break;
                    case "regular_loan_type_description":
                        column.HeaderText = "Loan Type";
                        column.Width = 200;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                        break;
                    case "regular_loan_type_description_freeze":
                        column.HeaderText = "Loan Type";
                        column.Width = 200;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                        column.Frozen = true;
                        break;
                    case "hospital_name":
                        column.HeaderText = "Hospital Name";
                        column.Width = 200;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                        break;
                    case "cause_of_admission":
                        column.HeaderText = "Cause of Admission";
                        column.Width = 200;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                        break;
                    case "loan_charges_description":
                        column.HeaderText = "Loan Charge Description";
                        column.Width = 300;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                        break;
                    case "loan_additions_description":
                        column.HeaderText = "Loan Additions Description";
                        column.Width = 300;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "include_coverage_description":
                        column.HeaderText = "Include Coverage Description";
                        column.Width = 300;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "exclude_coverage_description":
                        column.HeaderText = "Exclude Coverage Description";
                        column.Width = 300;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "repayment_description":
                        column.HeaderText = "Repayment Description";
                        column.Width = 300;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "check_no":
                        column.HeaderText = "Check No";
                        column.Width = 200;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "check_date":
                        column.HeaderText = "Check Date";
                        column.Width = 200;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "date_first_payment":
                        column.HeaderText = "First Payment Date";
                        column.Width = 200;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "date_maturity":
                        column.HeaderText = "Maturity Date";
                        column.Width = 200;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "effectivity_date":
                        column.HeaderText = "Effectivity Date";
                        column.Width = 200;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "reflected_date":
                        column.HeaderText = "Reflected Date";
                        column.Width = 200;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "received_date":
                        column.HeaderText = "Received Date";
                        column.Width = 200;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "receipt_date":
                        column.HeaderText = "Receipt Date";
                        column.Width = 200;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "date_from":
                        column.HeaderText = "Date From";
                        column.Width = 200;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "date_to":
                        column.HeaderText = "Date To";
                        column.Width = 200;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "penalty_rate":
                        column.HeaderText = "Penalty Rate";
                        column.Width = 100;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        break;
                   case "payment_no":
                        column.HeaderText = "Payment No.";
                        column.Width = 70;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;                   
                    case "payment_date_to":
                        column.HeaderText = "Payment Date";
                        column.Width = 200;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "balance_beginning":
                        column.HeaderText = "Beginning Balance";
                        column.Width = 150;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        break;
                    case "payment_amount":
                        column.HeaderText = "Scheduled Payment";
                        column.Width = 150;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        break;
                    case "amount_paid":
                        column.HeaderText = "Amount Paid";
                        column.Width = 150;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        break;
                    case "interest_paid":
                        column.HeaderText = "Interest Paid";
                        column.Width = 150;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        break;
                    case "principal_paid":
                        column.HeaderText = "Principal Paid";
                        column.Width = 150;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        break;
                    case "rebate_paid":
                        column.HeaderText = "Rebate Amount";
                        column.Width = 150;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        break;
                    case "amount_tendered":
                        column.HeaderText = "Amount Tendered";
                        column.Width = 150;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        break;
                    case "balance_ending":
                        column.HeaderText = "Balance Ending";
                        column.Width = 150;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        break;
                    case "property_type":
                        column.HeaderText = "Property Type";
                        column.Width = 150;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "property_brand":
                        column.HeaderText = "Property Brand";
                        column.Width = 150;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "serial_no":
                        column.HeaderText = "Serial No.";
                        column.Width = 150;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "year_purchased":
                        column.HeaderText = "Year Purchased";
                        column.Width = 150;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "purchase_price":
                        column.HeaderText = "Purchase Price";
                        column.Width = 150;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        break;
                    case "remarks":
                        column.HeaderText = "Remarks";
                        column.Width = 300;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                        break;
                    case "estimated_appraised_value":
                        column.HeaderText = "Appraisal Value";
                        column.Width = 150;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        break;
                    case "creditor_name":
                        column.HeaderText = "Creditor Name";
                        column.Width = 200;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                        break;
                    case "certificate_no":
                        column.HeaderText = "Certificate No.";
                        column.Width = 150;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                        break;  
                    case "date_due":
                        column.HeaderText = "Due Date";
                        column.Width = 150;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "amount_owned":
                        column.HeaderText = "Amount Owned";
                        column.Width = 150;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        break;
                    case "amortization_amount":
                        column.HeaderText = "Amortization Amount";
                        column.Width = 150;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        break;
                    case "premium_amount_due":
                        column.HeaderText = "Premium Amount";
                        column.Width = 150;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        break;
                    case "maximum_amount":
                        column.HeaderText = "Maximum Amount";
                        column.Width = 150;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        break;
                    case "account_code_name":
                        column.HeaderText = "Account Code Name";
                        column.Width = 250;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                        column.Frozen = true;
                        column.DefaultCellStyle.ForeColor = Color.Maroon;
                        break;
                    case "account_code_name_not_frozen":
                        column.HeaderText = "Account Code Name";
                        column.Width = 250;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                        column.DefaultCellStyle.ForeColor = Color.Maroon;
                        break;
                    case "category_description":
                        column.HeaderText = "Category";
                        column.Width = 150;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "account_code_name_summary":
                        column.HeaderText = "Summary Account";
                        column.Width = 150;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                        break;
                    case "category_description_summary":
                        column.HeaderText = "Summary Category";
                        column.Width = 150;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "sysid_account":
                        column.HeaderText = "System ID";
                        column.Width = 150;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                        break;
                    case "sysid_bank":
                        column.HeaderText = "System ID";
                        column.Width = 150;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                        break;
                    case "transaction_system_id":
                        column.HeaderText = "System ID";
                        column.Width = 150;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                        break;
                    case "system_user_id":
                        column.HeaderText = "System ID";
                        column.Width = 90;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                        break;
                    case "bank_name":
                        column.HeaderText = "Bank Name";
                        column.Width = 150;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                        break;
                    case "bank_address":
                        column.HeaderText = "Bank Address";
                        column.Width = 200;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                        break;
                    case "account_number":
                        column.HeaderText = "Account No.";
                        column.Width = 150;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        column.Frozen = true;
                        break;
                    case "transaction_account":
                        column.HeaderText = "Account No.";
                        column.Width = 150;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "transaction_amount":
                        column.HeaderText = "Amount";
                        column.Width = 100;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        break;
                    case "transaction_date":
                        column.HeaderText = "Date";
                        column.Width = 200;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "transaction_date_string":
                        column.HeaderText = "Transaction Date";
                        column.Width = 200;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "transaction_description_name":
                        column.HeaderText = "Description Name";
                        column.Width = 150;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "access_description":
                        column.HeaderText = "Access Level";
                        column.Width = 320;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "sysid_voucher":
                        column.HeaderText = "Voucher No";
                        column.Width = 150;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                        break;
                    case "department_id":
                        column.HeaderText = "System ID";
                        column.Width = 150;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                        break;
                    case "department_name":
                        column.HeaderText = "Cost Center";
                        column.Width = 150;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                        break;
                    case "debit_amount":
                        column.HeaderText = "Debit";
                        column.Width = 100;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        break;
                    case "credit_amount":
                        column.HeaderText = "Credit";
                        column.Width = 100;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        break;
                    case "check_no_not_froze":
                        column.HeaderText = "Check No.";
                        column.Width = 150;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                        break;
                    case "date_issued":
                        column.HeaderText = "Date Issued";
                        column.Width = 150;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                        break;
                    case "check_amount":
                        column.HeaderText = "Check Amount";
                        column.Width = 150;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        break;
                    case "particulars":
                        column.HeaderText = "Particular Description";
                        column.Width = 200;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                        break;
                    case "receipt_no":
                        column.HeaderText = "   Receipt    No.";
                        column.Width = 80;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    default:
                        column.Visible = false;
                        column.Width = 0;
                        break;
                    case "transaction_done":
                        column.HeaderText = "Transaction Done";
                        column.Width = 1000;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                        break;
                }

                width += column.Width;
            }

            if (useSize)
            {
                dgvBase.Width = width;
            }
        }//---------------------------

        //this procedure sets the textbox initial message
        public static void TextBoxMessageTip(TextBox txtInput, String strMessage, Boolean showMessage)
        {
            String strInput = txtInput.Text.Trim();

            if (showMessage && (String.Equals(strInput, "") || strInput == null))
            {
                txtInput.Text = strMessage;
                txtInput.Font = new Font(txtInput.Font, FontStyle.Italic);
                txtInput.ForeColor = Color.DarkCyan;
            }
            else
            {
                if (String.Equals(strInput, strMessage) || strInput == null)
                {
                    txtInput.Text = "";
                }

                txtInput.Font = new Font(txtInput.Font, FontStyle.Regular);
                txtInput.ForeColor = Color.Black;
            }

        } //--------------------------

        //this procedure makes the textbox accept on numbers
        public static void TextBoxAmountOnly(KeyPressEventArgs e)
        {
            if (e.KeyChar != '.' && e.KeyChar != ',' && !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        } //------------------------------

        //this procedure makes the textbox accept on numbers
        public static void TextBoxFloatDecimalOnly(KeyPressEventArgs e)
        {
            if (e.KeyChar != '.' && !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        } //------------------------------

        //this procedure makes the textbox accept letters only
        public static void TextBoxLettersOnly(KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !Char.Equals('-', e.KeyChar))
            {
                e.Handled = true;
            }
        } //-----------------------------

        //this proceudre makes the textbox accept only for the username and password
        public static void TextBoxForUserNamePassword(KeyPressEventArgs e)
        {
            if ((Convert.ToInt32(e.KeyChar) < 32 || Convert.ToInt32(e.KeyChar) > 126) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        } //----------------------------------

        //this procedure makes the textbox accept integers only
        public static void TextBoxIntegersOnly(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        } //------------------------------

        //this procedure validates the textbox
        public static void TextBoxValidateAmount(TextBox txtInput)
        {
            Decimal input;

            if (Decimal.TryParse(txtInput.Text, out input))
            {
                txtInput.Text = input.ToString("N");
            }
            else
            {
                txtInput.Text = "0.00";
            }

        }//--------------------------------------

        //this procedure validates the textbox
        public static void TextBoxValidateFloatMaxTwoDecimal(TextBox txtInput)
        {
            Single input;

            if (Single.TryParse(txtInput.Text, out input))
            {
                txtInput.Text = input.ToString("0.##");
            }
            else
            {
                txtInput.Text = "0.0";
            }

        }//--------------------------------------

        //this procedure validates the textbox
        public static void TextBoxValidateInteger(TextBox txtInput)
        {
            Int32 input;

            if (Int32.TryParse(txtInput.Text, out input))
            {
                txtInput.Text = input.ToString();
            }
            else
            {
                txtInput.Text = "0";
            }

        } //--------------------------------------

        //this function deletes a specified directory
        public static void DeleteDirectory(String dirPath)
        {
            DirectoryInfo infoDir = new DirectoryInfo(dirPath);

            if (infoDir.Exists)
            {
                infoDir.Delete(true);
            }
        } //-----------------------------------

        //this function shows an error message
        public static void ShowErrorDialog(String errMsg, String errCaption)
        {
            MessageBox.Show("A business rule has been violated... \nDetails: " + errMsg, errCaption,
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        } //-------------------------

        #endregion

        #region Programmer-Defined Function Procedures

        //this function gets the array of bytes of a file
        public static Byte[] GetFileArrayBytes(String filePath)
        {
            FileStream fileStr = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            BinaryReader binReader = new BinaryReader(fileStr);

            Byte[] fileByte = binReader.ReadBytes((Int32)fileStr.Length);

            fileStr.Close();
            binReader.Close();

            fileStr = null;
            binReader = null;

            return fileByte;

        } //--------------------------

        //this function trims the special characters
        public static String TrimStartEndString(String strBase)
        {
            if (!String.IsNullOrEmpty(strBase))
            {
                return strBase.TrimStart(null).TrimEnd(null);
            }
            else
            {
                return "";
            }

        } //-----------------------

        //this function gets the complete name
        public static String GetCompleteNameMiddleInitial(DataRow srcRow, String colLName, String colFName, String colMName)
        {
            return RemoteServerLib.ProcStatic.DataRowConvert(srcRow, colLName, "").ToUpper() + ", " +
                RemoteServerLib.ProcStatic.DataRowConvert(srcRow, colFName, "") + " " +
                (String.IsNullOrEmpty(RemoteServerLib.ProcStatic.DataRowConvert(srcRow, colMName, "")) ? "" :
                (RemoteServerLib.ProcStatic.DataRowConvert(srcRow, colMName, "").Substring(0, 1).ToUpper() + "."));
        } //------------------------------        

        //this function gets the complete name
        public static String GetCompleteNameMiddleInitial(String lName, String fName, String mName)
        {
            return lName.ToUpper() + ", " + fName + " " + (String.IsNullOrEmpty(mName) ? "" : (mName.Substring(0, 1).ToUpper() + "."));
        } //------------------------------   

        //this function gets the complete name
        public static String GetCompleteNameMiddleInitial(DataRow srcRow, String colPreFix, String colLName, String colFName, String colMName, String colSuFix)
        {
            return RemoteServerLib.ProcStatic.DataRowConvert(srcRow, colPreFix, "") + " " +
                RemoteServerLib.ProcStatic.DataRowConvert(srcRow, colFName, "") + " " +
                (String.IsNullOrEmpty(RemoteServerLib.ProcStatic.DataRowConvert(srcRow, colMName, "")) ? "" :
                (RemoteServerLib.ProcStatic.DataRowConvert(srcRow, colMName, "").Substring(0, 1).ToUpper() + ".")) + " " +
                 RemoteServerLib.ProcStatic.DataRowConvert(srcRow, colLName, "") + ", " +
                 RemoteServerLib.ProcStatic.DataRowConvert(srcRow, colSuFix, "");
        } //------------------------------ 

        //this function gets the complete name
        public static String GetCompleteNameMiddleInitial(String preFix, String lName, String fName, String mName, String suFix)
        {
            String tempPrefix = String.IsNullOrEmpty(preFix) ? String.Empty : preFix;
            String tempSuffix = String.IsNullOrEmpty(suFix) ? String.Empty : suFix;

            tempPrefix = tempPrefix.Replace(".", "");
            tempPrefix = !String.IsNullOrEmpty(tempPrefix) ? preFix + ". " : String.Empty;
            tempSuffix = tempSuffix.Replace(",", "");
            tempSuffix = !String.IsNullOrEmpty(tempSuffix) ? ", " + suFix : String.Empty;

            return tempPrefix + " " + fName + "  " + (String.IsNullOrEmpty(mName) ? "" : (mName.Substring(0, 1).ToUpper() + ".")) + " " +
                lName + tempSuffix;
        } //------------------------------   

        //this function returns the network information
        public static String GetNetworkInformation()
        {
            StringBuilder strNetInfo = new StringBuilder();

            if (NetworkInterface.GetIsNetworkAvailable())
            {
                IPGlobalProperties computerProperties = IPGlobalProperties.GetIPGlobalProperties();
                NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();

                strNetInfo.Append("Windows IP Configuration: " + "\n\n");
                strNetInfo.Append("\t" + "Host Name...........................: " + computerProperties.HostName + "\n");
                strNetInfo.Append("\t" + "Domain Name.........................: " + computerProperties.DomainName + "\n");

                if (nics == null || nics.Length < 1)
                {
                    strNetInfo.Append("\n" + "No network interface found.");
                }
                else
                {
                    foreach (NetworkInterface adapter in nics)
                    {
                        if (!adapter.Supports(NetworkInterfaceComponent.IPv4))
                        {
                            continue;
                        }

                        IPInterfaceProperties properties = adapter.GetIPProperties();
                        IPv4InterfaceProperties ipV4 = properties.GetIPv4Properties();

                        strNetInfo.Append("\n" + adapter.NetworkInterfaceType + " Adapter " + adapter.Name + "\n");
                        strNetInfo.Append("\t" + "Description.........................: " + adapter.Description + "\n");
                        strNetInfo.Append("\t" + "Physical Address....................: ");

                        PhysicalAddress address = adapter.GetPhysicalAddress();
                        Byte[] bytes = address.GetAddressBytes();

                        for (int i = 0; i < bytes.Length; i++)
                        {
                            strNetInfo.Append(bytes[i].ToString("X2"));

                            if (i != bytes.Length - 1)
                            {
                                strNetInfo.Append("-");
                            }
                        }

                        if (ipV4 == null)
                        {
                            strNetInfo.Append("\n");
                            strNetInfo.Append("\t" + "No IPv4 information is available for this interface.");
                            continue;
                        }

                        strNetInfo.Append("\n");
                        strNetInfo.Append("\t" + "IP Address..........................: ");

                        foreach (UnicastIPAddressInformation ipInfo in properties.UnicastAddresses)
                        {
                            strNetInfo.Append(ipInfo.Address);
                            strNetInfo.Append("   ");
                        }

                        strNetInfo.Append("\n");
                        strNetInfo.Append("\t" + "Gateway Addresses...................: ");

                        foreach (GatewayIPAddressInformation gateway in properties.GatewayAddresses)
                        {
                            strNetInfo.Append(gateway.Address);
                            strNetInfo.Append("   ");
                        }
                        strNetInfo.Append("\n");
                        strNetInfo.Append("\t" + "DNS Servers.........................: ");

                        foreach (IPAddress ipInfo in properties.DnsAddresses)
                        {
                            bytes = ipInfo.GetAddressBytes();

                            for (int i = 0; i < bytes.Length; i++)
                            {
                                strNetInfo.Append(bytes[i].ToString());

                                if (i != bytes.Length - 1)
                                {
                                    strNetInfo.Append(".");
                                }
                            }

                            strNetInfo.Append("   ");
                        }

                        strNetInfo.Append("\n");
                    }
                }

            }
            else
            {
                strNetInfo.Append("Using LOCALHOST network information");
            }

            return strNetInfo.ToString();

        } //----------------------------

         #endregion
    }
}
