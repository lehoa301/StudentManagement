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

namespace StudentManagement.QuanTri
{
    public partial class SuaDiem : Form
    {
        public SuaDiem()
        {
            InitializeComponent();
            for (int i = 0; i < 10; i++)
            {
                UCDiem diem = new UCDiem();
                PnContainer.Controls.Add(diem);
            }
        }
    }
}
