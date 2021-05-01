using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using System.Globalization;

namespace exercise2
{
    //membuat kelas program
    class program
    {
        //membuat variabel dengan tipe double
        public double pilih;
        //membuat variabel dengan tipe double
        public double harga, harga1, harga2, harga3, harga4, harga5, harga6;
        //membuat variabel dengan tipe double
        public double jumlahminyak, totalminyak;
        //membuat variabel dengan tipe double
        public double jumlahberas, totalberas;
        //membuat variabel dengan tipe double
        public double jumlahtelura, totaltelura;
        //membuat variabel dengan tipe double
        public double jumlahtelurb, totaltelurb;
        //membuat variabel dengan tipe double
        public double jumlahmie, totalmie;
        //membuat variabel dengan tipe double
        public double jumlahkopi, totalkopi;
        //membuat variabel dengan tipe double
        public double jumlahteh, totalteh;
        //membuat variabel dengan tipe double
        public double Hminyak = 10000;
        //membuat variabel dengan tipe double
        public double Hberas = 9500;
        //membuat variabel dengan tipe double
        public double Htelura = 20000;
        //membuat variabel dengan tipe double
        public double Htelurb = 25000;
        //membuat variabel dengan tipe double
        public double Hmie = 3000;
        //membuat variabel dengan tipe double
        public double Hkopi = 2000;
        //membuat variabel dengan tipe double
        public double Hteh = 1500;
        //membuat variabel dengan tipe double
        public double Totalsemua;
        //membuat variabel dengan tipe string
        public string cetaksay;

        static void Main(string[] args)
        {
            //memanggil kelas program
            program pr = new program();

            //membuat perulangan do while
            do
            {
                //menuliskan nama toko 
                Console.WriteLine("\t\tTOKO SEMBAKO MURAH MERIAH");
                Console.WriteLine("\t\twe deserve what you need");
                Console.WriteLine("\t\t--------------------------\n\n");
                //menuliskan daftar menu
                Console.WriteLine("Daftar Barang dan Harga");
                Console.WriteLine("1. Minyak Goreng     = Rp10.000/liter");
                Console.WriteLine("2. Beras             = Rp9.500/Kg");
                Console.WriteLine("3. Telur Ayam        = Rp20.000/Kg");
                Console.WriteLine("4. Telur Bebek       = Rp25.000/Kg");
                Console.WriteLine("5. Mie Instan        = Rp3.000/Bungkus");
                Console.WriteLine("6. Kopi              = Rp2.000/Bungkus");
                Console.WriteLine("7. Teh               = Rp1.500/Bungkus");
                Console.WriteLine("8. Selesai");
                //menuliskan pilihan untuk dipilih
                Console.WriteLine("Pilihan (1/2/3/4/5/6/7/8) : ");
                Console.WriteLine("---Selamat Berbelanja---");
                string menu = (Console.ReadLine());
                Console.WriteLine();

                //membuat switch case untuk pemilihan menu
                switch (menu)
                {
                    //membuat case pilihan untuk minyak goreng
                    case "1":
                        Console.WriteLine("Berapa Liter minyak goreng yang akan dibeli? ");
                        pr.jumlahminyak = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(pr.jumlahminyak + " Liter ditambahkan ke keranjang");
                        pr.totalminyak += pr.jumlahminyak;
                        pr.harga = pr.Hminyak * pr.totalminyak;
                        break;
                    //membuat case pilihan untuk beras
                    case "2":
                        Console.WriteLine("Berapa Kilogram beras yang akan dibeli? ");
                        pr.jumlahberas = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(pr.jumlahberas + " Kilogram ditambahkan ke keranjang");
                        pr.totalberas += pr.jumlahberas;
                        pr.harga1 = pr.Hberas * pr.totalberas;
                        break;
                    //membuat case pilihan untuk telur ayam
                    case "3":
                        Console.Write("Berapa kilogram telur ayam yang akan dibeli? ");
                        pr.jumlahtelura = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(pr.jumlahtelura + " Kilogram ditambahkan ke keranjang");
                        pr.totaltelura += pr.jumlahtelura;
                        pr.harga2 = pr.Htelura * pr.totaltelura;
                        break;
                    //membuat case pilihan untuk telur bebek
                    case "4":
                        Console.Write("Berapa kilogram telur bebek yang akan dibeli? ");
                        pr.jumlahtelurb = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(pr.jumlahtelurb + " Kilogram ditambahkan ke keranjang");
                        pr.totaltelurb += pr.jumlahtelurb;
                        pr.harga3 = pr.Htelurb * pr.totaltelurb;
                        break;
                    //membuat case pilihan untuk mie instan
                    case "5":
                        Console.Write("Berapa bungkus mie instan yang akan dibeli? ");
                        pr.jumlahmie = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(pr.jumlahmie + " Bungkus ditambahkan ke keranjang");
                        pr.totalmie += pr.jumlahmie;
                        pr.harga4 = pr.Hmie * pr.totalmie;
                        break;
                    //membuat case pilihan untuk kopi
                    case "6":
                        Console.Write("Berapa bungkus kopi yang akan dibeli? ");
                        pr.jumlahkopi = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(pr.jumlahkopi + " Bungkus ditambahkan ke keranjang");
                        pr.totalkopi += pr.jumlahkopi;
                        pr.harga5 = pr.Hkopi * pr.totalkopi;
                        break;
                    //membuat case pilihan untuk teh
                    case "7":
                        Console.Write("Berapa bungkus teh yang akan dibeli? ");
                        pr.jumlahteh = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(pr.jumlahteh + " Bungkus ditambahkan ke keranjang");
                        pr.totalteh += pr.jumlahteh;
                        pr.harga6 = pr.Hteh * pr.totalteh;
                        break;
                    //membuat case untuk membuat nota dengan streamwriter
                    case "8":
                        StreamWriter str = new StreamWriter("//Users//digitaldeveloper//Documents//Exe2 PAW//" + "notaPAW" + ".txt");
                        str.WriteLine("\t\tTOKO SEMBAKO MURAH MERIAH");
                        str.WriteLine("\t\twe deserve what you need");
                        str.WriteLine("\t\t--------------------------");
                        str.WriteLine("Nota Pembelian Anda");
                        str.WriteLine("-------------------");
                        str.WriteLine(pr.totalminyak + " Liter minyak goreng, dengan harga " + "Rp" + pr.harga);
                        str.WriteLine(pr.totalberas + " Kilogram beras, dengan harga " + "Rp" + pr.harga1);
                        str.WriteLine(pr.totaltelura + " Kilogram telur ayam, dengan harga " + "Rp" + pr.harga2);
                        str.WriteLine(pr.totaltelurb + " Kilogram telur bebek, dengan harga " + "Rp" + pr.harga3);
                        str.WriteLine(pr.totalmie + " Bungkus mie instan, dengan harga " + "Rp" + pr.harga4);
                        str.WriteLine(pr.totalkopi + " Bungkus kopi, dengan harga " + "Rp" + pr.harga5);
                        str.WriteLine(pr.totalteh + " Bungkus teh, dengan harga " + "Rp" + pr.harga6);
                        str.WriteLine("----------------------------------");
                        str.WriteLine("Total Harga");
                        pr.Totalsemua = pr.harga + pr.harga1 + pr.harga2 + pr.harga3 + pr.harga4 + pr.harga5 + pr.harga6;
                        pr.cetaksay += pr.Totalsemua;
                        str.WriteLine("Rp" + pr.cetaksay);
                        str.WriteLine("\t-------------------------------------------");
                        str.WriteLine("\tTerima Kasih Telah Berbelanja di Toko Kami");
                        str.WriteLine("\t\tSelamat Berbelanja Kembali");
                        str.Close();
                        pr.pilih = 8;
                        break;
                    //membuat case untuk melanjutkan pemilihan
                    case "Ya":
                        pr.pilih = 0;
                        break;
                    //membuat case untuk pilihan yang salah 
                    default:
                        Console.WriteLine("Daftar tidak ada di menu! Silakan pilih sesuai menu!");
                        Console.ReadLine();
                        break;
                }
            }
            while (pr.pilih != 8);
            }
        }
    }
