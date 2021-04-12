namespace RegistroActivos
{
    partial class FormAyuda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAyuda));
            this.labelHora = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtremitente = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbmensaje = new System.Windows.Forms.TextBox();
            this.asd = new System.Windows.Forms.Label();
            this.txtpara = new System.Windows.Forms.TextBox();
            this.txtasunto = new System.Windows.Forms.TextBox();
            this.btnAbrir = new System.Windows.Forms.PictureBox();
            this.txtadjuntos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Correo = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtcc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnEnviar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAbrir)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHora
            // 
            this.labelHora.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHora.AutoSize = true;
            this.labelHora.Font = new System.Drawing.Font("Century Gothic", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHora.Location = new System.Drawing.Point(656, 5);
            this.labelHora.Name = "labelHora";
            this.labelHora.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelHora.Size = new System.Drawing.Size(164, 63);
            this.labelHora.TabIndex = 3;
            this.labelHora.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(764, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 27);
            this.label4.TabIndex = 87;
            this.label4.Text = "De:";
            // 
            // txtremitente
            // 
            this.txtremitente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtremitente.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtremitente.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txtremitente.Location = new System.Drawing.Point(847, 123);
            this.txtremitente.Name = "txtremitente";
            this.txtremitente.Size = new System.Drawing.Size(541, 30);
            this.txtremitente.TabIndex = 0;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Image = ((System.Drawing.Image)(resources.GetObject("btnEnviar.Image")));
            this.btnEnviar.Location = new System.Drawing.Point(1218, 413);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(142, 88);
            this.btnEnviar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEnviar.TabIndex = 85;
            this.btnEnviar.TabStop = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(19, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 27);
            this.label3.TabIndex = 84;
            this.label3.Text = "Asunto:";
            // 
            // rtbmensaje
            // 
            this.rtbmensaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rtbmensaje.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbmensaje.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.rtbmensaje.Location = new System.Drawing.Point(24, 344);
            this.rtbmensaje.Multiline = true;
            this.rtbmensaje.Name = "rtbmensaje";
            this.rtbmensaje.Size = new System.Drawing.Size(1166, 233);
            this.rtbmensaje.TabIndex = 0;
            // 
            // asd
            // 
            this.asd.AutoSize = true;
            this.asd.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.asd.Location = new System.Drawing.Point(19, 123);
            this.asd.Name = "asd";
            this.asd.Size = new System.Drawing.Size(61, 27);
            this.asd.TabIndex = 80;
            this.asd.Text = "Para:";
            // 
            // txtpara
            // 
            this.txtpara.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtpara.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpara.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txtpara.Location = new System.Drawing.Point(102, 123);
            this.txtpara.Name = "txtpara";
            this.txtpara.Size = new System.Drawing.Size(582, 30);
            this.txtpara.TabIndex = 0;
            // 
            // txtasunto
            // 
            this.txtasunto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtasunto.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtasunto.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txtasunto.Location = new System.Drawing.Point(102, 189);
            this.txtasunto.Name = "txtasunto";
            this.txtasunto.Size = new System.Drawing.Size(582, 30);
            this.txtasunto.TabIndex = 0;
            // 
            // btnAbrir
            // 
            this.btnAbrir.Image = ((System.Drawing.Image)(resources.GetObject("btnAbrir.Image")));
            this.btnAbrir.Location = new System.Drawing.Point(1321, 265);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(39, 33);
            this.btnAbrir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAbrir.TabIndex = 89;
            this.btnAbrir.TabStop = false;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // txtadjuntos
            // 
            this.txtadjuntos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtadjuntos.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtadjuntos.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txtadjuntos.Location = new System.Drawing.Point(208, 268);
            this.txtadjuntos.Name = "txtadjuntos";
            this.txtadjuntos.Size = new System.Drawing.Size(1096, 30);
            this.txtadjuntos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(19, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 27);
            this.label1.TabIndex = 90;
            this.label1.Text = "Archivos adjuntos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(727, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 27);
            this.label2.TabIndex = 95;
            this.label2.Text = "Contraseña";
            // 
            // Correo
            // 
            this.Correo.AutoSize = true;
            this.Correo.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Correo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Correo.Location = new System.Drawing.Point(19, 74);
            this.Correo.Name = "Correo";
            this.Correo.Size = new System.Drawing.Size(73, 27);
            this.Correo.TabIndex = 93;
            this.Correo.Text = "Correo";
            // 
            // txtnombre
            // 
            this.txtnombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtnombre.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txtnombre.Location = new System.Drawing.Point(102, 70);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(582, 30);
            this.txtnombre.TabIndex = 0;
            // 
            // txtpassword
            // 
            this.txtpassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtpassword.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txtpassword.Location = new System.Drawing.Point(847, 71);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(541, 30);
            this.txtpassword.TabIndex = 0;
            this.txtpassword.Enter += new System.EventHandler(this.txtpassword_Enter);
            // 
            // txtcc
            // 
            this.txtcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtcc.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcc.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txtcc.Location = new System.Drawing.Point(847, 179);
            this.txtcc.Name = "txtcc";
            this.txtcc.Size = new System.Drawing.Size(541, 30);
            this.txtcc.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(764, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 27);
            this.label5.TabIndex = 96;
            this.label5.Text = "CC";
            // 
            // FormAyuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1400, 612);
            this.Controls.Add(this.rtbmensaje);
            this.Controls.Add(this.txtadjuntos);
            this.Controls.Add(this.txtcc);
            this.Controls.Add(this.txtasunto);
            this.Controls.Add(this.txtremitente);
            this.Controls.Add(this.txtpara);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Correo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.asd);
            this.Controls.Add(this.labelHora);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAyuda";
            this.Text = "FormAyuda";
            ((System.ComponentModel.ISupportInitialize)(this.btnEnviar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAbrir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtremitente;
        private System.Windows.Forms.PictureBox btnEnviar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox rtbmensaje;
        private System.Windows.Forms.Label asd;
        private System.Windows.Forms.TextBox txtpara;
        private System.Windows.Forms.TextBox txtasunto;
        private System.Windows.Forms.PictureBox btnAbrir;
        private System.Windows.Forms.TextBox txtadjuntos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Correo;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtcc;
        private System.Windows.Forms.Label label5;
    }
}