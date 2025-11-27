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
    public partial class FormThemTaiKhoan : Form
    {
        //Fields
        private int borderRadius = 20;
        private int borderSize = 2;
        private Color borderColor = Color.White;

        //Constructor
        public FormThemTaiKhoan()
        {
            this.DoubleBuffered = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);
            InitializeComponent();
            LoadForm();
        }
        //Control Box

        //Form Move
        #region Draw Form
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //Event Methods
        private void FormThemTaiKhoan_Paint(object sender, PaintEventArgs e)
        {
            
        }
        private void FormThemTaiKhoan_Resize(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void FormThemTaiKhoan_SizeChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void FormThemTaiKhoan_Activated(object sender, EventArgs e)
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
        #endregion
        private void FormThemTaiKhoan_Load(object sender, EventArgs e)
        {
            this.ActiveControl = LabelThemTaiKhoan;
            //CTTextBoxNhapMatKhau.PasswordChar = false;
        }

        private void LoadForm()
        {
            try
            {
                this.comboBoxMaNV.Items.Clear();
                List<TaiKhoan> taiKhoans = TaiKhoanBUS.Instance.GetTaiKhoans();
                List<NhanVien> nhanViens = NhanVienBUS.Instance.GetNhanViens();
                foreach(NhanVien nhanVien in nhanViens)
                {
                    if (taiKhoans.Where(p => p.MaNV == nhanVien.MaNV).Any())
                        continue;
                    //comboBoxMaNV.Items.Add("  " + nhanVien.MaNV);
                    comboBoxMaNV.Items.Add(nhanVien.MaNV);
                }    
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CTButtonCapNhat_Click(object sender, EventArgs e)
        {
            string MaNVRaw = comboBoxMaNV.Texts;
            string TenTK = CTTextBoxNhapTenTaiKhoan.Texts;
            string MK = CTTextBoxNhapMatKhau.Texts;
            string CapDoQuyen = comboBoxCapDoQuyen.Texts;
            string MaNV = MaNVRaw.Trim();
            if (string.IsNullOrWhiteSpace(MaNV) || TenTK == "" || MK == "" || CapDoQuyen == "  Cấp độ quyền")
            {
                CTMessageBox.Show("Vui lòng nhập đầy đủ thông tin tài khoản.", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(TaiKhoanBUS.Instance.GetTKDangNhap(TenTK)!=null)
            {
                CTMessageBox.Show("Tên đăng nhập này đã tồn tại.", "Thông báo",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }    
            try
            {
                TaiKhoan taiKhoan = new TaiKhoan();
                taiKhoan.TenTK=TenTK;
                taiKhoan.Password = MK;
                taiKhoan.MaNV=MaNV;

                if (CapDoQuyen == "  Admin")
                    taiKhoan.CapDoQuyen = 3;
                else if (CapDoQuyen == "  Quản lý")
                    taiKhoan.CapDoQuyen = 2;
                else
                    taiKhoan.CapDoQuyen = 1;
                TaiKhoanBUS.Instance.AddOrUpdateTK(taiKhoan);

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

        private void CTTextBoxNhapTenTaiKhoan__TextChanged(object sender, EventArgs e)
        {

        }

        //private void CTTextBoxNhapMatKhau__TextChanged(object sender, EventArgs e)
        //{
        //    TextBox textBoxPasswordConfirm = sender as TextBox;
        //    if (textBoxPasswordConfirm.Focused == false)
        //        textBoxPasswordConfirm.UseSystemPasswordChar = true;
        //    else
        //        textBoxPasswordConfirm.UseSystemPasswordChar = true;
        //}
    }
}
