namespace WindowsFormsApp1
{
    partial class insertlibro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(insertlibro));
            this.closeinsertlibro = new System.Windows.Forms.PictureBox();
            this.panelTopInsertar = new System.Windows.Forms.Panel();
            this.textBoxeditorialinsertar = new System.Windows.Forms.TextBox();
            this.textBoxautorinsertar = new System.Windows.Forms.TextBox();
            this.labeleditorialinsertar = new System.Windows.Forms.Label();
            this.labelautorinsertar = new System.Windows.Forms.Label();
            this.labeltituloinsertar = new System.Windows.Forms.Label();
            this.textBoxtituloinsertar = new System.Windows.Forms.TextBox();
            this.insertarbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.closeinsertlibro)).BeginInit();
            this.panelTopInsertar.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeinsertlibro
            // 
            this.closeinsertlibro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeinsertlibro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeinsertlibro.Image = ((System.Drawing.Image)(resources.GetObject("closeinsertlibro.Image")));
            this.closeinsertlibro.Location = new System.Drawing.Point(748, 7);
            this.closeinsertlibro.Name = "closeinsertlibro";
            this.closeinsertlibro.Size = new System.Drawing.Size(40, 40);
            this.closeinsertlibro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeinsertlibro.TabIndex = 3;
            this.closeinsertlibro.TabStop = false;
            this.closeinsertlibro.Click += new System.EventHandler(this.closeinsertlibro_Click);
            // 
            // panelTopInsertar
            // 
            this.panelTopInsertar.Controls.Add(this.closeinsertlibro);
            this.panelTopInsertar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopInsertar.Location = new System.Drawing.Point(0, 0);
            this.panelTopInsertar.Name = "panelTopInsertar";
            this.panelTopInsertar.Size = new System.Drawing.Size(800, 56);
            this.panelTopInsertar.TabIndex = 4;
            this.panelTopInsertar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTopInsertar_MouseDown);
            // 
            // textBoxeditorialinsertar
            // 
            this.textBoxeditorialinsertar.AcceptsReturn = true;
            this.textBoxeditorialinsertar.AcceptsTab = true;
            this.textBoxeditorialinsertar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxeditorialinsertar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.textBoxeditorialinsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxeditorialinsertar.Location = new System.Drawing.Point(379, 248);
            this.textBoxeditorialinsertar.Name = "textBoxeditorialinsertar";
            this.textBoxeditorialinsertar.Size = new System.Drawing.Size(216, 30);
            this.textBoxeditorialinsertar.TabIndex = 22;
            // 
            // textBoxautorinsertar
            // 
            this.textBoxautorinsertar.AcceptsReturn = true;
            this.textBoxautorinsertar.AcceptsTab = true;
            this.textBoxautorinsertar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxautorinsertar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.textBoxautorinsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxautorinsertar.Location = new System.Drawing.Point(379, 149);
            this.textBoxautorinsertar.Name = "textBoxautorinsertar";
            this.textBoxautorinsertar.Size = new System.Drawing.Size(216, 30);
            this.textBoxautorinsertar.TabIndex = 21;
            // 
            // labeleditorialinsertar
            // 
            this.labeleditorialinsertar.AutoSize = true;
            this.labeleditorialinsertar.Font = new System.Drawing.Font("Imprint MT Shadow", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeleditorialinsertar.Location = new System.Drawing.Point(117, 248);
            this.labeleditorialinsertar.Name = "labeleditorialinsertar";
            this.labeleditorialinsertar.Size = new System.Drawing.Size(123, 34);
            this.labeleditorialinsertar.TabIndex = 20;
            this.labeleditorialinsertar.Text = "Editorial";
            // 
            // labelautorinsertar
            // 
            this.labelautorinsertar.AutoSize = true;
            this.labelautorinsertar.Font = new System.Drawing.Font("Imprint MT Shadow", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelautorinsertar.Location = new System.Drawing.Point(117, 149);
            this.labelautorinsertar.Name = "labelautorinsertar";
            this.labelautorinsertar.Size = new System.Drawing.Size(88, 34);
            this.labelautorinsertar.TabIndex = 19;
            this.labelautorinsertar.Text = "Autor";
            // 
            // labeltituloinsertar
            // 
            this.labeltituloinsertar.AutoSize = true;
            this.labeltituloinsertar.Font = new System.Drawing.Font("Imprint MT Shadow", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltituloinsertar.Location = new System.Drawing.Point(117, 74);
            this.labeltituloinsertar.Name = "labeltituloinsertar";
            this.labeltituloinsertar.Size = new System.Drawing.Size(93, 34);
            this.labeltituloinsertar.TabIndex = 18;
            this.labeltituloinsertar.Text = "Título";
            // 
            // textBoxtituloinsertar
            // 
            this.textBoxtituloinsertar.AcceptsReturn = true;
            this.textBoxtituloinsertar.AcceptsTab = true;
            this.textBoxtituloinsertar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxtituloinsertar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.textBoxtituloinsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxtituloinsertar.Location = new System.Drawing.Point(379, 74);
            this.textBoxtituloinsertar.Name = "textBoxtituloinsertar";
            this.textBoxtituloinsertar.Size = new System.Drawing.Size(216, 30);
            this.textBoxtituloinsertar.TabIndex = 17;
            // 
            // insertarbutton
            // 
            this.insertarbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insertarbutton.FlatAppearance.BorderSize = 0;
            this.insertarbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aquamarine;
            this.insertarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insertarbutton.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertarbutton.ForeColor = System.Drawing.Color.Black;
            this.insertarbutton.Image = ((System.Drawing.Image)(resources.GetObject("insertarbutton.Image")));
            this.insertarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.insertarbutton.Location = new System.Drawing.Point(245, 317);
            this.insertarbutton.Name = "insertarbutton";
            this.insertarbutton.Size = new System.Drawing.Size(394, 67);
            this.insertarbutton.TabIndex = 16;
            this.insertarbutton.Text = "Insertar";
            this.insertarbutton.UseVisualStyleBackColor = true;
            this.insertarbutton.Click += new System.EventHandler(this.insertarbutton_Click);
            // 
            // insertlibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxeditorialinsertar);
            this.Controls.Add(this.textBoxautorinsertar);
            this.Controls.Add(this.labeleditorialinsertar);
            this.Controls.Add(this.labelautorinsertar);
            this.Controls.Add(this.labeltituloinsertar);
            this.Controls.Add(this.textBoxtituloinsertar);
            this.Controls.Add(this.insertarbutton);
            this.Controls.Add(this.panelTopInsertar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "insertlibro";
            this.Text = "insertlibro";
            ((System.ComponentModel.ISupportInitialize)(this.closeinsertlibro)).EndInit();
            this.panelTopInsertar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox closeinsertlibro;
        private System.Windows.Forms.Panel panelTopInsertar;
        private System.Windows.Forms.TextBox textBoxeditorialinsertar;
        private System.Windows.Forms.TextBox textBoxautorinsertar;
        private System.Windows.Forms.Label labeleditorialinsertar;
        private System.Windows.Forms.Label labelautorinsertar;
        private System.Windows.Forms.Label labeltituloinsertar;
        private System.Windows.Forms.TextBox textBoxtituloinsertar;
        private System.Windows.Forms.Button insertarbutton;
    }
}