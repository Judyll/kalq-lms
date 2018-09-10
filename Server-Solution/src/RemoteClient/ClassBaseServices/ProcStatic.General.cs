using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Net.NetworkInformation;
using System.Net;
using System.Windows.Forms;
using System.Drawing;
using System.Data;

namespace RemoteClient
{
    [Serializable()]
    public partial class ProcStatic
    {  
      
        #region Programmer-Defined Function Procedures

        //this function determines if the record is locked by reflected date and received date
        //Database Function:    ums.IsRecordLockByReflectedCreatedDate
        public static Boolean IsRecordLocked(Int32 addMonths, DateTime createdDate, DateTime serverDateTime)
        {
            Boolean isLocked = true;

            if (DateTime.Compare(serverDateTime, createdDate.AddMonths(addMonths)) <= 0)
            {
                isLocked = !isLocked;
            }

            return isLocked;

        } //-----------------------------

        //this function determines if the record is locked by reflected date and received date
        //Database Function:    ums.IsRecordLockByReflectedCreatedDate
        public static Boolean IsRecordLocked(Int32 addMonths, DateTime receiptDate, DateTime createdDate, DateTime serverDateTime)
        {
            Boolean isLocked = true;

            if ((DateTime.Compare(receiptDate, createdDate.AddMonths(addMonths)) <= 0) &&
                (DateTime.Compare(receiptDate, createdDate.AddMonths(addMonths - (addMonths * 2))) >= 0) &&
                (DateTime.Compare(serverDateTime, createdDate.AddMonths(addMonths)) <= 0))
            {
                isLocked = !isLocked;
            }

            return isLocked;

        } //-----------------------------

        #endregion

    }
}
