using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectPenjualan
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek penjualan
        static List<Penjualan> daftarPenjualan = new List<Penjualan>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahPenjualan();
                        break;

                    case 2:
                        HapusPenjualan();
                        break;

                    case 3:
                        TampilPenjualan();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.WriteLine("1. Tambah Penjualan");
            Console.WriteLine("2. Hapus Penjualan");
            Console.WriteLine("3. Tampilkan Penjualan");
            Console.WriteLine("4. Keluar");
            Console.WriteLine();
            Console.Write("Silahkan Pilih [1-4] : ");
            int pilihan;
            int pil;
            pilihan = int.Parse(Console.ReadLine());
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan menu
        }

        static void TambahPenjualan()
        {
            string nota,NotaTotal;
            string jenis, tanggal ;
           
            Console.WriteLine("Nota : ");
            nota = Console.ReadLine();
            Console.WriteLine("Tanggal : ");
            tanggal = Console.ReadLine();
            Console.WriteLine("Jenis : ");
            jenis = (Console.ReadLine());
            Console.WriteLine("NotaTotal : ");
            NotaTotal = (Console.ReadLine());

            Penjualan.Add(new ProjectPenjualan() { Nota = nota, Tanggal = tanggal, Jenis = jenis, NotaTotal = NotaTotal}); ;
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menambahkan penjualan ke dalam collection

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusPenjualan()
        {
            Console.WriteLine("Hapus Nota");
            Console.WriteLine();
            string hapus;
            Console.WriteLine("Masukan Nota yang ingin dihapus : ");
            hapus = Console.ReadLine();
            int i = 0;
            foreach (Penjualan penjualan in Penjualan)
            {
                if (hapus == penjualan.Nota)
                {
                    penjualan.RemoveAt(i);
                    break;
                }
                i++;
            }
            i = 0;
           
            Console.WriteLine("Data Berhasil dihapus");
            Console.WriteLine("Tekan Enter Untuk Lanjut");
            Console.ReadKey(true);
            Console.Clear();
            goto menu;
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menghapus penjualan dari dalam collection

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilPenjualan()
        {
            Console.WriteLine("Data Karyawan");
            Console.WriteLine();
            int no = 1;
            foreach ( penjualan Penjualan in ProjectPenjualan)
            {
                Console.WriteLine("{0}. Nota : {1}, Tanggal : {2}, Gaji : {3}, Karyawan Tetap",
                no, Penjualan.nota,Penjualan.tanggal,Penjualan.jenis,Penjualan.NotaTotal());
                no++;
            }

            Console.WriteLine("Tekan Enter Untuk Lanjut");
            Console.ReadKey(true);
            Console.Clear();
            TampilMenu();
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan daftar penjualan yang ada di dalam collection

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
