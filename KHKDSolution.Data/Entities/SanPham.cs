using KHKDSolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace KHKDSolution.Data.Entities
{
    public class SanPham
    {
        public string MaSP { get; set; }
        public string MSSP { get; set; }
        public string MaCLSpPhu { get; set; }
        public string MaCLSP { get; set; }
        public string GhiChu { get; set; }
        public Guid UserCreate { get; set; }
        public DateTime DateCreate { get; set; }
        public BTP BTP { get; set; }
        public string TenBTP { get; set; }
        public string MaSAP { get; set; }
        public string MaKhuon { get; set; }
        public List<DpLSXL> DpLSXL { get; set; }
        public AppUser AppUser { get; set; }
    }
}
