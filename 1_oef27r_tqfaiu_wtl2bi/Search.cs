﻿using System;
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
    public partial class Search : Form
    {
        public Search()
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

        private void QueryButton_Click(object sender, EventArgs e)
        {
            #region adatbeolvasas
            string brand = BrandInput.Text.Trim();
            string name = NameInput.Text.Trim();
            string season = SeasonInput.SelectedItem?.ToString();
            string fuelEfficiency = FuelEfficiencyInput.SelectedItem?.ToString();
            string stoppingDistance = StoppingDistanceInput.SelectedItem?.ToString();
            string punctureResistance = PunctureResistanceInput.SelectedItem?.ToString();
            string speedIndex = SpeedIndexInput.SelectedItem?.ToString();
            int profileWidth = (int)ProfileWidthInput.Value;
            int profileRatio = (int)ProfileRatioInput.Value;
            int diameter = (int)DiameterInput.Value;
            int rollingNoise = (int)RollingNoiseInput.Value;
            int loadIndex = (int)LoadIndexInput.Value;
            #endregion
            // Az abroncsok kozott kereso fuggveny meghivasa
            SearchTyres(brand, name, season, fuelEfficiency, stoppingDistance, punctureResistance,
                        speedIndex, profileWidth, profileRatio, diameter, rollingNoise, loadIndex);
        }

        private void SearchTyres(string brand, string name, string season, string fuelEfficiency, string stoppingDistance, string punctureResistance, string speedIndex, int profileWidth, int profileRatio, int diameter, int rollingNoise, int loadIndex)
        {
            // tyre.xml megnyitasa
            XDocument doc = XDocument.Load("Data/tyre.xml");
            Dictionary<string, int> speedIndexes = new Dictionary<string, int> // A sebessegindexeknel valo szureshez kell (lexikografikus osszevetes nem mukodik, mas erteket kell valasztani a rendezeshez (ezert kell egy map: az ertekei alapjan vizsgal)
            {
                { "", 0 },
                { "A1", 1 },
                { "A2", 2 },
                { "A3", 3 },
                { "A4", 4 },
                { "A5", 5 },
                { "A6", 6 },
                { "A7", 7 },
                { "A8", 8 },
                { "B", 9 },
                { "C", 10 },
                { "D", 11 },
                { "E", 12 },
                { "F", 13 },
                { "G", 14 },
                { "J", 15 },
                { "K", 16 },
                { "L", 17 },
                { "M", 18 },
                { "N", 19 },
                { "H", 20 },
                { "P", 21 },
                { "Q", 22 },
                { "R", 23 },
                { "S", 24 },
                { "T", 25 },
                { "U", 26 },
                { "V", 27 },
                { "W", 28 },
                { "Y", 29 }
            };
            // Szures
            var filteredTyres = doc.Descendants("tyre").Where(t =>
            /*
                Szuresi logika:
                1. csak az az abroncs megy at, ami igaz ertekkel ter vissza minden szures utan
                2. szuresek felepitese:
                    - bal oldalt: ha nincs beallitva szuresi feltetel, akkor egybol igaz erteket ad
                    - jobb oldalt: a tenyleges szuresi feltetel (akkor szamit, ha meg lett adva szuresi feltetel)
            */
                (string.IsNullOrEmpty(brand) || t.Element("brand")?.Value.Contains(brand, StringComparison.OrdinalIgnoreCase) == true) &&
                (string.IsNullOrEmpty(name) || t.Element("name")?.Value.Contains(name, StringComparison.OrdinalIgnoreCase) == true) &&
                (string.IsNullOrEmpty(season) || t.Element("season")?.Value == season) &&
                (string.IsNullOrEmpty(fuelEfficiency) || string.Compare(t.Element("fuelEfficiency")?.Value, fuelEfficiency, StringComparison.Ordinal) <= 0) &&
                (string.IsNullOrEmpty(stoppingDistance) || string.Compare(t.Element("stoppingDistance")?.Value, stoppingDistance, StringComparison.Ordinal) <= 0) &&
                (string.IsNullOrEmpty(punctureResistance) || string.Compare(t.Element("punctureResistance")?.Value, punctureResistance, StringComparison.Ordinal) <= 0) &&
                (string.IsNullOrEmpty(speedIndex) || (speedIndexes.TryGetValue(t.Element("speedIndex")?.Value, out var inputIndex) && speedIndexes.TryGetValue(speedIndex, out var dictionaryIndex) && inputIndex >= dictionaryIndex)) &&
                (profileWidth == 0 || int.Parse(t.Element("profileWidth")?.Value) == profileWidth) &&
                (profileRatio == 0 || int.Parse(t.Element("profileRatio")?.Value) == profileRatio) &&
                (diameter == 0 || int.Parse(t.Element("diameter")?.Value) == diameter) &&
                (rollingNoise == 0 || int.Parse(t.Element("rollingNoise")?.Value) <= rollingNoise) &&
                (loadIndex == 0 || int.Parse(t.Element("loadIndex")?.Value) >= loadIndex)
            )
            .Select(t => new
            { // Adatok kinyerese a talalt elemekbol
                ColBrand = t.Element("brand")?.Value,
                ColName = t.Element("name")?.Value,
                ColSeason = t.Element("season")?.Value,
                ColFuelEfficiency = t.Element("fuelEfficiency")?.Value,
                ColStoppingDistance = t.Element("stoppingDistance")?.Value,
                ColPunctureResistance = t.Element("punctureResistance")?.Value,
                ColSpeedIndex = t.Element("speedIndex")?.Value,
                ColLocation = t.Element("location")?.Value,
                ColQuantity = int.Parse(t.Element("quantity")?.Value),
                ColPrice = int.Parse(t.Element("price")?.Value),
                ColProfileWidth = int.Parse(t.Element("profileWidth")?.Value),
                ColProfileRatio = int.Parse(t.Element("profileRatio")?.Value),
                ColDiameter = int.Parse(t.Element("diameter")?.Value),
                ColRollingNoise = int.Parse(t.Element("rollingNoise")?.Value),
                ColLoadIndex = int.Parse(t.Element("loadIndex")?.Value),
            })
            .ToList();
            // A kimeneti tablazatban esetlegesen elofordulo sorok (pl. ha nem az elso kereses tortenik, akkor az elozo eredmeny) eltavolitasa
            FoundTyresDataGrid.Rows.Clear();
            // Talalt abroncsok tablazatba valo beszurasa
            foreach (var tyre in filteredTyres)
            {
                FoundTyresDataGrid.Rows.Add(
                    tyre.ColBrand,
                    tyre.ColName,
                    tyre.ColSeason,
                    tyre.ColProfileWidth,
                    tyre.ColProfileRatio,
                    tyre.ColDiameter,
                    tyre.ColFuelEfficiency,
                    tyre.ColStoppingDistance,
                    tyre.ColPunctureResistance,
                    tyre.ColRollingNoise,
                    tyre.ColLoadIndex,
                    tyre.ColSpeedIndex,
                    tyre.ColLocation,
                    tyre.ColQuantity,
                    tyre.ColPrice
                );
            }
        }

        private void FoundTyresDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (FoundTyresDataGrid.SelectedRows.Count == 1)
            {
                // A kivalasztott sor adatai
                var selectedRow = FoundTyresDataGrid.SelectedRows[0];

                // Populate controls with tyre data
                IdTextBox.Text = selectedRow.Cells["ColId"].Value.ToString();
                NameTextBox.Text = selectedRow.Cells["ColName"].Value.ToString();
                BrandTextBox.Text = selectedRow.Cells["ColBrand"].Value.ToString();
                SeasonComboBox.Text = selectedRow.Cells["ColSeason"].Value.ToString();
                QuantityNumericUpDown.Value = Convert.ToDecimal(selectedRow.Cells["ColQuantity"].Value);
                PriceNumericUpDown.Value = Convert.ToDecimal(selectedRow.Cells["ColPrice"].Value);

                // Add more fields as necessary...
            }
        }
    }
}