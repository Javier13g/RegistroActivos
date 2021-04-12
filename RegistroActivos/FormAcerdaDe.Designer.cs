namespace RegistroActivos
{
    partial class FormAcerdaDe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAcerdaDe));
            this.labelHora = new System.Windows.Forms.Label();
            this.btn911 = new System.Windows.Forms.PictureBox();
            this.btnDominicanaGob = new System.Windows.Forms.PictureBox();
            this.btnAtencionCiudadana = new System.Windows.Forms.PictureBox();
            this.btnPolicia = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn911)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDominicanaGob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAtencionCiudadana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPolicia)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHora
            // 
            this.labelHora.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHora.AutoSize = true;
            this.labelHora.Font = new System.Drawing.Font("Century Gothic", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHora.Location = new System.Drawing.Point(392, 9);
            this.labelHora.Name = "labelHora";
            this.labelHora.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelHora.Size = new System.Drawing.Size(499, 63);
            this.labelHora.TabIndex = 2;
            this.labelHora.Text = "Páginas de Interés";
            // 
            // btn911
            // 
            this.btn911.Image = ((System.Drawing.Image)(resources.GetObject("btn911.Image")));
            this.btn911.Location = new System.Drawing.Point(184, 107);
            this.btn911.Name = "btn911";
            this.btn911.Size = new System.Drawing.Size(294, 117);
            this.btn911.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn911.TabIndex = 3;
            this.btn911.TabStop = false;
            this.btn911.Click += new System.EventHandler(this.btn911_Click);
            // 
            // btnDominicanaGob
            // 
            this.btnDominicanaGob.Image = ((System.Drawing.Image)(resources.GetObject("btnDominicanaGob.Image")));
            this.btnDominicanaGob.Location = new System.Drawing.Point(503, 107);
            this.btnDominicanaGob.Name = "btnDominicanaGob";
            this.btnDominicanaGob.Size = new System.Drawing.Size(294, 117);
            this.btnDominicanaGob.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDominicanaGob.TabIndex = 4;
            this.btnDominicanaGob.TabStop = false;
            this.btnDominicanaGob.Click += new System.EventHandler(this.btnDominicanaGob_Click);
            // 
            // btnAtencionCiudadana
            // 
            this.btnAtencionCiudadana.Image = ((System.Drawing.Image)(resources.GetObject("btnAtencionCiudadana.Image")));
            this.btnAtencionCiudadana.Location = new System.Drawing.Point(826, 107);
            this.btnAtencionCiudadana.Name = "btnAtencionCiudadana";
            this.btnAtencionCiudadana.Size = new System.Drawing.Size(294, 117);
            this.btnAtencionCiudadana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAtencionCiudadana.TabIndex = 5;
            this.btnAtencionCiudadana.TabStop = false;
            this.btnAtencionCiudadana.Click += new System.EventHandler(this.btnAtencionCiudadana_Click);
            // 
            // btnPolicia
            // 
            this.btnPolicia.Image = ((System.Drawing.Image)(resources.GetObject("btnPolicia.Image")));
            this.btnPolicia.Location = new System.Drawing.Point(504, 283);
            this.btnPolicia.Name = "btnPolicia";
            this.btnPolicia.Size = new System.Drawing.Size(294, 117);
            this.btnPolicia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPolicia.TabIndex = 6;
            this.btnPolicia.TabStop = false;
            this.btnPolicia.Click += new System.EventHandler(this.btnPolicia_Click);
            // 
            // FormAcerdaDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1400, 612);
            this.Controls.Add(this.btnPolicia);
            this.Controls.Add(this.btnAtencionCiudadana);
            this.Controls.Add(this.btnDominicanaGob);
            this.Controls.Add(this.btn911);
            this.Controls.Add(this.labelHora);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAcerdaDe";
            this.Text = "FormAcerdaDe";
            this.Load += new System.EventHandler(this.FormAcerdaDe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn911)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDominicanaGob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAtencionCiudadana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPolicia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.PictureBox btn911;
        private System.Windows.Forms.PictureBox btnDominicanaGob;
        private System.Windows.Forms.PictureBox btnAtencionCiudadana;
        private System.Windows.Forms.PictureBox btnPolicia;
    }
}