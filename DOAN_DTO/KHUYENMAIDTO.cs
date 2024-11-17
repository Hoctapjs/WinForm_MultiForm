using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_DTO
{
    public class KHUYENMAIDTO
    {
        int makm;
        string tenkm;
        DateTime ngaybd;
        DateTime ngaykt;
        float hesokm;

        public int Makm { get => makm; set => makm = value; }
        public string Tenkm { get => tenkm; set => tenkm = value; }
        public DateTime Ngaybd { get => ngaybd; set => ngaybd = value; }
        public DateTime Ngaykt { get => ngaykt; set => ngaykt = value; }
        public float Hesokm { get => hesokm; set => hesokm = value; }
    }
}
