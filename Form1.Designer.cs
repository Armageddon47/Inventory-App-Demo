namespace Inventory_App_Demo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.passwordTXT = new System.Windows.Forms.TextBox();
            this.UserTXT = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // passwordTXT
            // 
            this.passwordTXT.Location = new System.Drawing.Point(159, 260);
            this.passwordTXT.MinimumSize = new System.Drawing.Size(4, 30);
            this.passwordTXT.Multiline = true;
            this.passwordTXT.Name = "passwordTXT";
            this.passwordTXT.PasswordChar = '*';
            this.passwordTXT.Size = new System.Drawing.Size(156, 33);
            this.passwordTXT.TabIndex = 0;
            this.passwordTXT.Text = "password";
            // 
            // UserTXT
            // 
            this.UserTXT.Location = new System.Drawing.Point(159, 210);
            this.UserTXT.MinimumSize = new System.Drawing.Size(4, 30);
            this.UserTXT.Multiline = true;
            this.UserTXT.Name = "UserTXT";
            this.UserTXT.Size = new System.Drawing.Size(156, 33);
            this.UserTXT.TabIndex = 1;
            this.UserTXT.Text = "Username";
            // 
            // loginBtn
            // 
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.Location = new System.Drawing.Point(159, 320);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(156, 43);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(187, 379);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(102, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(488, 1);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(26, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(514, 472);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.UserTXT);
            this.Controls.Add(this.passwordTXT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.TextBox passwordTXT;
        private System.Windows.Forms.TextBox UserTXT;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button5;
    }
}

