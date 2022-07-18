using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChkResultLib;

namespace CREntry_GR
{
    public partial class frmEntResult : Form
    {
        DataTable dtTbl = new DataTable();
        private readonly string JobNo;
        private readonly string serverName;
        private readonly string dbName;
        private readonly string userDb;
        private readonly string passDb;
        private readonly int entryNo;
        private readonly SQLClass sqlCls = new SQLClass();
        private readonly DataAccessClass dac = new DataAccessClass();
        public frmEntResult(DataTable dtChkSheet, string JobNbr, int entryNbr)
        {
            InitializeComponent();
            dtTbl = dtChkSheet;
            JobNo = JobNbr;
            entryNo = entryNbr;

            serverName = Properties.Settings.Default.serverName;
            dbName = Properties.Settings.Default.dbName;
            userDb = Properties.Settings.Default.userDb;
            passDb = Properties.Settings.Default.passDb;
        }

        private void frmEntResult_Load(object sender, EventArgs e)
        {
            dgvResult.GetType().GetProperty("DoubleBuffered",
                                        BindingFlags.Instance | BindingFlags.NonPublic).SetValue(dgvResult, true, null);

            txtEntryNo.Text = entryNo.ToString().Trim(); 
            txtJobNo.Text = JobNo;
            fillGridResult();
        }

        private void fillGridResult()
        {
            int idx = 0;
            if(dtTbl.Rows.Count > 0)
                foreach(DataRow dr in dtTbl.Rows)
                {
                    dgvResult.Rows[idx].Cells[""].Value = dr[""].ToString().Trim();
                    dgvResult.Rows[idx].Cells[""].Value = dr[""].ToString().Trim();
                    dgvResult.Rows[idx].Cells[""].Value = dr[""].ToString().Trim();
                    idx++;
                }
        }

        private void btnAddMachine_Click(object sender, EventArgs e)
        {
            string strQry = sqlCls.funAddMachine(cmbMachine.Text.Trim());
            if (dac.funExecSingleQuery(serverName, dbName, userDb, passDb, strQry))
                MessageBox.Show("Machine succesfully added to local system.", "INFORMATION", MessageBoxButtons.OK);
            else
                MessageBox.Show("Machine cannot be added to local system.", "ERROR", MessageBoxButtons.OK);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            funClearObjectField();
        }

        private void funClearObjectField()
        {
            txtSet.Text = "";
            txtPosition.Text = "";
            cmbMachine.Text = "";
            mtProdDate.Clear();

            if(dgvResult.Rows.Count > 0)
                for(int x=0; x <= dgvResult.Rows.Count -1; x++)
                {
                    dgvResult.Rows[x].Cells["colResult1"].Value = "";
                    dgvResult.Rows[x].Cells["colResult2"].Value = "";
                    dgvResult.Rows[x].Cells["colFlagValidate"].Value = "";
                }
        }

        private void mtProdDate_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string mtVal = mtProdDate.Text.Trim();
                if (mtVal.Length == 10)
                {
                    DateTime dt;
                    dt = DateTime.ParseExact(mtProdDate.Text, "dd/MM/yyyy", null);
                    dtProdDate.Value = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK);
                mtProdDate.Clear();
            }
        }

        private void dtProdDate_CloseUp(object sender, EventArgs e)
        {
            DateTime dtProd = dtProdDate.Value;
            string strProdDate = dtProd.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
            mtProdDate.Text = strProdDate;
        }
    }
}
