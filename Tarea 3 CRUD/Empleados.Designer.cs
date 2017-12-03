namespace Tarea_3_CRUD
{
    partial class Empleados
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
            this.btnimprimir = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.datanomina = new System.Windows.Forms.DataGridView();
            this.cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sueldobruto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ahorros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rdbnombre = new System.Windows.Forms.RadioButton();
            this.rdbapellido = new System.Windows.Forms.RadioButton();
            this.rdbcedula = new System.Windows.Forms.RadioButton();
            this.rdbid = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tbbuscar = new System.Windows.Forms.TextBox();
            this.btnmostrartodo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datanomina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnimprimir
            // 
            this.btnimprimir.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnimprimir.Enabled = false;
            this.btnimprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimprimir.Location = new System.Drawing.Point(68, 381);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(220, 46);
            this.btnimprimir.TabIndex = 3;
            this.btnimprimir.Text = "Imprimir";
            this.btnimprimir.UseVisualStyleBackColor = false;
            this.btnimprimir.Click += new System.EventHandler(this.btnimprimir_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.Cornsilk;
            this.btnbuscar.Font = new System.Drawing.Font("Harlow Solid Italic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.Location = new System.Drawing.Point(391, 12);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(129, 38);
            this.btnbuscar.TabIndex = 1;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnagregar.Location = new System.Drawing.Point(526, 11);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(169, 39);
            this.btnagregar.TabIndex = 2;
            this.btnagregar.Text = "Agregar Empleado (+)";
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
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
            this.cedula,
            this.Nombre,
            this.sueldobruto,
            this.cargo,
            this.ahorros,
            this.isr});
            this.datanomina.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.datanomina.Location = new System.Drawing.Point(12, 56);
            this.datanomina.Name = "datanomina";
            this.datanomina.ReadOnly = true;
            this.datanomina.RowHeadersVisible = false;
            this.datanomina.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datanomina.Size = new System.Drawing.Size(683, 319);
            this.datanomina.TabIndex = 25;
            this.datanomina.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datanomina_CellDoubleClick);
            this.datanomina.KeyUp += new System.Windows.Forms.KeyEventHandler(this.datanomina_KeyUp);
            // 
            // cedula
            // 
            this.cedula.HeaderText = "ID";
            this.cedula.Name = "cedula";
            this.cedula.ReadOnly = true;
            this.cedula.Width = 60;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 130;
            // 
            // sueldobruto
            // 
            this.sueldobruto.HeaderText = "Apellido";
            this.sueldobruto.Name = "sueldobruto";
            this.sueldobruto.ReadOnly = true;
            this.sueldobruto.Width = 150;
            // 
            // cargo
            // 
            this.cargo.HeaderText = "Cargo";
            this.cargo.Name = "cargo";
            this.cargo.ReadOnly = true;
            this.cargo.Width = 120;
            // 
            // ahorros
            // 
            this.ahorros.HeaderText = "Departamento";
            this.ahorros.Name = "ahorros";
            this.ahorros.ReadOnly = true;
            this.ahorros.Width = 120;
            // 
            // isr
            // 
            this.isr.HeaderText = "Fecha Ing.";
            this.isr.Name = "isr";
            this.isr.ReadOnly = true;
            // 
            // rdbnombre
            // 
            this.rdbnombre.AutoSize = true;
            this.rdbnombre.Checked = true;
            this.rdbnombre.Location = new System.Drawing.Point(101, 12);
            this.rdbnombre.Name = "rdbnombre";
            this.rdbnombre.Size = new System.Drawing.Size(62, 17);
            this.rdbnombre.TabIndex = 30;
            this.rdbnombre.TabStop = true;
            this.rdbnombre.Text = "Nombre";
            this.rdbnombre.UseVisualStyleBackColor = true;
            // 
            // rdbapellido
            // 
            this.rdbapellido.AutoSize = true;
            this.rdbapellido.Location = new System.Drawing.Point(101, 33);
            this.rdbapellido.Name = "rdbapellido";
            this.rdbapellido.Size = new System.Drawing.Size(62, 17);
            this.rdbapellido.TabIndex = 30;
            this.rdbapellido.Text = "Apellido";
            this.rdbapellido.UseVisualStyleBackColor = true;
            // 
            // rdbcedula
            // 
            this.rdbcedula.AutoSize = true;
            this.rdbcedula.Location = new System.Drawing.Point(160, 33);
            this.rdbcedula.Name = "rdbcedula";
            this.rdbcedula.Size = new System.Drawing.Size(58, 17);
            this.rdbcedula.TabIndex = 30;
            this.rdbcedula.Text = "Cédula";
            this.rdbcedula.UseVisualStyleBackColor = true;
            // 
            // rdbid
            // 
            this.rdbid.AutoSize = true;
            this.rdbid.Location = new System.Drawing.Point(160, 12);
            this.rdbid.Name = "rdbid";
            this.rdbid.Size = new System.Drawing.Size(34, 17);
            this.rdbid.TabIndex = 30;
            this.rdbid.Text = "Id";
            this.rdbid.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 248);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(508, 118);
            this.dataGridView1.TabIndex = 31;
            this.dataGridView1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 29);
            this.label1.TabIndex = 32;
            this.label1.Text = "Buscar Por";
            // 
            // tbbuscar
            // 
            this.tbbuscar.BackColor = System.Drawing.Color.AliceBlue;
            this.tbbuscar.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbbuscar.Location = new System.Drawing.Point(224, 17);
            this.tbbuscar.Name = "tbbuscar";
            this.tbbuscar.Size = new System.Drawing.Size(161, 30);
            this.tbbuscar.TabIndex = 0;
            this.tbbuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbbuscar_KeyUp);
            // 
            // btnmostrartodo
            // 
            this.btnmostrartodo.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnmostrartodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmostrartodo.Location = new System.Drawing.Point(411, 381);
            this.btnmostrartodo.Name = "btnmostrartodo";
            this.btnmostrartodo.Size = new System.Drawing.Size(220, 46);
            this.btnmostrartodo.TabIndex = 3;
            this.btnmostrartodo.Text = "Mostrar Todo";
            this.btnmostrartodo.UseVisualStyleBackColor = false;
            this.btnmostrartodo.Click += new System.EventHandler(this.btnmostrartodo_Click);
            // 
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 433);
            this.Controls.Add(this.tbbuscar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.rdbcedula);
            this.Controls.Add(this.rdbapellido);
            this.Controls.Add(this.rdbid);
            this.Controls.Add(this.rdbnombre);
            this.Controls.Add(this.btnmostrartodo);
            this.Controls.Add(this.btnimprimir);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.datanomina);
            this.Controls.Add(this.label1);
            this.Name = "Empleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.Empleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datanomina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnimprimir;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.DataGridView datanomina;
        private System.Windows.Forms.RadioButton rdbnombre;
        private System.Windows.Forms.RadioButton rdbapellido;
        private System.Windows.Forms.RadioButton rdbcedula;
        private System.Windows.Forms.RadioButton rdbid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn sueldobruto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ahorros;
        private System.Windows.Forms.DataGridViewTextBoxColumn isr;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbbuscar;
        private System.Windows.Forms.Button btnmostrartodo;
    }
}