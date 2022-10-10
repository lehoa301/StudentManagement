using StudentManagement.QuanTri.QLGV.BaoGiang;
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

namespace StudentManagement.QuanTri.QLGV
{
    public partial class DanhSachGiaoVien : Form
    {
        public DanhSachGiaoVien()
        {
            InitializeComponent();
            for (int i = 0; i < 30; i++)
            {
                UCGiaoVien diem = new UCGiaoVien();
                PnContainer.Controls.Add(diem);
            }
        }
    }
}
