using ApplicationSettings;
using Hotel_Management_System.ApplicationSettings;
using Hotel_Management_System.BUS;
using Hotel_Management_System.CustomControl;
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
    public partial class FormThemNhanVien : Form
    {
        //Fields
        private int borderRadius = 20;
        private int borderSize = 2;
        private Color borderColor = Color.White;

        //Constructor
        public FormThemNhanVien()
        {
            this.DoubleBuffered = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);
            InitializeComponent();
        }
        //Control Box

        //Form Move

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //Event Methods
        private void FormThemNhanVien_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void FormThemNhanVien_Activated(object sender, EventArgs e)
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

        private void FormThemNhanVien_Load(object sender, EventArgs e)
        {
            this.ActiveControl = LabelThemNhanVien;
        }

        private void CTTextBoxNhapHoTen__TextChanged(object sender, EventArgs e)
        {
            TextBox textBoxOnlyChu = sender as TextBox;
            textBoxOnlyChu.KeyPress += TextBoxOnlyChu_KeyPress;
        }

        private void TextBoxOnlyChu_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxType.Instance.TextBoxNotNumber(e);
        }

        private void CTTextBoxLuong__TextChanged(object sender, EventArgs e)
        {
            TextBox textBoxMoney = sender as TextBox;
            textBoxMoney.KeyPress += TextBoxMoney_KeyPress;
            TextBoxType.Instance.CurrencyType(sender, e);
        }

        private void TextBoxMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxType.Instance.TextBoxOnlyNumber(e);
        }

        private void ctTextBoxSDT__TextChanged(object sender, EventArgs e)
        {
            TextBox textBoxOnlyNum = sender as TextBox;
            textBoxOnlyNum.MaxLength = 10;
            textBoxOnlyNum.KeyPress += TextBoxOnlyNum_KeyPress;
        }

        private void CTTextBoxNhapCCCD__TextChanged(object sender, EventArgs e)
        {
            TextBox textBoxOnlyNum = sender as TextBox;
            textBoxOnlyNum.MaxLength = 12;
            textBoxOnlyNum.KeyPress += TextBoxOnlyNum_KeyPress;
        }

        private void TextBoxOnlyNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxType.Instance.TextBoxOnlyNumber(e);

        }

        private void CTButtonCapNhat_Click(object sender, EventArgs e)
        {
            string HoTen = CTTextBoxNhapHoTen.Texts;
            //string ChucVu = CTTextBoxNhapChucVu.Texts;
            string ChucVu = ComboBoxChucVu.Texts;
            string Luong = CTTextBoxLuong.Texts;
            string SDT = ctTextBoxSDT.Texts;
            string CCCD = CTTextBoxNhapCCCD.Texts;
            string DiaChi = CTTextBoxDiaChi.Texts;
            string email = ctTextBoxEmail.Texts;
            string GioiTinh = ComboBoxGioiTinh.Texts;
            if (HoTen == "" || ChucVu == "" || Luong == "" || SDT == "" || CCCD == "" || DiaChi == "" || email == "" || GioiTinh == "  Giới tính")
            {
                CTMessageBox.Show("Vui lòng nhập đầy đủ thông tin nhân viên.", "Thông báo",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                NhanVien nhanVien = new NhanVien();
                List<NhanVien> nhanViens = NhanVienBUS.Instance.GetNhanViens();
                if (nhanViens.Where(p => p.CCCD == this.CTTextBoxNhapCCCD.Texts).SingleOrDefault() != null)
                {
                    if (nhanVien.CCCD == this.CTTextBoxNhapCCCD.Texts)
                    {
                        CTMessageBox.Show("Đã tồn tại số CCCD này trong danh sách nhân viên! Vui lòng kiểm tra lại thông tin.", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else if (nhanVien.SDT == this.ctTextBoxSDT.Texts)
                    {
                        CTMessageBox.Show("Đã tồn tại SĐT này trong danh sách nhân viên! Vui lòng kiểm tra lại thông tin.", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                try
                {
                    //nhanVien.MaNV = NhanVienBUS.Instance.GetMaNVNext();
                    nhanVien.MaNV = NhanVienBUS.Instance.GetMaNVNextAdvance(this.ComboBoxChucVu.Texts.Trim(' '));
                    nhanVien.ChucVu = ChucVu;
                    nhanVien.CCCD = CCCD;
                    nhanVien.GioiTinh = this.ComboBoxGioiTinh.Texts.Trim(' ');
                    nhanVien.NgaySinh = this.ctDatePicker1.Value;
                    nhanVien.Email = email;
                    nhanVien.SDT = SDT;
                    nhanVien.DiaChi = DiaChi;
                    nhanVien.TenNV = HoTen;
                    nhanVien.Luong = decimal.Parse(Luong.Trim(','));
                    NhanVienBUS.Instance.UpdateOrInsert(nhanVien);

                    CTMessageBox.Show("Thêm thông tin thành công.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    CTMessageBox.Show("Đã xảy ra lỗi! Vui lòng thử lại.", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {

                }
            }
            catch (Exception)
            {
                CTMessageBox.Show("Đã xảy ra lỗi! Vui lòng thử lại.", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ctTextBoxSDT_Load(object sender, EventArgs e)
        {

        }
    }
}
