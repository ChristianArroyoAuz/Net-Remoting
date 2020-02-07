namespace ClienteGolpea
{
    partial class ClienteGolpea
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
            this.lblGolpes = new System.Windows.Forms.Label();
            this.lblFallos = new System.Windows.Forms.Label();
            this.pnlPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblGolpes
            // 
            this.lblGolpes.AutoSize = true;
            this.lblGolpes.Location = new System.Drawing.Point(22, 31);
            this.lblGolpes.Name = "lblGolpes";
            this.lblGolpes.Size = new System.Drawing.Size(52, 13);
            this.lblGolpes.TabIndex = 0;
            this.lblGolpes.Text = "Golpes: 0";
            // 
            // lblFallos
            // 
            this.lblFallos.AutoSize = true;
            this.lblFallos.Location = new System.Drawing.Point(22, 62);
            this.lblFallos.Name = "lblFallos";
            this.lblFallos.Size = new System.Drawing.Size(46, 13);
            this.lblFallos.TabIndex = 1;
            this.lblFallos.Text = "Fallos: 0";
            // 
            // pnlPanel
            // 
            this.pnlPanel.Location = new System.Drawing.Point(12, 99);
            this.pnlPanel.Name = "pnlPanel";
            this.pnlPanel.Size = new System.Drawing.Size(587, 309);
            this.pnlPanel.TabIndex = 2;
            this.pnlPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlPanel_MouseDown);
            // 
            // frmClienteGolpea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 420);
            this.Controls.Add(this.pnlPanel);
            this.Controls.Add(this.lblFallos);
            this.Controls.Add(this.lblGolpes);
            this.Name = "frmClienteGolpea";
            this.Text = "Cliente Golpea";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGolpes;
        private System.Windows.Forms.Label lblFallos;
        private System.Windows.Forms.Panel pnlPanel;
    }
}

