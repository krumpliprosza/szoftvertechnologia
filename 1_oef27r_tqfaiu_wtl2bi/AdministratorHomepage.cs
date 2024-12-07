using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace _1_oef27r_tqfaiu_wtl2bi
{
    public partial class AdministratorHomepage : Form
    {
        public AdministratorHomepage()
        {
            InitializeComponent();
            PopulateOrdersToSendDataGrid();
            PopulateReadyOrdersDataGrid();
        }
        public void RefreshOrdersToSendDataGrid()
        {
            XDocument doc = XDocument.Load("Data/order.xml");
            var orders = doc.Descendants("order")
                            .Where(o => (string)o.Element("status") == "Felvételre vár" && decimal.TryParse(o.Element("totalPrice")?.Value, out decimal price) && price > 0)
                            .Select(o => new
                            {
                                Id = o.Element("id")?.Value,
                                Name = o.Element("customer")?.Element("name")?.Value,
                                LicenseNumber = o.Element("customer")?.Element("licenseNumber")?.Value,
                                TotalPrice = o.Element("totalPrice")?.Value
                            });
            OrdersToSendDataGrid.Rows.Clear();
            foreach (var order in orders)
            {
                OrdersToSendDataGrid.Rows.Add(order.Id, order.Name, order.LicenseNumber, order.TotalPrice);
            }
        }
        public void PopulateReadyOrdersDataGrid()
        {
            XDocument doc = XDocument.Load("Data/order.xml");
            var orders = doc.Descendants("order")
                            .Where(o => (string)o.Element("status") == "Kész")
                            .Select(o => new
                            {
                                Id = o.Element("id")?.Value,
                                Name = o.Element("customer")?.Element("name")?.Value,
                                LicenseNumber = o.Element("customer")?.Element("licenseNumber")?.Value,
                                TotalPrice = o.Element("totalPrice")?.Value
                            });
            ReadyOrders.Rows.Clear();
            foreach (var order in orders)
            {
                ReadyOrders.Rows.Add(order.Id, order.Name, order.LicenseNumber, order.TotalPrice);
            }
        }

        private void PopulateOrdersToSendDataGrid()
        {
            // order.xml betoltese
            XDocument doc = XDocument.Load("Data/order.xml");

            // Szures
            var orders = doc.Descendants("order")
                            .Where(o =>
                                decimal.TryParse(o.Element("totalPrice")?.Value, out decimal price) &&
                                price > 0 &&
                                (string)o.Element("status") == "Felvételre vár")
                            .Select(o => new
                            {
                                Id = o.Element("id")?.Value,
                                Name = o.Element("customer")?.Element("name")?.Value,
                                LicenseNumber = o.Element("customer")?.Element("licenseNumber")?.Value,
                                TotalPrice = o.Element("totalPrice")?.Value
                            });

            // DataGrid torlese es feltoltese
            OrdersToSendDataGrid.Rows.Clear();
            foreach (var order in orders)
            {
                OrdersToSendDataGrid.Rows.Add(order.Id, order.Name, order.LicenseNumber, order.TotalPrice);
            }
        }
        private void StorageQuery_Click(object sender, EventArgs e)
        {
            // Kereses oldal megnyitasa
            Search searchPage = new Search();
            searchPage.Show();
            this.Close();
        }
        private void OrderCreate_Click(object sender, EventArgs e)
        {
            // Rendelest felvevo oldal megnyitasa
            OrderAdd orderAddPage = new OrderAdd();
            orderAddPage.Show();
        }
        private void ServiceQuery_Click(object sender, EventArgs e)
        {
            // Kereses oldal megnyitasa
            ServiceAdd serviceAddPage = new ServiceAdd();
            serviceAddPage.Show();
            this.Close();
        }
        private void OrdersToSendDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (OrdersToSendDataGrid.SelectedRows.Count == 1)
            {
                var selectedRow = OrdersToSendDataGrid.SelectedRows[0];
                int orderId = int.Parse(selectedRow.Cells["ColId"].Value?.ToString());
                XDocument doc = XDocument.Load("Data/order.xml");
                var order = doc.Descendants("order")
                               .FirstOrDefault(o => (int)o.Element("id") == orderId);
                if (order != null)
                {
                    bool hasChosenTyres = order.Element("chosenTyres")?.Elements("chosenTyre").Any() ?? false;
                    if (!hasChosenTyres)
                    {
                        order.Element("status")?.SetValue("Szerelés alatt");
                    }
                    else
                    {
                        order.Element("status")?.SetValue("Előkészítés alatt");
                    }
                    doc.Save("Data/order.xml");
                    MessageBox.Show("Rendelés státusza frissítve!", "Státusz Frissítés", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PopulateOrdersToSendDataGrid();
                }
            }
        }

        private void ReadyOrders_SelectionChanged(object sender, EventArgs e)
        {
            if (ReadyOrders.SelectedRows.Count == 1)
            {
                var selectedRow = ReadyOrders.SelectedRows[0];
                int orderId = int.Parse(selectedRow.Cells["ColumnId"].Value?.ToString());
                XDocument doc = XDocument.Load("Data/order.xml");
                var order = doc.Descendants("order")
                               .FirstOrDefault(o => (int)o.Element("id") == orderId);
                if (order != null)
                {
                    order.Remove();
                    doc.Save("Data/order.xml");
                    PopulateReadyOrders();
                    MessageBox.Show("Rendelés sikeresen törölve!", "Sikeres törlés", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("A kiválasztott rendelés nem található.", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void PopulateReadyOrders()
        {
            XDocument doc = XDocument.Load("Data/order.xml");

            var orders = doc.Descendants("order")
                            .Where(o => (string)o.Element("status") == "Kész")
                            .Select(o => new
                            {
                                Id = o.Element("id")?.Value,
                                Name = o.Element("customer")?.Element("name")?.Value,
                                LicenseNumber = o.Element("customer")?.Element("licenseNumber")?.Value,
                                TotalPrice = o.Element("totalPrice")?.Value
                            });

            ReadyOrders.Rows.Clear();

            foreach (var order in orders)
            {
                ReadyOrders.Rows.Add(order.Id, order.Name, order.LicenseNumber, order.TotalPrice);
            }
        }
    }
}
