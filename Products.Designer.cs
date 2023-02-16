namespace Inventory_App_Demo
{
    partial class Products
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.PriceTXT = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.QuantityTXT = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ProductNameTXT = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ProductIDTXT = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DescriptionTXT = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.label1.Location = new System.Drawing.Point(353, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Products";
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.Location = new System.Drawing.Point(134, 527);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(58, 36);
            this.button4.TabIndex = 31;
            this.button4.Text = "Home";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.Location = new System.Drawing.Point(198, 485);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(58, 36);
            this.button3.TabIndex = 30;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Location = new System.Drawing.Point(134, 485);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(58, 36);
            this.button2.TabIndex = 29;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Location = new System.Drawing.Point(70, 485);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 36);
            this.button1.TabIndex = 28;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PriceTXT
            // 
            this.PriceTXT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.PriceTXT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.PriceTXT.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.PriceTXT.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.PriceTXT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PriceTXT.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceTXT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PriceTXT.HintForeColor = System.Drawing.Color.Empty;
            this.PriceTXT.HintText = "";
            this.PriceTXT.isPassword = false;
            this.PriceTXT.LineFocusedColor = System.Drawing.Color.Blue;
            this.PriceTXT.LineIdleColor = System.Drawing.Color.Gray;
            this.PriceTXT.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.PriceTXT.LineThickness = 3;
            this.PriceTXT.Location = new System.Drawing.Point(87, 346);
            this.PriceTXT.Margin = new System.Windows.Forms.Padding(4);
            this.PriceTXT.MaxLength = 32767;
            this.PriceTXT.Name = "PriceTXT";
            this.PriceTXT.Size = new System.Drawing.Size(159, 33);
            this.PriceTXT.TabIndex = 27;
            this.PriceTXT.Text = "Price";
            this.PriceTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // QuantityTXT
            // 
            this.QuantityTXT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.QuantityTXT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.QuantityTXT.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.QuantityTXT.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.QuantityTXT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.QuantityTXT.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityTXT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.QuantityTXT.HintForeColor = System.Drawing.Color.Empty;
            this.QuantityTXT.HintText = "";
            this.QuantityTXT.isPassword = false;
            this.QuantityTXT.LineFocusedColor = System.Drawing.Color.Blue;
            this.QuantityTXT.LineIdleColor = System.Drawing.Color.Gray;
            this.QuantityTXT.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.QuantityTXT.LineThickness = 3;
            this.QuantityTXT.Location = new System.Drawing.Point(87, 293);
            this.QuantityTXT.Margin = new System.Windows.Forms.Padding(4);
            this.QuantityTXT.MaxLength = 32767;
            this.QuantityTXT.Name = "QuantityTXT";
            this.QuantityTXT.Size = new System.Drawing.Size(159, 32);
            this.QuantityTXT.TabIndex = 26;
            this.QuantityTXT.Text = "Quantity";
            this.QuantityTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ProductNameTXT
            // 
            this.ProductNameTXT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.ProductNameTXT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.ProductNameTXT.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ProductNameTXT.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.ProductNameTXT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProductNameTXT.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNameTXT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ProductNameTXT.HintForeColor = System.Drawing.Color.Empty;
            this.ProductNameTXT.HintText = "";
            this.ProductNameTXT.isPassword = false;
            this.ProductNameTXT.LineFocusedColor = System.Drawing.Color.Blue;
            this.ProductNameTXT.LineIdleColor = System.Drawing.Color.Gray;
            this.ProductNameTXT.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.ProductNameTXT.LineThickness = 3;
            this.ProductNameTXT.Location = new System.Drawing.Point(87, 241);
            this.ProductNameTXT.Margin = new System.Windows.Forms.Padding(4);
            this.ProductNameTXT.MaxLength = 32767;
            this.ProductNameTXT.Name = "ProductNameTXT";
            this.ProductNameTXT.Size = new System.Drawing.Size(159, 32);
            this.ProductNameTXT.TabIndex = 25;
            this.ProductNameTXT.Text = "Product Name";
            this.ProductNameTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ProductIDTXT
            // 
            this.ProductIDTXT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.ProductIDTXT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.ProductIDTXT.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ProductIDTXT.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.ProductIDTXT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProductIDTXT.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductIDTXT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ProductIDTXT.HintForeColor = System.Drawing.Color.Empty;
            this.ProductIDTXT.HintText = "";
            this.ProductIDTXT.isPassword = false;
            this.ProductIDTXT.LineFocusedColor = System.Drawing.Color.Blue;
            this.ProductIDTXT.LineIdleColor = System.Drawing.Color.Gray;
            this.ProductIDTXT.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.ProductIDTXT.LineThickness = 3;
            this.ProductIDTXT.Location = new System.Drawing.Point(87, 188);
            this.ProductIDTXT.Margin = new System.Windows.Forms.Padding(4);
            this.ProductIDTXT.MaxLength = 32767;
            this.ProductIDTXT.Name = "ProductIDTXT";
            this.ProductIDTXT.Size = new System.Drawing.Size(159, 32);
            this.ProductIDTXT.TabIndex = 24;
            this.ProductIDTXT.Text = "Product ID";
            this.ProductIDTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel2.Location = new System.Drawing.Point(0, 608);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(843, 17);
            this.panel2.TabIndex = 32;
            // 
            // DescriptionTXT
            // 
            this.DescriptionTXT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.DescriptionTXT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.DescriptionTXT.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.DescriptionTXT.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.DescriptionTXT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DescriptionTXT.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionTXT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DescriptionTXT.HintForeColor = System.Drawing.Color.Empty;
            this.DescriptionTXT.HintText = "";
            this.DescriptionTXT.isPassword = false;
            this.DescriptionTXT.LineFocusedColor = System.Drawing.Color.Blue;
            this.DescriptionTXT.LineIdleColor = System.Drawing.Color.Gray;
            this.DescriptionTXT.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.DescriptionTXT.LineThickness = 3;
            this.DescriptionTXT.Location = new System.Drawing.Point(87, 393);
            this.DescriptionTXT.Margin = new System.Windows.Forms.Padding(4);
            this.DescriptionTXT.MaxLength = 32767;
            this.DescriptionTXT.Name = "DescriptionTXT";
            this.DescriptionTXT.Size = new System.Drawing.Size(159, 33);
            this.DescriptionTXT.TabIndex = 34;
            this.DescriptionTXT.Text = "Description";
            this.DescriptionTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox1.Location = new System.Drawing.Point(87, 434);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(159, 24);
            this.comboBox1.TabIndex = 35;
            this.comboBox1.Text = "Category";
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.comboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox2.Location = new System.Drawing.Point(455, 139);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(159, 24);
            this.comboBox2.TabIndex = 37;
            this.comboBox2.Text = "Category";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.Location = new System.Drawing.Point(620, 140);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(105, 24);
            this.button6.TabIndex = 36;
            this.button6.Text = "Search";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(731, 139);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 25);
            this.button7.TabIndex = 38;
            this.button7.Text = "Refresh";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 625);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.DescriptionTXT);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PriceTXT);
            this.Controls.Add(this.QuantityTXT);
            this.Controls.Add(this.ProductNameTXT);
            this.Controls.Add(this.ProductIDTXT);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Products";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PriceTXT;
        private Bunifu.Framework.UI.BunifuMaterialTextbox QuantityTXT;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ProductNameTXT;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ProductIDTXT;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox DescriptionTXT;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}