namespace Tarea_3_CRUD
{
    partial class HEXTODEC
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
            this.btnguardar = new System.Windows.Forms.Button();
            this.tbnombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbapellidos = new System.Windows.Forms.TextBox();
            this.tbbuscar = new System.Windows.Forms.TextBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.rdbactivo = new System.Windows.Forms.RadioButton();
            this.rdbinactivo = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.cbcargo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbdepto = new System.Windows.Forms.ComboBox();
            this.btndepartagregar = new System.Windows.Forms.Button();
            this.btncargoagregar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbcedula = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtfechaing = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dtnacimiento = new System.Windows.Forms.DateTimePicker();
            this.tbsueldo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbahorro = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ptbfotoempleado = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbfotoempleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(20, 226);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(126, 59);
            this.btnguardar.TabIndex = 9;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnconvert_Click);
            // 
            // tbnombre
            // 
            this.tbnombre.Location = new System.Drawing.Point(114, 38);
            this.tbnombre.Name = "tbnombre";
            this.tbnombre.Size = new System.Drawing.Size(115, 20);
            this.tbnombre.TabIndex = 0;
            this.tbnombre.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbnombre_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID";
            // 
            // tbid
            // 
            this.tbid.Enabled = false;
            this.tbid.Location = new System.Drawing.Point(114, 12);
            this.tbid.Name = "tbid";
            this.tbid.Size = new System.Drawing.Size(61, 20);
            this.tbid.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Apellidos";
            // 
            // tbapellidos
            // 
            this.tbapellidos.Location = new System.Drawing.Point(114, 64);
            this.tbapellidos.Name = "tbapellidos";
            this.tbapellidos.Size = new System.Drawing.Size(163, 20);
            this.tbapellidos.TabIndex = 1;
            // 
            // tbbuscar
            // 
            this.tbbuscar.Location = new System.Drawing.Point(191, 265);
            this.tbbuscar.Name = "tbbuscar";
            this.tbbuscar.Size = new System.Drawing.Size(42, 20);
            this.tbbuscar.TabIndex = 10;
            this.tbbuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbbuscar_KeyUp);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(159, 228);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(104, 32);
            this.btnbuscar.TabIndex = 11;
            this.btnbuscar.Text = "Buscar Por ID";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(271, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 59);
            this.button1.TabIndex = 12;
            this.button1.Text = "Nuevo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(321, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Estado";
            // 
            // rdbactivo
            // 
            this.rdbactivo.AutoSize = true;
            this.rdbactivo.Checked = true;
            this.rdbactivo.Location = new System.Drawing.Point(288, 195);
            this.rdbactivo.Name = "rdbactivo";
            this.rdbactivo.Size = new System.Drawing.Size(55, 17);
            this.rdbactivo.TabIndex = 14;
            this.rdbactivo.TabStop = true;
            this.rdbactivo.Text = "Activo";
            this.rdbactivo.UseVisualStyleBackColor = true;
            // 
            // rdbinactivo
            // 
            this.rdbinactivo.AutoSize = true;
            this.rdbinactivo.Location = new System.Drawing.Point(347, 195);
            this.rdbinactivo.Name = "rdbinactivo";
            this.rdbinactivo.Size = new System.Drawing.Size(63, 17);
            this.rdbinactivo.TabIndex = 15;
            this.rdbinactivo.Text = "Inactivo";
            this.rdbinactivo.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(74, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Cargo";
            // 
            // cbcargo
            // 
            this.cbcargo.FormattingEnabled = true;
            this.cbcargo.Location = new System.Drawing.Point(115, 196);
            this.cbcargo.Name = "cbcargo";
            this.cbcargo.Size = new System.Drawing.Size(121, 21);
            this.cbcargo.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Departamento";
            // 
            // cbdepto
            // 
            this.cbdepto.FormattingEnabled = true;
            this.cbdepto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbdepto.Location = new System.Drawing.Point(115, 169);
            this.cbdepto.Name = "cbdepto";
            this.cbdepto.Size = new System.Drawing.Size(121, 21);
            this.cbdepto.TabIndex = 5;
            // 
            // btndepartagregar
            // 
            this.btndepartagregar.Location = new System.Drawing.Point(242, 169);
            this.btndepartagregar.Name = "btndepartagregar";
            this.btndepartagregar.Size = new System.Drawing.Size(22, 21);
            this.btndepartagregar.TabIndex = 16;
            this.btndepartagregar.Text = "+";
            this.btndepartagregar.UseVisualStyleBackColor = true;
            this.btndepartagregar.Click += new System.EventHandler(this.btndepartagregar_Click);
            // 
            // btncargoagregar
            // 
            this.btncargoagregar.Location = new System.Drawing.Point(242, 195);
            this.btncargoagregar.Name = "btncargoagregar";
            this.btncargoagregar.Size = new System.Drawing.Size(22, 21);
            this.btncargoagregar.TabIndex = 17;
            this.btncargoagregar.Text = "+";
            this.btncargoagregar.UseVisualStyleBackColor = true;
            this.btncargoagregar.Click += new System.EventHandler(this.btncargoagregar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(67, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Cédula";
            // 
            // tbcedula
            // 
            this.tbcedula.Location = new System.Drawing.Point(114, 90);
            this.tbcedula.Name = "tbcedula";
            this.tbcedula.Size = new System.Drawing.Size(163, 20);
            this.tbcedula.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Fecha de Ingreso";
            // 
            // dtfechaing
            // 
            this.dtfechaing.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfechaing.Location = new System.Drawing.Point(115, 143);
            this.dtfechaing.Name = "dtfechaing";
            this.dtfechaing.Size = new System.Drawing.Size(101, 20);
            this.dtfechaing.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(43, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Fech. Nac.";
            // 
            // dtnacimiento
            // 
            this.dtnacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtnacimiento.Location = new System.Drawing.Point(114, 117);
            this.dtnacimiento.Name = "dtnacimiento";
            this.dtnacimiento.Size = new System.Drawing.Size(101, 20);
            this.dtnacimiento.TabIndex = 3;
            // 
            // tbsueldo
            // 
            this.tbsueldo.Location = new System.Drawing.Point(325, 119);
            this.tbsueldo.Name = "tbsueldo";
            this.tbsueldo.Size = new System.Drawing.Size(89, 20);
            this.tbsueldo.TabIndex = 7;
            this.tbsueldo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbnombre_KeyUp);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(277, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Sueldo";
            // 
            // tbahorro
            // 
            this.tbahorro.Location = new System.Drawing.Point(325, 142);
            this.tbahorro.Name = "tbahorro";
            this.tbahorro.Size = new System.Drawing.Size(42, 20);
            this.tbahorro.TabIndex = 8;
            this.tbahorro.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbnombre_KeyUp);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(258, 145);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Ahorro (%)";
            // 
            // ptbfotoempleado
            // 
            this.ptbfotoempleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ptbfotoempleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ptbfotoempleado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptbfotoempleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbfotoempleado.ErrorImage = global::Tarea_3_CRUD.Properties.Resources.foto;
            this.ptbfotoempleado.Image = global::Tarea_3_CRUD.Properties.Resources.foto;
            this.ptbfotoempleado.InitialImage = global::Tarea_3_CRUD.Properties.Resources.foto;
            this.ptbfotoempleado.Location = new System.Drawing.Point(299, 12);
            this.ptbfotoempleado.Name = "ptbfotoempleado";
            this.ptbfotoempleado.Size = new System.Drawing.Size(98, 98);
            this.ptbfotoempleado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbfotoempleado.TabIndex = 13;
            this.ptbfotoempleado.TabStop = false;
            this.ptbfotoempleado.Click += new System.EventHandler(this.ptbfotoempleado_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Tarea_3_CRUD.Properties.Resources.Arrow;
            this.pictureBox2.Location = new System.Drawing.Point(152, 261);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Tarea_3_CRUD.Properties.Resources.Arrow___copia;
            this.pictureBox1.Location = new System.Drawing.Point(225, 258);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // HEXTODEC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 299);
            this.Controls.Add(this.tbbuscar);
            this.Controls.Add(this.dtnacimiento);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtfechaing);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbcedula);
            this.Controls.Add(this.ptbfotoempleado);
            this.Controls.Add(this.cbdepto);
            this.Controls.Add(this.cbcargo);
            this.Controls.Add(this.rdbinactivo);
            this.Controls.Add(this.rdbactivo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbapellidos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbid);
            this.Controls.Add(this.tbahorro);
            this.Controls.Add(this.tbsueldo);
            this.Controls.Add(this.tbnombre);
            this.Controls.Add(this.btncargoagregar);
            this.Controls.Add(this.btndepartagregar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "HEXTODEC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleado";
            this.Load += new System.EventHandler(this.HEXTODEC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbfotoempleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.TextBox tbnombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbapellidos;
        private System.Windows.Forms.TextBox tbbuscar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdbactivo;
        private System.Windows.Forms.RadioButton rdbinactivo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbcargo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbdepto;
        private System.Windows.Forms.Button btndepartagregar;
        private System.Windows.Forms.Button btncargoagregar;
        private System.Windows.Forms.PictureBox ptbfotoempleado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbcedula;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtfechaing;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtnacimiento;
        private System.Windows.Forms.TextBox tbsueldo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbahorro;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

