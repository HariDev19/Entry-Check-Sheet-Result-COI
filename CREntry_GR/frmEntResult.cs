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
        private readonly SQLClass sqlCls = new SQLClass();
        private readonly DataAccessClass dac = new DataAccessClass();
        public frmEntResult(DataTable dtChkSheet, string JobNbr)
        {
            InitializeComponent();
            dtTbl = dtChkSheet;
            JobNo = JobNbr;
        }

        private void frmEntResult_Load(object sender, EventArgs e)
        {
            dgvResult.GetType().GetProperty("DoubleBuffered",
                                        BindingFlags.Instance | BindingFlags.NonPublic).SetValue(dgvResult, true, null);
        }

        private void btnAddMachine_Click(object sender, EventArgs e)
        {

        }
    }
}
