using StudentManagement.QuanTri.QLHS.QuanLyLop;
using StudentManagement.QuanTri.ThoiGianBieu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement.QuanTri.QLHS
{
    public partial class ThemMoiLop : Form
    {
        public ThemMoiLop()
        {
            InitializeComponent();
            for (int i = 0; i < 10; i++)
            {
                UCPhanCong nLop = new UCPhanCong();
                Container1.Controls.Add(nLop);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
