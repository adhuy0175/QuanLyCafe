
namespace QuanLyCafe
{
    partial class foLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(foLogin));
            this.SigninBttn = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.ExitBttn = new System.Windows.Forms.Button();
            this.CheckToShowPass = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // SigninBttn
            // 
            this.SigninBttn.AutoSize = true;
            this.SigninBttn.BackColor = System.Drawing.Color.Transparent;
            this.SigninBttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SigninBttn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SigninBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SigninBttn.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SigninBttn.ForeColor = System.Drawing.Color.White;
            this.SigninBttn.Location = new System.Drawing.Point(211, 493);
            this.SigninBttn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SigninBttn.Name = "SigninBttn";
            this.SigninBttn.Size = new System.Drawing.Size(157, 48);
            this.SigninBttn.TabIndex = 3;
            this.SigninBttn.Text = "SIGN IN";
            this.SigninBttn.UseVisualStyleBackColor = false;
            this.SigninBttn.Click += new System.EventHandler(this.SigninBttn_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(195, 310);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(216, 35);
            this.txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(195, 402);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(216, 35);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // ExitBttn
            // 
            this.ExitBttn.AutoSize = true;
            this.ExitBttn.BackColor = System.Drawing.Color.Transparent;
            this.ExitBttn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ExitBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBttn.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.ExitBttn.ForeColor = System.Drawing.Color.White;
            this.ExitBttn.Location = new System.Drawing.Point(231, 568);
            this.ExitBttn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExitBttn.Name = "ExitBttn";
            this.ExitBttn.Size = new System.Drawing.Size(117, 47);
            this.ExitBttn.TabIndex = 4;
            this.ExitBttn.Text = "EXIT";
            this.ExitBttn.UseVisualStyleBackColor = false;
            this.ExitBttn.Click += new System.EventHandler(this.ExitBttn_Click);
            // 
            // CheckToShowPass
            // 
            this.CheckToShowPass.AutoSize = true;
            this.CheckToShowPass.BackColor = System.Drawing.Color.Maroon;
            this.CheckToShowPass.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckToShowPass.ForeColor = System.Drawing.Color.White;
            this.CheckToShowPass.Location = new System.Drawing.Point(211, 452);
            this.CheckToShowPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CheckToShowPass.Name = "CheckToShowPass";
            this.CheckToShowPass.Size = new System.Drawing.Size(125, 21);
            this.CheckToShowPass.TabIndex = 5;
            this.CheckToShowPass.Text = "Show Password";
            this.CheckToShowPass.UseVisualStyleBackColor = false;
            this.CheckToShowPass.CheckedChanged += new System.EventHandler(this.CheckToShowPass_CheckedChanged);
            // 
            // foLogin
            // 
            this.AcceptButton = this.SigninBttn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(579, 626);
            this.Controls.Add(this.CheckToShowPass);
            this.Controls.Add(this.ExitBttn);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.SigninBttn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "foLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN FORM";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.foLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SigninBttn;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button ExitBttn;
        private System.Windows.Forms.CheckBox CheckToShowPass;
    }
}

