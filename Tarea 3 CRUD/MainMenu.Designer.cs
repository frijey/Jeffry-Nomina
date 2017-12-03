namespace Tarea_3_CRUD
{
    partial class MainMenu
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
            this.btnempleados = new System.Windows.Forms.Button();
            this.btnnomina = new System.Windows.Forms.Button();
            this.btnconsultnom = new System.Windows.Forms.Button();
            this.btndepartamentos = new System.Windows.Forms.Button();
            this.btncargos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnempleados
            // 
            this.btnempleados.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnempleados.Font = new System.Drawing.Font("Vivaldi", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnempleados.ForeColor = System.Drawing.Color.Firebrick;
            this.btnempleados.Location = new System.Drawing.Point(12, 12);
            this.btnempleados.Name = "btnempleados";
            this.btnempleados.Size = new System.Drawing.Size(124, 98);
            this.btnempleados.TabIndex = 0;
            this.btnempleados.Text = "Empleados";
            this.btnempleados.UseVisualStyleBackColor = false;
            this.btnempleados.Click += new System.EventHandler(this.btnempleados_Click);
            // 
            // btnnomina
            // 
            this.btnnomina.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnnomina.Font = new System.Drawing.Font("Vivaldi", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnomina.ForeColor = System.Drawing.Color.Firebrick;
            this.btnnomina.Location = new System.Drawing.Point(142, 12);
            this.btnnomina.Name = "btnnomina";
            this.btnnomina.Size = new System.Drawing.Size(124, 98);
            this.btnnomina.TabIndex = 1;
            this.btnnomina.Text = "Generar Nómina";
            this.btnnomina.UseVisualStyleBackColor = false;
            this.btnnomina.Click += new System.EventHandler(this.btnnomina_Click);
            // 
            // btnconsultnom
            // 
            this.btnconsultnom.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnconsultnom.Font = new System.Drawing.Font("Vivaldi", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconsultnom.ForeColor = System.Drawing.Color.Firebrick;
            this.btnconsultnom.Location = new System.Drawing.Point(272, 12);
            this.btnconsultnom.Name = "btnconsultnom";
            this.btnconsultnom.Size = new System.Drawing.Size(124, 98);
            this.btnconsultnom.TabIndex = 2;
            this.btnconsultnom.Text = "Consultar Nómina";
            this.btnconsultnom.UseVisualStyleBackColor = false;
            this.btnconsultnom.Click += new System.EventHandler(this.btnconsultnom_Click);
            // 
            // btndepartamentos
            // 
            this.btndepartamentos.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btndepartamentos.Font = new System.Drawing.Font("Vivaldi", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndepartamentos.ForeColor = System.Drawing.Color.Firebrick;
            this.btndepartamentos.Location = new System.Drawing.Point(42, 115);
            this.btndepartamentos.Name = "btndepartamentos";
            this.btndepartamentos.Size = new System.Drawing.Size(160, 77);
            this.btndepartamentos.TabIndex = 3;
            this.btndepartamentos.TabStop = false;
            this.btndepartamentos.Text = "Departamentos";
            this.btndepartamentos.UseVisualStyleBackColor = false;
            this.btndepartamentos.Click += new System.EventHandler(this.btndepartamentos_Click);
            // 
            // btncargos
            // 
            this.btncargos.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btncargos.Font = new System.Drawing.Font("Vivaldi", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncargos.ForeColor = System.Drawing.Color.Firebrick;
            this.btncargos.Location = new System.Drawing.Point(208, 115);
            this.btncargos.Name = "btncargos";
            this.btncargos.Size = new System.Drawing.Size(159, 77);
            this.btncargos.TabIndex = 4;
            this.btncargos.TabStop = false;
            this.btncargos.Text = "Cargos";
            this.btncargos.UseVisualStyleBackColor = false;
            this.btncargos.Click += new System.EventHandler(this.btncargos_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 201);
            this.Controls.Add(this.btnconsultnom);
            this.Controls.Add(this.btnnomina);
            this.Controls.Add(this.btncargos);
            this.Controls.Add(this.btndepartamentos);
            this.Controls.Add(this.btnempleados);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnempleados;
        private System.Windows.Forms.Button btnnomina;
        private System.Windows.Forms.Button btnconsultnom;
        private System.Windows.Forms.Button btndepartamentos;
        private System.Windows.Forms.Button btncargos;
    }
}