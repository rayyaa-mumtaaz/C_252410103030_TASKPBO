
using System;
using System.Collections.Generic;

namespace SistemKaryawan
{
    public class Perusahaan
    {
        private List<Karyawan> daftarKaryawan;

        public Perusahaan()
        {
            daftarKaryawan = new List<Karyawan>();
        }

        public void TambahKaryawan(Karyawan karyawan)
        {
            daftarKaryawan.Add(karyawan);
            Console.WriteLine(karyawan.Nama + " berhasil ditambahkan.");
        }

        public void DaftarKaryawan()
        {
            Console.WriteLine("\n=== DAFTAR KARYAWAN ===");

            foreach (Karyawan karyawan in daftarKaryawan)
            {
                Console.WriteLine("-------------------------");
                karyawan.InfoKaryawan();
            }
        }
    }
}
