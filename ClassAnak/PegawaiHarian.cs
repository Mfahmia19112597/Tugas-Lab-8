﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8.ClassAnak
{
    public class PegawaiHarian : ClassInduk.Pegawai
    {
        public double upahperjam { get; set; }
        public double jumlahjamkerja { get; set; }
        public override double GAJI()
        {
            return jumlahjamkerja * upahperjam;
        }
    }
}