using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WindowsFormsApp1
{
    public partial class insertlibro : Form
    {
        public insertlibro()
        {
            InitializeComponent();
        }

    [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void closeinsertlibro_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelTopInsertar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void insertarbutton_Click(object sender, EventArgs e)
        {
            Libro.Book nuevo = new Libro.Book(textBoxtituloinsertar.Text, textBoxautorinsertar.Text, textBoxeditorialinsertar.Text);
            Libro.biblioteca.Add(nuevo);
            MessageBox.Show("Libro insertado correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            textBoxtituloinsertar.Text = "";
            textBoxautorinsertar.Text = "";
            textBoxeditorialinsertar.Text = "";
            this.Close();
        }
    }
}
