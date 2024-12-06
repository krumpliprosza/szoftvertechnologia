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
    public partial class TyreDetails : Form
    {
        private Search _searchForm;
        public TyreDetails()
        {
            InitializeComponent();
        }
        public TyreDetails(DataGridViewRow selectedRow, Search searchForm)
        {
            InitializeComponent();
            // Az ezelotti keresesi adatok beolvasasa (pl. edit/delete eseten szukseg lesz ra)
            _searchForm = searchForm;
            // A kapott sorbol a megfelelo szovegdobozok feltoltese
            IdValue.Text = selectedRow.Cells["ColId"].Value?.ToString();
            BrandValue.Text = selectedRow.Cells["ColBrand"].Value?.ToString();
            NameValue.Text = selectedRow.Cells["ColName"].Value?.ToString();
            SeasonValue.Text = selectedRow.Cells["ColSeason"].Value?.ToString();
            ProfileWidthValue.Text = (selectedRow.Cells["ColProfileWidth"].Value).ToString();
            ProfileRatioValue.Text = (selectedRow.Cells["ColProfileRatio"].Value).ToString();
            DiameterValue.Text = (selectedRow.Cells["ColDiameter"].Value).ToString();
            FuelEfficiencyValue.Text = selectedRow.Cells["ColFuelEfficiency"].Value?.ToString();
            StoppingDistanceValue.Text = selectedRow.Cells["ColStoppingDistance"].Value?.ToString();
            PunctureResistanceValue.Text = selectedRow.Cells["ColPunctureResistance"].Value?.ToString();
            RollingNoiseValue.Text = (selectedRow.Cells["ColRollingNoise"].Value).ToString();
            LoadIndexValue.Text = (selectedRow.Cells["ColLoadIndex"].Value).ToString();
            LocationValue.Text = selectedRow.Cells["ColLocation"].Value?.ToString();
            SpeedIndexValue.Text = selectedRow.Cells["ColSpeedIndex"].Value?.ToString();
            QuantityValue.Text = (selectedRow.Cells["ColQuantity"].Value).ToString();
            PriceValue.Text = (selectedRow.Cells["ColPrice"].Value).ToString();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            // Adatmasolas
            string id = IdValue.Text;
            string brand = BrandValue.Text;
            string name = NameValue.Text;
            string season = SeasonValue.Text;
            string profileWidth = ProfileWidthValue.Text;
            string profileRatio = ProfileRatioValue.Text;
            string diameter = DiameterValue.Text;
            string fuelEfficiency = FuelEfficiencyValue.Text;
            string stoppingDistance = StoppingDistanceValue.Text;
            string punctureResistance = PunctureResistanceValue.Text;
            string speedIndex = SpeedIndexValue.Text;
            string quantity = QuantityValue.Text;
            string price = PriceValue.Text;
            // tyre.xml megnyitasa
            XDocument doc = XDocument.Load("Data/tyre.xml");
            // Modositando abroncs megkeresese
            var tyreToEdit = doc.Descendants("tyre")
                .FirstOrDefault(t => t.Element("id")?.Value == id);
            // Szerkesztes
            if (tyreToEdit != null)
            {
                tyreToEdit.Element("brand")?.SetValue(brand);
                tyreToEdit.Element("name")?.SetValue(name);
                tyreToEdit.Element("season")?.SetValue(season);
                tyreToEdit.Element("profileWidth")?.SetValue(profileWidth);
                tyreToEdit.Element("profileRatio")?.SetValue(profileRatio);
                tyreToEdit.Element("diameter")?.SetValue(diameter);
                tyreToEdit.Element("fuelEfficiency")?.SetValue(fuelEfficiency);
                tyreToEdit.Element("stoppingDistance")?.SetValue(stoppingDistance);
                tyreToEdit.Element("punctureResistance")?.SetValue(punctureResistance);
                tyreToEdit.Element("speedIndex")?.SetValue(speedIndex);
                tyreToEdit.Element("quantity")?.SetValue(quantity);
                tyreToEdit.Element("price")?.SetValue(price);

                // Mentes
                doc.Save("Data/tyre.xml");

                MessageBox.Show("Minden változtatás sikeresen elmentve!", "Sikeres módosítás", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _searchForm.RefreshQueryGrid();
            }
            else
            {
                MessageBox.Show("A módosítandó abroncs nem található!", "Módosítási hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            // Azonosito masolasa
            string id = IdValue.Text;
            // tyre.xml megnyitasa
            XDocument doc = XDocument.Load("Data/tyre.xml");
            // Torlendo abroncs megkeresese
            var tyreToDelete = doc.Descendants("tyre")
                .FirstOrDefault(t => t.Element("id")?.Value == id);
            // Torles
            if (tyreToDelete != null)
            {
                tyreToDelete.Remove();
                // Mentes
                doc.Save("Data/tyre.xml");
                MessageBox.Show("A kiválasztott abroncs sikeresen törölve!", "Sikeres törlés", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _searchForm.RefreshQueryGrid();
                this.Close();
            }
            else
            {
                MessageBox.Show("A törlendő abroncs nem található!", "Törlési hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
