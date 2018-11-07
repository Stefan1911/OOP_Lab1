using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Narudzbenica
{
    public partial class NewOrder : Form
    {
        private Order orderToEdit;

        public NewOrder()
        {
            OrderToEdit = null;
            InitializeComponent();
        }


        #region properties
        public Button addButton { get => this.addBtf2; }
        public Order OrderToEdit { get => orderToEdit; set => orderToEdit = value; }
        #endregion

        #region Methods
        public void setStatus(status status)
        {
            (idGrid.Rows[0].Cells["status"] as DataGridViewComboBoxCell).Value = (idGrid.Rows[0].Cells["status"] as DataGridViewComboBoxCell).Items[(int)status];
        }

        private void resizeItemsGrid()
        {
            if (itemsGrid.Rows.Count <= 6)
                itemsGrid.Height = itemsGrid.ColumnHeadersHeight + itemsGrid.Rows.GetRowsHeight(DataGridViewElementStates.Visible) + 10;
        }
        private Order orderBuidelr()
        {
            int id = Int32.Parse(idGrid.Rows[0].Cells[idGrid.Columns["id"].Index].Value.ToString());
            DateTime OrderDate = DateTime.ParseExact(idGrid.Rows[0].Cells[idGrid.Columns["orderDate"].Index].Value.ToString(), "MM/dd/yyyy", null, System.Globalization.DateTimeStyles.None);
            DateTime orderRequired = DateTime.ParseExact(ShippingDataGrid.Rows[0].Cells[ShippingDataGrid.Columns["req"].Index].Value.ToString(), "MM/dd/yyyy", null, System.Globalization.DateTimeStyles.None);
            DateTime orderShipped = DateTime.ParseExact(ShippingDataGrid.Rows[0].Cells[ShippingDataGrid.Columns["shipp"].Index].Value.ToString(),"MM/dd/yyyy", null, System.Globalization.DateTimeStyles.None);
            string shippedVia = ShippingDataGrid.Rows[0].Cells[ShippingDataGrid.Columns["via"].Index].Value.ToString();
            double charges = double.Parse(ShippingDataGrid.Rows[0].Cells[ShippingDataGrid.Columns["charges"].Index].Value.ToString());
            String custumer = customerTextBox.Text;
            //status status = (status)idGrid.Columns["status"].Index;
            status status = (status)Enum.Parse(typeof(status), idGrid.Rows[0].Cells[idGrid.Columns["status"].Index].Value.ToString()) ;
            DataGridView items = itemsGrid;

            return new Order(
                            id,
                            OrderDate,
                            orderRequired,
                            orderShipped,
                            shippedVia,
                            charges,
                            custumer,
                            status,
                            items
                            );
        }
        public void insertOrder(Order order)
        {
            idGrid.Rows[0].Cells["id"].Value = order.ID;
            idGrid.Rows[0].Cells["orderDate"].Value = order.FormatedOrderDate;
            this.setStatus(order.Status);
            ShippingDataGrid.Rows[0].Cells["req"].Value = order.FormatedDateReq;
            ShippingDataGrid.Rows[0].Cells["shipp"].Value = order.FormatedOrderShipped;
            ShippingDataGrid.Rows[0].Cells["via"].Value = order.ShippedVia;
            ShippingDataGrid.Rows[0].Cells["charges"].Value = order.FrightCharges;
            customerTextBox.Text = order.Customer;

            this.removeColumns();

            this.itemsGrid.DataSource = order.ItemList.ToList();
            this.resizeItemsGrid();
        }
        public void removeColumns()
        {
            itemsGrid.Columns.Remove("name");
            itemsGrid.Columns.Remove("unitPrice");
            itemsGrid.Columns.Remove("quantity");
            itemsGrid.Columns.Remove("tax");
        }

        
        #endregion

        #region Validation
        private bool validation()
        {
            bool IdVal = IdValidation(idGrid.Rows[0].Cells["id"],idErrLabel);
            bool orderDateVal = OrderDateVlaidation(idGrid.Rows[0].Cells["orderDate"],orderDateErrLabel);
            bool dateRqVal = OrderDateVlaidation(ShippingDataGrid.Rows[0].Cells["req"],dateRqErrLabel);
            bool dateShVal = OrderDateVlaidation(ShippingDataGrid.Rows[0].Cells["shipp"], DateShErrLabel);
            bool shViaVal = notNullValidation(ShippingDataGrid.Rows[0].Cells["via"], ShipViaErrLabel);
            bool customerVal = customerValidation();
            bool chargeVal = chargeValidation();
            bool itemVal = itemValidation();

            return IdVal && orderDateVal && dateRqVal && dateShVal && shViaVal && customerVal && itemVal && chargeVal;
        }
        private bool IdValidation(DataGridViewCell cell,Label label)
        {
            if (cell.Value == null || cell.Value.ToString().Length < 8 || this.chekIfNumeric(cell) == false)
            {
                idGrid.Rows[0].Cells[0].Style.BackColor = Color.LightPink;
                label.Visible = true;
                return false;
            }
            else
            {
                idGrid.Rows[0].Cells[0].Style.BackColor = Color.White;
                label.Visible = false;
            }
            return true;
        }
        private bool OrderDateVlaidation(DataGridViewCell cell,Label label)
        {
            DateTime temp;
            if (cell.Value == null || !DateTime.TryParseExact(cell.Value.ToString(), "MM/dd/yyyy",null,System.Globalization.DateTimeStyles.None,out temp))
            {
                cell.Style.BackColor = Color.LightPink;
                label.Visible = true;
                return false;
            }
            else
            {
                cell.Style.BackColor = Color.White;
                label.Visible = false;
            }
            return true;
}
        private bool notNullValidation(DataGridViewCell cell, Label label)
        {
            if (cell.Value == null)
            {
                cell.Style.BackColor = Color.LightPink;
                label.Visible = true;
                return false;
            }
            else
            {
                cell.Style.BackColor = Color.White;
                label.Visible = false;
                return true;
            }
        }
        private bool itemValidation()
        {
            bool ret = true;
            foreach(DataGridViewRow row in itemsGrid.Rows)
            {
                if(row.Cells["name"].Value != null)
                {
                    if (this.chekIfNumeric(row.Cells["unitPrice"]) == false)
                    {
                        row.Cells["unitPrice"].Style.BackColor = Color.LightPink;
                        ret = false;
                    }
                    else
                    {
                        row.Cells["unitPrice"].Style.BackColor = Color.White;
                    }
                    if (this.chekIfNumeric(row.Cells["quantity"]) == false)
                    {
                        row.Cells["quantity"].Style.BackColor = Color.LightPink;
                        ret = false;
                    }
                    else
                    {
                        row.Cells["quantity"].Style.BackColor = Color.White;
                    }
                    if(row.Cells["tax"].Value.ToString() == "8" || row.Cells["tax"].Value.ToString() == "20")
                    {
                        row.Cells["tax"].Style.BackColor = Color.White;
                    }
                    else
                    {
                        row.Cells["tax"].Style.BackColor = Color.LightPink;
                        ret = false;
                    }
                }
                
            }
            return ret;
        }
        private bool customerValidation()
        {
            if(customerTextBox.Text.IndexOf("\n") == -1)
            {
                customerTextBox.BackColor = Color.LightPink;
                return false;
            }
            else
            {
                customerTextBox.BackColor = Color.White;
                return true;
            }
        }
        private bool chargeValidation()
        {
            DataGridViewCell cell = ShippingDataGrid.Rows[0].Cells[ShippingDataGrid.Columns["charges"].Index];

            if (cell.Value == null)
                cell.Value = 0;
            if (this.chekIfNumeric(cell) == false)
            {
                cell.Style.BackColor = Color.LightPink;
                return false;
            }
            else
            {
                cell.Style.BackColor = Color.White;
                return true;
            }
        }
        private bool chekIfNumeric(DataGridViewCell cell)
        {
            if (cell.Value == null) return false;
            long id;
            int number;
            if (long.TryParse(cell.Value.ToString(), out id) || Int32.TryParse(cell.Value.ToString(), out number))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region events
        private void addBtf2_Click(object sender, EventArgs e)
        {
            if (this.validation())
            {
                if(this.orderToEdit != null)
                {
                    OrderList.Instance.List.Remove(this.orderToEdit);
                    OrderList.Instance.List.Add(this.orderBuidelr());
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    OrderList.Instance.List.Add(this.orderBuidelr());
                    DialogResult = DialogResult.OK;
                    this.Close();
                }

                
            }
        }

        private void NewOrder_Load(object sender, EventArgs e)
        {
           
        }
        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            this.resizeItemsGrid();
        }

        private void itemsGrid_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            this.resizeItemsGrid();
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
