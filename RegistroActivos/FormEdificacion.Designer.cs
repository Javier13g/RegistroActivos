namespace RegistroActivos
{
    partial class FormEdificacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEdificacion));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAgregarEd = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TipoActivoEd = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValorEdificio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDimensionEdi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnEditarEd = new System.Windows.Forms.PictureBox();
            this.btnEliminarEd = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnPDF = new System.Windows.Forms.PictureBox();
            this.txtLongitud = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLatitud = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregarEd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditarEd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminarEd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPDF)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregarEd
            // 
            this.btnAgregarEd.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarEd.Image")));
            this.btnAgregarEd.Location = new System.Drawing.Point(255, 158);
            this.btnAgregarEd.Name = "btnAgregarEd";
            this.btnAgregarEd.Size = new System.Drawing.Size(142, 88);
            this.btnAgregarEd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAgregarEd.TabIndex = 76;
            this.btnAgregarEd.TabStop = false;
            this.btnAgregarEd.Click += new System.EventHandler(this.btnAgregarEd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(67, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 27);
            this.label3.TabIndex = 74;
            this.label3.Text = "Tipo Activo";
            // 
            // TipoActivoEd
            // 
            this.TipoActivoEd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TipoActivoEd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoActivoEd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TipoActivoEd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipoActivoEd.ForeColor = System.Drawing.SystemColors.Info;
            this.TipoActivoEd.FormattingEnabled = true;
            this.TipoActivoEd.Items.AddRange(new object[] {
            "Tangible",
            "Intangible"});
            this.TipoActivoEd.Location = new System.Drawing.Point(13, 259);
            this.TipoActivoEd.Name = "TipoActivoEd";
            this.TipoActivoEd.Size = new System.Drawing.Size(209, 27);
            this.TipoActivoEd.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(90, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 27);
            this.label2.TabIndex = 72;
            this.label2.Text = "Valor";
            // 
            // txtValorEdificio
            // 
            this.txtValorEdificio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtValorEdificio.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorEdificio.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txtValorEdificio.Location = new System.Drawing.Point(13, 172);
            this.txtValorEdificio.Name = "txtValorEdificio";
            this.txtValorEdificio.Size = new System.Drawing.Size(208, 30);
            this.txtValorEdificio.TabIndex = 0;
            this.txtValorEdificio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorEdificio_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(80, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 27);
            this.label1.TabIndex = 66;
            this.label1.Text = "Tamaño";
            // 
            // txtDimensionEdi
            // 
            this.txtDimensionEdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtDimensionEdi.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDimensionEdi.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txtDimensionEdi.Location = new System.Drawing.Point(13, 87);
            this.txtDimensionEdi.Name = "txtDimensionEdi";
            this.txtDimensionEdi.Size = new System.Drawing.Size(208, 30);
            this.txtDimensionEdi.TabIndex = 0;
            this.txtDimensionEdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDimensionEdi_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(664, 379);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 27);
            this.label5.TabIndex = 82;
            this.label5.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtBuscar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txtBuscar.Location = new System.Drawing.Point(603, 409);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(208, 30);
            this.txtBuscar.TabIndex = 81;
            this.txtBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyUp);
            // 
            // btnEditarEd
            // 
            this.btnEditarEd.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarEd.Image")));
            this.btnEditarEd.Location = new System.Drawing.Point(404, 158);
            this.btnEditarEd.Name = "btnEditarEd";
            this.btnEditarEd.Size = new System.Drawing.Size(142, 88);
            this.btnEditarEd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEditarEd.TabIndex = 83;
            this.btnEditarEd.TabStop = false;
            this.btnEditarEd.Click += new System.EventHandler(this.btnEditarEd_Click);
            // 
            // btnEliminarEd
            // 
            this.btnEliminarEd.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarEd.Image")));
            this.btnEliminarEd.Location = new System.Drawing.Point(254, 257);
            this.btnEliminarEd.Name = "btnEliminarEd";
            this.btnEliminarEd.Size = new System.Drawing.Size(142, 88);
            this.btnEliminarEd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEliminarEd.TabIndex = 84;
            this.btnEliminarEd.TabStop = false;
            this.btnEliminarEd.Click += new System.EventHandler(this.btnEliminarEd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.SteelBlue;
            this.dataGridView1.Location = new System.Drawing.Point(12, 441);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Size = new System.Drawing.Size(1368, 159);
            this.dataGridView1.TabIndex = 88;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.SeleccionarUbicacion);
            // 
            // btnPDF
            // 
            this.btnPDF.Image = ((System.Drawing.Image)(resources.GetObject("btnPDF.Image")));
            this.btnPDF.Location = new System.Drawing.Point(402, 257);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(144, 88);
            this.btnPDF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPDF.TabIndex = 104;
            this.btnPDF.TabStop = false;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // txtLongitud
            // 
            this.txtLongitud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtLongitud.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLongitud.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txtLongitud.Location = new System.Drawing.Point(248, 87);
            this.txtLongitud.Name = "txtLongitud";
            this.txtLongitud.Size = new System.Drawing.Size(208, 30);
            this.txtLongitud.TabIndex = 111;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(310, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 27);
            this.label7.TabIndex = 112;
            this.label7.Text = "Longitud";
            // 
            // txtLatitud
            // 
            this.txtLatitud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtLatitud.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLatitud.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txtLatitud.Location = new System.Drawing.Point(11, 331);
            this.txtLatitud.Name = "txtLatitud";
            this.txtLatitud.Size = new System.Drawing.Size(211, 30);
            this.txtLatitud.TabIndex = 109;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(80, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 27);
            this.label6.TabIndex = 110;
            this.label6.Text = "Latitud";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gMapControl1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(640, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(748, 321);
            this.groupBox1.TabIndex = 113;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ubicacion Edificios";
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(14, 21);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(726, 294);
            this.gMapControl1.TabIndex = 104;
            this.gMapControl1.Zoom = 0D;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(596, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(248, 38);
            this.label8.TabIndex = 110;
            this.label8.Text = "EDIFICACIONES";
            // 
            // FormEdificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1400, 612);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtDimensionEdi);
            this.Controls.Add(this.txtValorEdificio);
            this.Controls.Add(this.TipoActivoEd);
            this.Controls.Add(this.txtLongitud);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtLatitud);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnPDF);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnEliminarEd);
            this.Controls.Add(this.btnEditarEd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnAgregarEd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEdificacion";
            this.Text = "FormEdificacion";
            this.Load += new System.EventHandler(this.FormEdificacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregarEd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditarEd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminarEd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPDF)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnAgregarEd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox TipoActivoEd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValorEdificio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDimensionEdi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.PictureBox btnEditarEd;
        private System.Windows.Forms.PictureBox btnEliminarEd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox btnPDF;
        private System.Windows.Forms.TextBox txtLongitud;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLatitud;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.Label label8;
    }
}