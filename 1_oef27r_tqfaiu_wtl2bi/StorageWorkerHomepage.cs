using _1_oef27r_tqfaiu_wtl2bi.Classes;
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
    public partial class StorageWorkerHomepage : Form
    {
        public StorageWorkerHomepage()
        {
            InitializeComponent();
            PopulateItemsToCollectDataGrid();
        }

        private void PopulateItemsToCollectDataGrid()
        {
            XDocument orderDoc = XDocument.Load("Data/order.xml");
            var orders = orderDoc.Descendants("order")
                                 .Where(o => (string)o.Element("status") == "Előkészítés alatt")
                                 .Select(o => new
                                 {
                                     OrderId = (int)o.Element("id"),
                                     Tyres = o.Element("chosenTyres")?.Elements("chosenTyre")
                                 })
                                 .Where(o => o.Tyres != null)
                                 .ToList();
            XDocument tyreDoc = XDocument.Load("Data/tyre.xml");
            ItemsToCollectDataGrid.Rows.Clear();
            foreach (var order in orders)
            {
                foreach (var tyre in order.Tyres)
                {
                    string orderTyreBrand = (string)tyre.Element("brand");
                    string orderTyreName = (string)tyre.Element("name");
                    int orderQuantity = (int)tyre.Element("quantity");
                    var matchedTyre = tyreDoc.Descendants("tyre")
                                             .FirstOrDefault(t => (string)t.Element("brand") == orderTyreBrand &&
                                                                  (string)t.Element("name") == orderTyreName);

                    if (matchedTyre != null)
                    {
                        string location = (string)matchedTyre.Element("location");
                        ItemsToCollectDataGrid.Rows.Add(order.OrderId, orderTyreBrand, orderTyreName, location, orderQuantity);
                    }
                }
            }
        }

        private void LowStock_Click(object sender, EventArgs e)
        {
            // tyre.xml megnyitasa
            XDocument doc = XDocument.Load("Data/tyre.xml");
            // Alacsony darabszamu termekek keresese (quantity < 4)
            var lowStockTyres = doc.Descendants("tyre")
                                      .Where(t => int.Parse(t.Element("quantity").Value) < 4)
                                      .Select(t => new Tyre(
                                          int.Parse(t.Element("id").Value),
                                          t.Element("brand").Value,
                                          t.Element("name").Value,
                                          int.Parse(t.Element("quantity").Value),
                                          t.Element("location").Value
                                      ))
                                      .ToList();
            if (lowStockTyres.Any())
            {
                // Ha talalt termeket, akkor vele/veluk meghivja a LowStock lapot (mukodeset lasd: LowStock.cs)
                LowStock lowStock = new LowStock(lowStockTyres);
                lowStock.ShowDialog();
            }
            else
            {
                // Ha pedig nem talalt ilyen termeket, akkor meg jelez a raktarosnak
                MessageBox.Show("Nem található alacsony darabszámú termék.", "Eredménytelen keresés", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void storageQuery_Click(object sender, EventArgs e)
        {
            // Kereses oldal megnyitasa
            Search searchPage = new Search();
            searchPage.Show();
        }

        private void TyreAdd_Click(object sender, EventArgs e)
        {
            // Hozzaado oldal megnyitasa
            TyreAdd TyreAddPage = new TyreAdd();
            TyreAddPage.Show();
        }

        private void ItemsToCollectDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (ItemsToCollectDataGrid.SelectedRows.Count == 1)
            {
                var selectedRow = ItemsToCollectDataGrid.SelectedRows[0];
                int orderId = int.Parse(selectedRow.Cells["ColId"].Value?.ToString());
                XDocument orderDoc = XDocument.Load("Data/order.xml");
                var order = orderDoc.Descendants("order")
                                    .FirstOrDefault(o => (int)o.Element("id") == orderId);

                if (order != null)
                {
                    bool hasServices = order.Element("chosenServices")?.Elements("chosenService").Any() ?? false;
                    if (hasServices)
                    {
                        order.Element("status")?.SetValue("Szerelés alatt");
                    }
                    else
                    {
                        order.Element("status")?.SetValue("Kész");
                    }
                    orderDoc.Save("Data/order.xml");
                    MessageBox.Show("Rendelés státusza frissítve!", "Státusz frissítve", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PopulateItemsToCollectDataGrid();
                }
            }
        }
    }
}
