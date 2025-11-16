using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel_Management_System.DAO;
using Hotel_Management_System.DTO;

namespace Hotel_Management_System.BUS
{
    internal class PhieuThueBUS
    {
        private static PhieuThueBUS instance;
        public static PhieuThueBUS Instance
        {
            get { if (instance == null) instance = new PhieuThueBUS(); return instance; }
            private set { instance = value; }
        }
        private PhieuThueBUS() { }
        public List<PhieuThue> GetPhieuThues()
        {
            return PhieuThueDAO.Instance.GetPhieuThues();
        }
        public PhieuThue GetPhieuThue(string MaPT)
        {
            return PhieuThueDAO.Instance.GetPhieuThue(MaPT);
        }
        public void AddOrUpdatePhieuThue(PhieuThue phieuThue)
        {
            PhieuThueDAO.Instance.UpdatePhieuThue(phieuThue);
        }
        public List<PhieuThue> GetPhieuThuesWithNameCus(string name)
        {
            return PhieuThueDAO.Instance.GetPhieuThuesWithNameCus(name);
        }
        public string GetMaPTNext()
        {
            return PhieuThueDAO.Instance.GetMaPTNext();
        }
    }
}
