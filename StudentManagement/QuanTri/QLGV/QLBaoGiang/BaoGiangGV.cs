using StudentManagement.QuanTri.QLGV.BaoGiang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement.QuanTri.QLGV
{
    public partial class BaoGiangGV : Form
    {
        public BaoGiangGV()
        {
            InitializeComponent();
            for (int i = 0; i < 5; i++)
            {
                UCBaoGiang diem = new UCBaoGiang();
                Container1.Controls.Add(diem);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
