using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BabysittingSYS
{
    public partial class frmRemoveClient : Form
    {
        public frmRemoveClient()
        {
            InitializeComponent();
        }

        private void frmRemoveClient_Load(object sender, EventArgs e)
        {
            txt_ClientID.Text = "00001";
        }

        private void bnRemoveDetails_Click(object sender, EventArgs e)
        {

        }

        private void bnDeleteDetails_Click(object sender, EventArgs e)
        {
            txt_FirstName.Focus();
        }
    }
}
