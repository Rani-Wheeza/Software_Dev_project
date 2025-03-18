using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace BabysittingSYS
{
    public partial class frmDBConnect: Form
    {
        OracleConnection conn = new OracleConnection(DBConnect.oradb);

        public frmDBConnect()
        {
            InitializeComponent();
        }
               
        private void bnOpen_Click(object sender, EventArgs e)
        {
            //open a connection to the database
            if (conn.State == ConnectionState.Open)
                return;
            conn.Open();
            //lblStatus.Text = "Connection is now OPEN";//lblStatus has an issue
        }

        private void bnClose_Click(object sender, EventArgs e)
        {
            conn.Close();
           // lblStatus.Text = "Connection is now Closed";
        }

        private void frmDBConnect_Load(object sender, EventArgs e)
        {

        }
    }
}
