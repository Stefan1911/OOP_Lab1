using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Narudzbenica
{
    public class OrderList
    {
        private List<Order> list;


        public OrderList()
        {
            list = new List<Order>();
        }

        internal List<Order> List { get => list; set => list = value; }

        public List<Order> filter(TextBox textBox, DateTimePicker startPicker, DateTimePicker endPicer, ComboBox comboBox)
        {
            List<Order> retList = new List<Order>();
            foreach (Order order in list)
            {
                if (order.ID == long.Parse(textBox.Text) && order.OrderDate.Date > startPicker.Value.Date && order.OrderDate < endPicer.Value.Date && order.Status == (status)Enum.Parse(typeof(status), comboBox.Text))
                {
                    retList.Add(order);
                }
            }
            return retList;
        }

        #region singletone
        private static OrderList _instanced = null;
        public static OrderList Instance {
            get
            {
                if(_instanced == null)
                {
                    _instanced = new OrderList();
                }
                return _instanced;
            }
        }
        #endregion

        #region methodes
        public bool notInList(Order order)
        {
            foreach (Order currOder in this.list)
            {
                if (currOder.ID == order.ID) return false;
            }
            return true;
        }
        public void writeToFile(string path)
        {
            string seperator = "############################";
            StreamWriter writer = new StreamWriter(path);
            writer.WriteLine(list.Count);
            foreach(Order order in list)
            {
                order.writeToFile(writer);
                writer.WriteLine(seperator);
            }
            writer.Close();
        }
        public void ReadFromFile(string path)
        {
            StreamReader reader = new StreamReader(path);
            int numberOfOrders = Int32.Parse(reader.ReadLine());
            for (int i = 0; i < numberOfOrders; ++i)
            {
                list.Add(new Order(reader));
                reader.ReadLine(); //for the seperator
            }
            reader.Close();
        }
        
        #endregion
    }
}
