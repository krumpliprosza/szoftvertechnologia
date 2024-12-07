using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace _1_oef27r_tqfaiu_wtl2bi
{
    public partial class OrderAdd : Form
    {
        public OrderAdd()
        {
            InitializeComponent();
            EndDateInput.MinDate = DateTime.Today;
            EndDateInput.MaxDate = DateTime.Today.AddDays(365);
        }

        private void OrderMake_Click(object sender, EventArgs e)
        {
            string customerName = NameInput.Text;
            string customerTelNo = TelNoInput.Text;
            string customerLicenseNumber = LicNoInput.Text;
            DateTime orderDate = EndDateInput.Value;
            // Input átvizsgálása
            if (string.IsNullOrEmpty(customerName) || string.IsNullOrEmpty(customerTelNo) || string.IsNullOrEmpty(customerLicenseNumber))
            {
                MessageBox.Show("Hiányzó ügyféladatok!", "Hibás adatbevitel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // order.xml megnyitasa, id generalasa
            XDocument doc = XDocument.Load("Data/order.xml");
            int newOrderId = (doc.Descendants("order")
                .Select(o => (int?)o.Element("id"))
                .Max() ?? 0) + 1;
            // Rendeles letrehozasa
            XElement newOrder = new XElement("order",
                new XElement("id", newOrderId),
                new XElement("customer",
                    new XElement("name", customerName),
                    new XElement("telNo", customerTelNo),
                    new XElement("licenseNumber", customerLicenseNumber)
                ),
                new XElement("chosenTyres"),
                new XElement("chosenServices"),
                new XElement("endDate", orderDate),
                new XElement("totalPrice", 0),
                new XElement("status", "Felvételre vár")
            );
            // Hozzaadas
            doc.Element("orders").Add(newOrder);
            // Mentes
            doc.Save("Data/order.xml");
            MessageBox.Show("Új rendelés sikeresen létrehozva!", "Rendelés hozzáadva", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Debug.WriteLine(doc.ToString());
            // Input torlese
            NameInput.Clear();
            TelNoInput.Clear();
            LicNoInput.Clear();
        }
    }
}
