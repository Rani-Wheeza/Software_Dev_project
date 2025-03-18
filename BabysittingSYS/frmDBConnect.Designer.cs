namespace BabysittingSYS
{
    partial class frmDBConnect
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
            this.bnOpen = new System.Windows.Forms.Button();
            this.bnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bnOpen
            // 
            this.bnOpen.Location = new System.Drawing.Point(290, 81);
            this.bnOpen.Name = "bnOpen";
            this.bnOpen.Size = new System.Drawing.Size(142, 51);
            this.bnOpen.TabIndex = 0;
            this.bnOpen.Text = "Open";
            this.bnOpen.UseVisualStyleBackColor = true;
            this.bnOpen.Click += new System.EventHandler(this.bnOpen_Click);
            // 
            // bnClose
            // 
            this.bnClose.Location = new System.Drawing.Point(290, 198);
            this.bnClose.Name = "bnClose";
            this.bnClose.Size = new System.Drawing.Size(142, 51);
            this.bnClose.TabIndex = 1;
            this.bnClose.Text = "Close";
            this.bnClose.UseVisualStyleBackColor = true;
            this.bnClose.Click += new System.EventHandler(this.bnClose_Click);
            // 
            // frmDBConnect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bnClose);
            this.Controls.Add(this.bnOpen);
            this.Name = "frmDBConnect";
            this.Text = "frmDBConnect";
            this.Load += new System.EventHandler(this.frmDBConnect_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bnOpen;
        private System.Windows.Forms.Button bnClose;
    }
}