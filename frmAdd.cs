using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace To_Do_List
{
    public partial class frmAdd : Form
    {
        public frmAdd()
        {
            InitializeComponent();
        }

        private void frmAdd_Load(object sender, EventArgs e)
        {
            dtDeadLine.MinDate = DateTime.Now; 
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(tbInput.Text))
            {
                MessageBox.Show("Please enter a task name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else 
            this.Close();
        }
    }
}
