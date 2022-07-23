namespace ProyectoEmpleados
{
    partial class FLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FLogIn));
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
            this.lbl1F1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1F1.Font = new System.Drawing.Font("Constantia", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1F1.Location = new System.Drawing.Point(89, 9);
            this.lbl1F1.Name = "lbl1F1";
            this.lbl1F1.Size = new System.Drawing.Size(203, 39);
            this.lbl1F1.TabIndex = 0;
            this.lbl1F1.Text = "Iniciar Sesion";
            // 
            // lbl2F1
            // 
            this.lbl2F1.AutoSize = true;
            this.lbl2F1.BackColor = System.Drawing.Color.Transparent;
            this.lbl2F1.Font = new System.Drawing.Font("Constantia", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2F1.Location = new System.Drawing.Point(22, 65);
            this.lbl2F1.Name = "lbl2F1";
            this.lbl2F1.Size = new System.Drawing.Size(132, 39);
            this.lbl2F1.TabIndex = 1;
            this.lbl2F1.Text = "Usuario:";
            // 
            // lbl3F1
            // 
            this.lbl3F1.AutoSize = true;
            this.lbl3F1.BackColor = System.Drawing.Color.Transparent;
            this.lbl3F1.Font = new System.Drawing.Font("Constantia", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3F1.ForeColor = System.Drawing.Color.Black;
            this.lbl3F1.Location = new System.Drawing.Point(22, 113);
            this.lbl3F1.Name = "lbl3F1";
            this.lbl3F1.Size = new System.Drawing.Size(181, 39);
            this.lbl3F1.TabIndex = 2;
            this.lbl3F1.Text = "Contraseña:";
            // 
            // txtBoxUser
            // 
            this.txtBoxUser.Location = new System.Drawing.Point(230, 81);
            this.txtBoxUser.Name = "txtBoxUser";
            this.txtBoxUser.Size = new System.Drawing.Size(148, 20);
            this.txtBoxUser.TabIndex = 3;
            this.txtBoxUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBoxPsswrd
            // 
            this.txtBoxPsswrd.Location = new System.Drawing.Point(230, 128);
            this.txtBoxPsswrd.Name = "txtBoxPsswrd";
            this.txtBoxPsswrd.PasswordChar = '*';
            this.txtBoxPsswrd.Size = new System.Drawing.Size(148, 20);
            this.txtBoxPsswrd.TabIndex = 4;
            this.txtBoxPsswrd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBoxPsswrd.UseSystemPasswordChar = true;
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnLogIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogIn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogIn.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.ForeColor = System.Drawing.Color.Black;
            this.btnLogIn.Location = new System.Drawing.Point(189, 196);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(189, 34);
            this.btnLogIn.TabIndex = 5;
            this.btnLogIn.Text = "Iniciar Sesion";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // FLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 253);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.txtBoxPsswrd);
            this.Controls.Add(this.txtBoxUser);
            this.Controls.Add(this.lbl3F1);
            this.Controls.Add(this.lbl2F1);
            this.Controls.Add(this.lbl1F1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FLogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
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

