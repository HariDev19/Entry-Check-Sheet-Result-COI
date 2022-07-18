using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChkResultLib
{
    public class SQLClass
    {
        bool ret = false;
        string retStr = "";
        string strInsert;

        public bool funInsertResultHeader()
        {

            return ret;
        }

        public bool funInsertResultDetail()
        {
            return ret;
        }

        public bool funAddMachine(string machineCode)
        {
            strInsert = "INSERT INTO [dbo].[]";
            return ret;
        }

        public string funSelectCheckSheetInq(string jobcode, string proddate, string itemcode, string customer)
        {
            retStr = "SELECT DISTINCT CGRCode, DProdDate, CCOINo, CustName, ItemCode, CGINo, CustItemDesc " +
                     "FROM [dbo].[TGRCOI0] WHERE 1=1 ";
            if (jobcode != "")
                retStr += " AND CGRCode = '" + jobcode + "' ";
            else if (proddate != "")
                retStr += " AND DProdDate = '" + proddate + "' ";
            else if (itemcode != "")
                retStr += " AND ItemCode = '" + itemcode + "' ";
            else if (customer != "")
                retStr += " AND CustName = '"+customer+"' ";
            retStr += " ORDER BY CGRCode ASC ";

            return retStr;
        }

        public string funSelectJobCode()
        {
            retStr = "SELECT DISTINCT JobCode FROM [dbo].[COI] ORDER BY JobCode ASC";
            return retStr;
        }

        public string funSelectItemCode()
        {
            retStr = "SELECT DISTINCT ItemCode FROM [dbo].[COI] ORDER BY ItemCode ASC";
            return retStr;
        }

        public string funSelectCustomer()
        {
            retStr = "SELECT DISTINCT CustName FROM [dbo].[COI] ORDER BY CustName ASC";
            return retStr;
        }

        public string funRetrieveDataFromRadius(string JobNo)
        {
            retStr = "";
            return retStr;
        }
    }
}
