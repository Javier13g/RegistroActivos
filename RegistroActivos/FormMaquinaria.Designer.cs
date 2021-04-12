namespace RegistroActivos
{
    partial class FormMaquinaria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMaquinaria));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAgregarMa = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TipoActivoMa = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValorMaquinaria = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnEliminarMa = new System.Windows.Forms.PictureBox();
            this.btnEditarMa = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnPDF = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtTipoMaquinaria = new System.Windows.Forms.TextBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregarMa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminarMa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditarMa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPDF)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarMa
            // 
            this.btnAgregarMa.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarMa.Image")));
            this.btnAgregarMa.Location = new System.Drawing.Point(2, 389);
            this.btnAgregarMa.Name = "btnAgregarMa";
            this.btnAgregarMa.Size = new System.Drawing.Size(142, 88);
            this.btnAgregarMa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAgregarMa.TabIndex = 84;
            this.btnAgregarMa.TabStop = false;
            this.btnAgregarMa.Click += new System.EventHandler(this.btnAgregarMa_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(85, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 27);
            this.label3.TabIndex = 82;
            this.label3.Text = "Tipo Activo";
            // 
            // TipoActivoMa
            // 
            this.TipoActivoMa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TipoActivoMa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoActivoMa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TipoActivoMa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipoActivoMa.ForeColor = System.Drawing.SystemColors.Info;
            this.TipoActivoMa.FormattingEnabled = true;
            this.TipoActivoMa.Items.AddRange(new object[] {
            "Tangible",
            "Intangible"});
            this.TipoActivoMa.Location = new System.Drawing.Point(31, 317);
            this.TipoActivoMa.Name = "TipoActivoMa";
            this.TipoActivoMa.Size = new System.Drawing.Size(209, 27);
            this.TipoActivoMa.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(107, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 27);
            this.label2.TabIndex = 80;
            this.label2.Text = "Valor";
            // 
            // txtValorMaquinaria
            // 
            this.txtValorMaquinaria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtValorMaquinaria.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorMaquinaria.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txtValorMaquinaria.Location = new System.Drawing.Point(32, 244);
            this.txtValorMaquinaria.Name = "txtValorMaquinaria";
            this.txtValorMaquinaria.Size = new System.Drawing.Size(208, 30);
            this.txtValorMaquinaria.TabIndex = 0;
            this.txtValorMaquinaria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorMaquinaria_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(66, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 27);
            this.label1.TabIndex = 78;
            this.label1.Text = "Tipo Maquinaria";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(811, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 27);
            this.label5.TabIndex = 86;
            this.label5.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtBuscar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txtBuscar.Location = new System.Drawing.Point(750, 251);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(208, 30);
            this.txtBuscar.TabIndex = 85;
            this.txtBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyUp);
            // 
            // btnEliminarMa
            // 
            this.btnEliminarMa.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarMa.Image")));
            this.btnEliminarMa.Location = new System.Drawing.Point(2, 483);
            this.btnEliminarMa.Name = "btnEliminarMa";
            this.btnEliminarMa.Size = new System.Drawing.Size(142, 88);
            this.btnEliminarMa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEliminarMa.TabIndex = 88;
            this.btnEliminarMa.TabStop = false;
            this.btnEliminarMa.Click += new System.EventHandler(this.btnEliminarMa_Click);
            // 
            // btnEditarMa
            // 
            this.btnEditarMa.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarMa.Image")));
            this.btnEditarMa.Location = new System.Drawing.Point(158, 389);
            this.btnEditarMa.Name = "btnEditarMa";
            this.btnEditarMa.Size = new System.Drawing.Size(142, 88);
            this.btnEditarMa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEditarMa.TabIndex = 87;
            this.btnEditarMa.TabStop = false;
            this.btnEditarMa.Click += new System.EventHandler(this.btnEditarMa_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(346, 288);
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
            this.dataGridView1.Size = new System.Drawing.Size(1032, 305);
            this.dataGridView1.TabIndex = 89;
            // 
            // btnPDF
            // 
            this.btnPDF.Image = ((System.Drawing.Image)(resources.GetObject("btnPDF.Image")));
            this.btnPDF.Location = new System.Drawing.Point(158, 483);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(142, 88);
            this.btnPDF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPDF.TabIndex = 104;
            this.btnPDF.TabStop = false;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(791, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 27);
            this.label4.TabIndex = 106;
            this.label4.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtDescripcion.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txtDescripcion.Location = new System.Drawing.Point(289, 108);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(1099, 107);
            this.txtDescripcion.TabIndex = 0;
            // 
            // txtTipoMaquinaria
            // 
            this.txtTipoMaquinaria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtTipoMaquinaria.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoMaquinaria.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txtTipoMaquinaria.Location = new System.Drawing.Point(35, 109);
            this.txtTipoMaquinaria.Name = "txtTipoMaquinaria";
            this.txtTipoMaquinaria.Size = new System.Drawing.Size(208, 30);
            this.txtTipoMaquinaria.TabIndex = 0;
            // 
            // txtMatricula
            // 
            this.txtMatricula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtMatricula.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatricula.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txtMatricula.Location = new System.Drawing.Point(33, 176);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(208, 30);
            this.txtMatricula.TabIndex = 107;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(87, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 27);
            this.label6.TabIndex = 108;
            this.label6.Text = "Matricula";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(617, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(214, 38);
            this.label8.TabIndex = 111;
            this.label8.Text = "MAQUINARIA";
            // 
            // FormMaquinaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1400, 612);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTipoMaquinaria);
            this.Controls.Add(this.TipoActivoMa);
            this.Controls.Add(this.txtValorMaquinaria);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnPDF);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnEliminarMa);
            this.Controls.Add(this.btnEditarMa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnAgregarMa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMaquinaria";
            this.Text = "FormMaquinaria";
            this.Load += new System.EventHandler(this.FormMaquinaria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregarMa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminarMa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditarMa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPDF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnAgregarMa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox TipoActivoMa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValorMaquinaria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.PictureBox btnEliminarMa;
        private System.Windows.Forms.PictureBox btnEditarMa;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox btnPDF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtTipoMaquinaria;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
    }
}