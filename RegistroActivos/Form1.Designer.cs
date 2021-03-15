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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.BotonRestaurar = new System.Windows.Forms.PictureBox();
            this.BotonMinimizar = new System.Windows.Forms.PictureBox();
            this.BotonMaximizar = new System.Windows.Forms.PictureBox();
            this.BotonCerrar = new System.Windows.Forms.PictureBox();
            this.Menu = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.botonPatente = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.botonMaquinaria = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.botonEdificaciones = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.botonVehiculo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTerrenos = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelHora = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.fechaHora = new System.Windows.Forms.Timer(this.components);
            this.panel6 = new System.Windows.Forms.Panel();
            this.botonUsuario = new System.Windows.Forms.Button();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelCorreo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.botonAyuda = new System.Windows.Forms.Button();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BotonRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonCerrar)).BeginInit();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BarraTitulo.Controls.Add(this.labelTitulo);
            this.BarraTitulo.Controls.Add(this.BotonRestaurar);
            this.BarraTitulo.Controls.Add(this.BotonMinimizar);
            this.BarraTitulo.Controls.Add(this.BotonMaximizar);
            this.BarraTitulo.Controls.Add(this.BotonCerrar);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1300, 38);
            this.BarraTitulo.TabIndex = 0;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // labelTitulo
            // 
            this.labelTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(515, 5);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(268, 30);
            this.labelTitulo.TabIndex = 4;
            this.labelTitulo.Text = "Registro de Activos Fijos";
            this.labelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelTitulo_MouseDown);
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
            this.Menu.Controls.Add(this.panel7);
            this.Menu.Controls.Add(this.botonAyuda);
            this.Menu.Controls.Add(this.label1);
            this.Menu.Controls.Add(this.labelCorreo);
            this.Menu.Controls.Add(this.labelNombre);
            this.Menu.Controls.Add(this.panel6);
            this.Menu.Controls.Add(this.botonUsuario);
            this.Menu.Controls.Add(this.panel5);
            this.Menu.Controls.Add(this.botonPatente);
            this.Menu.Controls.Add(this.panel4);
            this.Menu.Controls.Add(this.botonMaquinaria);
            this.Menu.Controls.Add(this.panel3);
            this.Menu.Controls.Add(this.botonEdificaciones);
            this.Menu.Controls.Add(this.panel2);
            this.Menu.Controls.Add(this.botonVehiculo);
            this.Menu.Controls.Add(this.panel1);
            this.Menu.Controls.Add(this.btnTerrenos);
            this.Menu.Controls.Add(this.pictureBox1);
            this.Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menu.Location = new System.Drawing.Point(0, 38);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(200, 612);
            this.Menu.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel5.Location = new System.Drawing.Point(0, 380);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(12, 32);
            this.panel5.TabIndex = 10;
            // 
            // botonPatente
            // 
            this.botonPatente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.botonPatente.FlatAppearance.BorderSize = 0;
            this.botonPatente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.botonPatente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonPatente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonPatente.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.botonPatente.Image = ((System.Drawing.Image)(resources.GetObject("botonPatente.Image")));
            this.botonPatente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonPatente.Location = new System.Drawing.Point(12, 380);
            this.botonPatente.Name = "botonPatente";
            this.botonPatente.Size = new System.Drawing.Size(188, 32);
            this.botonPatente.TabIndex = 11;
            this.botonPatente.Text = "Patentes";
            this.botonPatente.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel4.Location = new System.Drawing.Point(0, 335);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(12, 32);
            this.panel4.TabIndex = 8;
            // 
            // botonMaquinaria
            // 
            this.botonMaquinaria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.botonMaquinaria.FlatAppearance.BorderSize = 0;
            this.botonMaquinaria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.botonMaquinaria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonMaquinaria.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonMaquinaria.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.botonMaquinaria.Image = ((System.Drawing.Image)(resources.GetObject("botonMaquinaria.Image")));
            this.botonMaquinaria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonMaquinaria.Location = new System.Drawing.Point(12, 335);
            this.botonMaquinaria.Name = "botonMaquinaria";
            this.botonMaquinaria.Size = new System.Drawing.Size(188, 32);
            this.botonMaquinaria.TabIndex = 9;
            this.botonMaquinaria.Text = "Maquinaria";
            this.botonMaquinaria.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel3.Location = new System.Drawing.Point(0, 290);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(12, 32);
            this.panel3.TabIndex = 6;
            // 
            // botonEdificaciones
            // 
            this.botonEdificaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.botonEdificaciones.FlatAppearance.BorderSize = 0;
            this.botonEdificaciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.botonEdificaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonEdificaciones.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonEdificaciones.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.botonEdificaciones.Image = ((System.Drawing.Image)(resources.GetObject("botonEdificaciones.Image")));
            this.botonEdificaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonEdificaciones.Location = new System.Drawing.Point(12, 290);
            this.botonEdificaciones.Name = "botonEdificaciones";
            this.botonEdificaciones.Size = new System.Drawing.Size(188, 32);
            this.botonEdificaciones.TabIndex = 7;
            this.botonEdificaciones.Text = "Edificaciones";
            this.botonEdificaciones.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel2.Location = new System.Drawing.Point(0, 246);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(12, 32);
            this.panel2.TabIndex = 4;
            // 
            // botonVehiculo
            // 
            this.botonVehiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.botonVehiculo.FlatAppearance.BorderSize = 0;
            this.botonVehiculo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.botonVehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonVehiculo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonVehiculo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.botonVehiculo.Image = ((System.Drawing.Image)(resources.GetObject("botonVehiculo.Image")));
            this.botonVehiculo.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.botonVehiculo.Location = new System.Drawing.Point(12, 246);
            this.botonVehiculo.Name = "botonVehiculo";
            this.botonVehiculo.Size = new System.Drawing.Size(188, 32);
            this.botonVehiculo.TabIndex = 5;
            this.botonVehiculo.Text = "Vehiculos";
            this.botonVehiculo.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel1.Location = new System.Drawing.Point(0, 204);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(12, 32);
            this.panel1.TabIndex = 3;
            // 
            // btnTerrenos
            // 
            this.btnTerrenos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnTerrenos.FlatAppearance.BorderSize = 0;
            this.btnTerrenos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnTerrenos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTerrenos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerrenos.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnTerrenos.Image = ((System.Drawing.Image)(resources.GetObject("btnTerrenos.Image")));
            this.btnTerrenos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTerrenos.Location = new System.Drawing.Point(12, 204);
            this.btnTerrenos.Name = "btnTerrenos";
            this.btnTerrenos.Size = new System.Drawing.Size(188, 32);
            this.btnTerrenos.TabIndex = 3;
            this.btnTerrenos.Text = "Terrenos";
            this.btnTerrenos.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panelContenedor.Controls.Add(this.pictureBox2);
            this.panelContenedor.Controls.Add(this.labelHora);
            this.panelContenedor.Controls.Add(this.labelFecha);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(200, 38);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1100, 612);
            this.panelContenedor.TabIndex = 2;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(458, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(185, 106);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // labelHora
            // 
            this.labelHora.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHora.AutoSize = true;
            this.labelHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHora.Location = new System.Drawing.Point(384, 136);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(249, 91);
            this.labelHora.TabIndex = 1;
            this.labelHora.Text = "label1";
            // 
            // labelFecha
            // 
            this.labelFecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.Location = new System.Drawing.Point(283, 244);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(126, 46);
            this.labelFecha.TabIndex = 0;
            this.labelFecha.Text = "label1";
            // 
            // fechaHora
            // 
            this.fechaHora.Enabled = true;
            this.fechaHora.Tick += new System.EventHandler(this.fechaHora_Tick);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel6.Location = new System.Drawing.Point(0, 424);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(12, 32);
            this.panel6.TabIndex = 12;
            // 
            // botonUsuario
            // 
            this.botonUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.botonUsuario.FlatAppearance.BorderSize = 0;
            this.botonUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.botonUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonUsuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonUsuario.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.botonUsuario.Image = ((System.Drawing.Image)(resources.GetObject("botonUsuario.Image")));
            this.botonUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonUsuario.Location = new System.Drawing.Point(12, 424);
            this.botonUsuario.Name = "botonUsuario";
            this.botonUsuario.Size = new System.Drawing.Size(188, 32);
            this.botonUsuario.TabIndex = 13;
            this.botonUsuario.Text = "Usuarios";
            this.botonUsuario.UseVisualStyleBackColor = false;
            this.botonUsuario.Click += new System.EventHandler(this.botonUsuario_Click);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelNombre.Location = new System.Drawing.Point(36, 104);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(126, 18);
            this.labelNombre.TabIndex = 3;
            this.labelNombre.Text = "Nombre Usuario";
            // 
            // labelCorreo
            // 
            this.labelCorreo.AutoSize = true;
            this.labelCorreo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCorreo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelCorreo.Location = new System.Drawing.Point(67, 135);
            this.labelCorreo.Name = "labelCorreo";
            this.labelCorreo.Size = new System.Drawing.Size(60, 18);
            this.labelCorreo.TabIndex = 14;
            this.labelCorreo.Text = "Correo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(67, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Cargo";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel7.Location = new System.Drawing.Point(0, 465);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(12, 32);
            this.panel7.TabIndex = 16;
            // 
            // botonAyuda
            // 
            this.botonAyuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.botonAyuda.FlatAppearance.BorderSize = 0;
            this.botonAyuda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.botonAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonAyuda.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAyuda.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.botonAyuda.Image = ((System.Drawing.Image)(resources.GetObject("botonAyuda.Image")));
            this.botonAyuda.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.botonAyuda.Location = new System.Drawing.Point(12, 465);
            this.botonAyuda.Name = "botonAyuda";
            this.botonAyuda.Size = new System.Drawing.Size(188, 32);
            this.botonAyuda.TabIndex = 17;
            this.botonAyuda.Text = "Ayuda";
            this.botonAyuda.UseVisualStyleBackColor = false;
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
            this.BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BotonRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonCerrar)).EndInit();
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Timer fechaHora;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnTerrenos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button botonVehiculo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button botonEdificaciones;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button botonMaquinaria;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button botonPatente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCorreo;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button botonUsuario;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button botonAyuda;
    }
}

