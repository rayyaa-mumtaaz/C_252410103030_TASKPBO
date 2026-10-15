
using System;

namespace SistemKaryawan
{
    public class Karyawan
    {
        public string Nama { get; set; }
        public double Gaji { get; set; }

        public Karyawan(string nama, double gaji)
        {
            Nama = nama;
            Gaji = gaji;
        }

        public virtual void Kerja()
        {
            Console.WriteLine(Nama + " sedang bekerja.");
        }

        public virtual void InfoKaryawan()
        {
            Console.WriteLine("Nama: " + Nama);
            Console.WriteLine("Gaji: Rp" + Gaji);
        }
    }
}
