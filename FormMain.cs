using ApplicationSettings;
using Hotel_Management_System.GUI.SoDoPhong;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            openChildForm(new FormTrangChu());
            int time = 300;
            WinAPI.AnimateWindow(this.Handle, time, WinAPI.CENTER);
            //this.LabelTenNguoiDung.Text = taiKhoan.NhanVien.TenNV;
        }
        private Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMainChildForm.Controls.Add(childForm);
            panelMainChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        //Button color change
        private void SetAllButtonNormalColor()
        {
            ButtonTrangChu.BackColor = Color.FromArgb(72, 145, 153);
            ButtonSoDoPhong.BackColor = Color.FromArgb(72, 145, 153);
            ButtonDanhSachDatPhong.BackColor = Color.FromArgb(72, 145, 153);
            ButtonDanhSachHoaDon.BackColor = Color.FromArgb(72, 145, 153);
            ButtonDanhSachKhachHang.BackColor = Color.FromArgb(72, 145, 153);
            ButtonPhong.BackColor = Color.FromArgb(72, 145, 153);
            ButtonLoaiPhong.BackColor = Color.FromArgb(72, 145, 153);
            ButtonDanhSachDichVu.BackColor = Color.FromArgb(72, 145, 153);
            ButtonDanhSachTienNghi.BackColor = Color.FromArgb(72, 145, 153);
            ButtonDanhSachTaiKhoan.BackColor = Color.FromArgb(72, 145, 153);
            ButtonDanhSachNhanVien.BackColor = Color.FromArgb(72, 145, 153);
            ButtonThongKe.BackColor = Color.FromArgb(72, 145, 153);

            ButtonTrangChu.ForeColor
                = ButtonSoDoPhong.ForeColor
                = ButtonDanhSachDatPhong.ForeColor
                = ButtonDanhSachHoaDon.ForeColor
                = ButtonDanhSachKhachHang.ForeColor
                = ButtonPhong.ForeColor
                = ButtonLoaiPhong.ForeColor
                = ButtonDanhSachDichVu.ForeColor
                = ButtonDanhSachTienNghi.ForeColor
                = ButtonDanhSachTaiKhoan.ForeColor
                = ButtonDanhSachNhanVien.ForeColor
                = ButtonThongKe.ForeColor = Color.Black;
        }

        

        private void ButtonTrangChu_Click(object sender, EventArgs e)
        {
            SetAllButtonNormalColor();
            ButtonTrangChu.BackColor = Color.FromArgb(233, 117, 32);
            ButtonTrangChu.ForeColor = Color.White;
            openChildForm(new FormTrangChu(this));
        }

        private void ButtonSoDoPhong_Click(object sender, EventArgs e)
        {
            SetAllButtonNormalColor();
            ButtonSoDoPhong.BackColor = Color.FromArgb(233, 117, 32);
            ButtonSoDoPhong.ForeColor = Color.White;
            openChildForm(new FormSoDoPhong(this));
        }
    }
}
