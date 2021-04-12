namespace RegistroActivos
{
    partial class FormProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProfile));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkEditPass = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtPassActual = new System.Windows.Forms.TextBox();
            this.btnEliminarMa = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtConfirmarPass = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCorreo = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.labelPosicion = new System.Windows.Forms.Label();
            this.labelCon = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminarMa)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(325, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(278, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panel1.Controls.Add(this.linkEditPass);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.btnEliminarMa);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(982, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 612);
            this.panel1.TabIndex = 1;
            this.panel1.Visible = false;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // linkEditPass
            // 
            this.linkEditPass.AutoSize = true;
            this.linkEditPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.linkEditPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkEditPass.LinkColor = System.Drawing.Color.White;
            this.linkEditPass.Location = new System.Drawing.Point(282, 252);
            this.linkEditPass.Name = "linkEditPass";
            this.linkEditPass.Size = new System.Drawing.Size(35, 16);
            this.linkEditPass.TabIndex = 93;
            this.linkEditPass.TabStop = true;
            this.linkEditPass.Text = "Edit";
            this.linkEditPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkEditPass_LinkClicked);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(220, 346);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 23);
            this.label7.TabIndex = 92;
            this.label7.Text = "Contraseña Actual";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtPassActual);
            this.panel6.Location = new System.Drawing.Point(209, 369);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(202, 60);
            this.panel6.TabIndex = 91;
            // 
            // txtPassActual
            // 
            this.txtPassActual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtPassActual.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassActual.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txtPassActual.Location = new System.Drawing.Point(10, 16);
            this.txtPassActual.Name = "txtPassActual";
            this.txtPassActual.Size = new System.Drawing.Size(184, 30);
            this.txtPassActual.TabIndex = 1;
            // 
            // btnEliminarMa
            // 
            this.btnEliminarMa.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarMa.Image")));
            this.btnEliminarMa.Location = new System.Drawing.Point(260, 465);
            this.btnEliminarMa.Name = "btnEliminarMa";
            this.btnEliminarMa.Size = new System.Drawing.Size(73, 57);
            this.btnEliminarMa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEliminarMa.TabIndex = 90;
            this.btnEliminarMa.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(18, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 23);
            this.label6.TabIndex = 80;
            this.label6.Text = "Confirmar Contraseña";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtConfirmarPass);
            this.panel5.Location = new System.Drawing.Point(3, 372);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(202, 60);
            this.panel5.TabIndex = 79;
            // 
            // txtConfirmarPass
            // 
            this.txtConfirmarPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtConfirmarPass.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmarPass.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txtConfirmarPass.Location = new System.Drawing.Point(8, 13);
            this.txtConfirmarPass.Name = "txtConfirmarPass";
            this.txtConfirmarPass.Size = new System.Drawing.Size(184, 30);
            this.txtConfirmarPass.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(99, 465);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 57);
            this.btnSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSave.TabIndex = 89;
            this.btnSave.TabStop = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(162, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 27);
            this.label5.TabIndex = 78;
            this.label5.Text = "Contraseña";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtPass);
            this.panel4.Location = new System.Drawing.Point(100, 274);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(238, 60);
            this.panel4.TabIndex = 77;
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtPass.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txtPass.Location = new System.Drawing.Point(15, 15);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(208, 30);
            this.txtPass.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(178, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 27);
            this.label3.TabIndex = 76;
            this.label3.Text = "Correo";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Location = new System.Drawing.Point(100, 172);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(238, 60);
            this.panel2.TabIndex = 75;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtEmail.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txtEmail.Location = new System.Drawing.Point(15, 15);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(208, 30);
            this.txtEmail.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(140, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 27);
            this.label4.TabIndex = 74;
            this.label4.Text = "Nombre Usuario";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtUser);
            this.panel3.Location = new System.Drawing.Point(99, 71);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(235, 60);
            this.panel3.TabIndex = 73;
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtUser.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txtUser.Location = new System.Drawing.Point(13, 15);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(208, 30);
            this.txtUser.TabIndex = 86;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(149, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 32);
            this.label2.TabIndex = 18;
            this.label2.Text = "Mis Datos";
            // 
            // labelCorreo
            // 
            this.labelCorreo.AutoSize = true;
            this.labelCorreo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCorreo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelCorreo.Location = new System.Drawing.Point(361, 310);
            this.labelCorreo.Name = "labelCorreo";
            this.labelCorreo.Size = new System.Drawing.Size(49, 16);
            this.labelCorreo.TabIndex = 16;
            this.labelCorreo.Text = "Correo";
            this.labelCorreo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelNombre.Location = new System.Drawing.Point(417, 279);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(102, 16);
            this.labelNombre.TabIndex = 15;
            this.labelNombre.Text = "Nombre Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(405, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 32);
            this.label1.TabIndex = 17;
            this.label1.Text = "My Profile";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(434, 375);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(103, 20);
            this.linkLabel1.TabIndex = 91;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Editar Perfil";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // labelPosicion
            // 
            this.labelPosicion.AutoSize = true;
            this.labelPosicion.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPosicion.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelPosicion.Location = new System.Drawing.Point(420, 331);
            this.labelPosicion.Name = "labelPosicion";
            this.labelPosicion.Size = new System.Drawing.Size(57, 16);
            this.labelPosicion.TabIndex = 92;
            this.labelPosicion.Text = "Posicion";
            // 
            // labelCon
            // 
            this.labelCon.AutoSize = true;
            this.labelCon.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCon.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelCon.Location = new System.Drawing.Point(420, 354);
            this.labelCon.Name = "labelCon";
            this.labelCon.Size = new System.Drawing.Size(57, 16);
            this.labelCon.TabIndex = 93;
            this.labelCon.Text = "Posicion";
            // 
            // FormProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1400, 612);
            this.Controls.Add(this.labelCon);
            this.Controls.Add(this.labelPosicion);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCorreo);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProfile";
            this.Text = "FormProfile";
            this.Load += new System.EventHandler(this.FormProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminarMa)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelCorreo;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtValorEdificio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtDimensionEdi;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtConfirmarPass;
        private System.Windows.Forms.PictureBox btnEliminarMa;
        private System.Windows.Forms.PictureBox btnSave;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtPassActual;
        private System.Windows.Forms.Label labelPosicion;
        private System.Windows.Forms.Label labelCon;
        private System.Windows.Forms.LinkLabel linkEditPass;
    }
}