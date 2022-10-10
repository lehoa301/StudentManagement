using StudentManagement.QuanTri.ThoiGianBieu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Threading;
using System.Security.RightsManagement;
using System.ServiceModel.Channels;
using System.Drawing.Text;
using System.Speech.Synthesis;

namespace StudentManagement.Source
{
    internal class Object
    {
    }

    #region HocSinh
    public class HocSinh
    {
        private string id;
        private string Ten;
        private string GioiTinh;
        private string DiaChi;
        private string SDT;
        private string Email;
        private string TrangThai;

        public string LayHanhKiem(int HocKyID)
        {
            string query = "Select HanhKiem from HanhKiem, LoaiHanhKiem where HanhKiem.IDLoai = LoaiHanhKiem.ID and IDHocKy = " + HocKyID + " and IDHocSinh = " + id + "";
            DataTable dt = new DataTable();
            Function fn = new Function(); dt = fn.getdata(query);
            string temp = dt.Rows[0][0].ToString();
            return temp;
        }

        public string LayDiem(int IDBaiKT)
        {
            DataTable dt = new DataTable();
            Function fn = new Function();
            string query = "Select Diem from KetQua where KetQua.IDBaiKT = " + IDBaiKT + " and IDHocSinh = " + id + "";
            dt = fn.getdata(query);
            string temp = dt.Rows[0][0].ToString();
            return temp;
        }

        public HocSinh(string id)
        {
            this.id = id;
            DataTable dt = new DataTable();
            Function fn = new Function();
            string query = "Select Ten, GioiTinh, DiaChi, SDT, Email, TrangThai from HSHocSinh where ID = " + id + "";
            dt = fn.getdata(query);
            this.Ten = dt.Rows[0][0].ToString();
            this.GioiTinh = dt.Rows[0][1].ToString();
            this.DiaChi = dt.Rows[0][2].ToString();
            this.SDT = dt.Rows[0][3].ToString();
            this.Email = dt.Rows[0][4].ToString();
            this.TrangThai = dt.Rows[0][5].ToString();
        }
    }
    #endregion

    #region GiaoVien
    public class GiaoVien
    {
        private int ID;
        private int IDMon;
        private string Ten;
        private string GioiTinh;
        private string DiaChi;
        private string SDT;
        private string Email;
        private string TrangThai;

        public MonHoc mon()
        {
            MonHoc temp = new MonHoc(IDMon);
            return temp;
        }

        public LopHoc LopCN()
        {
            DataTable dt = new DataTable();
            Function fn = new Function();
            string query = "Select IDLop from HSLopHoc where IDGV = " + ID + " and TrangThai = true";
            dt = fn.getdata(query);
            int temp = Convert.ToInt32(dt.Rows[0][0].ToString());
            LopHoc lp = new LopHoc(temp);
            return lp;
        }

        public GiaoVien(int ID)
        {
            this.ID = ID;
            DataTable dt = new DataTable();
            Function fn = new Function();
            string query = "Select Ten, IDMon, GioiTinh, DiaChi, SDT, Email, TrangThai from HSLopHoc where ID = " + ID + "";
            dt = fn.getdata(query);
            this.Ten = dt.Rows[0][0].ToString();
            this.IDMon = Convert.ToInt32(dt.Rows[0][1].ToString());
            this.GioiTinh = Convert.ToString(dt.Rows[0][2].ToString());
            this.DiaChi = Convert.ToString(dt.Rows[0][3].ToString());
            this.SDT = Convert.ToString(dt.Rows[0][4].ToString());
            this.Email = Convert.ToString(dt.Rows[0][5].ToString());
            this.TrangThai = dt.Rows[0][6].ToString();
        }
    }

    #endregion

    #region LopHoc
    public class LopHoc
    {
        private int ID;
        private string Ten;
        private int IDGV;
        private DateTime NgayBatDau;
        private DateTime NgayKetThuc;
        private int Khoi;
        private string TrangThai;
        private int IDNamHoc;

        public GiaoVien gvcn()
        {
            DataTable dt = new DataTable();
            Function fn = new Function();
            string query = "Select ID from HSGiaoVien where ID = " + IDGV + "";
            dt = fn.getdata(query);
            int temp = Convert.ToInt32(dt.Rows[0][0].ToString());
            GiaoVien gv = new GiaoVien(temp);
            return gv;
        }

        public LopHoc(int ID)
        {
            this.ID = ID;
            DataTable dt = new DataTable();
            Function fn = new Function();
            string query = "Select Ten, IDGV, NgayBatDau, NgayKetThuc, Khoi, TrangThai from HSLopHoc where ID = " + ID + "";
            dt = fn.getdata(query);
            this.Ten = dt.Rows[0][0].ToString();
            this.IDGV = Convert.ToInt32(dt.Rows[0][1].ToString());
            this.NgayBatDau = Convert.ToDateTime(dt.Rows[0][2].ToString());
            this.NgayKetThuc = Convert.ToDateTime(dt.Rows[0][3].ToString());
            this.Khoi = Convert.ToInt32(dt.Rows[0][4].ToString());
            this.TrangThai = dt.Rows[0][5].ToString();
        }

        public NamHoc namhoc ()
        {
            NamHoc temp = new NamHoc(IDNamHoc);
            return temp;
        }
    }
    #endregion

    #region NamHoc
    public class NamHoc
    {
        private int ID;
        private string Ten;
        private DateTime NgayBatDau;
        private DateTime NgayKetThuc;
        private string TrangThai;

        public NamHoc(int id)
        {
            ID = id;
            DataTable dt = new DataTable();
            Function fn = new Function();
            string query = "Select Ten, NgayBatDau, NgayKetThuc, TrangThai from HSNamHoc where ID = " + id + "";
            dt = fn.getdata(query);
            this.Ten = dt.Rows[0][0].ToString();
            this.NgayBatDau = Convert.ToDateTime(dt.Rows[0][1].ToString());
            this.NgayKetThuc = Convert.ToDateTime(dt.Rows[0][2].ToString());
            this.TrangThai = dt.Rows[0][3].ToString();
        }
    }
    #endregion

    #region ChiTietTKB
    public class ChiTietTKB
    {
        private int ID;
        private int IDTKB;
        private int IDTiet;
        private int IDThu;
        private int IDMon;

        public ChiTietTKB(int id)
        {
            this.ID = id;
            DataTable dt = new DataTable();
            Function fn = new Function();
            string query = "Select IDTKB, IDDonViTiet, IDNgayTuan, IDMon from ChiTietTKB where ID = " + id + "";
            dt = fn.getdata(query);
            this.IDTKB = Convert.ToInt32(dt.Rows[0][0].ToString());
            this.IDTiet = Convert.ToInt32(dt.Rows[0][1].ToString());
            this.IDThu = Convert.ToInt32(dt.Rows[0][2].ToString());
            this.IDMon = Convert.ToInt32(dt.Rows[0][3].ToString());
        }

        public Tiet TTTiet()
        {
            Tiet temp = new Tiet(IDTiet);
            return temp;
        }

        public string ThuNgay()
        {
            string temp = "";
            DataTable dt = new DataTable();
            Function fn = new Function();
            string query = "Select Ngay from NgayTrongTuan where ID = " + IDThu + "";
            dt = fn.getdata(query);
            temp = dt.Rows[0][0].ToString();
            return temp;
        }

    }
    #endregion

    #region Tiethoc
    public class Tiet
    {
        private int ID;
        private string BatDau;
        private string KetThuc;

        public string TenTiet()
        {
            string temp = "";
            temp = "Tiết" + ID.ToString();
            return temp;
        }
        public Tiet(int id)
        {
            this.ID = id;
            DataTable dt = new DataTable();
            Function fn = new Function();
            string query = "Select BatDau, KetThuc from DonViTiet where ID = " + id + "";
            dt = fn.getdata(query);
            this.BatDau = dt.Rows[0][0].ToString();
            this.KetThuc = dt.Rows[0][1].ToString();
        }
    }
    #endregion

    #region PhanCong
    public class PhanCong
    {
        private int ID;
        private int IDLop;
        private int IDNamHoc;
        private int IDGiaoVien;

        public LopHoc Lop ()
        {
            LopHoc temp = new LopHoc(IDLop);
            return temp;
        }

        public GiaoVien gvien()
        {
            GiaoVien temp = new GiaoVien(IDGiaoVien);
            return temp;
        }
        public NamHoc namhoc()
        {
            NamHoc temp = new NamHoc(IDNamHoc);
            return temp;
        }

    }
    #endregion

    #region ThoiKhoaBieu
    public class ThoiKhoaBieu
    {
        private string Ten;
        private int IDLop;
    }
    #endregion

    #region MonHoc
    public class MonHoc
    {
        private int id;
        private string Ten;
        private int SoTietTuan;
        private int TongTiet;

        public MonHoc(int id)
        {
            this.id = id;
            DataTable dt = new DataTable();
            Function fn = new Function();
            string query = "Select TenMon, SoTietTuan, TongTiet from MonHoc where ID = " + id + "";
            dt = fn.getdata(query);
            this.Ten = dt.Rows[0][0].ToString();
            this.SoTietTuan = Convert.ToInt32(dt.Rows[0][1].ToString());
            this.TongTiet = Convert.ToInt32(dt.Rows[0][2].ToString());
        }
    }
    #endregion

}
