namespace ClienteCorre
{
    partial class ClienteCorre
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
            this.pnlPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlPanel
            // 
            this.pnlPanel.Location = new System.Drawing.Point(12, 12);
            this.pnlPanel.Name = "pnlPanel";
            this.pnlPanel.Size = new System.Drawing.Size(587, 382);
            this.pnlPanel.TabIndex = 0;
            // 
            // frmClienteCorre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 405);
            this.Controls.Add(this.pnlPanel);
            this.Name = "frmClienteCorre";
            this.Text = "Cliente Corre";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPanel_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPanel;
    }
}

