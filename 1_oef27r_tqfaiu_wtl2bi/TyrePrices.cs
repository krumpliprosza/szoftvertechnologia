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
    public partial class TyrePrices : Form
    {
        public TyrePrices()
        {
            InitializeComponent();
        }
        public TyrePrices(List<Tyre> trpice)
        {
            InitializeComponent();
            foreach(var tyre in trpice)
            {
                dataGridView1.Rows.Add(tyre.GetId(),tyre.GetBrand(),tyre.GetName(),tyre.GetPrice());
            }
        }

        
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                ItemPriceEditor itemPriceEditor = new ItemPriceEditor(selectedRow);
                itemPriceEditor.Show();
            }
        }
         

    }
}
