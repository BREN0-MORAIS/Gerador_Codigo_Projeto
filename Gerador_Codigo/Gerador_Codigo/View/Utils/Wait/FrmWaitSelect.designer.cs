
namespace View
{
    partial class FrmWaitSelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWaitSelect));
            this.pctWait = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctWait)).BeginInit();
            this.SuspendLayout();
            // 
            // pctWait
            // 
            this.pctWait.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pctWait.Image = ((System.Drawing.Image)(resources.GetObject("pctWait.Image")));
            this.pctWait.Location = new System.Drawing.Point(0, 0);
            this.pctWait.Name = "pctWait";
            this.pctWait.Size = new System.Drawing.Size(100, 100);
            this.pctWait.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctWait.TabIndex = 4;
            this.pctWait.TabStop = false;
            // 
            // FrmWaitSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(198)))));
            this.ClientSize = new System.Drawing.Size(100, 100);
            this.Controls.Add(this.pctWait);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmWaitSelect";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmWaitSelect";
            ((System.ComponentModel.ISupportInitialize)(this.pctWait)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pctWait;
    }
}