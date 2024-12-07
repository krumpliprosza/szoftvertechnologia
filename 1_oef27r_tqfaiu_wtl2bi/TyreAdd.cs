using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace _1_oef27r_tqfaiu_wtl2bi
{
    public partial class TyreAdd : Form
    {
        public TyreAdd()
        {
            InitializeComponent();
            // Evszak input valaszthato ertekeinek betoltese, eloszor az elso ertek legyen kivalasztva, es csak az adott ertekek legyenek valaszthatoak, irni ne lehessen (tobbi inputnal ugyanezek tortennek)
            #region betoltes
            SeasonInput.Items.Add("");
            SeasonInput.Items.Add("Nyári");
            SeasonInput.Items.Add("Téli");
            SeasonInput.Items.Add("4 évszakos");
            #endregion
            SeasonInput.SelectedIndex = 0;
            SeasonInput.DropDownStyle = ComboBoxStyle.DropDownList;
            // Uzemanyag-takarekossagi osztaly input valaszthato ertekeinek betoltese
            #region betoltes
            FuelEfficiencyInput.Items.Add("");
            FuelEfficiencyInput.Items.Add("A");
            FuelEfficiencyInput.Items.Add("B");
            FuelEfficiencyInput.Items.Add("C");
            FuelEfficiencyInput.Items.Add("D");
            FuelEfficiencyInput.Items.Add("E");
            FuelEfficiencyInput.Items.Add("F");
            FuelEfficiencyInput.Items.Add("G");
            #endregion
            FuelEfficiencyInput.SelectedIndex = 0;
            FuelEfficiencyInput.DropDownStyle = ComboBoxStyle.DropDownList;
            // Fekut input valaszthato ertekeinek betoltese
            #region betoltes
            StoppingDistanceInput.Items.Add("");
            StoppingDistanceInput.Items.Add("A");
            StoppingDistanceInput.Items.Add("B");
            StoppingDistanceInput.Items.Add("C");
            StoppingDistanceInput.Items.Add("D");
            StoppingDistanceInput.Items.Add("E");
            StoppingDistanceInput.Items.Add("F");
            #endregion
            StoppingDistanceInput.SelectedIndex = 0;
            StoppingDistanceInput.DropDownStyle = ComboBoxStyle.DropDownList;
            // Defekttures input valaszthato ertekeinek betoltese
            #region betoltes
            PunctureResistanceInput.Items.Add("");
            PunctureResistanceInput.Items.Add("Igen");
            PunctureResistanceInput.Items.Add("Nem");
            #endregion
            PunctureResistanceInput.SelectedIndex = 0;
            PunctureResistanceInput.DropDownStyle = ComboBoxStyle.DropDownList;
            // Sebessegindex input valaszthato ertekeinek betoltese
            #region betoltes
            SpeedIndexInput.Items.Add("");
            SpeedIndexInput.Items.Add("A1");
            SpeedIndexInput.Items.Add("A2");
            SpeedIndexInput.Items.Add("A3");
            SpeedIndexInput.Items.Add("A4");
            SpeedIndexInput.Items.Add("A5");
            SpeedIndexInput.Items.Add("A6");
            SpeedIndexInput.Items.Add("A7");
            SpeedIndexInput.Items.Add("A8");
            SpeedIndexInput.Items.Add("B");
            SpeedIndexInput.Items.Add("C");
            SpeedIndexInput.Items.Add("D");
            SpeedIndexInput.Items.Add("E");
            SpeedIndexInput.Items.Add("F");
            SpeedIndexInput.Items.Add("G");
            SpeedIndexInput.Items.Add("J");
            SpeedIndexInput.Items.Add("K");
            SpeedIndexInput.Items.Add("L");
            SpeedIndexInput.Items.Add("M");
            SpeedIndexInput.Items.Add("N");
            SpeedIndexInput.Items.Add("P");
            SpeedIndexInput.Items.Add("Q");
            SpeedIndexInput.Items.Add("R");
            SpeedIndexInput.Items.Add("S");
            SpeedIndexInput.Items.Add("T");
            SpeedIndexInput.Items.Add("U");
            SpeedIndexInput.Items.Add("H");
            SpeedIndexInput.Items.Add("V");
            SpeedIndexInput.Items.Add("W");
            SpeedIndexInput.Items.Add("Y");
            #endregion
            SpeedIndexInput.SelectedIndex = 0;
            SpeedIndexInput.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            // Adatmasolas
            string brand = BrandInput.Text;
            string name = NameInput.Text;
            string season = SeasonInput.SelectedItem?.ToString();
            string profileWidth = ProfileWidthInput.Value.ToString();
            string profileRatio = ProfileRatioInput.Value.ToString();
            string diameter = DiameterInput.Value.ToString();
            string fuelEfficiency = FuelEfficiencyInput.SelectedItem?.ToString();
            string stoppingDistance = StoppingDistanceInput.SelectedItem?.ToString();
            string punctureResistance = PunctureResistanceInput.SelectedItem?.ToString();
            string speedIndex = SpeedIndexInput.SelectedItem?.ToString();
            string quantity = QuantityInput.Value.ToString();
            string price = PriceInput.Value.ToString();
            string rollingNoise = RollingNoiseInput.Value.ToString();
            string location = LocationInput.Text;
            string loadIndex = LoadIndexInput.Value.ToString();
            // Ellenorzes nullertekekre
            if (
                string.IsNullOrWhiteSpace(brand) ||
                string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(season) ||
                string.IsNullOrWhiteSpace(profileWidth) ||
                string.IsNullOrWhiteSpace(profileRatio) ||
                string.IsNullOrWhiteSpace(diameter) ||
                string.IsNullOrWhiteSpace(fuelEfficiency) ||
                string.IsNullOrWhiteSpace(stoppingDistance) ||
                string.IsNullOrWhiteSpace(punctureResistance) ||
                string.IsNullOrWhiteSpace(speedIndex) ||
                string.IsNullOrWhiteSpace(quantity) ||
                string.IsNullOrWhiteSpace(price) ||
                string.IsNullOrWhiteSpace(rollingNoise) ||
                string.IsNullOrWhiteSpace(location) ||
                string.IsNullOrWhiteSpace(loadIndex)
            )
            {
                MessageBox.Show("Az adatok hiányosan lettek megadva!", "Hozzáadási hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // tyre.xml megnyitasa
            XDocument doc = XDocument.Load("Data/tyre.xml");
            // Az uj abroncs azonositojanak meghatarozasa (maxId + 1)
            int id = doc.Descendants("tyre")
                           .Select(t => int.Parse(t.Element("id")?.Value))
                           .Max() + 1;
            
            // Az uj abroncs hozzadasa
            doc.Root?.Add(new XElement("tyre",
                new XElement("id", id),
                new XElement("brand", brand),
                new XElement("name", name),
                new XElement("season", season),
                new XElement("profileWidth", profileWidth),
                new XElement("profileRatio", profileRatio),
                new XElement("diameter", diameter),
                new XElement("fuelEfficiency", fuelEfficiency),
                new XElement("stoppingDistance", stoppingDistance),
                new XElement("punctureResistance", punctureResistance),
                new XElement("speedIndex", speedIndex),
                new XElement("location", location),
                new XElement("rollingNoise", rollingNoise),
                new XElement("loadIndex", loadIndex),
                new XElement("quantity", quantity),
                new XElement("price", price)
            ));
            // Mentes
            doc.Save("Data/tyre.xml");
            MessageBox.Show("Abroncs sikeresen hozzáadva a készlethez!", "Sikeres hozzáadás", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearFields();
        }
        public void ClearFields()
        {
            BrandInput.Text = string.Empty;
            NameInput.Text = string.Empty;
            SeasonInput.SelectedIndex = -1;
            ProfileWidthInput.Value = 0;
            ProfileRatioInput.Value = 0;
            DiameterInput.Value = 0;
            FuelEfficiencyInput.SelectedIndex = -1;
            StoppingDistanceInput.SelectedIndex = -1;
            PunctureResistanceInput.SelectedIndex = -1;
            RollingNoiseInput.Value = 0;
            LoadIndexInput.Value = 0;
            SpeedIndexInput.SelectedIndex = -1;
            LocationInput.Text = string.Empty;
            QuantityInput.Value = 0;
            PriceInput.Value = 0;
        }
    }
}

