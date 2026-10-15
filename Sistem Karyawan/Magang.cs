
using System;

namespace SistemKaryawan
{
    public class Magang : Kontrak
    {
        public Magang(string nama, double gaji, int durasi)
            : base(nama, gaji, durasi)
        {
        }

        public void Belajar()
        {
            Console.WriteLine(Nama + " sedang belajar dan mengembangkan keterampilan.");
        }

        public override void Kerja()
        {
            Console.WriteLine(Nama + " sedang menjalankan tugas magang.");
        }
    }
}
