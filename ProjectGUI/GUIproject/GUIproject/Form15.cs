using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUIproject.BL;
using GUIproject.DL;

namespace GUIproject
{
    public partial class Form15 : Form
    {
        public Form15()
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
            dataGridView1.DataSource = TeacherDL.teachers;
            SizeSet();
            dataGridView1.Refresh();
        }
        private void SizeSet()
        {
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
    }
}
