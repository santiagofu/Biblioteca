using System.ComponentModel;

namespace WindowsFormsApp1
{

    partial class FormModify
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModify));
            this.toppanelmodify = new System.Windows.Forms.Panel();
            this.closemodify = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toppanelmodify.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closemodify)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toppanelmodify
            // 
            this.toppanelmodify.Controls.Add(this.closemodify);
            this.toppanelmodify.Dock = System.Windows.Forms.DockStyle.Top;
            this.toppanelmodify.Location = new System.Drawing.Point(0, 0);
            this.toppanelmodify.Name = "toppanelmodify";
            this.toppanelmodify.Size = new System.Drawing.Size(1317, 65);
            this.toppanelmodify.TabIndex = 1;
            this.toppanelmodify.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toppanelmodify_MouseDown);
            // 
            // closemodify
            // 
            this.closemodify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closemodify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closemodify.Image = ((System.Drawing.Image)(resources.GetObject("closemodify.Image")));
            this.closemodify.Location = new System.Drawing.Point(1265, 12);
            this.closemodify.Name = "closemodify";
            this.closemodify.Size = new System.Drawing.Size(40, 40);
            this.closemodify.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closemodify.TabIndex = 4;
            this.closemodify.TabStop = false;
            this.closemodify.Click += new System.EventHandler(this.closemodify_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1293, 383);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.DataSource = Libro.biblioteca;
            // 
            // FormModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 466);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toppanelmodify);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormModify";
            this.Text = "Form4";
            this.toppanelmodify.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closemodify)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel toppanelmodify;
        private System.Windows.Forms.PictureBox closemodify;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}