namespace Inventory_App_Demo
{
    partial class CustomerManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CustomerPhoneTXT = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.CustomerNameTXT = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.CustomerIDTXT = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(843, 117);
            this.panel1.TabIndex = 23;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(817, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(26, 23);
            this.button5.TabIndex = 2;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(282, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Manager";
            // 
            // CustomerPhoneTXT
            // 
            this.CustomerPhoneTXT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.CustomerPhoneTXT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.CustomerPhoneTXT.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.CustomerPhoneTXT.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.CustomerPhoneTXT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CustomerPhoneTXT.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerPhoneTXT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CustomerPhoneTXT.HintForeColor = System.Drawing.Color.Empty;
            this.CustomerPhoneTXT.HintText = "";
            this.CustomerPhoneTXT.isPassword = false;
            this.CustomerPhoneTXT.LineFocusedColor = System.Drawing.Color.Blue;
            this.CustomerPhoneTXT.LineIdleColor = System.Drawing.Color.Gray;
            this.CustomerPhoneTXT.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.CustomerPhoneTXT.LineThickness = 3;
            this.CustomerPhoneTXT.Location = new System.Drawing.Point(46, 280);
            this.CustomerPhoneTXT.Margin = new System.Windows.Forms.Padding(4);
            this.CustomerPhoneTXT.MaxLength = 32767;
            this.CustomerPhoneTXT.Name = "CustomerPhoneTXT";
            this.CustomerPhoneTXT.Size = new System.Drawing.Size(159, 32);
            this.CustomerPhoneTXT.TabIndex = 26;
            this.CustomerPhoneTXT.Text = "Customer Phone";
            this.CustomerPhoneTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // CustomerNameTXT
            // 
            this.CustomerNameTXT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.CustomerNameTXT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.CustomerNameTXT.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.CustomerNameTXT.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.CustomerNameTXT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CustomerNameTXT.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNameTXT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CustomerNameTXT.HintForeColor = System.Drawing.Color.Empty;
            this.CustomerNameTXT.HintText = "";
            this.CustomerNameTXT.isPassword = false;
            this.CustomerNameTXT.LineFocusedColor = System.Drawing.Color.Blue;
            this.CustomerNameTXT.LineIdleColor = System.Drawing.Color.Gray;
            this.CustomerNameTXT.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.CustomerNameTXT.LineThickness = 3;
            this.CustomerNameTXT.Location = new System.Drawing.Point(46, 228);
            this.CustomerNameTXT.Margin = new System.Windows.Forms.Padding(4);
            this.CustomerNameTXT.MaxLength = 32767;
            this.CustomerNameTXT.Name = "CustomerNameTXT";
            this.CustomerNameTXT.Size = new System.Drawing.Size(159, 32);
            this.CustomerNameTXT.TabIndex = 25;
            this.CustomerNameTXT.Text = "Customer Name";
            this.CustomerNameTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // CustomerIDTXT
            // 
            this.CustomerIDTXT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.CustomerIDTXT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.CustomerIDTXT.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.CustomerIDTXT.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.CustomerIDTXT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CustomerIDTXT.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerIDTXT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CustomerIDTXT.HintForeColor = System.Drawing.Color.Empty;
            this.CustomerIDTXT.HintText = "";
            this.CustomerIDTXT.isPassword = false;
            this.CustomerIDTXT.LineFocusedColor = System.Drawing.Color.Blue;
            this.CustomerIDTXT.LineIdleColor = System.Drawing.Color.Gray;
            this.CustomerIDTXT.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.CustomerIDTXT.LineThickness = 3;
            this.CustomerIDTXT.Location = new System.Drawing.Point(46, 175);
            this.CustomerIDTXT.Margin = new System.Windows.Forms.Padding(4);
            this.CustomerIDTXT.MaxLength = 32767;
            this.CustomerIDTXT.Name = "CustomerIDTXT";
            this.CustomerIDTXT.Size = new System.Drawing.Size(159, 32);
            this.CustomerIDTXT.TabIndex = 24;
            this.CustomerIDTXT.Text = "Customer ID";
            this.CustomerIDTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Turquoise;
            this.label3.Location = new System.Drawing.Point(468, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 39);
            this.label3.TabIndex = 27;
            this.label3.Text = "Customers List";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(325, 185);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Navy;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Snow;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.Size = new System.Drawing.Size(518, 428);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel2.Location = new System.Drawing.Point(0, 610);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(843, 17);
            this.panel2.TabIndex = 29;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.Location = new System.Drawing.Point(99, 446);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(58, 36);
            this.button4.TabIndex = 33;
            this.button4.Text = "Home";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.Location = new System.Drawing.Point(163, 404);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(58, 36);
            this.button3.TabIndex = 32;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Location = new System.Drawing.Point(99, 404);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(58, 36);
            this.button2.TabIndex = 31;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Location = new System.Drawing.Point(35, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 36);
            this.button1.TabIndex = 30;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CustomerManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 625);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CustomerPhoneTXT);
            this.Controls.Add(this.CustomerNameTXT);
            this.Controls.Add(this.CustomerIDTXT);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerManagement";
            this.Load += new System.EventHandler(this.CustomerManagement_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox CustomerPhoneTXT;
        private Bunifu.Framework.UI.BunifuMaterialTextbox CustomerNameTXT;
        private Bunifu.Framework.UI.BunifuMaterialTextbox CustomerIDTXT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}