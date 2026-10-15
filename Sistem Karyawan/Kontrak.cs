
using System;

namespace SistemKaryawan
{
    public class Kontrak : Karyawan
    {
        public int Durasi { get; set; }

        public Kontrak(string nama, double gaji, int durasi)
            : base(nama, gaji)
        {
            Durasi = durasi;
        }

        public void CekKontrak()
        {
            Console.WriteLine(
                "Durasi kontrak " + Nama + ": " + Durasi + " bulan."
            );
        }

        public override void Kerja()
        {
            Console.WriteLine(Nama + " sedang bekerja sebagai karyawan kontrak.");
        }

        public override void InfoKaryawan()
        {
            base.InfoKaryawan();
            Console.WriteLine("Durasi Kontrak: " + Durasi + " bulan");
        }
    }
}
