using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        private readonly int entryNo;
        private readonly SQLClass sqlCls = new SQLClass();
        private readonly DataAccessClass dac = new DataAccessClass();
        public frmEntResult(DataTable dtChkSheet, string JobNbr, int entryNbr)
        {
            InitializeComponent();
            dtTbl = dtChkSheet;
            JobNo = JobNbr;
            entryNo = entryNbr;
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

        }

        private void btnNew_Click(object sender, EventArgs e)
        {

        }
    }
}
