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
    }
}
