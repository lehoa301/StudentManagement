using StudentManagement.QuanTri;
using StudentManagement.QuanTri.QLGV;
using StudentManagement.QuanTri.QLHS;
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

namespace StudentManagement
{
    public partial class Menu_QT : Form
    {
        public Menu_QT()
        {
            InitializeComponent();
        }

        private void hideSubMenu()
        {
            SubDM.Visible = false;
            SubGV.Visible = false;
            SubHS.Visible = false;
            SubTGB.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private Form activeForm = null;
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PanelChildForm.Controls.Add(childForm);
            PanelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            LinkMenu.Text = childForm.Text;
        }

        private void Menu_QT_Load(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildFormInPanel(new Home());
        }

        private void ButtonDanhmuc_Click(object sender, EventArgs e)
        {
            showSubMenu(SubDM);
        }

        private void ButtonTTHocSinh_Click(object sender, EventArgs e)
        {
            showSubMenu(SubHS);
        }

        private void ButtonGV_Click(object sender, EventArgs e)
        {
            showSubMenu(SubGV);
        }

        private void ButtonTKB_Click(object sender, EventArgs e)
        {
            showSubMenu(SubTGB);
        }

        private void ButtonThongTinHS_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new ThongTinHS());
        }

        private void ButtonNamHoc_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new HSNamHoc());
        }


        private void ButtonNgayNghi_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new NgayNghi());
        }

        private void ButtonDMKyThi_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new KyThi());
        }

        private void ButtonSuKien_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new SuKien());
        }

        private void ButtonHSLop_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new HoSoLop());
        }

        private void ButtonTTGV_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new ThongTinGV());
        }

        private void ButtonBaoGiang_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new DanhSachGiaoVien());
        }


        private void ButtonXemTKB_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new ThoiKhoaBieu());
        }

        private void ButtonDSKythi_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new QLKyThi());
        }

        private void Button_QLHT_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new QuanLyHT());
        }

        private void ButtonBaoCao_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new BaoCao());
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Home());
            hideSubMenu();
        }
    }
}
