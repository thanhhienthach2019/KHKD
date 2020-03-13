using System;
using System.Collections.Generic;
using System.Text;

namespace KHKDSolution.Data.Entities
{
    public class DpLSXL
    {
        public int SoLSXID { get; set; }
        public string SoLSX { get; set; }
        public string ChiNhanh { get; set; }
        public string MaSP { get; set; }
        public string MaMau { get; set; }
        public string MSM { get; set; }
        public string LoaiBTP { get; set; }
        public string MauBTP { get; set; }
        public string QuiCachBTL { get; set; }
        public int CoSoID { get; set; }
        public long SoLuong { get; set; }
        public string SoSOA { get; set; }
        public string SoDH { get; set; }
        public string SoDHK { get; set; }
        public string MauKhach { get; set; }
        public string CSDanTem { get; set; }
        public string MaSPK { get; set; }
        public DateTime NgayPhatSinh { get; set; }
        public string DVT { get; set; }
        public string DienGiaiCT { get; set; }
        public DpLSXH DpLSXH { get; set; }
        public SanPham SanPham { get; set; }
    }
}
