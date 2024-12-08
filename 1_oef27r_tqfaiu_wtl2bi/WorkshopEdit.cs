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
    public partial class WorkshopEdit : Form
    {
        public WorkshopEdit()
        {
            InitializeComponent();
        }

        public WorkshopEdit(DataGridViewRow selectedRow)
        {
            InitializeComponent();
            licenseTB.Text = selectedRow.Cells["licenseNo"].Value?.ToString();
            brandTB.Text = selectedRow.Cells["brand"].Value?.ToString();
            tNameTB.Text = selectedRow.Cells["tyreName"].Value?.ToString();
            tquantityTB.Text = selectedRow.Cells["tquantity"].Value?.ToString();
            sNameTB.Text = selectedRow.Cells["sName"].Value?.ToString();
            squantityTB.Text = selectedRow.Cells["squantity"].Value?.ToString();
            endDateBox.Text = selectedRow.Cells["endDate"].Value?.ToString();
            statusBox.Text = selectedRow.Cells["status"].Value?.ToString();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string endDate = endDateBox.Text;
            string status = statusBox.Text;
            XDocument doc = XDocument.Load("Data/order.xml");
            var ordertoEdit = doc.Descendants("order")
                .FirstOrDefault(t=>t.Element("status").Value!="");
            if (ordertoEdit != null)
            {
                ordertoEdit.Element("endDate")?.SetValue(endDate);
                ordertoEdit.Element("status")?.SetValue(status);
                doc.Save("Data/order.xml");
                MessageBox.Show("Minden változtatás sikeresen elmentve!", "Sikeres módosítás", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("A módosítandó elem nem található!", "Módosítási hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
