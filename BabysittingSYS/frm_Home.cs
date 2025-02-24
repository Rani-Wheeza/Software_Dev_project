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
    public partial class frm_Home : Form
    {
       
        public frm_Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void ratesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mnu_MainMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void lbQuestion_Click(object sender, EventArgs e)
        {

        }

        private void bnClient_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddClient nextForm = new frmAddClient();

            nextForm.Show();
        }

        private void bnSitter_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_AddSitter nextForm = new frm_AddSitter();

            nextForm.Show();
        }

        private void bn_Admin_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Admin nextForm = new frm_Admin();

            nextForm.Show();
        }
    }
}
