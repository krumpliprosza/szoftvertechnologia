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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _1_oef27r_tqfaiu_wtl2bi
{
    public partial class EditPage : Form
    {
        public EditPage()
        {
            InitializeComponent();
        }

        public EditPage(DataGridViewRow selectedRow)
        {
            InitializeComponent();
            usernameBox.Text = selectedRow.Cells["username"].Value?.ToString();
            passwordBox.Text = selectedRow.Cells["password"].Value?.ToString();
            roleBox.Text = selectedRow.Cells["role"].Value?.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username=usernameBox.Text;
            string password=passwordBox.Text;
            string role=roleBox.Text;
            XDocument doc=XDocument.Load("Data/worker.xml");
            var workerToEdit = doc.Descendants("worker")
                .FirstOrDefault(t=>t.Element("username")?.Value==username);
            if(workerToEdit != null)
            {
                workerToEdit.Element("username")?.SetValue(username);
                workerToEdit.Element("password")?.SetValue(password);
                workerToEdit.Element("role")?.SetValue(role);
                doc.Save("Data/worker.xml");
                MessageBox.Show("Minden változtatás sikeresen elmentve!", "Sikeres módosítás", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("A módosítandó abroncs nem található!", "Módosítási hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
