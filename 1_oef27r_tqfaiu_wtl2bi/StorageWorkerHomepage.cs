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
    }
}
