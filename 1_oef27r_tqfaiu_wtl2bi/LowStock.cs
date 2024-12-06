using _1_oef27r_tqfaiu_wtl2bi.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_oef27r_tqfaiu_wtl2bi
{
    public partial class LowStock : Form
    {
        public LowStock()
        {
            InitializeComponent();
        }
        public LowStock(List<Tyre> lowStockTyres)
        {
            InitializeComponent();
            // A lapon talalhato tablazat feltoltese a talalt termekekkel
            foreach (var tyre in lowStockTyres)
            {
                lowStockDataGrid.Rows.Add(tyre.GetId(), tyre.GetBrand(), tyre.GetName(), tyre.GetQuantity(), tyre.GetLocation());
            }
        }
        private void PopulateDataGrid()
        {
            lowStockDataGrid.Rows.Clear(); // A régi adatokat töröljük
            foreach (var tyre in stock)
            {
                lowStockDataGrid.Rows.Add(tyre.GetId(), tyre.GetBrand(), tyre.GetName(), tyre.GetQuantity(), tyre.GetLocation());
            }
        }

        // A keresés gomb kattintás eseménye
        private void SearchButton_Click(object sender, EventArgs e)
        {
            string searchTerm = searchTextBox.Text.Trim(); // A keresett kifejezés
            Tyre foundTyre = FindTyre(searchTerm);

            if (foundTyre != null)
            {
                // Ha a termék megtalálható, listázzuk
                PopulateDataGrid(); // Újra feltöltjük a DataGrid-et a friss adatokkal
                MessageBox.Show($"A keresett termék megtalálható: {foundTyre.GetName()}");
            }
            else
            {
                // Ha nem található, üzenet és hozzáadás kérdése
                MessageBox.Show("A keresett termék nem található.");

                DialogResult result = MessageBox.Show("Szeretné hozzáadni a terméket a raktárkészlethez?", "Termék hozzáadása", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // Ha a felhasználó igent válaszolt, a terméket hozzáadjuk a raktárhoz
                    AddNewTyre();
                }
            }
        }

        // A termék keresése
        private Tyre FindTyre(string searchTerm)
        {
            // A raktárkészletben keresünk
            foreach (var tyre in stock)
            {
                if (tyre.GetName().ToLower().Contains(searchTerm.ToLower()))
                {
                    return tyre; // Ha megtaláltuk, visszaadjuk
                }
            }
            return null; // Ha nem található
        }

        // Új termék hozzáadása a raktárhoz
        private void AddNewTyre()
        {
            // A felhasználótól bekérjük az új termék adatokat
            string newBrand = Microsoft.VisualBasic.Interaction.InputBox("Adja meg a márkát:", "Márka");
            string newName = Microsoft.VisualBasic.Interaction.InputBox("Adja meg a termék nevét:", "Termék neve");
            int newQuantity = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Adja meg a darabszámot:", "Darabszám"));
            string newLocation = Microsoft.VisualBasic.Interaction.InputBox("Adja meg a termék helyét:", "Helyszín");

            // Új abroncs objektum létrehozása és hozzáadása a készlethez
            Tyre newTyre = new Tyre(stock.Count + 1, newBrand, newName, newQuantity, newLocation);
            stock.Add(newTyre); // Hozzáadjuk a raktárhoz

            MessageBox.Show("A termék sikeresen hozzáadva a raktárkészlethez.");

            // Új keresést indítunk
            PopulateDataGrid(); // Újra feltöltjük a DataGrid-et a friss adatokkal
        }
 private void EditButton_Click(object sender, EventArgs e)
        {
            if (lowStockDataGrid.SelectedRows.Count > 0)
            {
                // A kiválasztott sor adatainak kinyerése
                var selectedRow = lowStockDataGrid.SelectedRows[0];
                int tyreId = (int)selectedRow.Cells["Id"].Value;
                Tyre selectedTyre = stock.Find(t => t.GetId() == tyreId);

                if (selectedTyre != null)
                {
                    // A felhasználótól bekérjük az új darabszámot
                    string newQuantityStr = Microsoft.VisualBasic.Interaction.InputBox($"Adja meg az új darabszámot a következő termékhez: {selectedTyre.GetName()}", "Darabszám szerkesztése");
                    if (int.TryParse(newQuantityStr, out int newQuantity) && newQuantity >= 0)
                    {
                        // A darabszám frissítése
                        selectedTyre.SetQuantity(newQuantity);
                        MessageBox.Show("A darabszám sikeresen frissítve lett!");

                        // Az adatbázist frissítjük (a táblázat is frissül)
                        PopulateDataGrid();
                    }
                    else
                    {
                        MessageBox.Show("Érvénytelen darabszám. Kérjük, adjon meg egy érvényes számot.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Kérjük, válasszon ki egy terméket a szerkesztéshez.");
            }
        }
}
    }
}
