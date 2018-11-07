namespace Narudzbenica
{
    partial class NewOrder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.addBtf2 = new System.Windows.Forms.Button();
            this.ShippingDataGrid = new System.Windows.Forms.DataGridView();
            this.req = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.via = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.charges = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idGrid = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.customerTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.itemsGrid = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.idErrLabel = new System.Windows.Forms.Label();
            this.orderDateErrLabel = new System.Windows.Forms.Label();
            this.dateRqErrLabel = new System.Windows.Forms.Label();
            this.DateShErrLabel = new System.Windows.Forms.Label();
            this.ShipViaErrLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ShippingDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // addBtf2
            // 
            this.addBtf2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtf2.Location = new System.Drawing.Point(12, 542);
            this.addBtf2.Name = "addBtf2";
            this.addBtf2.Size = new System.Drawing.Size(109, 33);
            this.addBtf2.TabIndex = 1;
            this.addBtf2.Text = "ADD";
            this.addBtf2.UseVisualStyleBackColor = true;
            this.addBtf2.Click += new System.EventHandler(this.addBtf2_Click);
            // 
            // ShippingDataGrid
            // 
            this.ShippingDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ShippingDataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ShippingDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ShippingDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShippingDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.req,
            this.shipp,
            this.via,
            this.charges});
            this.ShippingDataGrid.EnableHeadersVisualStyles = false;
            this.ShippingDataGrid.Location = new System.Drawing.Point(7, 170);
            this.ShippingDataGrid.Name = "ShippingDataGrid";
            this.ShippingDataGrid.RowHeadersVisible = false;
            this.ShippingDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ShippingDataGrid.Size = new System.Drawing.Size(528, 40);
            this.ShippingDataGrid.TabIndex = 4;
            // 
            // req
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.req.DefaultCellStyle = dataGridViewCellStyle2;
            this.req.HeaderText = "Date Requierd";
            this.req.Name = "req";
            // 
            // shipp
            // 
            this.shipp.HeaderText = "Date Shiped";
            this.shipp.Name = "shipp";
            // 
            // via
            // 
            this.via.HeaderText = "Ship via";
            this.via.Name = "via";
            // 
            // charges
            // 
            this.charges.HeaderText = "Freight Charges";
            this.charges.Name = "charges";
            // 
            // idGrid
            // 
            this.idGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.idGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.idGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.idGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.idGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.orderDate,
            this.status});
            this.idGrid.EnableHeadersVisualStyles = false;
            this.idGrid.Location = new System.Drawing.Point(288, 45);
            this.idGrid.Name = "idGrid";
            this.idGrid.RowHeadersVisible = false;
            this.idGrid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.idGrid.Size = new System.Drawing.Size(244, 56);
            this.idGrid.TabIndex = 5;
            // 
            // id
            // 
            this.id.HeaderText = "Order ID";
            this.id.MaxInputLength = 8;
            this.id.Name = "id";
            // 
            // orderDate
            // 
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.orderDate.DefaultCellStyle = dataGridViewCellStyle4;
            this.orderDate.HeaderText = "Order Date";
            this.orderDate.Name = "orderDate";
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Items.AddRange(new object[] {
            "Pending",
            "Processing",
            "Complete"});
            this.status.Name = "status";
            // 
            // customerTextBox
            // 
            this.customerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerTextBox.Location = new System.Drawing.Point(4, 264);
            this.customerTextBox.Multiline = true;
            this.customerTextBox.Name = "customerTextBox";
            this.customerTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.customerTextBox.Size = new System.Drawing.Size(528, 70);
            this.customerTextBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(528, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "Customer";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // itemsGrid
            // 
            this.itemsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.itemsGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.itemsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.itemsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.unitPrice,
            this.quantity,
            this.tax});
            this.itemsGrid.EnableHeadersVisualStyles = false;
            this.itemsGrid.Location = new System.Drawing.Point(4, 371);
            this.itemsGrid.Name = "itemsGrid";
            this.itemsGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.itemsGrid.Size = new System.Drawing.Size(528, 42);
            this.itemsGrid.TabIndex = 9;
            this.itemsGrid.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            this.itemsGrid.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.itemsGrid_RowsRemoved);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FloralWhite;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(528, 31);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ordered Items";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // idErrLabel
            // 
            this.idErrLabel.AutoSize = true;
            this.idErrLabel.ForeColor = System.Drawing.Color.Red;
            this.idErrLabel.Location = new System.Drawing.Point(251, 104);
            this.idErrLabel.Name = "idErrLabel";
            this.idErrLabel.Size = new System.Drawing.Size(114, 13);
            this.idErrLabel.TabIndex = 11;
            this.idErrLabel.Text = "ID must be 8 caracters";
            this.idErrLabel.Visible = false;
            // 
            // orderDateErrLabel
            // 
            this.orderDateErrLabel.AutoSize = true;
            this.orderDateErrLabel.ForeColor = System.Drawing.Color.Red;
            this.orderDateErrLabel.Location = new System.Drawing.Point(371, 104);
            this.orderDateErrLabel.Name = "orderDateErrLabel";
            this.orderDateErrLabel.Size = new System.Drawing.Size(117, 26);
            this.orderDateErrLabel.TabIndex = 12;
            this.orderDateErrLabel.Text = "not a date\r\nformat is MM/dd/YYYY\r\n";
            this.orderDateErrLabel.Visible = false;
            // 
            // dateRqErrLabel
            // 
            this.dateRqErrLabel.AutoSize = true;
            this.dateRqErrLabel.ForeColor = System.Drawing.Color.Red;
            this.dateRqErrLabel.Location = new System.Drawing.Point(33, 213);
            this.dateRqErrLabel.Name = "dateRqErrLabel";
            this.dateRqErrLabel.Size = new System.Drawing.Size(55, 13);
            this.dateRqErrLabel.TabIndex = 13;
            this.dateRqErrLabel.Text = "not a date";
            this.dateRqErrLabel.Visible = false;
            // 
            // DateShErrLabel
            // 
            this.DateShErrLabel.AutoSize = true;
            this.DateShErrLabel.ForeColor = System.Drawing.Color.Red;
            this.DateShErrLabel.Location = new System.Drawing.Point(171, 213);
            this.DateShErrLabel.Name = "DateShErrLabel";
            this.DateShErrLabel.Size = new System.Drawing.Size(55, 13);
            this.DateShErrLabel.TabIndex = 14;
            this.DateShErrLabel.Text = "not a date";
            this.DateShErrLabel.Visible = false;
            // 
            // ShipViaErrLabel
            // 
            this.ShipViaErrLabel.AutoSize = true;
            this.ShipViaErrLabel.ForeColor = System.Drawing.Color.Red;
            this.ShipViaErrLabel.Location = new System.Drawing.Point(285, 213);
            this.ShipViaErrLabel.Name = "ShipViaErrLabel";
            this.ShipViaErrLabel.Size = new System.Drawing.Size(93, 13);
            this.ShipViaErrLabel.TabIndex = 15;
            this.ShipViaErrLabel.Text = "must not be empty";
            this.ShipViaErrLabel.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(127, 542);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 33);
            this.button1.TabIndex = 16;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "ACME Corperation";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(63, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 65);
            this.label5.TabIndex = 18;
            this.label5.Text = "1223 First Streat\r\nMaounten view , CA 940900\r\n555-3445\r\nwww.acem.com\r\n\r\n";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // name
            // 
            this.name.FillWeight = 200F;
            this.name.HeaderText = "Product Name";
            this.name.Name = "name";
            // 
            // unitPrice
            // 
            this.unitPrice.HeaderText = "Unit price";
            this.unitPrice.Name = "unitPrice";
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            // 
            // tax
            // 
            this.tax.HeaderText = "tax";
            this.tax.Name = "tax";
            // 
            // NewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(540, 587);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ShipViaErrLabel);
            this.Controls.Add(this.DateShErrLabel);
            this.Controls.Add(this.dateRqErrLabel);
            this.Controls.Add(this.orderDateErrLabel);
            this.Controls.Add(this.idErrLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.itemsGrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.customerTextBox);
            this.Controls.Add(this.idGrid);
            this.Controls.Add(this.ShippingDataGrid);
            this.Controls.Add(this.addBtf2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "NewOrder";
            this.Text = "NewOrder";
            this.Load += new System.EventHandler(this.NewOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ShippingDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addBtf2;
        private System.Windows.Forms.DataGridView ShippingDataGrid;
        private System.Windows.Forms.DataGridView idGrid;
        private System.Windows.Forms.TextBox customerTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView itemsGrid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label idErrLabel;
        private System.Windows.Forms.Label orderDateErrLabel;
        private System.Windows.Forms.Label dateRqErrLabel;
        private System.Windows.Forms.Label DateShErrLabel;
        private System.Windows.Forms.Label ShipViaErrLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDate;
        private System.Windows.Forms.DataGridViewComboBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn req;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipp;
        private System.Windows.Forms.DataGridViewTextBoxColumn via;
        private System.Windows.Forms.DataGridViewTextBoxColumn charges;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn tax;
    }
}