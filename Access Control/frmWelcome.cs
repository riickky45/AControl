using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CS461_Access_Control
{
    public partial class frmWelcome : Form
    {
        public string message
        {
            set 
            { 
                txtMsg.Text = value;
                this.Update();
            }
        }

        public frmWelcome()
        {
            InitializeComponent();
            this.Update();
        }

        private void txtMsg_TextChanged(object sender, EventArgs e)
        {

        }
    }
}