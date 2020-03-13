using KHKDSolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace KHKDSolution.Data.Entities
{
    public class DpLSXH
    {
        public string SoLSX { get; set; }
        public string SoSOA { get; set; }
        public string MaKH { get; set; }
        public string SoTN { get; set; }
        public string SoDDH { get; set; }
        public Guid UserCreate { get; set; }
        public DateTime NgayGH { get; set; }
        public DateTime NgayTN { get; set; }
        public DateTime NgayDP { get; set; }
        public DateTime NgayPH { get; set; }
        public DateTime NgayVTDU { get; set; }
        public DateTime NgayLap { get; set; }
        public DateTime NgayBBTN { get; set; }
        public DateTime NgayKiem { get; set; }
        public DateTime NgayNCVT { get; set; }
        public DateTime NgayDuPhong { get; set; }
        public string GhiChu { get; set; }
        public PhanBo PhanBo { get; set; }
        public BTP BTP { get; set; }
        public DateTime NgayGHM { get; set; }
        public string SoPO { get; set; }
        public List<DpLSXL> DpLSXL { get; set; }
        public AppUser AppUser { get; set; }
    }
}
