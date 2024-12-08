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
    public partial class WorkshopHomePage : Form
    {
        public WorkshopHomePage()
        {
            InitializeComponent();

            this.KeyPreview = true;

            XDocument doc = XDocument.Load("Data/order.xml");
            var or = doc.Descendants("order")
                .Where(t => t.Element("status").Value != "Kész")
                .Select(t => new Order(
                    t.Element("customer").Element("licenseNumber").Value,
                    t.Element("chosenTyres").Element("chosenTyre").Element("brand").Value,
                    t.Element("chosenTyres").Element("chosenTyre").Element("name").Value,
                    t.Element("chosenTyres").Element("chosenTyre").Element("quantity").Value,
                    t.Element("chosenServices").Element("chosenService").Element("name").Value,
                    t.Element("chosenServices").Element("chosenService").Element("quantity").Value,
                    t.Element("endDate").Value,
                    t.Element("status").Value
                    )).ToList();

            foreach (var order in or)
            {
                dataGridView1.Rows.Add(
                    order.GetLicenseNo(),
                    order.getBrandName(),
                    order.getTyreName(),
                    order.getTquantity(),
                    order.getSname(),
                    order.getSquantity(),
                    order.getEnddate(),
                    order.getStatus()
                    );
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                WorkshopEdit workshopEdit = new WorkshopEdit(selectedRow);
                workshopEdit.Show();
            }
        }


        private void WorkshopHomePage_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void WorkshopHomePage_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                dataGridView1.Refresh();
            }
        }
    }
}
