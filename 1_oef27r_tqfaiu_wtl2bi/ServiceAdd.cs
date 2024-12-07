using System;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace _1_oef27r_tqfaiu_wtl2bi
{
    public partial class ServiceAdd : Form
    {
        public ServiceAdd()
        {
            InitializeComponent();
            LoadServicesIntoDataGrid();
        }

        private void LoadServicesIntoDataGrid()
        {

            // service.xml betoltese
            XDocument doc = XDocument.Load("Data/service.xml");

            // Minden szolgaltatas kivalasztasa
            var services = doc.Descendants("service")
                              .Select(s => new
                              {
                                  Name = (string)s.Element("name"),
                                  BasePrice = (decimal)s.Element("basePrice")
                              });
            // ServiceDataGrid betoltese
            foreach (var service in services)
            {
                ServiceDataGrid.Rows.Add(service.Name, service.BasePrice);
            }
        }

        private void ServiceDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (ServiceDataGrid.SelectedRows.Count == 1)
            {
                var selectedRow = ServiceDataGrid.SelectedRows[0];
                ServiceToOrder servicetoorder = new ServiceToOrder(selectedRow);
                servicetoorder.Show();
            }
        }
    }
}