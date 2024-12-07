using _1_oef27r_tqfaiu_wtl2bi.Classes;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            // Bemeneti adatok formbol
            string username = UsernameTextBox.Text;
            string password = PasswordTextBox.Text;
            // Nullertekek kezelese
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password)) { MessageBox.Show("Hiányos felhasználónév/jelszó mező!", "Bejelentkezési hiba", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            // worker.xml megnyitasa
            XDocument doc = XDocument.Load("Data/worker.xml");
            // Kesobbi ellenorzeshez szukseges adatok
            int role = -1;
            // Az osszes dolgozoi adat lekerese es osszevetese a bemenettel
            var worker = doc.Descendants("worker")
                      .FirstOrDefault(w => (string)w.Element("username") == username &&
                                           (string)w.Element("password") == password);
            // Szerep kiolvasasa
            if (worker != null) { role = int.Parse((string)worker.Element("role")); UserSession.CurrentUserRole = role; }
            // Szerep vizsgalata/hibakezeles
            switch (role)
            {
                case 0: // Cegvezeto
                    CeoHomepage hp = new CeoHomepage();
                    hp.Show();
                    this.Hide();
                    break;
                case 1: // Ugyintezo
                    AdministratorHomepage AdministratorPage = new AdministratorHomepage();
                    AdministratorPage.Show();
                    this.Hide();
                    break;
                case 2: // Raktaros
                    StorageWorkerHomepage StorageWorkerPage = new StorageWorkerHomepage();
                    StorageWorkerPage.Show();
                    this.Hide();
                    break;
                case 3: // Szerelo

                    break;
                default: // Hibas adatok (nem kerul atirasra a role, igy -1 ertekkel rendelkezik)
                    MessageBox.Show("Hibás felhasználónév/jelszó!", "Bejelentkezési hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            };
        }
    }
}
