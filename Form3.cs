using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AdminForm : Form
    {

        

        public AdminForm()
        {
            InitializeComponent();
        }

        private void closeadminform_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonInsertar_Click(object sender, EventArgs e)
        {
            insertlibro insert = new insertlibro();
            insert.Show();
        }

        private void modifybutton_Click(object sender, EventArgs e)
        {
            FormModify modify = new FormModify();
            modify.Show();
        }
    }
}
