namespace WindowsFormsApp1
{
    partial class BuscarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarForm));
            this.buscarbutton2 = new System.Windows.Forms.Button();
            this.textBoxtitulo = new System.Windows.Forms.TextBox();
            this.labeltitulo = new System.Windows.Forms.Label();
            this.labelautor = new System.Windows.Forms.Label();
            this.labeleditorial = new System.Windows.Forms.Label();
            this.closebuscarform = new System.Windows.Forms.PictureBox();
            this.textBoxautor = new System.Windows.Forms.TextBox();
            this.textBoxeditorial = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.closebuscarform)).BeginInit();
            this.SuspendLayout();
            // 
            // buscarbutton2
            // 
            this.buscarbutton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buscarbutton2.FlatAppearance.BorderSize = 0;
            this.buscarbutton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.buscarbutton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscarbutton2.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarbutton2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buscarbutton2.Image = ((System.Drawing.Image)(resources.GetObject("buscarbutton2.Image")));
            this.buscarbutton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buscarbutton2.Location = new System.Drawing.Point(281, 347);
            this.buscarbutton2.Name = "buscarbutton2";
            this.buscarbutton2.Size = new System.Drawing.Size(301, 67);
            this.buscarbutton2.TabIndex = 6;
            this.buscarbutton2.Text = "Buscar";
            this.buscarbutton2.UseVisualStyleBackColor = true;
            // 
            // textBoxtitulo
            // 
            this.textBoxtitulo.AcceptsReturn = true;
            this.textBoxtitulo.AcceptsTab = true;
            this.textBoxtitulo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxtitulo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.textBoxtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxtitulo.Location = new System.Drawing.Point(322, 104);
            this.textBoxtitulo.Name = "textBoxtitulo";
            this.textBoxtitulo.Size = new System.Drawing.Size(216, 30);
            this.textBoxtitulo.TabIndex = 7;
            // 
            // labeltitulo
            // 
            this.labeltitulo.AutoSize = true;
            this.labeltitulo.Font = new System.Drawing.Font("Imprint MT Shadow", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltitulo.Location = new System.Drawing.Point(60, 104);
            this.labeltitulo.Name = "labeltitulo";
            this.labeltitulo.Size = new System.Drawing.Size(93, 34);
            this.labeltitulo.TabIndex = 10;
            this.labeltitulo.Text = "Título";
            // 
            // labelautor
            // 
            this.labelautor.AutoSize = true;
            this.labelautor.Font = new System.Drawing.Font("Imprint MT Shadow", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelautor.Location = new System.Drawing.Point(60, 179);
            this.labelautor.Name = "labelautor";
            this.labelautor.Size = new System.Drawing.Size(88, 34);
            this.labelautor.TabIndex = 11;
            this.labelautor.Text = "Autor";
            // 
            // labeleditorial
            // 
            this.labeleditorial.AutoSize = true;
            this.labeleditorial.Font = new System.Drawing.Font("Imprint MT Shadow", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeleditorial.Location = new System.Drawing.Point(60, 278);
            this.labeleditorial.Name = "labeleditorial";
            this.labeleditorial.Size = new System.Drawing.Size(123, 34);
            this.labeleditorial.TabIndex = 12;
            this.labeleditorial.Text = "Editorial";
            // 
            // closebuscarform
            // 
            this.closebuscarform.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closebuscarform.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closebuscarform.Image = ((System.Drawing.Image)(resources.GetObject("closebuscarform.Image")));
            this.closebuscarform.Location = new System.Drawing.Point(761, 12);
            this.closebuscarform.Name = "closebuscarform";
            this.closebuscarform.Size = new System.Drawing.Size(27, 27);
            this.closebuscarform.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closebuscarform.TabIndex = 13;
            this.closebuscarform.TabStop = false;
            this.closebuscarform.Click += new System.EventHandler(this.closebuscarform_Click);
            // 
            // textBoxautor
            // 
            this.textBoxautor.AcceptsReturn = true;
            this.textBoxautor.AcceptsTab = true;
            this.textBoxautor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxautor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.textBoxautor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxautor.Location = new System.Drawing.Point(322, 179);
            this.textBoxautor.Name = "textBoxautor";
            this.textBoxautor.Size = new System.Drawing.Size(216, 30);
            this.textBoxautor.TabIndex = 14;
            // 
            // textBoxeditorial
            // 
            this.textBoxeditorial.AcceptsReturn = true;
            this.textBoxeditorial.AcceptsTab = true;
            this.textBoxeditorial.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxeditorial.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.textBoxeditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxeditorial.Location = new System.Drawing.Point(322, 278);
            this.textBoxeditorial.Name = "textBoxeditorial";
            this.textBoxeditorial.Size = new System.Drawing.Size(216, 30);
            this.textBoxeditorial.TabIndex = 15;
            // 
            // BuscarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxeditorial);
            this.Controls.Add(this.textBoxautor);
            this.Controls.Add(this.closebuscarform);
            this.Controls.Add(this.labeleditorial);
            this.Controls.Add(this.labelautor);
            this.Controls.Add(this.labeltitulo);
            this.Controls.Add(this.textBoxtitulo);
            this.Controls.Add(this.buscarbutton2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BuscarForm";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.closebuscarform)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buscarbutton2;
        private System.Windows.Forms.TextBox textBoxtitulo;
        private System.Windows.Forms.Label labeltitulo;
        private System.Windows.Forms.Label labelautor;
        private System.Windows.Forms.Label labeleditorial;
        private System.Windows.Forms.PictureBox closebuscarform;
        private System.Windows.Forms.TextBox textBoxautor;
        private System.Windows.Forms.TextBox textBoxeditorial;
    }
}