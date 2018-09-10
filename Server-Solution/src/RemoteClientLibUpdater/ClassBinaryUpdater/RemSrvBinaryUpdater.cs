using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace RemoteServerLib
{
    public class RemSrvBinaryUpdater : MarshalByRefObject, IDisposable
    {
        #region Class Constructor and Destructor
        public RemSrvBinaryUpdater() { }

        void IDisposable.Dispose() { }
        #endregion

        #region Programmer-Defined Function Procedures

        //this function returns the updated binaries
        public List<CommonExchange.LmsBinaries> SelectLMSBinaries()
        {
            List<CommonExchange.LmsBinaries> lmsBinList = new List<CommonExchange.LmsBinaries>();

            return lmsBinList;
        } //----------------------------

        #endregion
    }
}
