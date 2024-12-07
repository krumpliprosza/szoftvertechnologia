using _1_oef27r_tqfaiu_wtl2bi.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace _1_oef27r_tqfaiu_wtl2bi
{
    public partial class CeoHomepage : Form
    {
        public CeoHomepage()
        {
            InitializeComponent();
        }


        private void bejelentkezésiAdatokSzerkesztéseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XDocument doc = XDocument.Load("Data/worker.xml");
            var workers = doc.Descendants("worker")
                .Where(t => int.Parse(t.Element("role").Value) < 4)
                .Select(t => new Worker(
                    t.Element("username").Value,
                    t.Element("password").Value,
                    int.Parse(t.Element("role").Value)
                    )).ToList();
            if (workers.Count > 0)
            {
                LoginEdit lge = new LoginEdit(workers);
                lge.ShowDialog();
            }
        }

        private void termékekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XDocument doc = XDocument.Load("Data/tyre.xml");
            var tprice = doc.Descendants("tyre")
                .Where(t => int.Parse(t.Element("price").Value) != 0)
                .Select(t => new Tyre(
                    int.Parse(t.Element("id").Value),
                    t.Element("brand").Value,
                    t.Element("name").Value,
                    int.Parse(t.Element("price").Value)
                    )).ToList();
            if (tprice.Count > 0)
            {
                TyrePrices tyrePrices = new TyrePrices(tprice);
                tyrePrices.Show();
            }
        }

        private void szolgáltatásokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XDocument doc = XDocument.Load("Data/service.xml");
            var sprice = doc.Descendants("service")
                .Where(t => int.Parse(t.Element("basePrice").Value) != 0)
                .Select(t => new Service(
                    t.Element("name").Value,
                    int.Parse(t.Element("basePrice").Value)
                    )).ToList();
            if (sprice.Count > 0)
            {
                ServicePrices servicePrices = new ServicePrices(sprice);
                servicePrices.Show();
            }
        }
    }
}
