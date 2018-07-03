namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelVertical = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buscarbutton = new System.Windows.Forms.Button();
            this.estadisticasbutton = new System.Windows.Forms.Button();
            this.administrarbutton = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.minimize = new System.Windows.Forms.PictureBox();
            this.maximize = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.PictureBox();
            this.panelCentral = new System.Windows.Forms.Panel();
            this.labeldatetime = new System.Windows.Forms.Label();
            this.panelVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.panelCentral.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelVertical
            // 
            this.panelVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panelVertical.Controls.Add(this.pictureBox2);
            this.panelVertical.Controls.Add(this.pictureBox1);
            this.panelVertical.Controls.Add(this.buscarbutton);
            this.panelVertical.Controls.Add(this.estadisticasbutton);
            this.panelVertical.Controls.Add(this.administrarbutton);
            this.panelVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelVertical.Location = new System.Drawing.Point(0, 0);
            this.panelVertical.Name = "panelVertical";
            this.panelVertical.Size = new System.Drawing.Size(301, 650);
            this.panelVertical.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 50);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(301, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // buscarbutton
            // 
            this.buscarbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buscarbutton.FlatAppearance.BorderSize = 0;
            this.buscarbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.buscarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscarbutton.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarbutton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buscarbutton.Image = ((System.Drawing.Image)(resources.GetObject("buscarbutton.Image")));
            this.buscarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buscarbutton.Location = new System.Drawing.Point(0, 137);
            this.buscarbutton.Name = "buscarbutton";
            this.buscarbutton.Size = new System.Drawing.Size(301, 67);
            this.buscarbutton.TabIndex = 4;
            this.buscarbutton.Text = "Buscar";
            this.buscarbutton.UseVisualStyleBackColor = true;
            this.buscarbutton.Click += new System.EventHandler(this.buscarbutton_Click);
            // 
            // estadisticasbutton
            // 
            this.estadisticasbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.estadisticasbutton.FlatAppearance.BorderSize = 0;
            this.estadisticasbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.estadisticasbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.estadisticasbutton.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estadisticasbutton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.estadisticasbutton.Image = ((System.Drawing.Image)(resources.GetObject("estadisticasbutton.Image")));
            this.estadisticasbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.estadisticasbutton.Location = new System.Drawing.Point(0, 406);
            this.estadisticasbutton.Name = "estadisticasbutton";
            this.estadisticasbutton.Size = new System.Drawing.Size(301, 67);
            this.estadisticasbutton.TabIndex = 3;
            this.estadisticasbutton.Text = "Estadísticas";
            this.estadisticasbutton.UseVisualStyleBackColor = true;
            this.estadisticasbutton.Click += new System.EventHandler(this.estadisticasbutton_Click);
            // 
            // administrarbutton
            // 
            this.administrarbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.administrarbutton.FlatAppearance.BorderSize = 0;
            this.administrarbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.administrarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.administrarbutton.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.administrarbutton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.administrarbutton.Image = ((System.Drawing.Image)(resources.GetObject("administrarbutton.Image")));
            this.administrarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.administrarbutton.Location = new System.Drawing.Point(0, 270);
            this.administrarbutton.Name = "administrarbutton";
            this.administrarbutton.Size = new System.Drawing.Size(301, 67);
            this.administrarbutton.TabIndex = 2;
            this.administrarbutton.Text = "Administrar";
            this.administrarbutton.UseVisualStyleBackColor = true;
            this.administrarbutton.Click += new System.EventHandler(this.administrarbutton_Click);
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.minimize);
            this.panelTop.Controls.Add(this.maximize);
            this.panelTop.Controls.Add(this.close);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(301, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(999, 50);
            this.panelTop.TabIndex = 1;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            // 
            // minimize
            // 
            this.minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimize.Image = ((System.Drawing.Image)(resources.GetObject("minimize.Image")));
            this.minimize.Location = new System.Drawing.Point(828, 4);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(40, 40);
            this.minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimize.TabIndex = 2;
            this.minimize.TabStop = false;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // maximize
            // 
            this.maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maximize.Image = ((System.Drawing.Image)(resources.GetObject("maximize.Image")));
            this.maximize.Location = new System.Drawing.Point(888, 4);
            this.maximize.Name = "maximize";
            this.maximize.Size = new System.Drawing.Size(40, 40);
            this.maximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.maximize.TabIndex = 1;
            this.maximize.TabStop = false;
            this.maximize.Click += new System.EventHandler(this.maximize_Click);
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.Location = new System.Drawing.Point(948, 5);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(40, 40);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close.TabIndex = 0;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // panelCentral
            // 
            this.panelCentral.Controls.Add(this.labeldatetime);
            this.panelCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentral.Location = new System.Drawing.Point(301, 50);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(999, 600);
            this.panelCentral.TabIndex = 2;
            // 
            // labeldatetime
            // 
            this.labeldatetime.AutoSize = true;
            this.labeldatetime.Location = new System.Drawing.Point(119, 234);
            this.labeldatetime.Name = "labeldatetime";
            this.labeldatetime.Size = new System.Drawing.Size(0, 17);
            this.labeldatetime.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.panelCentral);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.panelCentral.ResumeLayout(false);
            this.panelCentral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelVertical;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelCentral;
        private System.Windows.Forms.PictureBox minimize;
        private System.Windows.Forms.PictureBox maximize;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.Button buscarbutton;
        private System.Windows.Forms.Button estadisticasbutton;
        private System.Windows.Forms.Button administrarbutton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labeldatetime;
    }
}

