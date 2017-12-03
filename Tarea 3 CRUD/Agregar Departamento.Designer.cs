namespace Tarea_3_CRUD
{
    partial class Admin_Departamentos
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
            this.dgrprincipal = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnagregar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.rdinactivo = new System.Windows.Forms.RadioButton();
            this.rdactivo = new System.Windows.Forms.RadioButton();
            this.rdtodos = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrprincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrprincipal
            // 
            this.dgrprincipal.AllowUserToAddRows = false;
            this.dgrprincipal.AllowUserToDeleteRows = false;
            this.dgrprincipal.AllowUserToResizeColumns = false;
            this.dgrprincipal.AllowUserToResizeRows = false;
            this.dgrprincipal.BackgroundColor = System.Drawing.Color.White;
            this.dgrprincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrprincipal.Location = new System.Drawing.Point(11, 58);
            this.dgrprincipal.Name = "dgrprincipal";
            this.dgrprincipal.RowHeadersVisible = false;
            this.dgrprincipal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrprincipal.Size = new System.Drawing.Size(298, 128);
            this.dgrprincipal.TabIndex = 0;
            this.dgrprincipal.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrprincipal_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Departamentos";
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(53, 192);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(62, 33);
            this.btnagregar.TabIndex = 5;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(204, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 33);
            this.button1.TabIndex = 5;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rdinactivo
            // 
            this.rdinactivo.AutoSize = true;
            this.rdinactivo.Location = new System.Drawing.Point(240, 22);
            this.rdinactivo.Name = "rdinactivo";
            this.rdinactivo.Size = new System.Drawing.Size(68, 17);
            this.rdinactivo.TabIndex = 12;
            this.rdinactivo.Text = "Inactivos";
            this.rdinactivo.UseVisualStyleBackColor = true;
            this.rdinactivo.Click += new System.EventHandler(this.rdactivo_Click);
            // 
            // rdactivo
            // 
            this.rdactivo.AutoSize = true;
            this.rdactivo.Checked = true;
            this.rdactivo.Location = new System.Drawing.Point(240, 6);
            this.rdactivo.Name = "rdactivo";
            this.rdactivo.Size = new System.Drawing.Size(60, 17);
            this.rdactivo.TabIndex = 13;
            this.rdactivo.TabStop = true;
            this.rdactivo.Text = "Activos";
            this.rdactivo.UseVisualStyleBackColor = true;
            this.rdactivo.Click += new System.EventHandler(this.rdactivo_Click);
            // 
            // rdtodos
            // 
            this.rdtodos.AutoSize = true;
            this.rdtodos.Location = new System.Drawing.Point(240, 38);
            this.rdtodos.Name = "rdtodos";
            this.rdtodos.Size = new System.Drawing.Size(55, 17);
            this.rdtodos.TabIndex = 14;
            this.rdtodos.Text = "Todos";
            this.rdtodos.UseVisualStyleBackColor = true;
            this.rdtodos.Click += new System.EventHandler(this.rdactivo_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(121, 192);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(77, 33);
            this.button3.TabIndex = 5;
            this.button3.Text = "Editar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Admin_Departamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 236);
            this.Controls.Add(this.rdtodos);
            this.Controls.Add(this.rdinactivo);
            this.Controls.Add(this.rdactivo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.dgrprincipal);
            this.Controls.Add(this.label1);
            this.Name = "Admin_Departamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Departamentos";
            this.Load += new System.EventHandler(this.Agregar_Departamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrprincipal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrprincipal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rdinactivo;
        private System.Windows.Forms.RadioButton rdactivo;
        private System.Windows.Forms.RadioButton rdtodos;
        private System.Windows.Forms.Button button3;
    }
}