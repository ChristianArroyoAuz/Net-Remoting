namespace Cliente
{
    partial class Chat
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
            this.lblHistorial = new System.Windows.Forms.Label();
            this.lblMiembros = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtEnviar = new System.Windows.Forms.TextBox();
            this.lstMiembros = new System.Windows.Forms.ListBox();
            this.rtxHistorial = new System.Windows.Forms.RichTextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblHistorial
            // 
            this.lblHistorial.AutoSize = true;
            this.lblHistorial.Location = new System.Drawing.Point(22, 227);
            this.lblHistorial.Name = "lblHistorial";
            this.lblHistorial.Size = new System.Drawing.Size(44, 13);
            this.lblHistorial.TabIndex = 0;
            this.lblHistorial.Text = "Historial";
            // 
            // lblMiembros
            // 
            this.lblMiembros.AutoSize = true;
            this.lblMiembros.Location = new System.Drawing.Point(504, 227);
            this.lblMiembros.Name = "lblMiembros";
            this.lblMiembros.Size = new System.Drawing.Size(52, 13);
            this.lblMiembros.TabIndex = 1;
            this.lblMiembros.Text = "Miembros";
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(22, 27);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 23);
            this.btnIniciar.TabIndex = 2;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Location = new System.Drawing.Point(507, 27);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(80, 23);
            this.btnCerrarSesion.TabIndex = 3;
            this.btnCerrarSesion.Text = "Cerrar Sesion";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(508, 95);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(508, 147);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 5;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // txtEnviar
            // 
            this.txtEnviar.Location = new System.Drawing.Point(22, 78);
            this.txtEnviar.Multiline = true;
            this.txtEnviar.Name = "txtEnviar";
            this.txtEnviar.Size = new System.Drawing.Size(100, 78);
            this.txtEnviar.TabIndex = 6;
            // 
            // lstMiembros
            // 
            this.lstMiembros.FormattingEnabled = true;
            this.lstMiembros.Location = new System.Drawing.Point(508, 253);
            this.lstMiembros.Name = "lstMiembros";
            this.lstMiembros.Size = new System.Drawing.Size(120, 95);
            this.lstMiembros.TabIndex = 7;
            // 
            // rtxHistorial
            // 
            this.rtxHistorial.Location = new System.Drawing.Point(22, 253);
            this.rtxHistorial.Name = "rtxHistorial";
            this.rtxHistorial.Size = new System.Drawing.Size(100, 96);
            this.rtxHistorial.TabIndex = 8;
            this.rtxHistorial.Text = "";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(181, 267);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 9;
            // 
            // frmChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 519);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.rtxHistorial);
            this.Controls.Add(this.lstMiembros);
            this.Controls.Add(this.txtEnviar);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.lblMiembros);
            this.Controls.Add(this.lblHistorial);
            this.Name = "frmChat";
            this.Text = "Chat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHistorial;
        private System.Windows.Forms.Label lblMiembros;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txtEnviar;
        private System.Windows.Forms.ListBox lstMiembros;
        private System.Windows.Forms.RichTextBox rtxHistorial;
        private System.Windows.Forms.ListBox listBox1;
    }
}

