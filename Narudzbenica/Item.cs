using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Narudzbenica
{
   class Item
    {
        #region Atributs
        private String name;
        private int unitPrice;
        private int quantity;
        private int tax;

        
        #endregion

        public Item(DataGridViewRow row, DataGridView dataGrid)
        {
            this.name = row.Cells[dataGrid.Columns["name"].Index].Value.ToString();
            this.unitPrice = int.Parse(row.Cells[dataGrid.Columns["unitPrice"].Index].Value.ToString());
            this.quantity = int.Parse(row.Cells[dataGrid.Columns["quantity"].Index].Value.ToString());
            this.Tax = Int32.Parse(row.Cells[dataGrid.Columns["tax"].Index].Value.ToString());
        }
        public Item(StreamReader reader)
        {
            this.name = reader.ReadLine();
            this.unitPrice = Int32.Parse(reader.ReadLine());
            this.quantity = Int32.Parse(reader.ReadLine());
            this.tax = Int32.Parse(reader.ReadLine());
        }

        #region properties
        public string Name { get => name; set => name = value; }
        public int UnitPrice { get => unitPrice; set => unitPrice = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        [System.ComponentModel.Browsable(false)]
        public int Cost { get => unitPrice * quantity*(1-(tax/100)); }
        public int Tax { get => tax; set => tax = value; }
        #endregion

        #region methods
        internal void writeToFile(StreamWriter writer)
        {
            writer.WriteLine(name);
            writer.WriteLine(UnitPrice);
            writer.WriteLine(quantity);
            writer.WriteLine(tax);
        }
        #endregion 
    }
}
