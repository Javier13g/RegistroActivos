namespace RegistroActivos
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.BotonMaximizar = new System.Windows.Forms.PictureBox();
            this.BotonCerrar = new System.Windows.Forms.PictureBox();
            this.Menu = new System.Windows.Forms.Panel();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.BotonMinimizar = new System.Windows.Forms.PictureBox();
            this.BotonRestaurar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BotonMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonCerrar)).BeginInit();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BotonMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BarraTitulo.Controls.Add(this.BotonRestaurar);
            this.BarraTitulo.Controls.Add(this.BotonMinimizar);
            this.BarraTitulo.Controls.Add(this.BotonMaximizar);
            this.BarraTitulo.Controls.Add(this.BotonCerrar);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1300, 38);
            this.BarraTitulo.TabIndex = 0;
            // 
            // BotonMaximizar
            // 
            this.BotonMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BotonMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("BotonMaximizar.Image")));
            this.BotonMaximizar.Location = new System.Drawing.Point(1232, 5);
            this.BotonMaximizar.Name = "BotonMaximizar";
            this.BotonMaximizar.Size = new System.Drawing.Size(25, 25);
            this.BotonMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BotonMaximizar.TabIndex = 1;
            this.BotonMaximizar.TabStop = false;
            this.BotonMaximizar.Click += new System.EventHandler(this.BotonMaximizar_Click);
            // 
            // BotonCerrar
            // 
            this.BotonCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BotonCerrar.Image = ((System.Drawing.Image)(resources.GetObject("BotonCerrar.Image")));
            this.BotonCerrar.Location = new System.Drawing.Point(1263, 5);
            this.BotonCerrar.Name = "BotonCerrar";
            this.BotonCerrar.Size = new System.Drawing.Size(25, 25);
            this.BotonCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BotonCerrar.TabIndex = 0;
            this.BotonCerrar.TabStop = false;
            this.BotonCerrar.Click += new System.EventHandler(this.BotonCerrar_Click);
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Menu.Controls.Add(this.pictureBox1);
            this.Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menu.Location = new System.Drawing.Point(0, 38);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(200, 612);
            this.Menu.TabIndex = 1;
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(200, 38);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1100, 612);
            this.panelContenedor.TabIndex = 2;
            // 
            // BotonMinimizar
            // 
            this.BotonMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BotonMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("BotonMinimizar.Image")));
            this.BotonMinimizar.Location = new System.Drawing.Point(1201, 4);
            this.BotonMinimizar.Name = "BotonMinimizar";
            this.BotonMinimizar.Size = new System.Drawing.Size(25, 25);
            this.BotonMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BotonMinimizar.TabIndex = 2;
            this.BotonMinimizar.TabStop = false;
            this.BotonMinimizar.Click += new System.EventHandler(this.BotonMinimizar_Click);
            // 
            // BotonRestaurar
            // 
            this.BotonRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BotonRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("BotonRestaurar.Image")));
            this.BotonRestaurar.Location = new System.Drawing.Point(1232, 4);
            this.BotonRestaurar.Name = "BotonRestaurar";
            this.BotonRestaurar.Size = new System.Drawing.Size(25, 25);
            this.BotonRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BotonRestaurar.TabIndex = 3;
            this.BotonRestaurar.TabStop = false;
            this.BotonRestaurar.Visible = false;
            this.BotonRestaurar.Click += new System.EventHandler(this.BotonRestaurar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPrincipal";
            this.Text = "Form1";
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BotonMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonCerrar)).EndInit();
            this.Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BotonMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Panel Menu;
        private System.Windows.Forms.PictureBox BotonMaximizar;
        private System.Windows.Forms.PictureBox BotonCerrar;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox BotonMinimizar;
        private System.Windows.Forms.PictureBox BotonRestaurar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

