using System.Windows.Forms;

namespace Hotel_Management_System.GUI.SoDoPhong
{
    partial class FormSoDoPhong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public class DoubleBufferPanel : Panel
        {
            public DoubleBufferPanel()
            {
                // Set the value of the double-buffering style bits to true.
                this.DoubleBuffered = true;
                this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint |
                ControlStyles.OptimizedDoubleBuffer, true);
                UpdateStyles();
            }
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PanelLocPhong = new Hotel_Management_System.FormLogin.DoubleBufferPanel();
            this.PanelTinhTrangPhong = new Hotel_Management_System.GUI.SoDoPhong.FormSoDoPhong.DoubleBufferPanel();
            this.ctRadioButton1 = new Hotel_Management_System.CustomControl.CTRadioButton();
            this.CTRadioButtonChuaDonDep = new Hotel_Management_System.CustomControl.CTRadioButton();
            this.CTRadioButtonDaDonDep = new Hotel_Management_System.CustomControl.CTRadioButton();
            this.LabelTinhTrangDonDep = new System.Windows.Forms.Label();
            this.PanelLoaiPhong = new Hotel_Management_System.GUI.SoDoPhong.FormSoDoPhong.DoubleBufferPanel();
            this.CTRadioButtonTatCaLoaiPhong = new Hotel_Management_System.CustomControl.CTRadioButton();
            this.CTRadioButtonPhongVIPDoi = new Hotel_Management_System.CustomControl.CTRadioButton();
            this.CTRadioButtonPhongVIPDon = new Hotel_Management_System.CustomControl.CTRadioButton();
            this.CTRadioButtonPhongThuongDoi = new Hotel_Management_System.CustomControl.CTRadioButton();
            this.CTRadioButtonPhongThuongDon = new Hotel_Management_System.CustomControl.CTRadioButton();
            this.LabelLoaiPhong = new System.Windows.Forms.Label();
            this.PanelRadioButtonTrangThaiPhong = new Hotel_Management_System.GUI.SoDoPhong.FormSoDoPhong.DoubleBufferPanel();
            this.CTRadioButtonTatCaPhong = new Hotel_Management_System.CustomControl.CTRadioButton();
            this.CTRadioButtonPhongDangSuaChua = new Hotel_Management_System.CustomControl.CTRadioButton();
            this.CTRadioButtonPhongDangThue = new Hotel_Management_System.CustomControl.CTRadioButton();
            this.CTRadioButtonPhongDaDat = new Hotel_Management_System.CustomControl.CTRadioButton();
            this.CTRadioButtonPhongTrong = new Hotel_Management_System.CustomControl.CTRadioButton();
            this.LabelTrangThaiPhong = new System.Windows.Forms.Label();
            this.ctDatePicker1 = new Hotel_Management_System.CustomControl.CTDatePicker();
            this.PanelTitle = new Hotel_Management_System.GUI.SoDoPhong.FormSoDoPhong.DoubleBufferPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbBoxLetter = new Hotel_Management_System.CustomControl.CTComboBox();
            this.cbBoxGio = new Hotel_Management_System.CustomControl.CTComboBox();
            this.LabelChonNgay = new System.Windows.Forms.Label();
            this.ctTextBox1 = new Hotel_Management_System.CustomControl.CTTextBox();
            this.panelSoDoPhong = new Hotel_Management_System.GUI.SoDoPhong.FormSoDoPhong.DoubleBufferPanel();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.doubleBufferPanel5 = new Hotel_Management_System.FormLogin.DoubleBufferPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.doubleBufferPanel4 = new Hotel_Management_System.FormLogin.DoubleBufferPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.doubleBufferPanel3 = new Hotel_Management_System.FormLogin.DoubleBufferPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.doubleBufferPanel2 = new Hotel_Management_System.FormLogin.DoubleBufferPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.doubleBufferPanel1 = new Hotel_Management_System.FormLogin.DoubleBufferPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.timerSearch = new System.Windows.Forms.Timer(this.components);
            this.timerAppear = new System.Windows.Forms.Timer(this.components);
            this.PanelLocPhong.SuspendLayout();
            this.PanelTinhTrangPhong.SuspendLayout();
            this.PanelLoaiPhong.SuspendLayout();
            this.PanelRadioButtonTrangThaiPhong.SuspendLayout();
            this.PanelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelSoDoPhong.SuspendLayout();
            this.doubleBufferPanel5.SuspendLayout();
            this.doubleBufferPanel4.SuspendLayout();
            this.doubleBufferPanel3.SuspendLayout();
            this.doubleBufferPanel2.SuspendLayout();
            this.doubleBufferPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelLocPhong
            // 
            this.PanelLocPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.PanelLocPhong.Controls.Add(this.PanelTinhTrangPhong);
            this.PanelLocPhong.Controls.Add(this.PanelLoaiPhong);
            this.PanelLocPhong.Controls.Add(this.PanelRadioButtonTrangThaiPhong);
            this.PanelLocPhong.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLocPhong.Location = new System.Drawing.Point(0, 0);
            this.PanelLocPhong.Name = "PanelLocPhong";
            this.PanelLocPhong.Size = new System.Drawing.Size(237, 755);
            this.PanelLocPhong.TabIndex = 2;
            // 
            // PanelTinhTrangPhong
            // 
            this.PanelTinhTrangPhong.Controls.Add(this.ctRadioButton1);
            this.PanelTinhTrangPhong.Controls.Add(this.CTRadioButtonChuaDonDep);
            this.PanelTinhTrangPhong.Controls.Add(this.CTRadioButtonDaDonDep);
            this.PanelTinhTrangPhong.Controls.Add(this.LabelTinhTrangDonDep);
            this.PanelTinhTrangPhong.Location = new System.Drawing.Point(12, 529);
            this.PanelTinhTrangPhong.Name = "PanelTinhTrangPhong";
            this.PanelTinhTrangPhong.Size = new System.Drawing.Size(208, 153);
            this.PanelTinhTrangPhong.TabIndex = 4;
            // 
            // ctRadioButton1
            // 
            this.ctRadioButton1.AutoSize = true;
            this.ctRadioButton1.Checked = true;
            this.ctRadioButton1.CheckedColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ctRadioButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ctRadioButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctRadioButton1.Location = new System.Drawing.Point(12, 103);
            this.ctRadioButton1.MinimumSize = new System.Drawing.Size(0, 21);
            this.ctRadioButton1.Name = "ctRadioButton1";
            this.ctRadioButton1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ctRadioButton1.Size = new System.Drawing.Size(78, 25);
            this.ctRadioButton1.TabIndex = 1;
            this.ctRadioButton1.TabStop = true;
            this.ctRadioButton1.Text = "Tất cả";
            this.ctRadioButton1.UnCheckedColor = System.Drawing.Color.Gray;
            this.ctRadioButton1.UseVisualStyleBackColor = true;
            this.ctRadioButton1.CheckedChanged += new System.EventHandler(this.CTRadioButtonPhongTrong_CheckedChanged);
            // 
            // CTRadioButtonChuaDonDep
            // 
            this.CTRadioButtonChuaDonDep.AutoSize = true;
            this.CTRadioButtonChuaDonDep.CheckedColor = System.Drawing.Color.DodgerBlue;
            this.CTRadioButtonChuaDonDep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CTRadioButtonChuaDonDep.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTRadioButtonChuaDonDep.Location = new System.Drawing.Point(12, 72);
            this.CTRadioButtonChuaDonDep.MinimumSize = new System.Drawing.Size(0, 21);
            this.CTRadioButtonChuaDonDep.Name = "CTRadioButtonChuaDonDep";
            this.CTRadioButtonChuaDonDep.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.CTRadioButtonChuaDonDep.Size = new System.Drawing.Size(135, 25);
            this.CTRadioButtonChuaDonDep.TabIndex = 1;
            this.CTRadioButtonChuaDonDep.Text = "Chưa dọn dẹp";
            this.CTRadioButtonChuaDonDep.UnCheckedColor = System.Drawing.Color.Gray;
            this.CTRadioButtonChuaDonDep.UseVisualStyleBackColor = true;
            this.CTRadioButtonChuaDonDep.CheckedChanged += new System.EventHandler(this.CTRadioButtonPhongTrong_CheckedChanged);
            // 
            // CTRadioButtonDaDonDep
            // 
            this.CTRadioButtonDaDonDep.AutoSize = true;
            this.CTRadioButtonDaDonDep.CheckedColor = System.Drawing.Color.SeaGreen;
            this.CTRadioButtonDaDonDep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CTRadioButtonDaDonDep.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTRadioButtonDaDonDep.Location = new System.Drawing.Point(12, 40);
            this.CTRadioButtonDaDonDep.MinimumSize = new System.Drawing.Size(0, 21);
            this.CTRadioButtonDaDonDep.Name = "CTRadioButtonDaDonDep";
            this.CTRadioButtonDaDonDep.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.CTRadioButtonDaDonDep.Size = new System.Drawing.Size(118, 25);
            this.CTRadioButtonDaDonDep.TabIndex = 1;
            this.CTRadioButtonDaDonDep.Text = "Đã dọp dẹp";
            this.CTRadioButtonDaDonDep.UnCheckedColor = System.Drawing.Color.Gray;
            this.CTRadioButtonDaDonDep.UseVisualStyleBackColor = true;
            this.CTRadioButtonDaDonDep.CheckedChanged += new System.EventHandler(this.CTRadioButtonPhongTrong_CheckedChanged);
            // 
            // LabelTinhTrangDonDep
            // 
            this.LabelTinhTrangDonDep.AutoSize = true;
            this.LabelTinhTrangDonDep.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTinhTrangDonDep.Location = new System.Drawing.Point(7, 6);
            this.LabelTinhTrangDonDep.Name = "LabelTinhTrangDonDep";
            this.LabelTinhTrangDonDep.Size = new System.Drawing.Size(185, 25);
            this.LabelTinhTrangDonDep.TabIndex = 0;
            this.LabelTinhTrangDonDep.Text = "Tình trạng dọn dẹp";
            // 
            // PanelLoaiPhong
            // 
            this.PanelLoaiPhong.Controls.Add(this.CTRadioButtonTatCaLoaiPhong);
            this.PanelLoaiPhong.Controls.Add(this.CTRadioButtonPhongVIPDoi);
            this.PanelLoaiPhong.Controls.Add(this.CTRadioButtonPhongVIPDon);
            this.PanelLoaiPhong.Controls.Add(this.CTRadioButtonPhongThuongDoi);
            this.PanelLoaiPhong.Controls.Add(this.CTRadioButtonPhongThuongDon);
            this.PanelLoaiPhong.Controls.Add(this.LabelLoaiPhong);
            this.PanelLoaiPhong.Location = new System.Drawing.Point(13, 288);
            this.PanelLoaiPhong.Name = "PanelLoaiPhong";
            this.PanelLoaiPhong.Size = new System.Drawing.Size(208, 220);
            this.PanelLoaiPhong.TabIndex = 3;
            // 
            // CTRadioButtonTatCaLoaiPhong
            // 
            this.CTRadioButtonTatCaLoaiPhong.AutoSize = true;
            this.CTRadioButtonTatCaLoaiPhong.Checked = true;
            this.CTRadioButtonTatCaLoaiPhong.CheckedColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CTRadioButtonTatCaLoaiPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CTRadioButtonTatCaLoaiPhong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTRadioButtonTatCaLoaiPhong.Location = new System.Drawing.Point(12, 164);
            this.CTRadioButtonTatCaLoaiPhong.MinimumSize = new System.Drawing.Size(0, 21);
            this.CTRadioButtonTatCaLoaiPhong.Name = "CTRadioButtonTatCaLoaiPhong";
            this.CTRadioButtonTatCaLoaiPhong.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.CTRadioButtonTatCaLoaiPhong.Size = new System.Drawing.Size(156, 25);
            this.CTRadioButtonTatCaLoaiPhong.TabIndex = 1;
            this.CTRadioButtonTatCaLoaiPhong.TabStop = true;
            this.CTRadioButtonTatCaLoaiPhong.Text = "Tất cả loại phòng";
            this.CTRadioButtonTatCaLoaiPhong.UnCheckedColor = System.Drawing.Color.Gray;
            this.CTRadioButtonTatCaLoaiPhong.UseVisualStyleBackColor = true;
            this.CTRadioButtonTatCaLoaiPhong.CheckedChanged += new System.EventHandler(this.CTRadioButtonPhongTrong_CheckedChanged);
            // 
            // CTRadioButtonPhongVIPDoi
            // 
            this.CTRadioButtonPhongVIPDoi.AutoSize = true;
            this.CTRadioButtonPhongVIPDoi.CheckedColor = System.Drawing.Color.DodgerBlue;
            this.CTRadioButtonPhongVIPDoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CTRadioButtonPhongVIPDoi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTRadioButtonPhongVIPDoi.Location = new System.Drawing.Point(12, 133);
            this.CTRadioButtonPhongVIPDoi.MinimumSize = new System.Drawing.Size(0, 21);
            this.CTRadioButtonPhongVIPDoi.Name = "CTRadioButtonPhongVIPDoi";
            this.CTRadioButtonPhongVIPDoi.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.CTRadioButtonPhongVIPDoi.Size = new System.Drawing.Size(136, 25);
            this.CTRadioButtonPhongVIPDoi.TabIndex = 1;
            this.CTRadioButtonPhongVIPDoi.Text = "Phòng VIP đôi";
            this.CTRadioButtonPhongVIPDoi.UnCheckedColor = System.Drawing.Color.Gray;
            this.CTRadioButtonPhongVIPDoi.UseVisualStyleBackColor = true;
            this.CTRadioButtonPhongVIPDoi.CheckedChanged += new System.EventHandler(this.CTRadioButtonPhongTrong_CheckedChanged);
            // 
            // CTRadioButtonPhongVIPDon
            // 
            this.CTRadioButtonPhongVIPDon.AutoSize = true;
            this.CTRadioButtonPhongVIPDon.CheckedColor = System.Drawing.Color.Red;
            this.CTRadioButtonPhongVIPDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CTRadioButtonPhongVIPDon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTRadioButtonPhongVIPDon.Location = new System.Drawing.Point(12, 102);
            this.CTRadioButtonPhongVIPDon.MinimumSize = new System.Drawing.Size(0, 21);
            this.CTRadioButtonPhongVIPDon.Name = "CTRadioButtonPhongVIPDon";
            this.CTRadioButtonPhongVIPDon.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.CTRadioButtonPhongVIPDon.Size = new System.Drawing.Size(142, 25);
            this.CTRadioButtonPhongVIPDon.TabIndex = 1;
            this.CTRadioButtonPhongVIPDon.Text = "Phòng VIP đơn";
            this.CTRadioButtonPhongVIPDon.UnCheckedColor = System.Drawing.Color.Gray;
            this.CTRadioButtonPhongVIPDon.UseVisualStyleBackColor = true;
            this.CTRadioButtonPhongVIPDon.CheckedChanged += new System.EventHandler(this.CTRadioButtonPhongTrong_CheckedChanged);
            // 
            // CTRadioButtonPhongThuongDoi
            // 
            this.CTRadioButtonPhongThuongDoi.AutoSize = true;
            this.CTRadioButtonPhongThuongDoi.CheckedColor = System.Drawing.Color.Goldenrod;
            this.CTRadioButtonPhongThuongDoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CTRadioButtonPhongThuongDoi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTRadioButtonPhongThuongDoi.Location = new System.Drawing.Point(12, 71);
            this.CTRadioButtonPhongThuongDoi.MinimumSize = new System.Drawing.Size(0, 21);
            this.CTRadioButtonPhongThuongDoi.Name = "CTRadioButtonPhongThuongDoi";
            this.CTRadioButtonPhongThuongDoi.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.CTRadioButtonPhongThuongDoi.Size = new System.Drawing.Size(164, 25);
            this.CTRadioButtonPhongThuongDoi.TabIndex = 1;
            this.CTRadioButtonPhongThuongDoi.Text = "Phòng thường đôi";
            this.CTRadioButtonPhongThuongDoi.UnCheckedColor = System.Drawing.Color.Gray;
            this.CTRadioButtonPhongThuongDoi.UseVisualStyleBackColor = true;
            this.CTRadioButtonPhongThuongDoi.CheckedChanged += new System.EventHandler(this.CTRadioButtonPhongTrong_CheckedChanged);
            // 
            // CTRadioButtonPhongThuongDon
            // 
            this.CTRadioButtonPhongThuongDon.AutoSize = true;
            this.CTRadioButtonPhongThuongDon.CheckedColor = System.Drawing.Color.SeaGreen;
            this.CTRadioButtonPhongThuongDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CTRadioButtonPhongThuongDon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTRadioButtonPhongThuongDon.Location = new System.Drawing.Point(12, 40);
            this.CTRadioButtonPhongThuongDon.MinimumSize = new System.Drawing.Size(0, 21);
            this.CTRadioButtonPhongThuongDon.Name = "CTRadioButtonPhongThuongDon";
            this.CTRadioButtonPhongThuongDon.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.CTRadioButtonPhongThuongDon.Size = new System.Drawing.Size(170, 25);
            this.CTRadioButtonPhongThuongDon.TabIndex = 1;
            this.CTRadioButtonPhongThuongDon.Text = "Phòng thường đơn";
            this.CTRadioButtonPhongThuongDon.UnCheckedColor = System.Drawing.Color.Gray;
            this.CTRadioButtonPhongThuongDon.UseVisualStyleBackColor = true;
            this.CTRadioButtonPhongThuongDon.CheckedChanged += new System.EventHandler(this.CTRadioButtonPhongTrong_CheckedChanged);
            // 
            // LabelLoaiPhong
            // 
            this.LabelLoaiPhong.AutoSize = true;
            this.LabelLoaiPhong.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLoaiPhong.Location = new System.Drawing.Point(7, 6);
            this.LabelLoaiPhong.Name = "LabelLoaiPhong";
            this.LabelLoaiPhong.Size = new System.Drawing.Size(113, 25);
            this.LabelLoaiPhong.TabIndex = 0;
            this.LabelLoaiPhong.Text = "Loại phòng";
            // 
            // PanelRadioButtonTrangThaiPhong
            // 
            this.PanelRadioButtonTrangThaiPhong.Controls.Add(this.CTRadioButtonTatCaPhong);
            this.PanelRadioButtonTrangThaiPhong.Controls.Add(this.CTRadioButtonPhongDangSuaChua);
            this.PanelRadioButtonTrangThaiPhong.Controls.Add(this.CTRadioButtonPhongDangThue);
            this.PanelRadioButtonTrangThaiPhong.Controls.Add(this.CTRadioButtonPhongDaDat);
            this.PanelRadioButtonTrangThaiPhong.Controls.Add(this.CTRadioButtonPhongTrong);
            this.PanelRadioButtonTrangThaiPhong.Controls.Add(this.LabelTrangThaiPhong);
            this.PanelRadioButtonTrangThaiPhong.Location = new System.Drawing.Point(12, 40);
            this.PanelRadioButtonTrangThaiPhong.Name = "PanelRadioButtonTrangThaiPhong";
            this.PanelRadioButtonTrangThaiPhong.Size = new System.Drawing.Size(208, 220);
            this.PanelRadioButtonTrangThaiPhong.TabIndex = 2;
            // 
            // CTRadioButtonTatCaPhong
            // 
            this.CTRadioButtonTatCaPhong.AutoSize = true;
            this.CTRadioButtonTatCaPhong.Checked = true;
            this.CTRadioButtonTatCaPhong.CheckedColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CTRadioButtonTatCaPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CTRadioButtonTatCaPhong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTRadioButtonTatCaPhong.Location = new System.Drawing.Point(12, 164);
            this.CTRadioButtonTatCaPhong.MinimumSize = new System.Drawing.Size(0, 21);
            this.CTRadioButtonTatCaPhong.Name = "CTRadioButtonTatCaPhong";
            this.CTRadioButtonTatCaPhong.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.CTRadioButtonTatCaPhong.Size = new System.Drawing.Size(127, 25);
            this.CTRadioButtonTatCaPhong.TabIndex = 1;
            this.CTRadioButtonTatCaPhong.TabStop = true;
            this.CTRadioButtonTatCaPhong.Text = "Tất cả phòng";
            this.CTRadioButtonTatCaPhong.UnCheckedColor = System.Drawing.Color.Gray;
            this.CTRadioButtonTatCaPhong.UseVisualStyleBackColor = true;
            this.CTRadioButtonTatCaPhong.CheckedChanged += new System.EventHandler(this.CTRadioButtonPhongTrong_CheckedChanged);
            // 
            // CTRadioButtonPhongDangSuaChua
            // 
            this.CTRadioButtonPhongDangSuaChua.AutoSize = true;
            this.CTRadioButtonPhongDangSuaChua.CheckedColor = System.Drawing.Color.DodgerBlue;
            this.CTRadioButtonPhongDangSuaChua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CTRadioButtonPhongDangSuaChua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTRadioButtonPhongDangSuaChua.Location = new System.Drawing.Point(12, 133);
            this.CTRadioButtonPhongDangSuaChua.MinimumSize = new System.Drawing.Size(0, 21);
            this.CTRadioButtonPhongDangSuaChua.Name = "CTRadioButtonPhongDangSuaChua";
            this.CTRadioButtonPhongDangSuaChua.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.CTRadioButtonPhongDangSuaChua.Size = new System.Drawing.Size(187, 25);
            this.CTRadioButtonPhongDangSuaChua.TabIndex = 1;
            this.CTRadioButtonPhongDangSuaChua.Text = "Phòng đang sửa chữa";
            this.CTRadioButtonPhongDangSuaChua.UnCheckedColor = System.Drawing.Color.Gray;
            this.CTRadioButtonPhongDangSuaChua.UseVisualStyleBackColor = true;
            this.CTRadioButtonPhongDangSuaChua.CheckedChanged += new System.EventHandler(this.CTRadioButtonPhongTrong_CheckedChanged);
            // 
            // CTRadioButtonPhongDangThue
            // 
            this.CTRadioButtonPhongDangThue.AutoSize = true;
            this.CTRadioButtonPhongDangThue.CheckedColor = System.Drawing.Color.Red;
            this.CTRadioButtonPhongDangThue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CTRadioButtonPhongDangThue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTRadioButtonPhongDangThue.Location = new System.Drawing.Point(12, 102);
            this.CTRadioButtonPhongDangThue.MinimumSize = new System.Drawing.Size(0, 21);
            this.CTRadioButtonPhongDangThue.Name = "CTRadioButtonPhongDangThue";
            this.CTRadioButtonPhongDangThue.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.CTRadioButtonPhongDangThue.Size = new System.Drawing.Size(157, 25);
            this.CTRadioButtonPhongDangThue.TabIndex = 1;
            this.CTRadioButtonPhongDangThue.Text = "Phòng đang thuê";
            this.CTRadioButtonPhongDangThue.UnCheckedColor = System.Drawing.Color.Gray;
            this.CTRadioButtonPhongDangThue.UseVisualStyleBackColor = true;
            this.CTRadioButtonPhongDangThue.CheckedChanged += new System.EventHandler(this.CTRadioButtonPhongTrong_CheckedChanged);
            // 
            // CTRadioButtonPhongDaDat
            // 
            this.CTRadioButtonPhongDaDat.AutoSize = true;
            this.CTRadioButtonPhongDaDat.CheckedColor = System.Drawing.Color.Goldenrod;
            this.CTRadioButtonPhongDaDat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CTRadioButtonPhongDaDat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTRadioButtonPhongDaDat.Location = new System.Drawing.Point(12, 71);
            this.CTRadioButtonPhongDaDat.MinimumSize = new System.Drawing.Size(0, 21);
            this.CTRadioButtonPhongDaDat.Name = "CTRadioButtonPhongDaDat";
            this.CTRadioButtonPhongDaDat.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.CTRadioButtonPhongDaDat.Size = new System.Drawing.Size(130, 25);
            this.CTRadioButtonPhongDaDat.TabIndex = 1;
            this.CTRadioButtonPhongDaDat.Text = "Phòng đã đặt";
            this.CTRadioButtonPhongDaDat.UnCheckedColor = System.Drawing.Color.Gray;
            this.CTRadioButtonPhongDaDat.UseVisualStyleBackColor = true;
            this.CTRadioButtonPhongDaDat.CheckedChanged += new System.EventHandler(this.CTRadioButtonPhongTrong_CheckedChanged);
            // 
            // CTRadioButtonPhongTrong
            // 
            this.CTRadioButtonPhongTrong.AutoSize = true;
            this.CTRadioButtonPhongTrong.CheckedColor = System.Drawing.Color.SeaGreen;
            this.CTRadioButtonPhongTrong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CTRadioButtonPhongTrong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTRadioButtonPhongTrong.Location = new System.Drawing.Point(12, 40);
            this.CTRadioButtonPhongTrong.MinimumSize = new System.Drawing.Size(0, 21);
            this.CTRadioButtonPhongTrong.Name = "CTRadioButtonPhongTrong";
            this.CTRadioButtonPhongTrong.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.CTRadioButtonPhongTrong.Size = new System.Drawing.Size(125, 25);
            this.CTRadioButtonPhongTrong.TabIndex = 1;
            this.CTRadioButtonPhongTrong.Text = "Phòng trống";
            this.CTRadioButtonPhongTrong.UnCheckedColor = System.Drawing.Color.Gray;
            this.CTRadioButtonPhongTrong.UseVisualStyleBackColor = true;
            this.CTRadioButtonPhongTrong.CheckedChanged += new System.EventHandler(this.CTRadioButtonPhongTrong_CheckedChanged);
            // 
            // LabelTrangThaiPhong
            // 
            this.LabelTrangThaiPhong.AutoSize = true;
            this.LabelTrangThaiPhong.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTrangThaiPhong.Location = new System.Drawing.Point(7, 6);
            this.LabelTrangThaiPhong.Name = "LabelTrangThaiPhong";
            this.LabelTrangThaiPhong.Size = new System.Drawing.Size(166, 25);
            this.LabelTrangThaiPhong.TabIndex = 0;
            this.LabelTrangThaiPhong.Text = "Trạng thái phòng";
            // 
            // ctDatePicker1
            // 
            this.ctDatePicker1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(96)))), ((int)(((byte)(116)))));
            this.ctDatePicker1.BorderSize = 2;
            this.ctDatePicker1.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctDatePicker1.CustomFormat = "dd/MM/yyyy";
            this.ctDatePicker1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctDatePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ctDatePicker1.Location = new System.Drawing.Point(17, 15);
            this.ctDatePicker1.MinimumSize = new System.Drawing.Size(4, 35);
            this.ctDatePicker1.Name = "ctDatePicker1";
            this.ctDatePicker1.Size = new System.Drawing.Size(163, 35);
            this.ctDatePicker1.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.ctDatePicker1.TabIndex = 3;
            this.ctDatePicker1.TextColor = System.Drawing.Color.Black;
            this.ctDatePicker1.ValueChanged += new System.EventHandler(this.ctDatePicker1_ValueChanged);
            // 
            // PanelTitle
            // 
            this.PanelTitle.Controls.Add(this.pictureBox1);
            this.PanelTitle.Controls.Add(this.label7);
            this.PanelTitle.Controls.Add(this.cbBoxLetter);
            this.PanelTitle.Controls.Add(this.cbBoxGio);
            this.PanelTitle.Controls.Add(this.LabelChonNgay);
            this.PanelTitle.Controls.Add(this.ctDatePicker1);
            this.PanelTitle.Controls.Add(this.ctTextBox1);
            this.PanelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitle.Location = new System.Drawing.Point(237, 0);
            this.PanelTitle.Name = "PanelTitle";
            this.PanelTitle.Size = new System.Drawing.Size(991, 53);
            this.PanelTitle.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.pictureBox1.Image = global::Hotel_Management_System.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(644, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(256, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 15);
            this.label7.TabIndex = 42;
            this.label7.Text = "Chọn giờ";
            // 
            // cbBoxLetter
            // 
            this.cbBoxLetter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.cbBoxLetter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(96)))), ((int)(((byte)(116)))));
            this.cbBoxLetter.BorderSize = 2;
            this.cbBoxLetter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoxLetter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBoxLetter.ForeColor = System.Drawing.Color.Black;
            this.cbBoxLetter.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(145)))), ((int)(((byte)(175)))));
            this.cbBoxLetter.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.cbBoxLetter.ListTextColor = System.Drawing.Color.Black;
            this.cbBoxLetter.Location = new System.Drawing.Point(286, 15);
            this.cbBoxLetter.Name = "cbBoxLetter";
            this.cbBoxLetter.Padding = new System.Windows.Forms.Padding(2);
            this.cbBoxLetter.Size = new System.Drawing.Size(80, 35);
            this.cbBoxLetter.TabIndex = 43;
            this.cbBoxLetter.Texts = "  AM";
            this.cbBoxLetter.OnSelectedIndexChanged += new System.EventHandler(this.cbBoxLetter_OnSelectedIndexChanged);
            // 
            // cbBoxGio
            // 
            this.cbBoxGio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.cbBoxGio.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(96)))), ((int)(((byte)(116)))));
            this.cbBoxGio.BorderSize = 2;
            this.cbBoxGio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoxGio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBoxGio.ForeColor = System.Drawing.Color.Black;
            this.cbBoxGio.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(145)))), ((int)(((byte)(175)))));
            this.cbBoxGio.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.cbBoxGio.ListTextColor = System.Drawing.Color.Black;
            this.cbBoxGio.Location = new System.Drawing.Point(208, 15);
            this.cbBoxGio.Name = "cbBoxGio";
            this.cbBoxGio.Padding = new System.Windows.Forms.Padding(2);
            this.cbBoxGio.Size = new System.Drawing.Size(80, 35);
            this.cbBoxGio.TabIndex = 42;
            this.cbBoxGio.Texts = "12:0";
            this.cbBoxGio.OnSelectedIndexChanged += new System.EventHandler(this.cbBoxGio_OnSelectedIndexChanged);
            // 
            // LabelChonNgay
            // 
            this.LabelChonNgay.AutoSize = true;
            this.LabelChonNgay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelChonNgay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelChonNgay.Location = new System.Drawing.Point(46, 5);
            this.LabelChonNgay.Name = "LabelChonNgay";
            this.LabelChonNgay.Size = new System.Drawing.Size(65, 15);
            this.LabelChonNgay.TabIndex = 11;
            this.LabelChonNgay.Text = "Chọn ngày";
            // 
            // ctTextBox1
            // 
            this.ctTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.ctTextBox1.BorderColor = System.Drawing.Color.DarkGray;
            this.ctTextBox1.BorderFocusColor = System.Drawing.Color.DimGray;
            this.ctTextBox1.BorderRadius = 5;
            this.ctTextBox1.BorderSize = 1;
            this.ctTextBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctTextBox1.IsFocused = false;
            this.ctTextBox1.Location = new System.Drawing.Point(635, 15);
            this.ctTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.ctTextBox1.Multiline = false;
            this.ctTextBox1.Name = "ctTextBox1";
            this.ctTextBox1.Padding = new System.Windows.Forms.Padding(40, 7, 7, 7);
            this.ctTextBox1.PasswordChar = false;
            this.ctTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.ctTextBox1.PlaceholderText = "Nhập mã phòng cần tìm";
            this.ctTextBox1.ReadOnly = false;
            this.ctTextBox1.Size = new System.Drawing.Size(235, 36);
            this.ctTextBox1.TabIndex = 1;
            this.ctTextBox1.Texts = "";
            this.ctTextBox1.UnderlineedStyle = false;
            this.ctTextBox1._TextChanged += new System.EventHandler(this.ctTextBox1__TextChanged);
            // 
            // panelSoDoPhong
            // 
            this.panelSoDoPhong.AutoScroll = true;
            this.panelSoDoPhong.Controls.Add(this.flowLayoutPanel5);
            this.panelSoDoPhong.Controls.Add(this.doubleBufferPanel5);
            this.panelSoDoPhong.Controls.Add(this.flowLayoutPanel4);
            this.panelSoDoPhong.Controls.Add(this.doubleBufferPanel4);
            this.panelSoDoPhong.Controls.Add(this.flowLayoutPanel3);
            this.panelSoDoPhong.Controls.Add(this.doubleBufferPanel3);
            this.panelSoDoPhong.Controls.Add(this.flowLayoutPanel2);
            this.panelSoDoPhong.Controls.Add(this.doubleBufferPanel2);
            this.panelSoDoPhong.Controls.Add(this.flowLayoutPanel1);
            this.panelSoDoPhong.Controls.Add(this.doubleBufferPanel1);
            this.panelSoDoPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSoDoPhong.Location = new System.Drawing.Point(237, 53);
            this.panelSoDoPhong.Name = "panelSoDoPhong";
            this.panelSoDoPhong.Size = new System.Drawing.Size(991, 702);
            this.panelSoDoPhong.TabIndex = 4;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.AutoSize = true;
            this.flowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(0, 175);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(991, 0);
            this.flowLayoutPanel5.TabIndex = 9;
            // 
            // doubleBufferPanel5
            // 
            this.doubleBufferPanel5.Controls.Add(this.label5);
            this.doubleBufferPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.doubleBufferPanel5.Location = new System.Drawing.Point(0, 140);
            this.doubleBufferPanel5.Name = "doubleBufferPanel5";
            this.doubleBufferPanel5.Size = new System.Drawing.Size(991, 35);
            this.doubleBufferPanel5.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tầng 5";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.AutoSize = true;
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(0, 140);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(991, 0);
            this.flowLayoutPanel4.TabIndex = 7;
            // 
            // doubleBufferPanel4
            // 
            this.doubleBufferPanel4.Controls.Add(this.label4);
            this.doubleBufferPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.doubleBufferPanel4.Location = new System.Drawing.Point(0, 105);
            this.doubleBufferPanel4.Name = "doubleBufferPanel4";
            this.doubleBufferPanel4.Size = new System.Drawing.Size(991, 35);
            this.doubleBufferPanel4.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tầng 4";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 105);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(991, 0);
            this.flowLayoutPanel3.TabIndex = 5;
            // 
            // doubleBufferPanel3
            // 
            this.doubleBufferPanel3.Controls.Add(this.label3);
            this.doubleBufferPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.doubleBufferPanel3.Location = new System.Drawing.Point(0, 70);
            this.doubleBufferPanel3.Name = "doubleBufferPanel3";
            this.doubleBufferPanel3.Size = new System.Drawing.Size(991, 35);
            this.doubleBufferPanel3.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tầng 3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 70);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(991, 0);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // doubleBufferPanel2
            // 
            this.doubleBufferPanel2.Controls.Add(this.label2);
            this.doubleBufferPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.doubleBufferPanel2.Location = new System.Drawing.Point(0, 35);
            this.doubleBufferPanel2.Name = "doubleBufferPanel2";
            this.doubleBufferPanel2.Size = new System.Drawing.Size(991, 35);
            this.doubleBufferPanel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tầng 2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 35);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(991, 0);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // doubleBufferPanel1
            // 
            this.doubleBufferPanel1.Controls.Add(this.label1);
            this.doubleBufferPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.doubleBufferPanel1.Location = new System.Drawing.Point(0, 0);
            this.doubleBufferPanel1.Name = "doubleBufferPanel1";
            this.doubleBufferPanel1.Size = new System.Drawing.Size(991, 35);
            this.doubleBufferPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tầng 1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timerSearch
            // 
            this.timerSearch.Interval = 300;
            this.timerSearch.Tick += new System.EventHandler(this.timerSearch_Tick);
            // 
            // timerAppear
            // 
            this.timerAppear.Enabled = true;
            this.timerAppear.Interval = 500;
            this.timerAppear.Tick += new System.EventHandler(this.timerAppear_Tick);
            // 
            // FormSoDoPhong
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(1228, 755);
            this.Controls.Add(this.panelSoDoPhong);
            this.Controls.Add(this.PanelTitle);
            this.Controls.Add(this.PanelLocPhong);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormSoDoPhong";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FormSoDoPhong";
            this.Load += new System.EventHandler(this.FormSoDoPhong_Load);
            this.PanelLocPhong.ResumeLayout(false);
            this.PanelTinhTrangPhong.ResumeLayout(false);
            this.PanelTinhTrangPhong.PerformLayout();
            this.PanelLoaiPhong.ResumeLayout(false);
            this.PanelLoaiPhong.PerformLayout();
            this.PanelRadioButtonTrangThaiPhong.ResumeLayout(false);
            this.PanelRadioButtonTrangThaiPhong.PerformLayout();
            this.PanelTitle.ResumeLayout(false);
            this.PanelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelSoDoPhong.ResumeLayout(false);
            this.panelSoDoPhong.PerformLayout();
            this.doubleBufferPanel5.ResumeLayout(false);
            this.doubleBufferPanel5.PerformLayout();
            this.doubleBufferPanel4.ResumeLayout(false);
            this.doubleBufferPanel4.PerformLayout();
            this.doubleBufferPanel3.ResumeLayout(false);
            this.doubleBufferPanel3.PerformLayout();
            this.doubleBufferPanel2.ResumeLayout(false);
            this.doubleBufferPanel2.PerformLayout();
            this.doubleBufferPanel1.ResumeLayout(false);
            this.doubleBufferPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FormLogin.DoubleBufferPanel PanelLocPhong;
        private DoubleBufferPanel PanelRadioButtonTrangThaiPhong;
        private Label LabelTrangThaiPhong;
        private CustomControl.CTRadioButton CTRadioButtonPhongTrong;
        private CustomControl.CTRadioButton CTRadioButtonPhongDangThue;
        private CustomControl.CTRadioButton CTRadioButtonPhongDaDat;
        private CustomControl.CTRadioButton CTRadioButtonTatCaPhong;
        private CustomControl.CTRadioButton CTRadioButtonPhongDangSuaChua;
        private DoubleBufferPanel PanelTinhTrangPhong;
        private CustomControl.CTRadioButton ctRadioButton1;
        private CustomControl.CTRadioButton CTRadioButtonChuaDonDep;
        private CustomControl.CTRadioButton CTRadioButtonDaDonDep;
        private Label LabelTinhTrangDonDep;
        private DoubleBufferPanel PanelLoaiPhong;
        private CustomControl.CTRadioButton CTRadioButtonTatCaLoaiPhong;
        private CustomControl.CTRadioButton CTRadioButtonPhongVIPDoi;
        private CustomControl.CTRadioButton CTRadioButtonPhongVIPDon;
        private CustomControl.CTRadioButton CTRadioButtonPhongThuongDoi;
        private CustomControl.CTRadioButton CTRadioButtonPhongThuongDon;
        private Label LabelLoaiPhong;
        private CustomControl.CTDatePicker ctDatePicker1;
        private DoubleBufferPanel PanelTitle;
        private Label LabelChonNgay;
        private CustomControl.CTComboBox cbBoxGio;
        private CustomControl.CTComboBox cbBoxLetter;
        private Label label7;
        private PictureBox pictureBox1;
        private CustomControl.CTTextBox ctTextBox1;
        private DoubleBufferPanel panelSoDoPhong;
        private Timer timerSearch;
        private Timer timerAppear;
        private FlowLayoutPanel flowLayoutPanel1;
        private FormLogin.DoubleBufferPanel doubleBufferPanel1;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel2;
        private FormLogin.DoubleBufferPanel doubleBufferPanel2;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel5;
        private FormLogin.DoubleBufferPanel doubleBufferPanel5;
        private Label label5;
        private FlowLayoutPanel flowLayoutPanel4;
        private FormLogin.DoubleBufferPanel doubleBufferPanel4;
        private Label label4;
        private FlowLayoutPanel flowLayoutPanel3;
        private FormLogin.DoubleBufferPanel doubleBufferPanel3;
        private Label label3;
    }
}