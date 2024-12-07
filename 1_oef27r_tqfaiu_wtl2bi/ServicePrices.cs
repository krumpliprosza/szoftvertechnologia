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

namespace _1_oef27r_tqfaiu_wtl2bi
{
    public partial class ServicePrices : Form
    {
        public ServicePrices()
        {
            InitializeComponent();
        }
        public ServicePrices(List<Service> sprice)
        {
            InitializeComponent();
            foreach (var service in sprice)
            {
                    dataGridView1.Rows.Add(service.GetName(),service.GetPrice());
            }
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                var selectedRow= dataGridView1.SelectedRows[0];
                ServicePriceEditor servicePriceEditor = new ServicePriceEditor(selectedRow);
                servicePriceEditor.Show();
            }
        }
    }
}
