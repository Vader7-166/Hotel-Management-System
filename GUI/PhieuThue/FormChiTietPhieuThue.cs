using Hotel_Management_System.BUS;
using Hotel_Management_System.CustomControl;
using Hotel_Management_System.DTO;
using Hotel_Management_System.GUI.SoDoPhong;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System.GUI
{
    public partial class FormChiTietPhieuThue : Form
    {
        private Image delete = Properties.Resources.delete;
        private PhieuThue phieuThue;
        public FormChiTietPhieuThue()
        {
            InitializeComponent();
        }
        public FormChiTietPhieuThue(PhieuThue phieuThue)
        {
            this.phieuThue = phieuThue;
            InitializeComponent();
        }

        private void FormChiTietPhieuThue_Load(object sender, EventArgs e)
        {
            grid.ColumnHeadersDefaultCellStyle.Font = new Font(grid.Font, FontStyle.Bold);
            this.LabelNhanVienLapPhieu.Text = this.phieuThue.NhanVien.TenNV;
            this.LabelChiTietPhieuThueTieuDe.Text = this.phieuThue.MaPT;
            this.LabelTen.Text = this.phieuThue.KhachHang.TenKH;
            this.LabelThoiGianLapPhieu.Text = this.phieuThue.NgPT.ToString("dd/MM/yyyy hh:mm");
            LoadGrid();
        }
        private void LoadGrid()
        {
            grid.Rows.Clear();
            List<CTDP> ctdps = CTDP_BUS.Instance.GetCTDPs().Where(p => p.MaPT == phieuThue.MaPT && p.DaXoa == false).ToList();

            foreach (CTDP cTDP in ctdps)
            {
                string TrangThai;
                if (cTDP.TrangThai == "Đang thuê")
                    TrangThai = cTDP.TrangThai;
                else if (cTDP.TrangThai == "Đã xong")
                    TrangThai = "Hoàn thành";
                else
                    TrangThai = cTDP.TrangThai;
                grid.Rows.Add(new object[] { cTDP.MaPH, cTDP.CheckIn.ToString("dd/MM/yyyy hh:mm:ss"), cTDP.CheckOut.ToString("dd/MM/yyyy hh:mm:ss"), TrangThai, this.delete });
            }
        }

        private void grid_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            int y = e.RowIndex, x = e.ColumnIndex;
            if (y == -1 && x == 0 || y >= 0 && x == 4)
                grid.Cursor = Cursors.Hand;
            else
                grid.Cursor = Cursors.Default;
        }

        private void grid_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            grid.Cursor = Cursors.Default;
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int y = e.RowIndex, x = e.ColumnIndex;
            if (y >= 0 && x == 4)
            {
                // If click Delete button
                DialogResult dialogresult = CTMessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo",
                                             MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogresult == DialogResult.Yes)
                {
                    try
                    {
                        DateTime date = DateTime.ParseExact(grid.Rows[y].Cells[1].Value.ToString(), "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
                        CTDP cTDP = CTDP_BUS.Instance.GetCTDPs().Where(p => p.MaPT == phieuThue.MaPT).ToList()[y];
                        if (cTDP.TrangThai == "Đã xong")
                        {
                            CTMessageBox.Show("Thông tin đặt phòng này không hủy được do đã hoàn thành!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else if (cTDP.TrangThai == "Đang thuê")
                        {
                            CTMessageBox.Show("Thông tin đặt phòng này không hủy được do đang thuê!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        cTDP.TrangThai = "Đã hủy";
                        cTDP.DaXoa = true;
                        CTDP_BUS.Instance.RemoveCTDP(cTDP);
                        this.LoadGrid();
                        CTMessageBox.Show("Xóa thông tin thành công.", "Thông báo",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {

                    }
                }
            }
        }

        private void CTButtonThemPT_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormDatPhong formDatPhong = new FormDatPhong(null, this.phieuThue))
                {
                    formDatPhong.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                CTMessageBox.Show(ex.Message, "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
            }
        }

        private void CTButtonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
