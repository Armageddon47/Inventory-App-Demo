namespace Inventory_App_Demo
{
    partial class UserManager
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UserTXT = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.FullNameTXT = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.LastNameTXT = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.PhoneTXT = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(843, 116);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(224, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(419, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "Inventory Management";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Manager";
            // 
            // UserTXT
            // 
            this.UserTXT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.UserTXT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.UserTXT.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.UserTXT.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.UserTXT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserTXT.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserTXT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UserTXT.HintForeColor = System.Drawing.Color.Empty;
            this.UserTXT.HintText = "";
            this.UserTXT.isPassword = false;
            this.UserTXT.LineFocusedColor = System.Drawing.Color.Blue;
            this.UserTXT.LineIdleColor = System.Drawing.Color.Gray;
            this.UserTXT.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.UserTXT.LineThickness = 3;
            this.UserTXT.Location = new System.Drawing.Point(35, 142);
            this.UserTXT.Margin = new System.Windows.Forms.Padding(4);
            this.UserTXT.MaxLength = 32767;
            this.UserTXT.Name = "UserTXT";
            this.UserTXT.Size = new System.Drawing.Size(159, 32);
            this.UserTXT.TabIndex = 1;
            this.UserTXT.Text = "Username";
            this.UserTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // FullNameTXT
            // 
            this.FullNameTXT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.FullNameTXT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.FullNameTXT.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.FullNameTXT.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.FullNameTXT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FullNameTXT.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullNameTXT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FullNameTXT.HintForeColor = System.Drawing.Color.Empty;
            this.FullNameTXT.HintText = "";
            this.FullNameTXT.isPassword = false;
            this.FullNameTXT.LineFocusedColor = System.Drawing.Color.Blue;
            this.FullNameTXT.LineIdleColor = System.Drawing.Color.Gray;
            this.FullNameTXT.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.FullNameTXT.LineThickness = 3;
            this.FullNameTXT.Location = new System.Drawing.Point(35, 195);
            this.FullNameTXT.Margin = new System.Windows.Forms.Padding(4);
            this.FullNameTXT.MaxLength = 32767;
            this.FullNameTXT.Name = "FullNameTXT";
            this.FullNameTXT.Size = new System.Drawing.Size(159, 32);
            this.FullNameTXT.TabIndex = 2;
            this.FullNameTXT.Text = "FullName";
            this.FullNameTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // LastNameTXT
            // 
            this.LastNameTXT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.LastNameTXT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.LastNameTXT.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.LastNameTXT.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.LastNameTXT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LastNameTXT.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameTXT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LastNameTXT.HintForeColor = System.Drawing.Color.Empty;
            this.LastNameTXT.HintText = "";
            this.LastNameTXT.isPassword = false;
            this.LastNameTXT.LineFocusedColor = System.Drawing.Color.Blue;
            this.LastNameTXT.LineIdleColor = System.Drawing.Color.Gray;
            this.LastNameTXT.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.LastNameTXT.LineThickness = 3;
            this.LastNameTXT.Location = new System.Drawing.Point(35, 247);
            this.LastNameTXT.Margin = new System.Windows.Forms.Padding(4);
            this.LastNameTXT.MaxLength = 32767;
            this.LastNameTXT.Name = "LastNameTXT";
            this.LastNameTXT.Size = new System.Drawing.Size(159, 32);
            this.LastNameTXT.TabIndex = 3;
            this.LastNameTXT.Text = "LastName";
            this.LastNameTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // PhoneTXT
            // 
            this.PhoneTXT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.PhoneTXT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.PhoneTXT.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.PhoneTXT.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.PhoneTXT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PhoneTXT.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneTXT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PhoneTXT.HintForeColor = System.Drawing.Color.Empty;
            this.PhoneTXT.HintText = "";
            this.PhoneTXT.isPassword = false;
            this.PhoneTXT.LineFocusedColor = System.Drawing.Color.Blue;
            this.PhoneTXT.LineIdleColor = System.Drawing.Color.Gray;
            this.PhoneTXT.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.PhoneTXT.LineThickness = 3;
            this.PhoneTXT.Location = new System.Drawing.Point(35, 300);
            this.PhoneTXT.Margin = new System.Windows.Forms.Padding(4);
            this.PhoneTXT.MaxLength = 32767;
            this.PhoneTXT.Name = "PhoneTXT";
            this.PhoneTXT.Size = new System.Drawing.Size(159, 33);
            this.PhoneTXT.TabIndex = 4;
            this.PhoneTXT.Text = "Phone";
            this.PhoneTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(359, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(481, 415);
            this.dataGridView1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Location = new System.Drawing.Point(21, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 36);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Location = new System.Drawing.Point(85, 354);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(58, 36);
            this.button2.TabIndex = 7;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.Location = new System.Drawing.Point(149, 354);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(58, 36);
            this.button3.TabIndex = 8;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.Location = new System.Drawing.Point(85, 396);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(58, 36);
            this.button4.TabIndex = 9;
            this.button4.Text = "Home";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel2.Location = new System.Drawing.Point(0, 543);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(843, 10);
            this.panel2.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(804, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // UserManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.PhoneTXT);
            this.Controls.Add(this.LastNameTXT);
            this.Controls.Add(this.FullNameTXT);
            this.Controls.Add(this.UserTXT);
            this.Controls.Add(this.panel1);
            this.Name = "UserManager";
            this.Size = new System.Drawing.Size(843, 553);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox UserTXT;
        private Bunifu.Framework.UI.BunifuMaterialTextbox FullNameTXT;
        private Bunifu.Framework.UI.BunifuMaterialTextbox LastNameTXT;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PhoneTXT;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel2;
    }
}
