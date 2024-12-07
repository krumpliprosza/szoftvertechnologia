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
    public partial class ServiceToOrder : Form
    {
        public ServiceToOrder()
        {
            InitializeComponent();
        }
        public ServiceToOrder(DataGridViewRow selectedRow)
        {
            InitializeComponent();
            // A kapott sorbol a megfelelo szovegdobozok feltoltese
            NameValue.Text = selectedRow.Cells["ColName"].Value?.ToString();
            BasePriceValue.Text = selectedRow.Cells["ColBasePrice"].Value?.ToString();
            // order.xml betoltese
            XDocument doc = XDocument.Load("Data/order.xml");
            // Rendelesek megkeresese
            var orders = doc.Descendants("order")
                            .Where(o => (string)o.Element("status") == "Felvételre vár")
                            .Select(o => new
                            {
                                Id = o.Element("id")?.Value,
                                Name = o.Element("customer")?.Element("name")?.Value,
                                LicenseNumber = o.Element("customer")?.Element("licenseNumber")?.Value
                            })
                            .ToList();
            OrderDataGrid.Rows.Clear();
            foreach (var order in orders)
            {
                OrderDataGrid.Rows.Add(order.Id, order.Name, order.LicenseNumber);
            }
        }

        private void OrderDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (OrderDataGrid.SelectedRows.Count == 1)
            {
                var selectedRow = OrderDataGrid.SelectedRows[0];

                // Azonosito megszerzese
                int orderId = int.Parse(selectedRow.Cells["ColId"].Value?.ToString());

                // Input bekerese
                string serviceName = NameValue.Text;
                int basePrice;
                if (string.IsNullOrEmpty(BasePriceValue.Text) || !int.TryParse(BasePriceValue.Text, out basePrice))
                {
                    MessageBox.Show("Hibás vagy hiányzó alapár!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int serviceQuantity;
                if (string.IsNullOrEmpty(OrderQuantityValue.Text) || !int.TryParse(OrderQuantityValue.Text, out serviceQuantity) || serviceQuantity <= 0)
                {
                    MessageBox.Show("Hiányos vagy érvénytelen mennyiség!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int diameter;
                if (string.IsNullOrEmpty(DiameterValue.Text) || !int.TryParse(DiameterValue.Text, out diameter) || diameter <= 0)
                {
                    MessageBox.Show("Hiányos vagy érvénytelen átmérő!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // order.xml betoltese
                XDocument doc = XDocument.Load("Data/order.xml");

                // Rendeles megkeresese
                var order = doc.Descendants("order")
                    .FirstOrDefault(o => (int)o.Element("id") == orderId);

                if (order != null)
                {
                    XElement chosenServiceElement = new XElement("chosenService",
                        new XElement("name", serviceName),
                        new XElement("basePrice", basePrice),
                        new XElement("diameter", diameter),
                        new XElement("quantity", serviceQuantity)
                    );

                    // chosenService -> chosenServices
                    order.Element("chosenServices")?.Add(chosenServiceElement);

                    // Szamitas
                    decimal totalPrice = decimal.Parse(order.Element("totalPrice")?.Value ?? "0");
                    decimal servicePrice = basePrice * serviceQuantity;
                    if (diameter < 15)
                    {

                    }
                    else if (diameter < 17)
                    {
                        servicePrice = servicePrice * 135 / 100;
                        servicePrice = Math.Round(servicePrice / 100) * 100;
                    }
                    else if (diameter < 19)
                    {
                        servicePrice = servicePrice * 175 / 100;
                        servicePrice = Math.Round(servicePrice / 100) * 100;
                    }
                    else
                    {
                        servicePrice = servicePrice * 2;
                        servicePrice = Math.Round(servicePrice / 100) * 100;
                    }
                    totalPrice += servicePrice;
                    order.Element("totalPrice").Value = totalPrice.ToString();
                    // Mentes
                    doc.Save("Data/order.xml");
                    MessageBox.Show("Szolgáltatás sikeresen hozzáadva a rendeléshez!", "Sikeres hozzáadás", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    AdministratorHomepage administratorHomepage = new AdministratorHomepage();
                    administratorHomepage.Show();
                }
            }
        }
    }
}