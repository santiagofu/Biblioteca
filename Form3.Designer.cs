namespace WindowsFormsApp1
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.closeadminform = new System.Windows.Forms.PictureBox();
            this.buttonInsertar = new System.Windows.Forms.Button();
            this.modifybutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.closeadminform)).BeginInit();
            this.SuspendLayout();
            // 
            // closeadminform
            // 
            this.closeadminform.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeadminform.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeadminform.Image = ((System.Drawing.Image)(resources.GetObject("closeadminform.Image")));
            this.closeadminform.Location = new System.Drawing.Point(761, 12);
            this.closeadminform.Name = "closeadminform";
            this.closeadminform.Size = new System.Drawing.Size(27, 27);
            this.closeadminform.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeadminform.TabIndex = 14;
            this.closeadminform.TabStop = false;
            this.closeadminform.Click += new System.EventHandler(this.closeadminform_Click);
            // 
            // buttonInsertar
            // 
            this.buttonInsertar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInsertar.FlatAppearance.BorderSize = 0;
            this.buttonInsertar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.buttonInsertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInsertar.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsertar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonInsertar.Image = ((System.Drawing.Image)(resources.GetObject("buttonInsertar.Image")));
            this.buttonInsertar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonInsertar.Location = new System.Drawing.Point(130, 80);
            this.buttonInsertar.Name = "buttonInsertar";
            this.buttonInsertar.Size = new System.Drawing.Size(616, 67);
            this.buttonInsertar.TabIndex = 15;
            this.buttonInsertar.Text = "Insertar Libro";
            this.buttonInsertar.UseVisualStyleBackColor = true;
            this.buttonInsertar.Click += new System.EventHandler(this.buttonInsertar_Click);
            // 
            // modifybutton
            // 
            this.modifybutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modifybutton.FlatAppearance.BorderSize = 0;
            this.modifybutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.modifybutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifybutton.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifybutton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.modifybutton.Image = ((System.Drawing.Image)(resources.GetObject("modifybutton.Image")));
            this.modifybutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.modifybutton.Location = new System.Drawing.Point(130, 261);
            this.modifybutton.Name = "modifybutton";
            this.modifybutton.Size = new System.Drawing.Size(616, 67);
            this.modifybutton.TabIndex = 16;
            this.modifybutton.Text = "Modificar/borrar  libro";
            this.modifybutton.UseVisualStyleBackColor = true;
            this.modifybutton.Click += new System.EventHandler(this.modifybutton_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.modifybutton);
            this.Controls.Add(this.buttonInsertar);
            this.Controls.Add(this.closeadminform);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminForm";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.closeadminform)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox closeadminform;
        private System.Windows.Forms.Button buttonInsertar;
        private System.Windows.Forms.Button modifybutton;
    }
}