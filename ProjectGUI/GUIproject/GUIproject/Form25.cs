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
    public partial class Form25 : Form
    {
        public Form25()
        {
            InitializeComponent();
            label12.Text = TeacherDL.announcements[1];
            label13.Text = TeacherDL.announcements[2];
            label15.Text = TeacherDL.announcements[3];
            label16.Text = TeacherDL.announcements[4];
            label17.Text = TeacherDL.announcements[5];
            label18.Text = TeacherDL.announcements[6];
            label19.Text = TeacherDL.announcements[7];
            label20.Text = TeacherDL.announcements[8];
            label21.Text = TeacherDL.announcements[9];
            label22.Text = TeacherDL.announcements[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form25_Load(object sender, EventArgs e)
        {

        }
    }
}
