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
    public partial class FormSuaNhanVien : Form
    {
        //Fields
        private int borderRadius = 20;
        private int borderSize = 2;
        private Color borderColor = Color.White;
        NhanVien nhanVien;
        //Constructor
        public FormSuaNhanVien()
        {
            this.DoubleBuffered = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);
            InitializeComponent();
        }
        public FormSuaNhanVien(NhanVien nhanVien)
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
       
        private void LoadForm()
        {
            this.CTTextBoxNhapCCCD.RemovePlaceholder();
            this.CTTextBoxNhapChucVu.RemovePlaceholder();
            this.ctTextBoxEmail.RemovePlaceholder();
            this.ctTextBoxSDT.RemovePlaceholder();
            this.CTTextBoxDiaChi.RemovePlaceholder();
            this.CTTextBoxNhapHoTen.RemovePlaceholder();
            this.CTTextBoxLuong.RemovePlaceholder();

            this.CTTextBoxNhapCCCD.Texts = this.nhanVien.CCCD;
            this.ComboBoxGioiTinh.Texts = "  " + this.nhanVien.GioiTinh;
            this.CTTextBoxNhapChucVu.Texts = this.nhanVien.ChucVu;
            this.ctDatePicker1.Value = this.nhanVien.NgaySinh;
            this.ctTextBoxEmail.Texts = this.nhanVien.Email;
            this.ctTextBoxSDT.Texts = this.nhanVien.SDT;
            this.CTTextBoxDiaChi.Texts = this.nhanVien.DiaChi;
            this.CTTextBoxNhapHoTen.Texts = this.nhanVien.TenNV;
            this.CTTextBoxLuong.Texts = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C0}", this.nhanVien.Luong).Trim('$');
        }
        

        private void FormSuaNhanVien_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void FormSuaNhanVien_Resize(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void FormSuaNhanVien_SizeChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void FormSuaNhanVien_Activated(object sender, EventArgs e)
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

        private void FormSuaNhanVien_Load(object sender, EventArgs e)
        {
            this.ActiveControl = LabelSuaNhanVien;
        }

        private void CTButtonCapNhat_Click(object sender, EventArgs e)
        {
            string HoTen = CTTextBoxNhapHoTen.Texts;
            string ChucVu = CTTextBoxNhapChucVu.Texts;
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
                foreach (NhanVien nhanVien in NhanVienBUS.Instance.GetAllNhanViens())
                {
                    if (nhanVien.CCCD == this.CTTextBoxNhapCCCD.Texts && nhanVien.MaNV != this.nhanVien.MaNV)
                    {
                        CTMessageBox.Show("Đã tồn tại số CCCD này trong danh sách nhân viên! Vui lòng kiểm tra lại thông tin.", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else if (nhanVien.SDT == this.ctTextBoxSDT.Texts && nhanVien.MaNV != this.nhanVien.MaNV)
                    {
                        CTMessageBox.Show("Đã tồn tại SĐT này trong danh sách nhân viên! Vui lòng kiểm tra lại thông tin.", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                try
                {
                    this.nhanVien.ChucVu = ChucVu;
                    this.nhanVien.CCCD = CCCD;
                    this.nhanVien.GioiTinh = this.ComboBoxGioiTinh.Texts.Trim(' ');
                    this.nhanVien.NgaySinh = this.ctDatePicker1.Value;
                    this.nhanVien.Email = email;
                    this.nhanVien.SDT = SDT;
                    this.nhanVien.DiaChi = DiaChi;
                    this.nhanVien.TenNV = HoTen;
                    NhanVienBUS.Instance.UpdateOrInsert(nhanVien);
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
            catch (Exception)
            {
                CTMessageBox.Show("Đã xảy ra lỗi! Vui lòng thử lại.", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            textBoxMoney.TextChanged += TextBoxMoney_TextChanged;
        }

        private void TextBoxMoney_TextChanged(object sender, EventArgs e)
        {
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

        private void TextBoxOnlyNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxType.Instance.TextBoxOnlyNumber(e);

        }

        private void CTTextBoxNhapCCCD_Load(object sender, EventArgs e)
        {

        }

        private void CTTextBoxNhapCCCD__TextChanged(object sender, EventArgs e)
        {
            TextBox textBoxOnlyNum = sender as TextBox;
            textBoxOnlyNum.MaxLength = 12;
            textBoxOnlyNum.KeyPress += TextBoxOnlyNum_KeyPress;
        }
    }
}
