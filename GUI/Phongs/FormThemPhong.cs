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
    public partial class FormThemPhong : Form
    {
        public FormThemPhong()
        {
            InitializeComponent();
        }

        private void FormThemPhong_Load(object sender, EventArgs e)
        {
            this.ActiveControl = LabelThemPhong;
        }

        private void CTButtonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CTButtonCapNhat_Click(object sender, EventArgs e)
        {
            string MaPH = ctTextBoxMaPH.Texts;
            string TinhTrang = comboBoxTinhTrangPhong.Texts;
            string DonDep = comboBoxDonDep.Texts;
            string LoaiPhong = comboBoxLoaiPhong.Texts;
            string GhiChu = ctTextBoxGhiChu.Texts;
            int flag1 = 0;

            if (TinhTrang == "Tình trạng phòng" || DonDep == "Tình trạng dọn dẹp" || LoaiPhong == "Loại phòng" || MaPH == "")
            {
                CTMessageBox.Show("Vui lòng nhập đầy đủ thông tin phòng.", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                if (ctTextBoxMaPH.Texts.Length != 4 && !ctTextBoxMaPH.Texts.StartsWith("P"))
                {
                    CTMessageBox.Show("Mã phòng sai cú pháp\r\n Vui lòng nhập theo cú pháp P+ tầng + mã phòng VD: P100", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    flag1 = 1;
                    return;
                }
                int flag = 0;
                for (int i = 1; i <= 5; i++)
                {

                    if (int.Parse(ctTextBoxMaPH.Texts[1] + "") == i)
                    {
                        flag = 1;
                        break;
                    }
                }
                if (flag == 0)
                {
                    CTMessageBox.Show("Số tầng tối đa trong khách sạn chỉ là 5", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    flag1 = 1;
                    return;
                }
                List<Phong> phongs = PhongBUS.Instance.GetAllPhong();
                Phong phong = phongs.Where(p => p.MaPH == MaPH).SingleOrDefault();
                if (phong != null)
                {
                    string Maph1 = phongs.Where(p => p.MaPH.StartsWith("P" + MaPH[1])).LastOrDefault().MaPH;
                    CTMessageBox.Show("Đã tồn tại phòng này trên tầng \r\n Phòng tối đa trong tầng là: " + Maph1, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    flag1 = 1;
                    return;
                }
                Phong phong1 = new Phong();
                phong1.MaPH = MaPH;
                phong1.DaXoa = false;
                phong1.GhiChu = GhiChu;
                if (DonDep == "Đã dọn dẹp")
                    phong1.TTDD = "Đã dọn dẹp";
                else
                    phong1.TTDD = "Chưa dọn dẹp";
                if (TinhTrang == "Bình thường")
                    phong1.TTPH = "Bình thường";
                else
                    phong1.TTPH = "Đang sửa chữa";
                if (LoaiPhong == "Thường đơn")
                    phong1.MaLPH = "NOR01";
                else if (LoaiPhong == "Thường đôi")
                    phong1.MaLPH = "NOR02";
                else if (LoaiPhong == "VIP đơn")
                    phong1.MaLPH = "VIP01";
                else
                    phong1.MaLPH = "VIP02";
                PhongBUS.Instance.UpdateOrAdd(phong1);
            }
            catch (Exception)
            {
                CTMessageBox.Show("Đã xảy ra lỗi! Vui lòng thử lại.", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag1 = 1;
            }
            finally
            {
                if (flag1 == 0)
                {
                    CTMessageBox.Show("Thêm thông tin thành công.", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }
    }
}
