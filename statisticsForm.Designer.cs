namespace WindowsFormsApp1
{
    partial class statisticsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(statisticsForm));
            this.closestatsform = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.closestatsform)).BeginInit();
            this.SuspendLayout();
            // 
            // closestatsform
            // 
            this.closestatsform.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closestatsform.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closestatsform.Image = ((System.Drawing.Image)(resources.GetObject("closestatsform.Image")));
            this.closestatsform.Location = new System.Drawing.Point(761, 12);
            this.closestatsform.Name = "closestatsform";
            this.closestatsform.Size = new System.Drawing.Size(27, 27);
            this.closestatsform.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closestatsform.TabIndex = 15;
            this.closestatsform.TabStop = false;
            this.closestatsform.Click += new System.EventHandler(this.closestatsform_Click);
            // 
            // statisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.closestatsform);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "statisticsForm";
            this.Text = "statisticsForm";
            ((System.ComponentModel.ISupportInitialize)(this.closestatsform)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox closestatsform;
    }
}