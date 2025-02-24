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
    public partial class frm_Admin : Form
    {
        public frm_Admin()
        {
            InitializeComponent();
        }

        private void frm_Admin_Load(object sender, EventArgs e)
        {
            txt_AdminID.Text = "00001";
        }

        private void bn_Login_Click(object sender, EventArgs e)
        {

        }
    }
}
