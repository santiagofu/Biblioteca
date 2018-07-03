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
  
    public partial class Form1 : Form
    {

       
        
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Libro.WriteToBinaryFile<List<Libro.Book>>("biblioteca.txt", Libro.biblioteca);
            Application.Exit();
        }

        int maximized = 0;

        private void maximize_Click(object sender, EventArgs e)
        {
            if (maximized == 0){
                this.WindowState = FormWindowState.Maximized;
                maximized = 1;
            }
            else if (maximized == 1){
                this.WindowState = FormWindowState.Normal;
                maximized = 0;
            } 
        }

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
        }

        private void AbrirFormInPanel(object Formhijo)
        {
            if(this.panelCentral.Controls.Count >  0)
            {
                this.panelCentral.Controls.RemoveAt(0);
            }

            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelCentral.Controls.Add(fh);
            this.panelCentral.Tag = fh;
            fh.Show();
        }
        private void buscarbutton_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new BuscarForm());
        }

        private void administrarbutton_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new AdminForm());
        }

        private void estadisticasbutton_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new statisticsForm());
        }

       
    }
}
