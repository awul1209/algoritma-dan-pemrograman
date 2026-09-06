namespace variabel_dan_tipe_data // 2. Nama wilayah / perumahan
{
    internal class Program //3. Bangunan rumahnya
    {
        static void Main(string[] args) // 4. Pintu masuk utamanya
        {
            // Di dalam sinilah kita menulis instruksi
            //1

            // 1. DEKLARASI & INISIALISASI (EVALUASI PEMILIHAN TIPE DATA)
            string namaLengkap = "Ahmad Fulan";
            long nik = 3529012345678912;     // WAJIB long, int tidak akan muat 16 digit.
            int tahunLahir = 2001;           // int cukup untuk tahun.
            char jenisKelamin = 'L';         // WAJIB char (kutip satu).
            bool isKaryawanTetap = true;     // WAJIB bool.
            double gajiPokok = 3.555555;     // Wajib tipe desimal (double/float).

            //2.OUTPUT(EVALUASI CONSOLE.WRITE vs WRITELINE)
            Console.WriteLine("=======================================");
            Console.WriteLine("     KARTU IDENTITAS PEGAWAI DIGITAL");
            Console.WriteLine("=======================================\n");

            Console.WriteLine("Data Karyawan:");

            Console.Write("> Nama             : ");
            Console.WriteLine(namaLengkap);

            Console.Write("> NIK              : ");
            Console.WriteLine(nik);

            //Alternatif penggabungan string(Boleh dibenarkan jika ada mahasiswa yang pakai ini)
            Console.WriteLine("> Tahun Lahir      : " + tahunLahir);
            Console.WriteLine("> Jenis Kelamin    : " + jenisKelamin);
            Console.WriteLine("> Karyawan Tetap   : " + isKaryawanTetap);
            Console.WriteLine("> Gaji Pokok       : Rp. " + gajiPokok);

            Console.WriteLine("\n=======================================");
            Console.WriteLine("Terima kasih telah menggunakan sistem ini.");

            Console.ReadKey();








            //2

            //string nama = "Ayyub";
            //int tahunLahir = 2002;
            //int tahunSekarang = 2026;
            //int umur = tahunSekarang - tahunLahir;

            //Console.WriteLine("Nama Saya  : " + nama);
            //Console.WriteLine("Umur saya  : " + umur + " Tahun");

            //Console.ReadKey();



            //3
            //Console.Write("Masukkan Angka Pertama : "); 
            //string input1 = Console.ReadLine(); 

            //Console.Write("Masukkan Angka Kedua   : "); 
            //string input2 = Console.ReadLine();

            //// 2. Konversi String ke Integer
            //int angka1 = int.Parse(input1);
            //int angka2 = Convert.ToInt32(input2);

            //// 3. Proses Operasi Aritmatika & Output
            //int hasilJumlah = angka1 + angka2;
            //Console.WriteLine("Hasil Penjumlahan : " + hasilJumlah);

            //Console.ReadKey();



            //4

            //Tugas Membuat Program Luas dan Keliling Persegi Panjang
            // Header Tampilan Terminal
            //Console.WriteLine("=============================================");
            //Console.WriteLine("  PROGRAM KALKULATOR LUAS & KELILING PERSEGI  ");
            //Console.WriteLine("=============================================\n");

            //// 1. INPUT STREAM (Menangkap Input Teks dari Keyboard)
            //Console.Write("Masukkan Panjang (cm) : ");
            //string inputPanjang = Console.ReadLine();

            //Console.Write("Masukkan Lebar   (cm) : ");
            //string inputLebar = Console.ReadLine();

            //// 2. KONVERSI TIPE DATA (String ke Double)
            //// Mengubah tipe teks menjadi angka desimal agar bisa dihitung
            //double panjang = double.Parse(inputPanjang);
            //double lebar = double.Parse(inputLebar);

            //// 3. PROSES OPERASI ARITMATIKA
            //double luas = panjang * lebar;
            //double keliling = 2 * (panjang + lebar);

            //// 4. MENAMPILKAN OUTPUT (Menggunakan Concatenation)
            //Console.WriteLine("\n---------------------------------------------");
            //Console.WriteLine("HASIL PERHITUNGAN:");
            //Console.WriteLine("Luas Persegi Panjang     : " + luas + " cm²");
            //Console.WriteLine("Keliling Persegi Panjang : " + keliling + " cm");
            //Console.WriteLine("---------------------------------------------");

            //// 5. MENAHAN LAYAR TERMINAL
            //Console.WriteLine("\nTekan tombol apa saja di keyboard untuk keluar...");
            //Console.ReadKey();




        }
    }
}
