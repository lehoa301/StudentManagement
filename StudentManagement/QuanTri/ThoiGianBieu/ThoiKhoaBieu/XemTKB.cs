using StudentManagement.QuanTri.QLHocTap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement.QuanTri.ThoiGianBieu
{
    public partial class XemTKB : Form
    {
        public XemTKB()
        {
            InitializeComponent();
            for (int i = 0; i < 56; i++)
            {
                UCTKB diem = new UCTKB();
                PnContainer.Controls.Add(diem);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
