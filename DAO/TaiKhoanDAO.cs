using Hotel_Management_System.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System.DAO
{
    internal class TaiKhoanDAO
    {
        HotelDTO db = new HotelDTO();
        private static TaiKhoanDAO instance;
        public static TaiKhoanDAO Instance
        {
            get { if (instance == null) instance = new TaiKhoanDAO(); return instance; }
            private set { instance = value; }
        }
        private TaiKhoanDAO() { }

        public bool CheckLogin(string username, string password)
        {

                TaiKhoan tk = db.TaiKhoans.Where(p => p.TenTK == username && p.Password == password && p.DaXoa == false).SingleOrDefault();
                if (tk == null)
                    return false;
                return true;
            
        }
        public int GetQuyenTruyCap(string username)
        {

            TaiKhoan tk = db.TaiKhoans.Where(p => p.TenTK == username && p.DaXoa == false).SingleOrDefault();
                return tk.CapDoQuyen;
            
        }
        public List<TaiKhoan> GetTaiKhoans()
        {

            using (HotelDTO context = new HotelDTO())
            {
                return context.TaiKhoans.Include("NhanVien").AsNoTracking().Where(p => p.DaXoa == false).ToList();
            }
            ;

        }
        public List<TaiKhoan> GetTaiKhoansWithUserName(string username)
        {

                return db.TaiKhoans.Where(p => p.TenTK.Contains(username)).ToList();
            
        }    
        public TaiKhoan GetTKDangNhap(string username)
        {
            HotelDTO db = new HotelDTO();
            TaiKhoan tk = db.TaiKhoans.Where(p => p.TenTK == username && p.DaXoa == false).SingleOrDefault();

            return tk;
            
        }
        public void AddOrUpdateTK(TaiKhoan taiKhoan)
        {
            using (HotelDTO dbContext = new HotelDTO())
            {
                try
                {
                    // Tối ưu hóa: Chỉ dựa vào MaNV, không cần tải lại NhanVien
                    taiKhoan.NhanVien = null;

                    taiKhoan.DaXoa = false;

                    // Sửa lỗi: Sử dụng dbContext cục bộ mới
                    dbContext.TaiKhoans.AddOrUpdate(taiKhoan);
                    dbContext.SaveChanges(); // Lệnh lưu SẼ hoạt động đúng

                    // KHÔNG cần instance = null (đã bỏ)
                }
                catch (Exception ex)
                {
                    // Ném lỗi để form biết
                    throw ex;
                }
            }

        }
        public void RemoveTk(TaiKhoan taiKhoan)
        {

                taiKhoan.DaXoa = true;
                db.TaiKhoans.AddOrUpdate(taiKhoan);
                db.SaveChanges();
                instance = null;

        }
        public TaiKhoan CheckLegit(string username,string email)
        {

                return db.TaiKhoans.Where(p => p.TenTK == username && p.NhanVien.Email == email && p.DaXoa==false).SingleOrDefault();
            
        }
        
    }
}
