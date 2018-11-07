using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;


namespace Narudzbenica
{
    public enum status
    {
        Pending,
        Processing,
        Complete
    }
    public class Order
    {
        #region private Atributes
        private long id;
        private DateTime orderDate;
        private DateTime dateRequiered;
        private DateTime dateShipped;
        private string shippedVia;
        private double frightCharges;
        private string customer;
        private status status;
        private List<Item> itemList;
        #endregion

        #region Properties
        public long ID { get => id; }
        public status Status { get => status; set => status = value; }
        String PrintableStatus { get => status.ToString(); }
        public DateTime OrderDate { get => orderDate; set => orderDate = value; }
        [System.ComponentModel.Browsable(false)]
        public DateTime DateRequiered { get => dateRequiered; set => dateRequiered = value; }
        public string Name { get => Customer.Substring(0,Customer.IndexOf("\n"));  }
        [System.ComponentModel.Browsable(false)]
        public DateTime OrderShipped { get => dateShipped; set => dateShipped = value; }
        [System.ComponentModel.Browsable(false)]
        public string ShippedVia { get => shippedVia; set => shippedVia = value; }
        [System.ComponentModel.Browsable(false)]
        public double FrightCharges { get => frightCharges; set => frightCharges = value; }
        public double Income { get
                                {
                                    double sum = 0;
                                    foreach(Item item in ItemList)
                                    {
                                        sum += item.Cost;
                                    }
                                    return sum-frightCharges;
                                }
                             }

        internal List<Item> ItemList { get => itemList; set => itemList = value; }
        [System.ComponentModel.Browsable(false)]
        public string Customer { get => customer; set => customer = value; }
        [System.ComponentModel.Browsable(false)]
        public string FormatedOrderDate { get => orderDate.Month + "/" + orderDate.Day + "/" + orderDate.Year; }
        [System.ComponentModel.Browsable(false)]
        public string FormatedDateReq { get => dateRequiered.Month + "/" + dateRequiered.Day + "/" + dateRequiered.Year; }
        [System.ComponentModel.Browsable(false)]
        public string FormatedOrderShipped { get => dateShipped.Month + "/" + dateShipped.Day + "/" + dateShipped.Year; }
        #endregion

        #region constructors
        public Order(long id, DateTime orderDate, DateTime dateRequiered, DateTime dateShipped, string shippedVia, double frighetCharges, string customer, status status, DataGridView dataGrid)
        {
            this.id = id;
            this.orderDate = orderDate;
            this.DateRequiered = dateRequiered;
            this.dateShipped = dateShipped;
            this.shippedVia = shippedVia;
            this.frightCharges = frighetCharges;
            this.Customer = customer;
            this.status = status;
            this.ItemList = new List<Item>();
            foreach (DataGridViewRow row in dataGrid.Rows)
            {
                if (row.Index != dataGrid.RowCount - 1)
                {
                    ItemList.Add(new Item(row, dataGrid));
                }
            }
        }
        public Order(StreamReader reader)
        {
            this.id = long.Parse(reader.ReadLine());
            this.orderDate = DateTime.Parse(reader.ReadLine());
            this.dateRequiered = DateTime.Parse(reader.ReadLine());
            this.dateShipped = DateTime.Parse(reader.ReadLine());
            this.shippedVia = reader.ReadLine();
            this.frightCharges = double.Parse(reader.ReadLine());
            this.Customer = "";
            int lines = Int32.Parse(reader.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                Customer += reader.ReadLine() + "\r\n";
            }
            this.status = (status)Enum.Parse(typeof(status), reader.ReadLine());

            this.ItemList = new List<Item>();
            int numberOFItems = Int32.Parse(reader.ReadLine());
            for (int i = 0; i < numberOFItems; ++i)
            {
                ItemList.Add(new Item(reader));
            }
        }
        #endregion

        #region methos
        public void writeToFile(StreamWriter writer)
        {
            writer.WriteLine(id);
            writer.WriteLine(orderDate.Date);
            writer.WriteLine(DateRequiered.Date);
            writer.WriteLine(dateShipped.Date);
            writer.WriteLine(shippedVia);
            writer.WriteLine(frightCharges);
            writer.WriteLine(Customer.Split('\n').Length);
            writer.WriteLine(Customer);
            writer.WriteLine(status);
            writer.WriteLine(ItemList.Count);
            foreach(Item item in ItemList)
            {
                item.writeToFile(writer);
            }
        }
        #endregion

    }

}
