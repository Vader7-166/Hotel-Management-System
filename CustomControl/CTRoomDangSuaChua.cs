using Hotel_Management_System.DTO;
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

namespace Hotel_Management_System.CustomControl
{
    public partial class CTRoomDangSuaChua : CTRoom
    {
        private Phong phong = new Phong();
        FormMain formMain;
        private FormSoDoPhong formSoDoPhong;
        public override string getMaPhong()
        {
            return this.LabelMaPhong.Text;
        }
        public override void setLoaiPhong(string LoaiPhong)
        {
            this.LabelLoaiPhong.Text = LoaiPhong;
        }
        public override void setMaPhong(string maPhong)
        {
            this.LabelMaPhong.Text = maPhong;
            this.MaPhong = maPhong;

        }
        public override void setTrangThai(string trangThai)
        {
            this.LabelLoaiPhong.Text = trangThai;
            this.LabelTrangThaiLon.Text = trangThai;
        }
        public override void setThoiGianNone()
        {
            LabelThoiGian.Text = "";
        }
        public override void setThoiGian(string thoiGian)
        {
            this.LabelThoiGian.Text = thoiGian;
        }
        public override void setPhongTrong()
        {
            setThoiGianNone();
            setTrangThai("Phòng trống");
            PictureBoxTrangThai.Image = Properties.Resources.Trong;
        }
        public override void setChuaDonDep()
        {
            PictureBoxTrangThaiDonDep.Image = Properties.Resources.ChuaDonDep;
            LabelTrangThaiDonDep.Text = "Chưa dọn dẹp";
        }
        public override void setDaDonDep()
        {
            PictureBoxTrangThaiDonDep.Image = Properties.Resources.DaDonDep;
            LabelTrangThaiDonDep.Text = "Đã dọn dẹp";
        }
        public override void setGhiChu(string ghiChu)
        {
            this.LabelGhiChu.Text = ghiChu;
        }
        //Constructor
        public CTRoomDangSuaChua()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            this.Size = new Size(280, 155);
            this.BackColor = Color.FromArgb(43, 183, 213);
            this.ForeColor = Color.White;
            InitializeComponent();
        }
        public CTRoomDangSuaChua(Phong phong, FormSoDoPhong loaPhong, FormMain formMain)
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            this.Size = new Size(280, 155);
            this.BackColor = Color.FromArgb(43, 183, 213);
            this.ForeColor = Color.White;
            this.phong = phong;
            this.formSoDoPhong = loaPhong;
            InitializeComponent();
            this.formMain = formMain;
            this.LoaiPhong = "DangSuaChua";
            this.MaPhong = phong.MaPH;
        }

        private void CTRoomDangSuaChua_Click(object sender, EventArgs e)
        {
            //FormBackground formBackground = new FormBackground(formMain);
            //try
            //{
            //    using (FormThongTinPhong formThongTinPhong = new FormThongTinPhong(formMain, this.LabelTrangThaiLon.Text, null, phong))
            //    {
            //        formBackground.Owner = formMain;
            //        formBackground.Show();
            //        formThongTinPhong.Owner = formBackground;
            //        formThongTinPhong.ShowDialog();
            //        this.formSoDoPhong.LoadLanDau();
            //        formBackground.Dispose();
            //    }
            //}
            //catch (Exception)
            //{
            //    CTMessageBox.Show("Đã xảy ra lỗi! Vui lòng thử lại.", "Thông báo",
            //                MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //finally { formBackground.Dispose(); }
        }

    }
}
