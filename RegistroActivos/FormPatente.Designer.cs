namespace RegistroActivos
{
    partial class FormPatente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPatente));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAgregarPa = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TipoActivoPa = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescripcionPatente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombrePatente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValorPatente = new System.Windows.Forms.TextBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.PictureBox();
            this.btnEditarPa = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnPDF = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregarPa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditarPa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPDF)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarPa
            // 
            this.btnAgregarPa.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarPa.Image")));
            this.btnAgregarPa.Location = new System.Drawing.Point(21, 374);
            this.btnAgregarPa.Name = "btnAgregarPa";
            this.btnAgregarPa.Size = new System.Drawing.Size(113, 88);
            this.btnAgregarPa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAgregarPa.TabIndex = 76;
            this.btnAgregarPa.TabStop = false;
            this.btnAgregarPa.Click += new System.EventHandler(this.btnAgregarPa_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(78, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 27);
            this.label3.TabIndex = 74;
            this.label3.Text = "Tipo Activo";
            // 
            // TipoActivoPa
            // 
            this.TipoActivoPa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TipoActivoPa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoActivoPa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TipoActivoPa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipoActivoPa.ForeColor = System.Drawing.SystemColors.Info;
            this.TipoActivoPa.FormattingEnabled = true;
            this.TipoActivoPa.Items.AddRange(new object[] {
            "Tangible",
            "Intangible"});
            this.TipoActivoPa.Location = new System.Drawing.Point(21, 304);
            this.TipoActivoPa.Name = "TipoActivoPa";
            this.TipoActivoPa.Size = new System.Drawing.Size(209, 27);
            this.TipoActivoPa.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(787, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 27);
            this.label2.TabIndex = 72;
            this.label2.Text = "Descripcion";
            // 
            // txtDescripcionPatente
            // 
            this.txtDescripcionPatente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtDescripcionPatente.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionPatente.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txtDescripcionPatente.Location = new System.Drawing.Point(305, 97);
            this.txtDescripcionPatente.Multiline = true;
            this.txtDescripcionPatente.Name = "txtDescripcionPatente";
            this.txtDescripcionPatente.Size = new System.Drawing.Size(1051, 140);
            this.txtDescripcionPatente.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(88, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 27);
            this.label1.TabIndex = 66;
            this.label1.Text = "Nombre";
            // 
            // txtNombrePatente
            // 
            this.txtNombrePatente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtNombrePatente.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombrePatente.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txtNombrePatente.Location = new System.Drawing.Point(21, 97);
            this.txtNombrePatente.Name = "txtNombrePatente";
            this.txtNombrePatente.Size = new System.Drawing.Size(208, 30);
            this.txtNombrePatente.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(98, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 27);
            this.label4.TabIndex = 78;
            this.label4.Text = "Valor";
            // 
            // txtValorPatente
            // 
            this.txtValorPatente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtValorPatente.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorPatente.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txtValorPatente.Location = new System.Drawing.Point(21, 198);
            this.txtValorPatente.Name = "txtValorPatente";
            this.txtValorPatente.Size = new System.Drawing.Size(208, 30);
            this.txtValorPatente.TabIndex = 0;
            this.txtValorPatente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorPatente_KeyPress);
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtBuscar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txtBuscar.Location = new System.Drawing.Point(745, 300);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(208, 30);
            this.txtBuscar.TabIndex = 79;
            this.txtBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(806, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 27);
            this.label5.TabIndex = 80;
            this.label5.Text = "Buscar:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(140, 477);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(112, 88);
            this.btnEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEliminar.TabIndex = 86;
            this.btnEliminar.TabStop = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditarPa
            // 
            this.btnEditarPa.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarPa.Image")));
            this.btnEditarPa.Location = new System.Drawing.Point(140, 374);
            this.btnEditarPa.Name = "btnEditarPa";
            this.btnEditarPa.Size = new System.Drawing.Size(113, 88);
            this.btnEditarPa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEditarPa.TabIndex = 85;
            this.btnEditarPa.TabStop = false;
            this.btnEditarPa.Click += new System.EventHandler(this.btnEditarPa_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
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
            this.dataGridView1.Location = new System.Drawing.Point(305, 336);
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
            this.dataGridView1.Size = new System.Drawing.Size(1071, 264);
            this.dataGridView1.TabIndex = 88;
            // 
            // btnPDF
            // 
            this.btnPDF.Image = ((System.Drawing.Image)(resources.GetObject("btnPDF.Image")));
            this.btnPDF.Location = new System.Drawing.Point(21, 477);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(113, 88);
            this.btnPDF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPDF.TabIndex = 104;
            this.btnPDF.TabStop = false;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(670, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 38);
            this.label8.TabIndex = 112;
            this.label8.Text = "PATENTE";
            // 
            // FormPatente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1400, 612);
            this.Controls.Add(this.txtDescripcionPatente);
            this.Controls.Add(this.TipoActivoPa);
            this.Controls.Add(this.txtValorPatente);
            this.Controls.Add(this.txtNombrePatente);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnPDF);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditarPa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAgregarPa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPatente";
            this.Text = "FormPatente";
            this.Load += new System.EventHandler(this.FormPatente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregarPa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditarPa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPDF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnAgregarPa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox TipoActivoPa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescripcionPatente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombrePatente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValorPatente;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox btnEliminar;
        private System.Windows.Forms.PictureBox btnEditarPa;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox btnPDF;
        private System.Windows.Forms.Label label8;
    }
}