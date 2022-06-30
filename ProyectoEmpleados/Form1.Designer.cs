namespace ProyectoEmpleados
{
    partial class Form1
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
            this.lbl1F1 = new System.Windows.Forms.Label();
            this.lbl2F1 = new System.Windows.Forms.Label();
            this.lbl3F1 = new System.Windows.Forms.Label();
            this.txtBoxUser = new System.Windows.Forms.TextBox();
            this.txtBoxPsswrd = new System.Windows.Forms.TextBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1F1
            // 
            this.lbl1F1.AutoSize = true;
            this.lbl1F1.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1F1.Location = new System.Drawing.Point(12, 9);
            this.lbl1F1.Name = "lbl1F1";
            this.lbl1F1.Size = new System.Drawing.Size(134, 26);
            this.lbl1F1.TabIndex = 0;
            this.lbl1F1.Text = "Iniciar Sesion";
            // 
            // lbl2F1
            // 
            this.lbl2F1.AutoSize = true;
            this.lbl2F1.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2F1.Location = new System.Drawing.Point(12, 66);
            this.lbl2F1.Name = "lbl2F1";
            this.lbl2F1.Size = new System.Drawing.Size(68, 19);
            this.lbl2F1.TabIndex = 1;
            this.lbl2F1.Text = "Usuario:";
            // 
            // lbl3F1
            // 
            this.lbl3F1.AutoSize = true;
            this.lbl3F1.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3F1.Location = new System.Drawing.Point(12, 104);
            this.lbl3F1.Name = "lbl3F1";
            this.lbl3F1.Size = new System.Drawing.Size(92, 19);
            this.lbl3F1.TabIndex = 2;
            this.lbl3F1.Text = "Contraseña:";
            // 
            // txtBoxUser
            // 
            this.txtBoxUser.Location = new System.Drawing.Point(136, 67);
            this.txtBoxUser.Name = "txtBoxUser";
            this.txtBoxUser.Size = new System.Drawing.Size(255, 20);
            this.txtBoxUser.TabIndex = 3;
            this.txtBoxUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBoxPsswrd
            // 
            this.txtBoxPsswrd.Location = new System.Drawing.Point(136, 102);
            this.txtBoxPsswrd.Name = "txtBoxPsswrd";
            this.txtBoxPsswrd.PasswordChar = '*';
            this.txtBoxPsswrd.Size = new System.Drawing.Size(255, 20);
            this.txtBoxPsswrd.TabIndex = 4;
            this.txtBoxPsswrd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBoxPsswrd.UseSystemPasswordChar = true;
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLogIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogIn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogIn.Location = new System.Drawing.Point(163, 167);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(99, 23);
            this.btnLogIn.TabIndex = 5;
            this.btnLogIn.Text = "iniciar Sesion";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 222);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.txtBoxPsswrd);
            this.Controls.Add(this.txtBoxUser);
            this.Controls.Add(this.lbl3F1);
            this.Controls.Add(this.lbl2F1);
            this.Controls.Add(this.lbl1F1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1F1;
        private System.Windows.Forms.Label lbl2F1;
        private System.Windows.Forms.Label lbl3F1;
        private System.Windows.Forms.TextBox txtBoxUser;
        private System.Windows.Forms.TextBox txtBoxPsswrd;
        private System.Windows.Forms.Button btnLogIn;
    }
}

