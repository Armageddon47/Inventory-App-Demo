namespace Inventory_App_Demo
{
    partial class Orders
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.CustomerGrid = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.OrderIDTXT = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.CustomerIDTXT = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.ProductGrid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox1.Location = new System.Drawing.Point(525, 120);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(198, 33);
            this.comboBox1.TabIndex = 46;
            this.comboBox1.Text = "Category";
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // CustomerGrid
            // 
            this.CustomerGrid.AllowUserToResizeColumns = false;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.CustomerGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CustomerGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.CustomerGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CustomerGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.CustomerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerGrid.Location = new System.Drawing.Point(0, 159);
            this.CustomerGrid.Name = "CustomerGrid";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CustomerGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.CustomerGrid.RowHeadersVisible = false;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Navy;
            this.CustomerGrid.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.CustomerGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Snow;
            this.CustomerGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CustomerGrid.Size = new System.Drawing.Size(432, 175);
            this.CustomerGrid.TabIndex = 45;
            this.CustomerGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomerGrid_CellContentClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaption;
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker1.Location = new System.Drawing.Point(103, 440);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(246, 23);
            this.dateTimePicker1.TabIndex = 44;
            // 
            // OrderIDTXT
            // 
            this.OrderIDTXT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.OrderIDTXT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.OrderIDTXT.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.OrderIDTXT.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.OrderIDTXT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.OrderIDTXT.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderIDTXT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.OrderIDTXT.HintForeColor = System.Drawing.Color.Empty;
            this.OrderIDTXT.HintText = "";
            this.OrderIDTXT.isPassword = false;
            this.OrderIDTXT.LineFocusedColor = System.Drawing.Color.Blue;
            this.OrderIDTXT.LineIdleColor = System.Drawing.Color.Gray;
            this.OrderIDTXT.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.OrderIDTXT.LineThickness = 3;
            this.OrderIDTXT.Location = new System.Drawing.Point(82, 389);
            this.OrderIDTXT.Margin = new System.Windows.Forms.Padding(4);
            this.OrderIDTXT.MaxLength = 32767;
            this.OrderIDTXT.Name = "OrderIDTXT";
            this.OrderIDTXT.Size = new System.Drawing.Size(159, 32);
            this.OrderIDTXT.TabIndex = 43;
            this.OrderIDTXT.Text = "Order ID";
            this.OrderIDTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.CustomerIDTXT.Location = new System.Drawing.Point(246, 389);
            this.CustomerIDTXT.Margin = new System.Windows.Forms.Padding(4);
            this.CustomerIDTXT.MaxLength = 32767;
            this.CustomerIDTXT.Name = "CustomerIDTXT";
            this.CustomerIDTXT.Size = new System.Drawing.Size(159, 32);
            this.CustomerIDTXT.TabIndex = 42;
            this.CustomerIDTXT.Text = "Customer ID";
            this.CustomerIDTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Turquoise;
            this.label3.Location = new System.Drawing.Point(164, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 25);
            this.label3.TabIndex = 41;
            this.label3.Text = "Orders List";
            // 
            // ProductGrid
            // 
            this.ProductGrid.AllowUserToResizeColumns = false;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.ProductGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.ProductGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.ProductGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductGrid.Location = new System.Drawing.Point(438, 159);
            this.ProductGrid.Name = "ProductGrid";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.ProductGrid.RowHeadersVisible = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Navy;
            this.ProductGrid.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.ProductGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Snow;
            this.ProductGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductGrid.Size = new System.Drawing.Size(405, 175);
            this.ProductGrid.TabIndex = 40;
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
            this.panel1.TabIndex = 39;
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
            this.label1.Location = new System.Drawing.Point(282, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Manager";
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 625);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.CustomerGrid);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.OrderIDTXT);
            this.Controls.Add(this.CustomerIDTXT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ProductGrid);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Orders";
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.Orders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView CustomerGrid;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox OrderIDTXT;
        private Bunifu.Framework.UI.BunifuMaterialTextbox CustomerIDTXT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView ProductGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}