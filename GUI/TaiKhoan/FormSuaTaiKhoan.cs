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
    public partial class FormSuaTaiKhoan : Form
    {
        //Fields
        private int borderRadius = 20;
        private int borderSize = 2;
        private Color borderColor = Color.White;
        private TaiKhoan taiKhoan;
        //Constructor
        public FormSuaTaiKhoan()
        {
            this.DoubleBuffered = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);
            InitializeComponent();
        }
        public FormSuaTaiKhoan(TaiKhoan taiKhoan)
        {
            this.DoubleBuffered = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);
            this.taiKhoan = taiKhoan;
            InitializeComponent();
            LoadForm();
        }
        //Control Box

        //Form Move

        //Drag Form
        #region Draw form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        
        //Event Methods
        private void FormSuaTaiKhoan_Paint(object sender, PaintEventArgs e)
        {
            
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

        private void FormSuaTaiKhoan_Load(object sender, EventArgs e)
        {
            this.ActiveControl = LabelSuaTaiKhoan;
            CTTextBoxNhapMatKhau.PasswordChar = true;
        }
        #endregion
        private void LoadForm()
        {
            ctTextBoxMaNV.RemovePlaceholder();
            CTTextBoxNhapTenTaiKhoan.RemovePlaceholder();
            CTTextBoxNhapMatKhau.RemovePlaceholder();
            ctTextBoxMaNV.Texts = taiKhoan.MaNV;
            CTTextBoxNhapTenTaiKhoan.Texts = taiKhoan.TenTK;
            CTTextBoxNhapMatKhau.Texts = taiKhoan.Password;
            if (taiKhoan.CapDoQuyen == 3)
            {
                comboBoxCapDoQuyen.Texts = "  Admin";
            }
            else if (taiKhoan.CapDoQuyen == 2)
            {
                comboBoxCapDoQuyen.Texts = "  Quản lý";
            }
            else
                comboBoxCapDoQuyen.Texts = "  Lễ tân";
        }
        private void CTButtonCapNhat_Click(object sender, EventArgs e)
        {
            string MaNV = ctTextBoxMaNV.Texts;
            string TenTK = CTTextBoxNhapTenTaiKhoan.Texts;
            string MK = CTTextBoxNhapMatKhau.Texts;
            string CapDoQuyen = comboBoxCapDoQuyen.Texts;
            if (MaNV == "" || TenTK == "" || MK == "" || CapDoQuyen == "  Cấp độ quyền")
            {
                CTMessageBox.Show("Vui lòng nhập đầy đủ thông tin tài khoản.", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                taiKhoan.Password = MK;
                if (CapDoQuyen == "  Admin")
                    taiKhoan.CapDoQuyen = 3;
                else if (CapDoQuyen == "  Quản lý")
                    taiKhoan.CapDoQuyen = 2;
                else
                    taiKhoan.CapDoQuyen = 1;
                TaiKhoanBUS.Instance.AddOrUpdateTK(taiKhoan);
                //TaiKhoanBUS.Instance.UpdateTaiKhoanAndMaNV(taiKhoan);

                CTMessageBox.Show("Cập nhật thông tin thành công.", "Thông báo",
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

        private void CTTextBoxNhapMatKhau__TextChanged(object sender, EventArgs e)
        {
            if (CTTextBoxNhapMatKhau.Texts.Length > 0 && ctEyePassword1.IsShow == false)
            {
                CTTextBoxNhapMatKhau.PasswordChar = true;
            }
        }

        private void ctEyePassword1_Click(object sender, EventArgs e)
        {
            if (ctEyePassword1.IsShow == false)
            {
                ctEyePassword1.IsShow = true;
                CTTextBoxNhapMatKhau.PasswordChar = false;
                ctEyePassword1.BackgroundImage = Properties.Resources.hide;
            }
            else
            {
                ctEyePassword1.IsShow = false;
                if (CTTextBoxNhapMatKhau.Texts != "")
                {
                    CTTextBoxNhapMatKhau.PasswordChar = true;
                }
                ctEyePassword1.BackgroundImage = Properties.Resources.show;
            }
        }
    }
}
