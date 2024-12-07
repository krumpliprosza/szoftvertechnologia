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
    public partial class TyreToOrder : Form
    {
        private Search _searchForm;
        public TyreToOrder(DataGridViewRow selectedRow, Search searchForm)
        {
            InitializeComponent();
            // Az ezelotti keresesi adatok beolvasasa (uj rendeles felvetele eseten szukseg lesz ra)
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
    }
}
