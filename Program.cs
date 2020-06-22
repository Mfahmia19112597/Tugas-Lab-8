using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab8.ClassAnak;
using Lab8.ClassInduk;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tugas Lab 8 (Pertemuan 11) - Polymorphsim, Abstraction & Collection";

            ClassAnak.PegawaiTetap pegawaiTetap = new ClassAnak.PegawaiTetap();
            pegawaiTetap.NIK = 1911;
            pegawaiTetap.NAMA = "Muhammad";
            pegawaiTetap.gajibulanan = 1050000;

            ClassAnak.PegawaiHarian pegawaiHarian = new ClassAnak.PegawaiHarian();
            pegawaiHarian.NIK = 2597;
            pegawaiHarian.NAMA = "FAHMI";
            pegawaiHarian.jumlahjamkerja = 13;
            pegawaiHarian.upahperjam = 200000;

            ClassAnak.Sales sales = new ClassAnak.Sales();
            sales.NIK = 1209;
            sales.NAMA = "Attaqwa";
            sales.jumlahpenjualan = 39;
            sales.komisi = 70000;

            List<Pegawai> listPegawai = new List<Pegawai>();

            listPegawai.Add(pegawaiTetap);
            listPegawai.Add(pegawaiHarian);
            listPegawai.Add(sales);

            int noUrut = 1;

            foreach (Pegawai pegawai in listPegawai)
            {
                Console.WriteLine("{0}. NIK: {1}, NAMA: {2}, GAJI: {3:N0}", noUrut, pegawai.NIK, pegawai.NAMA, pegawai.GAJI());
                noUrut++;
            }

            Console.ReadKey();
        }
    }
}