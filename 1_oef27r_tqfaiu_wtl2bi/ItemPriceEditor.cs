using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace _1_oef27r_tqfaiu_wtl2bi
{
    public partial class ItemPriceEditor : Form
    {
        public ItemPriceEditor()
        {
            InitializeComponent();
        }
        public ItemPriceEditor(DataGridViewRow selectedRow)
        {
            InitializeComponent();
            idTB.Text = selectedRow.Cells["colID"].Value?.ToString();
            brandTB.Text = selectedRow.Cells["colBrand"].Value?.ToString();
            nameTB.Text = selectedRow.Cells["colName"].Value?.ToString();
            priceTB.Text = selectedRow.Cells["colPrice"].Value?.ToString();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string id=idTB.Text;
            string name=nameTB.Text;
            string brand=brandTB.Text;
            string price=priceTB.Text;
            XDocument doc = XDocument.Load("Data/tyre.xml");
            var tyreToEdit = doc.Descendants("tyre")
                .FirstOrDefault(t=>t.Element("id")?.Value==id);
            if(tyreToEdit != null)
            {
                tyreToEdit.Element("id")?.SetValue(id);
                tyreToEdit.Element("name")?.SetValue(name);
                tyreToEdit.Element("brand")?.SetValue(brand);
                tyreToEdit.Element("price")?.SetValue(price);
                doc.Save("Data/tyre.xml");
                MessageBox.Show("Minden változtatás sikeresen elmentve!", "Sikeres módosítás", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("A módosítandó abroncs nem található!", "Módosítási hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
