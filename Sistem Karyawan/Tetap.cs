
using System;

namespace SistemKaryawan
{
    public class Tetap : Karyawan
    {
        public double Tunjangan { get; set; }

        public Tetap(string nama, double gaji, double tunjangan)
            : base(nama, gaji)
        {
            Tunjangan = tunjangan;
        }

        public double HitungGajiTotal()
        {
            return Gaji + Tunjangan;
        }

        public override void Kerja()
        {
            Console.WriteLine(Nama + " sedang bekerja sebagai karyawan tetap.");
        }

        public override void InfoKaryawan()
        {
            base.InfoKaryawan();
            Console.WriteLine("Tunjangan: Rp" + Tunjangan);
            Console.WriteLine("Gaji Total: Rp" + HitungGajiTotal());
        }
    }
}
