
using System;

namespace SistemKaryawan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Membuat objek perusahaan
            Perusahaan perusahaan = new Perusahaan();

            // 2. Membuat beberapa objek karyawan
            Manager manager = new Manager(
                "Andi", 8000000, 2000000
            );

            Staff staff = new Staff(
                "Budi", 5000000, 1000000
            );

            Magang magang = new Magang(
                "Citra", 2000000, 6
            );

            Freelancer freelancer = new Freelancer(
                "Dedi", 4000000, 3
            );

            Tetap tetap = new Tetap(
                "Eka", 6000000, 1500000
            );

            Kontrak kontrak = new Kontrak(
                "Fajar", 4500000, 12
            );

            // 3. Menambahkan karyawan ke perusahaan
            perusahaan.TambahKaryawan(manager);
            perusahaan.TambahKaryawan(staff);
            perusahaan.TambahKaryawan(magang);
            perusahaan.TambahKaryawan(freelancer);
            perusahaan.TambahKaryawan(tetap);
            perusahaan.TambahKaryawan(kontrak);

            // 4. Menampilkan semua data karyawan
            perusahaan.DaftarKaryawan();

            // Soal 1
            Console.WriteLine("\n=== SOAL 1 ===");
            manager.Kerja();
            freelancer.Kerja();

            // Soal 2
            Console.WriteLine("\n=== SOAL 2 ===");
            manager.Memimpin();

            // Soal 3
            Console.WriteLine("\n=== SOAL 3 ===");
            manager.InfoKaryawan();

            // Soal 4
            Console.WriteLine("\n=== SOAL 4 ===");
            magang.Belajar();

            // Soal 5
            Console.WriteLine("\n=== SOAL 5 ===");
            Karyawan karyawanStaff = staff;
            karyawanStaff.Kerja();

            // Demonstrasi method khusus lainnya
            Console.WriteLine("\n=== METHOD KHUSUS ===");
            staff.KerjakanTugas();
            freelancer.AmbilProyek();
            magang.CekKontrak();
            freelancer.CekKontrak();

            // Demonstrasi polymorphism untuk semua subclass
            Console.WriteLine("\n=== POLYMORPHISM ===");

            Karyawan[] daftarKerja =
            {
                tetap,
                kontrak,
                manager,
                staff,
                magang,
                freelancer
            };

            foreach (Karyawan karyawan in daftarKerja)
            {
                karyawan.Kerja();
            }

            // Soal 6
            Console.WriteLine("\n=== SOAL 6 ===");
            Console.WriteLine(
                "Inheritance memungkinkan kelas turunan mewarisi " +
                "atribut dan method kelas induk."
            );
            Console.WriteLine(
                "Polymorphism memungkinkan method Kerja() " +
                "memiliki perilaku berbeda sesuai objeknya."
            );
        }
    }
}
