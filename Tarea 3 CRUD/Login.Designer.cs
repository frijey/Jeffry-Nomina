namespace Tarea_3_CRUD
{
    partial class Login
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
            this.tbsalir = new System.Windows.Forms.Button();
            this.lbusuario = new System.Windows.Forms.Label();
            this.lbpassword = new System.Windows.Forms.Label();
            this.tbusuario = new System.Windows.Forms.TextBox();
            this.tbpassword = new System.Windows.Forms.TextBox();
            this.tbentrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbsalir
            // 
            this.tbsalir.Location = new System.Drawing.Point(184, 79);
            this.tbsalir.Name = "tbsalir";
            this.tbsalir.Size = new System.Drawing.Size(129, 41);
            this.tbsalir.TabIndex = 3;
            this.tbsalir.Text = "Salir";
            this.tbsalir.UseVisualStyleBackColor = true;
            this.tbsalir.Click += new System.EventHandler(this.tbsalir_Click);
            // 
            // lbusuario
            // 
            this.lbusuario.AutoSize = true;
            this.lbusuario.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbusuario.Location = new System.Drawing.Point(74, 16);
            this.lbusuario.Name = "lbusuario";
            this.lbusuario.Size = new System.Drawing.Size(84, 24);
            this.lbusuario.TabIndex = 10;
            this.lbusuario.Text = "Usuario";
            // 
            // lbpassword
            // 
            this.lbpassword.AutoSize = true;
            this.lbpassword.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpassword.Location = new System.Drawing.Point(56, 47);
            this.lbpassword.Name = "lbpassword";
            this.lbpassword.Size = new System.Drawing.Size(102, 24);
            this.lbpassword.TabIndex = 8;
            this.lbpassword.Text = "Contaseña";
            // 
            // tbusuario
            // 
            this.tbusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbusuario.Location = new System.Drawing.Point(164, 16);
            this.tbusuario.MaxLength = 20;
            this.tbusuario.Name = "tbusuario";
            this.tbusuario.Size = new System.Drawing.Size(115, 23);
            this.tbusuario.TabIndex = 0;
            this.tbusuario.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbusuario_KeyUp);
            // 
            // tbpassword
            // 
            this.tbpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbpassword.Location = new System.Drawing.Point(164, 47);
            this.tbpassword.MaxLength = 20;
            this.tbpassword.Name = "tbpassword";
            this.tbpassword.PasswordChar = '*';
            this.tbpassword.Size = new System.Drawing.Size(115, 23);
            this.tbpassword.TabIndex = 1;
            this.tbpassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbpassword_KeyUp);
            // 
            // tbentrar
            // 
            this.tbentrar.Location = new System.Drawing.Point(21, 79);
            this.tbentrar.Name = "tbentrar";
            this.tbentrar.Size = new System.Drawing.Size(137, 41);
            this.tbentrar.TabIndex = 2;
            this.tbentrar.Text = "Entrar";
            this.tbentrar.UseVisualStyleBackColor = true;
            this.tbentrar.Click += new System.EventHandler(this.tbentrar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 134);
            this.Controls.Add(this.tbsalir);
            this.Controls.Add(this.lbusuario);
            this.Controls.Add(this.lbpassword);
            this.Controls.Add(this.tbusuario);
            this.Controls.Add(this.tbpassword);
            this.Controls.Add(this.tbentrar);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tbsalir;
        private System.Windows.Forms.Label lbusuario;
        private System.Windows.Forms.Label lbpassword;
        private System.Windows.Forms.TextBox tbusuario;
        private System.Windows.Forms.TextBox tbpassword;
        private System.Windows.Forms.Button tbentrar;
    }
}