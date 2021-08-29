
namespace Login
{
    partial class Form1
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
            this.textBox1_username = new System.Windows.Forms.TextBox();
            this.textBox2_password = new System.Windows.Forms.TextBox();
            this.label1_username = new System.Windows.Forms.Label();
            this.label2_password = new System.Windows.Forms.Label();
            this.button1_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1_username
            // 
            this.textBox1_username.Location = new System.Drawing.Point(226, 165);
            this.textBox1_username.Name = "textBox1_username";
            this.textBox1_username.Size = new System.Drawing.Size(179, 20);
            this.textBox1_username.TabIndex = 0;
            // 
            // textBox2_password
            // 
            this.textBox2_password.Location = new System.Drawing.Point(226, 203);
            this.textBox2_password.Name = "textBox2_password";
            this.textBox2_password.PasswordChar = '*';
            this.textBox2_password.Size = new System.Drawing.Size(179, 20);
            this.textBox2_password.TabIndex = 1;
            this.textBox2_password.UseSystemPasswordChar = true;
            this.textBox2_password.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1_username
            // 
            this.label1_username.AutoSize = true;
            this.label1_username.BackColor = System.Drawing.Color.Transparent;
            this.label1_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_username.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1_username.Location = new System.Drawing.Point(110, 165);
            this.label1_username.Name = "label1_username";
            this.label1_username.Size = new System.Drawing.Size(93, 20);
            this.label1_username.TabIndex = 2;
            this.label1_username.Text = "UserName";
            // 
            // label2_password
            // 
            this.label2_password.AutoSize = true;
            this.label2_password.BackColor = System.Drawing.Color.Transparent;
            this.label2_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2_password.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2_password.Location = new System.Drawing.Point(110, 203);
            this.label2_password.Name = "label2_password";
            this.label2_password.Size = new System.Drawing.Size(86, 20);
            this.label2_password.TabIndex = 3;
            this.label2_password.Text = "Password";
            // 
            // button1_login
            // 
            this.button1_login.BackColor = System.Drawing.Color.Transparent;
            this.button1_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_login.ForeColor = System.Drawing.Color.Red;
            this.button1_login.Location = new System.Drawing.Point(226, 262);
            this.button1_login.Name = "button1_login";
            this.button1_login.Size = new System.Drawing.Size(75, 23);
            this.button1_login.TabIndex = 4;
            this.button1_login.Text = "Login";
            this.button1_login.UseVisualStyleBackColor = false;
            this.button1_login.Click += new System.EventHandler(this.button1_login_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Login.Properties.Resources.images__7_;
            this.ClientSize = new System.Drawing.Size(514, 450);
            this.Controls.Add(this.button1_login);
            this.Controls.Add(this.label2_password);
            this.Controls.Add(this.label1_username);
            this.Controls.Add(this.textBox2_password);
            this.Controls.Add(this.textBox1_username);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1_username;
        private System.Windows.Forms.TextBox textBox2_password;
        private System.Windows.Forms.Label label1_username;
        private System.Windows.Forms.Label label2_password;
        private System.Windows.Forms.Button button1_login;
    }
}

