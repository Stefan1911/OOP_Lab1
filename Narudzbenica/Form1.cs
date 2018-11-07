using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Narudzbenica
{
    public partial class Form1 : Form
    {
        private static OrderList skeleton;
        public Form1()
        {
            skeleton = new OrderList();
            InitializeComponent();
        }

        public static OrderList Skeleton { get => skeleton; set => skeleton = value; }

    
       

        public DataGridView DataGrid { get => this.dataGrid; }
        public DataGridView getDat() { return this.dataGrid; }

        #region properties
        public Order Selected
        {
            get
            {
                if (dataGrid.RowCount == 0) return null;
                int rowIndex = DataGrid.CurrentCell.RowIndex;
                long id = long.Parse(dataGrid.Rows[rowIndex].Cells["ID"].Value.ToString());
                return OrderList.Instance.List.Where(i => i.ID == id).FirstOrDefault();
            }
        }
        #endregion

        #region metode
        public void updateGrid()
        {
            dataGrid.DataSource = OrderList.Instance.List.ToList();
       }
        public void filterGrid()
        {
            dataGrid.DataSource = OrderList.Instance.filter(filterTextBox, filterDatePicker1, filterDatePicker2, filterComboBox);
        }
        #endregion

        #region events
        private void addBt_Click(object sender, EventArgs e)
        {
            NewOrder orderForm = new NewOrder();
            orderForm.setStatus(status.Pending);
            if (orderForm.ShowDialog() == DialogResult.OK)
            {
                this.updateGrid();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            filterComboBox.SelectedIndex = 0;
            this.updateGrid();
        }
        private void writeButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            if(fileDialog.ShowDialog() == DialogResult.OK)
            {
                OrderList.Instance.writeToFile(fileDialog.FileName);
            }
        }
        private void readButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            if(fileDialog.ShowDialog() == DialogResult.OK)
            {
                OrderList.Instance.List.Clear();
                OrderList.Instance.ReadFromFile(fileDialog.FileName);
                this.updateGrid();
            }
        }
        private void filterBt_Click(object sender, EventArgs e)
        {
            this.filterGrid();
        }
        private void clearFilterBt_Click(object sender, EventArgs e)
        {
            this.filterTextBox.Text = "";
            this.updateGrid();
        }
        private void editButton_Click(object sender, EventArgs e)
        {
            if(this.Selected != null)
            {
                NewOrder orderForm = new NewOrder();
                orderForm.insertOrder(this.Selected);
                orderForm.addButton.Text = "EDIT";
                orderForm.OrderToEdit = this.Selected;
                if (orderForm.ShowDialog() == DialogResult.OK)
                {
                    this.updateGrid();
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if(this.Selected != null)
            {
                OrderList.Instance.List.Remove(this.Selected);
                this.updateGrid();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(this.Selected != null)
            {
                this.Selected.Status = status.Pending;
                this.updateGrid();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.Selected != null)
            {
                this.Selected.Status = status.Processing;
                this.updateGrid();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.Selected != null)
            {
                this.Selected.Status = status.Complete;
                this.updateGrid();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (this.Selected != null) ;
            SaveFileDialog fileDialog = new SaveFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(fileDialog.FileName);
                this.Selected.writeToFile(writer);
                writer.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        { 
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = new StreamReader(fileDialog.FileName);
                Order order = new Order(reader);
                reader.Close();

                if (OrderList.Instance.notInList(order))
                {
                    OrderList.Instance.List.Add(order);
                }
                this.updateGrid();
            }
        }
        #endregion
    }
}
