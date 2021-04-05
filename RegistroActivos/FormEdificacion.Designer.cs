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
            this.panel3 = new System.Windows.Forms.Panel();
            this.TipoActivoEd = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtValorEdificio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDimensionEdi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnEditarEd = new System.Windows.Forms.PictureBox();
            this.btnEliminarEd = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnPDF = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregarEd)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditarEd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminarEd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPDF)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarEd
            // 
            this.btnAgregarEd.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarEd.Image")));
            this.btnAgregarEd.Location = new System.Drawing.Point(8, 380);
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
            this.label3.Location = new System.Drawing.Point(90, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 27);
            this.label3.TabIndex = 74;
            this.label3.Text = "Tipo Activo";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.TipoActivoEd);
            this.panel3.Location = new System.Drawing.Point(20, 299);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(238, 60);
            this.panel3.TabIndex = 73;
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
            this.TipoActivoEd.Location = new System.Drawing.Point(12, 13);
            this.TipoActivoEd.Name = "TipoActivoEd";
            this.TipoActivoEd.Size = new System.Drawing.Size(209, 27);
            this.TipoActivoEd.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(110, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 27);
            this.label2.TabIndex = 72;
            this.label2.Text = "Valor";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtValorEdificio);
            this.panel2.Location = new System.Drawing.Point(21, 169);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(238, 60);
            this.panel2.TabIndex = 71;
            // 
            // txtValorEdificio
            // 
            this.txtValorEdificio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtValorEdificio.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorEdificio.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txtValorEdificio.Location = new System.Drawing.Point(13, 15);
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
            this.label1.Location = new System.Drawing.Point(100, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 27);
            this.label1.TabIndex = 66;
            this.label1.Text = "Tamaño";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtDimensionEdi);
            this.panel1.Location = new System.Drawing.Point(20, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 60);
            this.panel1.TabIndex = 65;
            // 
            // txtDimensionEdi
            // 
            this.txtDimensionEdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtDimensionEdi.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDimensionEdi.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txtDimensionEdi.Location = new System.Drawing.Point(13, 15);
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
            this.label5.Location = new System.Drawing.Point(642, 22);
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
            this.txtBuscar.Location = new System.Drawing.Point(581, 52);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(208, 30);
            this.txtBuscar.TabIndex = 81;
            this.txtBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyUp);
            // 
            // btnEditarEd
            // 
            this.btnEditarEd.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarEd.Image")));
            this.btnEditarEd.Location = new System.Drawing.Point(157, 380);
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
            this.btnEliminarEd.Location = new System.Drawing.Point(7, 479);
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
            this.dataGridView1.Location = new System.Drawing.Point(333, 116);
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
            this.dataGridView1.Size = new System.Drawing.Size(722, 393);
            this.dataGridView1.TabIndex = 88;
            // 
            // btnPDF
            // 
            this.btnPDF.Image = ((System.Drawing.Image)(resources.GetObject("btnPDF.Image")));
            this.btnPDF.Location = new System.Drawing.Point(155, 479);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(144, 88);
            this.btnPDF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPDF.TabIndex = 104;
            this.btnPDF.TabStop = false;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // FormEdificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1084, 573);
            this.Controls.Add(this.btnPDF);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnEliminarEd);
            this.Controls.Add(this.btnEditarEd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnAgregarEd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEdificacion";
            this.Text = "FormEdificacion";
            this.Load += new System.EventHandler(this.FormEdificacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregarEd)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditarEd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminarEd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPDF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnAgregarEd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox TipoActivoEd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtValorEdificio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDimensionEdi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.PictureBox btnEditarEd;
        private System.Windows.Forms.PictureBox btnEliminarEd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox btnPDF;
    }
}