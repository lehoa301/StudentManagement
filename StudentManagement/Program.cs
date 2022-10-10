using StudentManagement.QuanTri;
using StudentManagement.QuanTri.Danh_muc;
using StudentManagement.QuanTri.QLGV;
using StudentManagement.QuanTri.QLHocTap;
using StudentManagement.QuanTri.QLHS;
using StudentManagement.QuanTri.ThoiGianBieu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu_QT());
        }
    }
}
