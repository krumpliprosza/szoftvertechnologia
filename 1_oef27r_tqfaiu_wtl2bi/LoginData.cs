using System;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace _1_oef27r_tqfaiu_wtl2bi
{
    public partial class EditWorkerData : Form
    {
        public EditWorkerData()
        {
            InitializeComponent();
        }

        private string currentUsername; // A dolgozó aktuális felhasználóneve

        // A dolgozó adatainak betöltése
        public EditWorkerData(string username)
        {
            InitializeComponent();
            currentUsername = username;
            LoadWorkerData(username);
        }

        // A dolgozó adatainak betöltése
        private void LoadWorkerData(string username)
        {
            XDocument doc = XDocument.Load("Data/worker.xml");
            var worker = doc.Descendants("worker")
                            .FirstOrDefault(w => (string)w.Element("username") == username);

            if (worker != null)
            {
                // Az adatokat betöltjük a form mezőibe
                UsernameTextBox.Text = (string)worker.Element("username");
                PasswordTextBox.Text = (string)worker.Element("password");
                RoleComboBox.SelectedItem = (string)worker.Element("role"); // pl. 0: Cégvezető, 1: Ügyintéző, stb.
            }
            else
            {
                MessageBox.Show("A kiválasztott dolgozó nem található!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // A módosítás mentése
        private void SaveButton_Click(object sender, EventArgs e)
        {
            string newUsername = UsernameTextBox.Text;
            string newPassword = PasswordTextBox.Text;
            int role = int.Parse(RoleComboBox.SelectedItem.ToString());

            // Ellenőrizzük, hogy a felhasználónév már létezik-e
            if (IsUsernameTaken(newUsername))
            {
                MessageBox.Show("Ez a felhasználónév már foglalt!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Ellenőrizzük, hogy a jelszó megfelel-e a kritériumoknak
            if (!IsPasswordValid(newPassword))
            {
                MessageBox.Show("A megadott jelszó nem megfelelő!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Módosítjuk a dolgozó adatait
            XDocument doc = XDocument.Load("Data/worker.xml");
            var worker = doc.Descendants("worker")
                            .FirstOrDefault(w => (string)w.Element("username") == currentUsername);

            if (worker != null)
            {
                worker.SetElementValue("username", newUsername);
                worker.SetElementValue("password", newPassword);
                worker.SetElementValue("role", role);

                doc.Save("Data/worker.xml");

                MessageBox.Show("A dolgozó adatai sikeresen módosítva!", "Sikeres módosítás", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Visszatérés a bejelentkezési adatok képernyőre
                this.Close();
            }
        }

        // Ellenőrizzük, hogy a felhasználónév már foglalt-e
        private bool IsUsernameTaken(string username)
        {
            XDocument doc = XDocument.Load("Data/worker.xml");
            return doc.Descendants("worker")
                      .Any(w => (string)w.Element("username") == username);
        }

        // Jelszó érvényességi ellenőrzés
        private bool IsPasswordValid(string password)
        {
            // Példa validáció: a jelszó legalább 6 karakter hosszú
            return password.Length >= 6;
        }
    }
}
