using Hotel_Management_System.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System.GUI
{
    public partial class FormThongTinNhanVien : Form
    {
        //Fields
        NhanVien nhanVien;
        private int borderRadius = 20;
        private int borderSize = 2;
        private Color borderColor = Color.White;

        //Constructor
        public FormThongTinNhanVien()
        {
            this.DoubleBuffered = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);
            InitializeComponent();
        }
        public FormThongTinNhanVien(NhanVien nhanVien)
        {
            this.DoubleBuffered = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);
            this.nhanVien = nhanVien;
            InitializeComponent();
            LoadForm();
        }
        //Control Box

        //Form Move

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        CreateParams cp = base.CreateParams;
        //        cp.Style |= 0x20000; // <--- Minimize borderless form from taskbar
        //        return cp;
        //    }
        //}

        private void LoadForm()
        {
            this.CTTextBoxNhapCCCD.RemovePlaceholder();
            this.ctTextBoxGioiTinh.RemovePlaceholder();
            this.CTTextBoxNhapChucVu.RemovePlaceholder();
            this.ctTextBoxNgaySinh.RemovePlaceholder();
            this.ctTextBoxEmail.RemovePlaceholder();
            this.ctTextBoxSDT.RemovePlaceholder();
            this.CTTextBoxDiaChi.RemovePlaceholder();
            this.CTTextBoxNhapHoTen.RemovePlaceholder();
            this.CTTextBoxLuong.RemovePlaceholder();

            this.CTTextBoxNhapCCCD.Texts = this.nhanVien.CCCD;
            this.ctTextBoxGioiTinh.Texts = this.nhanVien.GioiTinh;
            this.CTTextBoxNhapChucVu.Texts = this.nhanVien.ChucVu;
            this.ctTextBoxNgaySinh.Texts = this.nhanVien.NgaySinh.ToString("dd/MM/yyyy");
            this.ctTextBoxEmail.Texts = this.nhanVien.Email;
            this.ctTextBoxSDT.Texts = this.nhanVien.SDT;
            this.CTTextBoxDiaChi.Texts = this.nhanVien.DiaChi;
            this.CTTextBoxNhapHoTen.Texts = this.nhanVien.TenNV;
            this.CTTextBoxLuong.Texts = this.nhanVien.Luong.ToString("#,#");
        }
        
        //Event Methods
        private void FormThongTinNhanVien_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void FormThongTinNhanVien_Activated(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void PanelBackground_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelBackground_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void CTButtonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormThongTinNhanVien_Load(object sender, EventArgs e)
        {
            this.ActiveControl = LabelThongTinNhanVien;
        }
    }
}
