namespace Tarea_3_CRUD
{
    partial class GenerarNomina
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
            this.datanomina = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sueldobruto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ahorros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totaldeduc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sueldoneto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.tbnumnomina = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbttbruto = new System.Windows.Forms.TextBox();
            this.cbmes = new System.Windows.Forms.ComboBox();
            this.btngenerar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbttdesc = new System.Windows.Forms.TextBox();
            this.tbttirs = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbttss = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbttneto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbttahorros = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnnomina = new System.Windows.Forms.Button();
            this.btnimprimir = new System.Windows.Forms.Button();
            this.btnnuevanomina = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnprocesar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbestado = new System.Windows.Forms.TextBox();
            this.btnemitir = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btneliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datanomina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // datanomina
            // 
            this.datanomina.AllowUserToAddRows = false;
            this.datanomina.AllowUserToDeleteRows = false;
            this.datanomina.AllowUserToResizeColumns = false;
            this.datanomina.AllowUserToResizeRows = false;
            this.datanomina.BackgroundColor = System.Drawing.Color.Azure;
            this.datanomina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datanomina.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.cedula,
            this.cargo,
            this.sueldobruto,
            this.isr,
            this.ss,
            this.ahorros,
            this.totaldeduc,
            this.sueldoneto});
            this.datanomina.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.datanomina.Location = new System.Drawing.Point(13, 79);
            this.datanomina.Name = "datanomina";
            this.datanomina.ReadOnly = true;
            this.datanomina.RowHeadersVisible = false;
            this.datanomina.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datanomina.Size = new System.Drawing.Size(903, 319);
            this.datanomina.TabIndex = 0;
            this.datanomina.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datanomina_CellDoubleClick);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // cedula
            // 
            this.cedula.HeaderText = "Cédula";
            this.cedula.Name = "cedula";
            this.cedula.ReadOnly = true;
            // 
            // cargo
            // 
            this.cargo.HeaderText = "Cargo";
            this.cargo.Name = "cargo";
            this.cargo.ReadOnly = true;
            // 
            // sueldobruto
            // 
            this.sueldobruto.HeaderText = "S. Bruto";
            this.sueldobruto.Name = "sueldobruto";
            this.sueldobruto.ReadOnly = true;
            // 
            // isr
            // 
            this.isr.HeaderText = "I.S.R.";
            this.isr.Name = "isr";
            this.isr.ReadOnly = true;
            // 
            // ss
            // 
            this.ss.HeaderText = "Deduc. S.S.";
            this.ss.Name = "ss";
            this.ss.ReadOnly = true;
            // 
            // ahorros
            // 
            this.ahorros.HeaderText = "Ahorros";
            this.ahorros.Name = "ahorros";
            this.ahorros.ReadOnly = true;
            // 
            // totaldeduc
            // 
            this.totaldeduc.HeaderText = "T.T. Deduc.";
            this.totaldeduc.Name = "totaldeduc";
            this.totaldeduc.ReadOnly = true;
            // 
            // sueldoneto
            // 
            this.sueldoneto.HeaderText = "Sueldo Neto";
            this.sueldoneto.Name = "sueldoneto";
            this.sueldoneto.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nómina";
            // 
            // tbnumnomina
            // 
            this.tbnumnomina.Enabled = false;
            this.tbnumnomina.Location = new System.Drawing.Point(98, 14);
            this.tbnumnomina.Name = "tbnumnomina";
            this.tbnumnomina.Size = new System.Drawing.Size(36, 20);
            this.tbnumnomina.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(334, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Total Bruto";
            // 
            // tbttbruto
            // 
            this.tbttbruto.Enabled = false;
            this.tbttbruto.Location = new System.Drawing.Point(410, 14);
            this.tbttbruto.Name = "tbttbruto";
            this.tbttbruto.Size = new System.Drawing.Size(96, 20);
            this.tbttbruto.TabIndex = 8;
            // 
            // cbmes
            // 
            this.cbmes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbmes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbmes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmes.FormattingEnabled = true;
            this.cbmes.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abrir",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.cbmes.Location = new System.Drawing.Point(179, 12);
            this.cbmes.Name = "cbmes";
            this.cbmes.Size = new System.Drawing.Size(121, 21);
            this.cbmes.TabIndex = 10;
            // 
            // btngenerar
            // 
            this.btngenerar.Location = new System.Drawing.Point(47, 40);
            this.btngenerar.Name = "btngenerar";
            this.btngenerar.Size = new System.Drawing.Size(126, 32);
            this.btngenerar.TabIndex = 11;
            this.btngenerar.Text = "Generar Nómina";
            this.btngenerar.UseVisualStyleBackColor = true;
            this.btngenerar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(512, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Total Descuentos";
            // 
            // tbttdesc
            // 
            this.tbttdesc.Enabled = false;
            this.tbttdesc.Location = new System.Drawing.Point(625, 48);
            this.tbttdesc.Name = "tbttdesc";
            this.tbttdesc.Size = new System.Drawing.Size(96, 20);
            this.tbttdesc.TabIndex = 14;
            // 
            // tbttirs
            // 
            this.tbttirs.Enabled = false;
            this.tbttirs.Location = new System.Drawing.Point(625, 13);
            this.tbttirs.Name = "tbttirs";
            this.tbttirs.Size = new System.Drawing.Size(96, 20);
            this.tbttirs.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(551, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "T.T. I.S.R.";
            // 
            // tbttss
            // 
            this.tbttss.Enabled = false;
            this.tbttss.Location = new System.Drawing.Point(800, 12);
            this.tbttss.Name = "tbttss";
            this.tbttss.Size = new System.Drawing.Size(96, 20);
            this.tbttss.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(743, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "T.T. SS";
            // 
            // tbttneto
            // 
            this.tbttneto.Enabled = false;
            this.tbttneto.Location = new System.Drawing.Point(800, 48);
            this.tbttneto.Name = "tbttneto";
            this.tbttneto.Size = new System.Drawing.Size(96, 20);
            this.tbttneto.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(727, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Total Neto";
            // 
            // tbttahorros
            // 
            this.tbttahorros.Enabled = false;
            this.tbttahorros.Location = new System.Drawing.Point(410, 47);
            this.tbttahorros.Name = "tbttahorros";
            this.tbttahorros.Size = new System.Drawing.Size(96, 20);
            this.tbttahorros.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(321, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Total Ahorros";
            // 
            // btnnomina
            // 
            this.btnnomina.Location = new System.Drawing.Point(179, 40);
            this.btnnomina.Name = "btnnomina";
            this.btnnomina.Size = new System.Drawing.Size(136, 32);
            this.btnnomina.TabIndex = 23;
            this.btnnomina.Text = "Buscar Nómina";
            this.btnnomina.UseVisualStyleBackColor = true;
            this.btnnomina.Click += new System.EventHandler(this.btnnomina_Click);
            // 
            // btnimprimir
            // 
            this.btnimprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimprimir.Location = new System.Drawing.Point(200, 415);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(138, 44);
            this.btnimprimir.TabIndex = 24;
            this.btnimprimir.Text = "Imprimir";
            this.btnimprimir.UseVisualStyleBackColor = true;
            this.btnimprimir.Click += new System.EventHandler(this.btnimprimir_Click);
            // 
            // btnnuevanomina
            // 
            this.btnnuevanomina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnuevanomina.Location = new System.Drawing.Point(352, 417);
            this.btnnuevanomina.Name = "btnnuevanomina";
            this.btnnuevanomina.Size = new System.Drawing.Size(172, 44);
            this.btnnuevanomina.TabIndex = 25;
            this.btnnuevanomina.Text = "Nueva Nómina";
            this.btnnuevanomina.UseVisualStyleBackColor = true;
            this.btnnuevanomina.Click += new System.EventHandler(this.btnnuevanomina_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 267);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(508, 118);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.Visible = false;
            // 
            // btnprocesar
            // 
            this.btnprocesar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnprocesar.Enabled = false;
            this.btnprocesar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprocesar.Location = new System.Drawing.Point(25, 415);
            this.btnprocesar.Name = "btnprocesar";
            this.btnprocesar.Size = new System.Drawing.Size(157, 46);
            this.btnprocesar.TabIndex = 24;
            this.btnprocesar.Text = "PROCESAR";
            this.btnprocesar.UseVisualStyleBackColor = false;
            this.btnprocesar.Click += new System.EventHandler(this.btnprocesar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Tarea_3_CRUD.Properties.Resources.engranaje_hi;
            this.pictureBox1.Location = new System.Drawing.Point(12, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tbestado
            // 
            this.tbestado.Enabled = false;
            this.tbestado.Location = new System.Drawing.Point(813, 408);
            this.tbestado.Name = "tbestado";
            this.tbestado.Size = new System.Drawing.Size(103, 20);
            this.tbestado.TabIndex = 4;
            // 
            // btnemitir
            // 
            this.btnemitir.BackColor = System.Drawing.Color.Coral;
            this.btnemitir.Enabled = false;
            this.btnemitir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnemitir.Location = new System.Drawing.Point(681, 432);
            this.btnemitir.Name = "btnemitir";
            this.btnemitir.Size = new System.Drawing.Size(194, 33);
            this.btnemitir.TabIndex = 24;
            this.btnemitir.Text = "Emitir Nómina";
            this.btnemitir.UseVisualStyleBackColor = false;
            this.btnemitir.Click += new System.EventHandler(this.btnemitir_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(638, 408);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 22);
            this.label9.TabIndex = 5;
            this.label9.Text = "Estado de la Nómina";
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.Red;
            this.btneliminar.Enabled = false;
            this.btneliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.Location = new System.Drawing.Point(530, 417);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(102, 42);
            this.btneliminar.TabIndex = 28;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // GenerarNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 471);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnnuevanomina);
            this.Controls.Add(this.btnemitir);
            this.Controls.Add(this.btnprocesar);
            this.Controls.Add(this.btnimprimir);
            this.Controls.Add(this.btnnomina);
            this.Controls.Add(this.tbttahorros);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbttneto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbttss);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbttirs);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbttdesc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btngenerar);
            this.Controls.Add(this.cbmes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbttbruto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbestado);
            this.Controls.Add(this.tbnumnomina);
            this.Controls.Add(this.datanomina);
            this.Name = "GenerarNomina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GenerarNomina";
            this.Load += new System.EventHandler(this.GenerarNomina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datanomina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datanomina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbnumnomina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbttbruto;
        private System.Windows.Forms.ComboBox cbmes;
        private System.Windows.Forms.Button btngenerar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbttdesc;
        private System.Windows.Forms.TextBox tbttirs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbttss;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbttneto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbttahorros;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnnomina;
        private System.Windows.Forms.Button btnimprimir;
        private System.Windows.Forms.Button btnnuevanomina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn sueldobruto;
        private System.Windows.Forms.DataGridViewTextBoxColumn isr;
        private System.Windows.Forms.DataGridViewTextBoxColumn ss;
        private System.Windows.Forms.DataGridViewTextBoxColumn ahorros;
        private System.Windows.Forms.DataGridViewTextBoxColumn totaldeduc;
        private System.Windows.Forms.DataGridViewTextBoxColumn sueldoneto;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnprocesar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbestado;
        private System.Windows.Forms.Button btnemitir;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btneliminar;
    }
}