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
    public partial class CTRoomDaDat : CTRoom
    {
        CTDP ctdp = new CTDP();
        FormSoDoPhong SoDoPhong;
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
        public override void setGhiChu(string ghiChu)
        {
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

        //Constructor
        public CTRoomDaDat()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            this.Size = new Size(280, 155);
            this.BackColor = Color.FromArgb(227, 196, 68);
            this.ForeColor = Color.White;
            InitializeComponent();
        }
        public CTRoomDaDat(CTDP cTDP, FormSoDoPhong SoDoPhong, FormMain formMain, TaiKhoan taiKhoan)
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            this.Size = new Size(280, 155);
            this.BackColor = Color.FromArgb(227, 196, 68);
            this.ForeColor = Color.White;
            ctdp = cTDP;
            this.SoDoPhong = SoDoPhong;
            InitializeComponent();
            this.formMain = formMain;
            this.taiKhoan = taiKhoan;
            this.LoaiPhong = "DaDat";
            this.MaPhong = cTDP.MaPH;
        }
        private void setColorMove(Color colorTop, Color colorBack)
        {
            LabelMaPhong.BackColor
                = LabelLoaiPhong.BackColor
                = PictureBoxTrangThai.BackColor
                = LabelTrangThaiLon.BackColor
                = LabelGhiChu.BackColor
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
                = LabelGhiChu.BackColor
                = colorTop;
            this.BackColor
                = PictureBoxThoiGian.BackColor
                = PictureBoxTrangThaiDonDep.BackColor
                = LabelThoiGian.BackColor
                = LabelTrangThaiDonDep.BackColor
                = colorBack;
        }
        private void CTRoomDaDat_MouseLeave(object sender, EventArgs e)
        {
            setColorLeave(Color.FromArgb(201, 167, 31), Color.FromArgb(230, 222, 224));
        }

        private void CTRoomDaDat_MouseMove(object sender, MouseEventArgs e)
        {
            setColorMove(Color.FromArgb(148, 122, 22), Color.FromArgb(154, 148, 150));
        }

        private void CTRoomDaDat_Click(object sender, EventArgs e)
        {
            FormBackground formBackground = new FormBackground(formMain);
            try
            {
                using (FormThongTinPhong formThongTinPhong = new FormThongTinPhong(formMain, this.LabelTrangThaiLon.Text, ctdp, BUS.PhongBUS.Instance.FindePhong(ctdp.MaPH), taiKhoan))
                {
                    formBackground.Owner = formMain;
                    formBackground.Show();
                    formThongTinPhong.Owner = formBackground;
                    formThongTinPhong.ShowDialog();
                    this.SoDoPhong.LoadLanDau();
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

        private void CTRoomDaDat_Load(object sender, EventArgs e)
        {
            this.Invalidate();
        }

    }
}
