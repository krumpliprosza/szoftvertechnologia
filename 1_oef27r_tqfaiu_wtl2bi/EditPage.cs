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
    public partial class EditPage : Form
    {
        public EditPage()
        {
            InitializeComponent();
        }

        public EditPage(DataGridViewRow selectedRow)
        {
            InitializeComponent();
            usernameBox.Text = selectedRow.Cells["username"].Value?.ToString();
            passwordBox.Text=selectedRow.Cells["password"].Value?.ToString();
            roleBox.Text=selectedRow.Cells["role"].Value?.ToString();
        }
    }
}
