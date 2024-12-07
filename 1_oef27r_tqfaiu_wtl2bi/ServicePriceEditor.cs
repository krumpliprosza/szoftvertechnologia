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
    public partial class ServicePriceEditor : Form
    {
        public ServicePriceEditor()
        {
            InitializeComponent();
        }
        public ServicePriceEditor(DataGridViewRow selectedRow)
        {
            InitializeComponent();
            nameTB.Text = selectedRow.Cells["name"].Value?.ToString();
            basepriceTB.Text = selectedRow.Cells["baseprice"].Value?.ToString();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string name=nameTB.Text;
            string baseprice=basepriceTB.Text;
            XDocument doc = XDocument.Load("Data/service.xml");
            var serviceToEdit = doc.Descendants("service")
                .FirstOrDefault(t => t.Element("name")?.Value == name);
            if(serviceToEdit != null)
            {
                serviceToEdit.Element("name")?.SetValue(name);
                serviceToEdit.Element("basePrice")?.SetValue(baseprice);
                doc.Save("Data/service.xml");
                MessageBox.Show("Minden változtatás sikeresen elmentve!", "Sikeres módosítás", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("A módosítandó elem nem található!", "Módosítási hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
