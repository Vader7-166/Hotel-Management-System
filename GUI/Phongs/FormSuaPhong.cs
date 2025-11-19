using Hotel_Management_System.BUS;
using Hotel_Management_System.CustomControl;
using Hotel_Management_System.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System.GUI
{
    public partial class FormSuaPhong : Form
    {
        Phong phong;
        public FormSuaPhong()
        {
            InitializeComponent();
        }
        public FormSuaPhong(Phong phong)
        {
            this.phong = phong;
            InitializeComponent();
            LoadForm();
        }
        private void LoadForm()
        {
            if (phong.GhiChu != "")
            {
                this.ctTextBoxGhiChu.RemovePlaceholder();
            }
            this.comboBoxDonDep.Texts = phong.TTDD;
            this.comboBoxLoaiPhong.Texts = phong.LoaiPhong.TenLPH;
            this.comboBoxTinhTrangPhong.Texts = phong.TTPH;
            this.ctTextBoxGhiChu.Texts = phong.GhiChu;
        }

        private void FormSuaPhong_Load(object sender, EventArgs e)
        {
            this.ActiveControl = LabelSuaPhong;
        }

        private void CTButtonCapNhat_Click(object sender, EventArgs e)
        {
            string TinhTrang = comboBoxTinhTrangPhong.Texts;
            string DonDep = comboBoxDonDep.Texts;
            string LoaiPhong = comboBoxLoaiPhong.Texts;
            string GhiChu = ctTextBoxGhiChu.Texts;
            if (TinhTrang == "Tình trạng phòng" || DonDep == "Tình trạng dọn dẹp" || LoaiPhong == "Loại phòng" || GhiChu == "")
            {
                CTMessageBox.Show("Vui lòng nhập đầy đủ thông tin phòng.", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                phong.TTDD = DonDep;
                phong.GhiChu = GhiChu;
                if (LoaiPhong == "Thường đơn")
                    phong.MaLPH = "NOR01";
                else if (LoaiPhong == "Thường đôi")
                    phong.MaLPH = "NOR02";
                else if (LoaiPhong == "Vip đơn")
                    phong.MaLPH = "VIP01";
                else
                    phong.MaLPH = "VIP02";
                phong.TTPH = TinhTrang;
                PhongBUS.Instance.UpdateOrAdd(phong);

                CTMessageBox.Show("Cập nhật thông tin thành công.", "Thông báo",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception)
            {
                CTMessageBox.Show("Đã xảy ra lỗi! Vui lòng thử lại.", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

            }
        }

        private void CTButtonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
