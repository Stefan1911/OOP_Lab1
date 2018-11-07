namespace Narudzbenica
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
            this.components = new System.ComponentModel.Container();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.addBt = new System.Windows.Forms.Button();
            this.writeButton = new System.Windows.Forms.Button();
            this.readButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.filterComboBox = new System.Windows.Forms.ComboBox();
            this.clearFilterBt = new System.Windows.Forms.Button();
            this.filterBt = new System.Windows.Forms.Button();
            this.filterDatePicker2 = new System.Windows.Forms.DateTimePicker();
            this.filterDatePicker1 = new System.Windows.Forms.DateTimePicker();
            this.filterTextBox = new System.Windows.Forms.TextBox();
            this.editButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.orderListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(12, 69);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.Size = new System.Drawing.Size(1050, 360);
            this.dataGrid.TabIndex = 0;
            // 
            // addBt
            // 
            this.addBt.Location = new System.Drawing.Point(12, 435);
            this.addBt.Name = "addBt";
            this.addBt.Size = new System.Drawing.Size(121, 40);
            this.addBt.TabIndex = 1;
            this.addBt.Text = "ADD";
            this.addBt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.addBt.UseVisualStyleBackColor = true;
            this.addBt.Click += new System.EventHandler(this.addBt_Click);
            // 
            // writeButton
            // 
            this.writeButton.Location = new System.Drawing.Point(14, 503);
            this.writeButton.Name = "writeButton";
            this.writeButton.Size = new System.Drawing.Size(119, 39);
            this.writeButton.TabIndex = 2;
            this.writeButton.Text = "save to file";
            this.writeButton.UseVisualStyleBackColor = true;
            this.writeButton.Click += new System.EventHandler(this.writeButton_Click);
            // 
            // readButton
            // 
            this.readButton.Location = new System.Drawing.Point(141, 503);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(119, 39);
            this.readButton.TabIndex = 3;
            this.readButton.Text = "read from file";
            this.readButton.UseVisualStyleBackColor = true;
            this.readButton.Click += new System.EventHandler(this.readButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.filterComboBox);
            this.groupBox1.Controls.Add(this.clearFilterBt);
            this.groupBox1.Controls.Add(this.filterBt);
            this.groupBox1.Controls.Add(this.filterDatePicker2);
            this.groupBox1.Controls.Add(this.filterDatePicker1);
            this.groupBox1.Controls.Add(this.filterTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1050, 51);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // filterComboBox
            // 
            this.filterComboBox.FormattingEnabled = true;
            this.filterComboBox.Items.AddRange(new object[] {
            "Pending",
            "Processing",
            "Complete"});
            this.filterComboBox.Location = new System.Drawing.Point(597, 17);
            this.filterComboBox.Name = "filterComboBox";
            this.filterComboBox.Size = new System.Drawing.Size(121, 21);
            this.filterComboBox.TabIndex = 5;
            // 
            // clearFilterBt
            // 
            this.clearFilterBt.Location = new System.Drawing.Point(888, 16);
            this.clearFilterBt.Name = "clearFilterBt";
            this.clearFilterBt.Size = new System.Drawing.Size(134, 29);
            this.clearFilterBt.TabIndex = 4;
            this.clearFilterBt.Text = "Clear Filter";
            this.clearFilterBt.UseVisualStyleBackColor = true;
            this.clearFilterBt.Click += new System.EventHandler(this.clearFilterBt_Click);
            // 
            // filterBt
            // 
            this.filterBt.BackColor = System.Drawing.SystemColors.Highlight;
            this.filterBt.Cursor = System.Windows.Forms.Cursors.Default;
            this.filterBt.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.filterBt.FlatAppearance.BorderSize = 0;
            this.filterBt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.filterBt.Location = new System.Drawing.Point(746, 16);
            this.filterBt.Name = "filterBt";
            this.filterBt.Size = new System.Drawing.Size(136, 29);
            this.filterBt.TabIndex = 3;
            this.filterBt.Text = "Filter";
            this.filterBt.UseVisualStyleBackColor = false;
            this.filterBt.Click += new System.EventHandler(this.filterBt_Click);
            // 
            // filterDatePicker2
            // 
            this.filterDatePicker2.Location = new System.Drawing.Point(398, 19);
            this.filterDatePicker2.Name = "filterDatePicker2";
            this.filterDatePicker2.Size = new System.Drawing.Size(192, 20);
            this.filterDatePicker2.TabIndex = 2;
            // 
            // filterDatePicker1
            // 
            this.filterDatePicker1.Location = new System.Drawing.Point(205, 19);
            this.filterDatePicker1.Name = "filterDatePicker1";
            this.filterDatePicker1.Size = new System.Drawing.Size(187, 20);
            this.filterDatePicker1.TabIndex = 1;
            // 
            // filterTextBox
            // 
            this.filterTextBox.Location = new System.Drawing.Point(23, 19);
            this.filterTextBox.Name = "filterTextBox";
            this.filterTextBox.Size = new System.Drawing.Size(166, 20);
            this.filterTextBox.TabIndex = 0;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(139, 436);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(121, 40);
            this.editButton.TabIndex = 5;
            this.editButton.Text = "EDIT";
            this.editButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(266, 436);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "DELETE";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(12, 487);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1050, 2);
            this.label1.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(973, 436);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 40);
            this.button2.TabIndex = 8;
            this.button2.Text = "--> Comlete";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(877, 436);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 40);
            this.button3.TabIndex = 9;
            this.button3.Text = "--> Processing";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(781, 436);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 40);
            this.button4.TabIndex = 10;
            this.button4.Text = "--> Pending";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(285, 503);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(119, 39);
            this.button5.TabIndex = 11;
            this.button5.Text = "Save Item";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(410, 503);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(119, 39);
            this.button6.TabIndex = 12;
            this.button6.Text = "Read Item";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // orderListBindingSource
            // 
            this.orderListBindingSource.DataSource = typeof(Narudzbenica.OrderList);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 554);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.readButton);
            this.Controls.Add(this.writeButton);
            this.Controls.Add(this.addBt);
            this.Controls.Add(this.dataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderListBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button addBt;
        private System.Windows.Forms.BindingSource orderListBindingSource;
        private System.Windows.Forms.Button writeButton;
        private System.Windows.Forms.Button readButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker filterDatePicker2;
        private System.Windows.Forms.DateTimePicker filterDatePicker1;
        private System.Windows.Forms.TextBox filterTextBox;
        private System.Windows.Forms.Button clearFilterBt;
        private System.Windows.Forms.Button filterBt;
        private System.Windows.Forms.ComboBox filterComboBox;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

