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
    public partial class TyreToOrder : Form
    {
        private Search _searchForm;
        public TyreToOrder(DataGridViewRow selectedRow, Search searchForm)
        {
            InitializeComponent();
            // Az ezelotti keresesi adatok beolvasasa (uj rendeles felvetele eseten szukseg lesz ra)
            _searchForm = searchForm;
            // A kapott sorbol a megfelelo szovegdobozok feltoltese
            IdValue.Text = selectedRow.Cells["ColId"].Value?.ToString();
            BrandValue.Text = selectedRow.Cells["ColBrand"].Value?.ToString();
            NameValue.Text = selectedRow.Cells["ColName"].Value?.ToString();
            SeasonValue.Text = selectedRow.Cells["ColSeason"].Value?.ToString();
            ProfileWidthValue.Text = (selectedRow.Cells["ColProfileWidth"].Value).ToString();
            ProfileRatioValue.Text = (selectedRow.Cells["ColProfileRatio"].Value).ToString();
            DiameterValue.Text = (selectedRow.Cells["ColDiameter"].Value).ToString();
            FuelEfficiencyValue.Text = selectedRow.Cells["ColFuelEfficiency"].Value?.ToString();
            StoppingDistanceValue.Text = selectedRow.Cells["ColStoppingDistance"].Value?.ToString();
            PunctureResistanceValue.Text = selectedRow.Cells["ColPunctureResistance"].Value?.ToString();
            RollingNoiseValue.Text = (selectedRow.Cells["ColRollingNoise"].Value).ToString();
            LoadIndexValue.Text = (selectedRow.Cells["ColLoadIndex"].Value).ToString();
            LocationValue.Text = selectedRow.Cells["ColLocation"].Value?.ToString();
            SpeedIndexValue.Text = selectedRow.Cells["ColSpeedIndex"].Value?.ToString();
            QuantityValue.Text = (selectedRow.Cells["ColQuantity"].Value).ToString();
            PriceValue.Text = (selectedRow.Cells["ColPrice"].Value).ToString();
            LoadOrders();
        }
        private void LoadOrders()
        {
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
                int orderId = int.Parse(selectedRow.Cells["ColId"].Value?.ToString());
                string tyreBrand = BrandValue.Text;
                string tyreName = NameValue.Text;
                int tyrePrice = int.Parse(PriceValue.Text);
                int tyreQuantity;
                if (string.IsNullOrEmpty(OrderQuantityInput.Text) || !int.TryParse(OrderQuantityInput.Text, out tyreQuantity) || tyreQuantity <= 0)
                {
                    MessageBox.Show("Hiányos bemeneti adat (Mennyiség)!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                tyreQuantity = int.Parse(OrderQuantityInput.Text);
                // order.xml betoltese
                XDocument doc = XDocument.Load("Data/order.xml");
                var order = doc.Descendants("order")
                    .FirstOrDefault(o => (int)o.Element("id") == orderId);
                if (order != null)
                {
                    // order.xml-ben chosenTyre hozzaadasa chosenTyres-hoz
                    XElement chosenTyreElement = new XElement("chosenTyre",
                        new XElement("brand", tyreBrand),
                        new XElement("name", tyreName),
                        new XElement("quantity", tyreQuantity)
                    );

                    order.Element("chosenTyres")?.Add(chosenTyreElement);

                    // Kerekbol jovo teljes ar hozzaadasa
                    decimal totalPrice = (decimal)order.Element("totalPrice");
                    totalPrice += tyrePrice * tyreQuantity;
                    order.Element("totalPrice").Value = totalPrice.ToString();

                    // Mentes
                    doc.Save("Data/order.xml");
                    MessageBox.Show("Termék sikeresen hozzáadva a rendeléshez!", "Sikeres hozzáadás", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    AdministratorHomepage administratorHomepage = new AdministratorHomepage();
                    administratorHomepage.Show();
                }
            }
        }
    }
}
