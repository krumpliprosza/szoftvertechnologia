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
using System.Xml.Linq;
using System.Xml;

namespace _1_oef27r_tqfaiu_wtl2bi
{
    public partial class LoginEdit : Form
    {
        public LoginEdit()
        {
            InitializeComponent();
        }
        public LoginEdit(List<Worker> workers)
        {
            InitializeComponent();
            foreach(var worker in workers)
            {
                dataGridView1.Rows.Add(worker.GetUserame(),worker.GetPassword(),worker.GetRole());
            }
        }
       
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                var selectedRow=dataGridView1.SelectedRows[0];
                EditPage editpage=new EditPage(selectedRow);
                editpage.Show();
            }
        }
    }

}
