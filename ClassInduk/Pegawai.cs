using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8.ClassInduk
{
    public abstract class Pegawai
    {
        public int NIK { get; set; }
        public string NAMA { get; set; }
        public abstract double GAJI();
    }
}