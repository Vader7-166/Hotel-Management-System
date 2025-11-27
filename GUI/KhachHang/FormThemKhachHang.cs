using ApplicationSettings;
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
    public partial class FormThemKhachHang : Form
    {
        //Fields
        private int borderRadius = 20;
        private int borderSize = 2;
        private Color borderColor = Color.White;
        FormDanhSachKhachHang formDanhSachKhachHang;

        //Constructor
        public FormThemKhachHang()
        {
            this.DoubleBuffered = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);
            InitializeComponent();
        }
        public FormThemKhachHang(FormDanhSachKhachHang formDanhSachKhachHang)
        {
            this.DoubleBuffered = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);
            this.formDanhSachKhachHang = formDanhSachKhachHang;
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
        private void FormThemKhachHang_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void FormThemKhachHang_Resize(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void FormThemKhachHang_SizeChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void FormThemKhachHang_Activated(object sender, EventArgs e)
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

        private void CTButtonCapNhat_Click(object sender, EventArgs e)
        {
            if (this.ctTextBoxName.Texts != "" && this.ctTextBoxQuocTich.Texts != "" && this.ctTextBoxCMND.Texts != "" && this.comboBoxGioiTinh.Texts != "  Giới tính")
            {
                if (ctTextBoxCMND.Texts.Length != 12 && ctTextBoxCMND.Texts.Length != 7)
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
                    if (khachHang.CCCD_Passport == this.ctTextBoxCMND.Texts)
                    {
                        CTMessageBox.Show("Đã tồn tại số CCCD/Passport này trong danh sách khách hàng! Vui lòng kiểm tra lại thông tin.", "Thông báo",
                                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                try
                {
                    KhachHang khachHang1 = new KhachHang();
                    khachHang1.MaKH = KhachHangBUS.Instance.GetMaKHNext();
                    khachHang1.TenKH = this.ctTextBoxName.Texts;
                    khachHang1.QuocTich = this.ctTextBoxQuocTich.Texts;
                    khachHang1.CCCD_Passport = this.ctTextBoxCMND.Texts;
                    khachHang1.SDT = this.ctTextBoxSDT.Texts;
                    khachHang1.GioiTinh = this.comboBoxGioiTinh.Texts.Trim(' ');
                    KhachHangBUS.Instance.UpdateOrAdd(khachHang1);

                    this.formDanhSachKhachHang.LoadAllGrid();
                    CTMessageBox.Show("Thêm thông tin thành công.", "Thông báo",
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
            else
                CTMessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng.", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ctTextBoxName__TextChanged(object sender, EventArgs e)
        {
            TextBox textBoxName = sender as TextBox;
            textBoxName.KeyPress += TextBoxName_KeyPress;
        }

        private void TextBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxType.Instance.TextBoxNotNumber(e);
        }

        private void FormThemKhachHang_Load(object sender, EventArgs e)
        {
            this.ActiveControl = labelThemKhachHang;
        }

        private void ctTextBoxCMND__TextChanged(object sender, EventArgs e)
        {
            TextBox textBoxCCCD = sender as TextBox;
            textBoxCCCD.MaxLength = 12;
            textBoxCCCD.KeyPress += TextBoxCCCD_KeyPress;
        }

        private void TextBoxCCCD_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxType.Instance.TextBoxOnlyNumber(e);
        }

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

        private void ctTextBoxQuocTich__TextChanged(object sender, EventArgs e)
        {
            TextBox textBoxQuocTich = sender as TextBox;
            textBoxQuocTich.KeyPress += TextBoxQuocTich_KeyPress;
        }

        private void TextBoxQuocTich_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxType.Instance.TextBoxNotNumber(e);
        }
    }
}
