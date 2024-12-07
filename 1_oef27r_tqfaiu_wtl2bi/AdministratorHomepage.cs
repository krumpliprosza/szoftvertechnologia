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
    public partial class AdministratorHomepage : Form
    {
        public AdministratorHomepage()
        {
            InitializeComponent();
        }

        private void StorageQuery_Click(object sender, EventArgs e)
        {
            // Kereses oldal megnyitasa
            Search searchPage = new Search();
            searchPage.Show();
        }

        private void OrderCreate_Click(object sender, EventArgs e)
        {
            // Rendelest felvevo oldal megnyitasa
            OrderAdd orderAddPage = new OrderAdd();
            orderAddPage.Show();
        }

        private void ServiceQuery_Click(object sender, EventArgs e)
        {
            // Kereses oldal megnyitasa
        }
    }
}
