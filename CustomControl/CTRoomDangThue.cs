using Hotel_Management_System.BUS;
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
    public partial class CTRoomDangThue : CTRoom
    {
        private CTDP ctdp;
        private FormSoDoPhong formSoDoPhong;
        FormMain formMain;
        TaiKhoan taiKhoan;
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
        public override void setGhiChu(string ghiChu)
        {
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
        //Constructor
        public CTRoomDangThue()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            this.Size = new Size(280, 155);
            this.BackColor = Color.FromArgb(236, 107, 104);
            this.ForeColor = Color.White;
            InitializeComponent();
        }
        public CTRoomDangThue(CTDP cTDP, FormSoDoPhong soDoPhong, FormMain formMain, TaiKhoan taiKhoan)
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            this.Size = new Size(280, 155);
            this.BackColor = Color.FromArgb(236, 107, 104);
            this.ForeColor = Color.White;
            InitializeComponent();
            ctdp = cTDP;
            this.formSoDoPhong = soDoPhong;
            this.formMain = formMain;
            this.LoaiPhong = "DangThue";
            this.MaPhong = ctdp.MaPH;
            this.taiKhoan = taiKhoan;
        }
        private void setColorMove(Color colorTop, Color colorBack)
        {
            LabelMaPhong.BackColor
                = LabelLoaiPhong.BackColor
                = PictureBoxTrangThai.BackColor
                = LabelTrangThaiLon.BackColor
                = PanelTop.BackColor = colorTop;
            this.BackColor
                = PictureBoxThoiGian.BackColor
                = PictureBoxTrangThaiDonDep.BackColor
                = LabelThoiGian.BackColor
                = LabelTrangThaiDonDep.BackColor
                = colorBack;
        }
        private void setColorLeave(Color colorTop, Color colorBack)
        {
            LabelMaPhong.BackColor
                = LabelLoaiPhong.BackColor
                = PictureBoxTrangThai.BackColor
                = LabelTrangThaiLon.BackColor
                = PanelTop.BackColor
                = colorTop;
            this.BackColor
                = PictureBoxThoiGian.BackColor
                = PictureBoxTrangThaiDonDep.BackColor
                = LabelThoiGian.BackColor
                = LabelTrangThaiDonDep.BackColor
                = colorBack;
        }
        private void CTRoomDangThue_MouseMove(object sender, MouseEventArgs e)
        {
            setColorMove(Color.FromArgb(147, 22, 19), Color.FromArgb(154, 148, 150));
        }

        private void CTRoomDangThue_MouseLeave(object sender, EventArgs e)
        {
            setColorLeave(Color.FromArgb(236, 107, 104), Color.FromArgb(230, 222, 224));
        }

        private void CTRoomDangThue_Click(object sender, EventArgs e)
        {
            FormBackground formBackground = new FormBackground(formMain);
            try
            {
                using (FormThongTinPhong formThongTinPhong = new FormThongTinPhong(formMain, this.LabelTrangThaiLon.Text, ctdp, PhongBUS.Instance.FindePhong(ctdp.MaPH), taiKhoan))
                {
                    formBackground.Owner = formMain;
                    formBackground.Show();
                    formThongTinPhong.Owner = formBackground;
                    formThongTinPhong.ShowDialog();
                    this.formSoDoPhong.LoadLanDau();
                    formBackground.Dispose();
                }
            }
            catch (Exception)
            {
                CTMessageBox.Show("Đã xảy ra lỗi! Vui lòng thử lại.", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { formBackground.Dispose(); }
        }

        private void CTRoomDangThue_Load(object sender, EventArgs e)
        {
            this.Invalidate();
        }
    }
}
