using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BR;

namespace GUI
{
    public partial class StartUp : Form
    {
        public StartUp()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void findAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnOk.Visible = true;
            cmbAccount.Visible = true;
            txtAccount.Visible = false;
            txtPass.Enabled = false;
            txtUser.Enabled = false;
            ModifyToolStripMenuItem.Enabled = false;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (cmbAccount.Visible == true)     //'Find Account' selected
            {    
                txtUser.Text = BR.GetUserData(cmbAccount.Text);    //txtUser loaded with User data
                txtPass.Text = BR.GetPassData(cmbAccount.Text);    //txtPass loaded with Password data
                ModifyToolStripMenuItem.Enabled = true;
            }
            else
            {                                    //'Add Account' selected

            }
        }

        private void StartUp_Load(object sender, EventArgs e)
        {
            //PreLoaded in FindAccount Mode
            btnOk.Visible = true;
            cmbAccount.Visible = true;
            txtAccount.Visible = false;
            txtPass.Enabled = false;
            txtUser.Enabled = false;
            ModifyToolStripMenuItem.Enabled = false;
            cmbAccount.DataSource = BR.GetAccountsData();
        }
    }
}
