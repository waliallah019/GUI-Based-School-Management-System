using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUIproject.BL;
using GUIproject.DL;
using System.Windows.Forms;

namespace GUIproject
{
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
            DataBind();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void DataBind()
        {
            dataGridView1.DataSource = null;            
            dataGridView1.DataSource = StudentDL.students;
            SizeSet();
            dataGridView1.Refresh();
        }
        
        private void SizeSet()
        {
            for(int i=0; i<dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
