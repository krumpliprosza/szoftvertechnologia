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
            if (worker != null) { 
            UsernameTextBox.Text = (string)worker.Element("username");
            PasswordTextBox.Text = (string)worker.Element("password");
            role = int.Parse((string)worker.Element("role")); 
            }
             else
            {
                MessageBox.Show("A kiválasztott dolgozó nem található!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
             if (IsUsernameTaken(newUsername))
            {
                MessageBox.Show("Ez a felhasználónév már foglalt!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Ellenőrizzük, hogy a jelszó megfelel-e a kritériumoknak (pl. minimális hossz, speciális karakterek stb.)
            if (!IsPasswordValid(newPassword))
            {
                MessageBox.Show("A megadott jelszó nem megfelelő!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

                
            // Szerep vizsgalata/hibakezeles
            switch (role)
            {
                case 0: // Cegvezeto

                    break;
                case 1: // Ugyintezo

                    break;
                case 2: // Raktaros
                    StorageWorkerHomepage homepage = new StorageWorkerHomepage();
                    homepage.Show();
                    this.Hide();
                    break;
                case 3: // Szerelo

                    break;
                default: // Hibas adatok (nem kerul atirasra a role, igy -1 ertekkel rendelkezik)
                
                   loginAttempts++; // Növeljük a próbálkozások számát
                if (loginAttempts >= 3) // Ha három próbálkozás után sem sikerült
                {
                    MessageBox.Show("Három hibás bejelentkezési kísérlet! A program leáll.", "Bejelentkezési hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit(); // Kilépés a programból
                    break;
                }

                // Ha még van próbálkozás, akkor értesítjük a felhasználót
                MessageBox.Show($"Hibás felhasználónév/jelszó! ({3 - loginAttempts} próbálkozás maradt)", "Bejelentkezési hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            };
        }
    }
}
