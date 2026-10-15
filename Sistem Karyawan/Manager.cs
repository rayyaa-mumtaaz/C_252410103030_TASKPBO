
using System;

namespace SistemKaryawan
{
    public class Manager : Tetap
    {
        public Manager(string nama, double gaji, double tunjangan)
            : base(nama, gaji, tunjangan)
        {
        }

        public void Memimpin()
        {
            Console.WriteLine(Nama + " sedang memimpin tim.");
        }

        public override void Kerja()
        {
            Console.WriteLine(Nama + " sedang mengelola pekerjaan dan tim.");
        }
    }
}
