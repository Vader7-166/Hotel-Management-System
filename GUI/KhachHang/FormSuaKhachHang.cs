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
    public partial class FormSuaKhachHang : Form
    {
        //Fields
        private int borderRadius = 20;
        private int borderSize = 2;
        private Color borderColor = Color.White;
        KhachHang khachHang;
        FormDanhSachKhachHang formDanhSachKhachHang;
        public FormSuaKhachHang()
        {
            this.DoubleBuffered = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);
            InitializeComponent();
        }

        public FormSuaKhachHang(KhachHang khachHang, FormDanhSachKhachHang formDanhSachKhachHang)
        {
            this.DoubleBuffered = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);
            this.khachHang = khachHang;
            this.formDanhSachKhachHang = formDanhSachKhachHang;
            InitializeComponent();
            LoadForm();
        }

        private void LoadForm() //load thoong tin khách hàng trong phiên hiện tại
        {
            this.ctTextBoxName.RemovePlaceholder();
            this.ctTextBoxQuocTich.RemovePlaceholder();
            this.ctTextBoxCCCD.RemovePlaceholder();
            this.ctTextBoxSDT.RemovePlaceholder();

            this.ctTextBoxName.Texts = this.khachHang.TenKH;
            this.ctTextBoxQuocTich.Texts = this.khachHang.QuocTich;
            this.ctTextBoxCCCD.Texts = this.khachHang.CCCD_Passport;
            this.comboBoxGioiTinh.Texts = "  " + this.khachHang.GioiTinh;
            this.ctTextBoxSDT.Texts = this.khachHang.SDT;
        }
        //Control Box

        //Form Move

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        
        //Event Methods
        private void FormSuaKhachHang_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void FormSuaKhachHang_Resize(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void FormSuaKhachHang_SizeChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void FormSuaKhachHang_Activated(object sender, EventArgs e)
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


        //troll func
        private void PanelTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void CTButtonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ctTextBoxName__TextChanged(object sender, EventArgs e)
        {
            TextBox textBoxName = sender as TextBox;
            textBoxName.KeyPress += TextBoxName_KeyPress; //gán sự kiện EKyPress với hàm xử lí sự kiện KeyPressPhias bên dưới
        }

        private void TextBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxType.Instance.TextBoxNotNumber(e); //không cho phép nhập số
        }

        //private void ctTextBox2__TextChanged(object sender, EventArgs e)
        //{

        //}
        private void ctTextBoxCCCD__TextChanged(object sender, EventArgs e)
        {
            TextBox textBoxCCCD = sender as TextBox;
            textBoxCCCD.MaxLength = 12;
            textBoxCCCD.KeyPress += TextBoxCCCD_KeyPress;
        }

        private void TextBoxCCCD_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxType.Instance.TextBoxOnlyNumber(e);
        }

        private void CTButtonCapNhat_Click(object sender, EventArgs e)
        {
            if (this.ctTextBoxName.Texts != "" && this.ctTextBoxQuocTich.Texts != "" && this.ctTextBoxCCCD.Texts != "" && this.comboBoxGioiTinh.Texts != "  Giới tính")
            {
                if (ctTextBoxCCCD.Texts.Length != 12 && ctTextBoxCCCD.Texts.Length != 7)
                {
                    CTMessageBox.Show("Vui lòng nhập đầy đủ số CCCD/Passport.", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (ctTextBoxSDT.Texts.Length != 10)
                {
                    CTMessageBox.Show("Vui lòng nhập đầy đủ SĐT.", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                List<KhachHang> khachHangs = KhachHangBUS.Instance.GetKhachHangs();
                foreach (KhachHang khachHang in khachHangs)
                {
                    if (khachHang.CCCD_Passport == this.ctTextBoxCCCD.Texts && this.khachHang.CCCD_Passport != this.ctTextBoxCCCD.Texts)
                    {
                        CTMessageBox.Show("Đã tồn tại số CCCD/Passport này trong danh sách khách hàng! Vui lòng kiểm tra lại thông tin.", "Thông báo",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                try
                {
                    khachHang.TenKH = this.ctTextBoxName.Texts;
                    khachHang.QuocTich = this.ctTextBoxQuocTich.Texts;
                    khachHang.CCCD_Passport = this.ctTextBoxCCCD.Texts;
                    khachHang.SDT = this.ctTextBoxSDT.Texts;
                    khachHang.GioiTinh = this.comboBoxGioiTinh.Texts.Trim(' ');
                    KhachHangBUS.Instance.UpdateOrAdd(khachHang);

                    CTMessageBox.Show("Cập nhật thông tin thành công.", "Thông báo",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.formDanhSachKhachHang.LoadAllGrid();
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
            else
                CTMessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng.", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //private void ctTextBoxSDT__TextChanged(object sender, EventArgs e)
        //{

        //}
        private void ctTextBoxSDT__TextChanged(object sender, EventArgs e)
        {
            TextBox textBoxSDT = sender as TextBox;
            textBoxSDT.MaxLength = 10;
            textBoxSDT.KeyPress += TextBoxSDT_KeyPress;
        }

        private void TextBoxSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxType.Instance.TextBoxOnlyNumber(e);
        }

        //private void ctTextBoxQuocTich__TextChanged(object sender, EventArgs e)
        //{

        //}
        private void ctTextBoxQuocTich__TextChanged_1(object sender, EventArgs e)
        {
            TextBox textBoxQuocTich = sender as TextBox;
            textBoxQuocTich.KeyPress += TextBoxQuocTich_KeyPress;
        }

        private void TextBoxQuocTich_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxType.Instance.TextBoxNotNumber(e);
        }

        private void FormSuaKhachHang_Load(object sender, EventArgs e)
        {
            this.ActiveControl = labelSuaKhachHang;
        }


    }
}
