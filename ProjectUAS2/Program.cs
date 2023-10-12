using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace ProjectUAS2
{
    public class Resto
    {
        public decimal nasigoreng, steakdaging, ayamladahitam, jusmangga, jusapel, jusalpukat, Hrgnasigoreng, Hrgsteakdaging, Hrgayamladahitam, Hrgjusmangga, Hrgjusapel, Hrgjusalpukat, nama, kasir, jam, tanggal;
        public List<decimal> price = new List<decimal>();
        int choose;

        string data;
        public void NasiGoreng()
        {
            try
            {
                Console.Write("Nasi Goreng = ");
                nasigoreng = Decimal.Parse(Console.ReadLine());
                Hrgnasigoreng = nasigoreng * 35000;
                price.Add(Hrgnasigoreng);
                Console.WriteLine("\n Total Harga Nasi Goreng {0} \n", Hrgnasigoreng);
            }
            catch (FormatException)
            {
                Console.WriteLine("==========================================");
                Console.WriteLine("\nHanya diisi dengan format angka !\n");
                Console.WriteLine("==========================================");
            }
        }
        public void SteakDaging()
        {
            try
            {
                Console.Write("Steak Daging = ");
                steakdaging = Decimal.Parse(Console.ReadLine());
                Hrgsteakdaging = steakdaging * 70000;
                price.Add(Hrgsteakdaging);
                Console.WriteLine("\n Total Harga Steak Daging {0}\n", Hrgsteakdaging);
            }
            catch (FormatException)
            {
                Console.WriteLine("==========================================");
                Console.WriteLine("\nHanya diisi dengan format angka !\n");
                Console.WriteLine("==========================================");
            }
        }
        public void AyamLadaHitam()
        {
            try
            {
                Console.Write("Ayam Lada Hitam = ");
                ayamladahitam = Decimal.Parse(Console.ReadLine());
                Hrgayamladahitam = ayamladahitam * 40000;
                price.Add(Hrgayamladahitam);
                Console.WriteLine("\n Total Harga Ayam Lada Hitam {0}  \n", Hrgayamladahitam);
            }
            catch (FormatException)
            {
                Console.WriteLine("==========================================");
                Console.WriteLine("\nHanya diisi dengan format angka !\n");
                Console.WriteLine("==========================================");
            }
        }
        public void JusMangga()
        {
            try
            {
                Console.Write("Jus Mangga = ");
                jusmangga = Decimal.Parse(Console.ReadLine());
                Hrgjusmangga = jusmangga * 15000;
                price.Add(Hrgjusmangga);
                Console.WriteLine("\n Total Harga Jus Mangga {0} \n", Hrgjusmangga);
            }
            catch (FormatException)
            {
                Console.WriteLine("==========================================");
                Console.WriteLine("\nHanya diisi dengan format angka !\n");
                Console.WriteLine("==========================================");
            }
        }
        public void JusApel()
        {
            try
            {
                Console.Write("Jus Apel = ");
                jusapel = Decimal.Parse(Console.ReadLine());
                Hrgjusapel = jusapel * 17000;
                price.Add(Hrgjusapel);
                Console.WriteLine("\n Total Harga Jus Apel {0} \n", Hrgjusapel);
            }
            catch (FormatException)
            {
                Console.WriteLine("==========================================");
                Console.WriteLine("\nHanya diisi dengan format angka !\n");
                Console.WriteLine("==========================================");
            }
        }
        public void JusAlpukat()
        {
            try
            {
                Console.Write("Jus Alpukat = ");
                jusalpukat = Decimal.Parse(Console.ReadLine());
                Hrgjusalpukat = jusalpukat * 20000;
                price.Add(Hrgjusalpukat);
                Console.WriteLine("\n Total Harga Jus Alpukat {0} \n", Hrgjusalpukat);
            }
            catch (FormatException)
            {
                Console.WriteLine("==========================================");
                Console.WriteLine("\nHanya diisi dengan format angka !\n");
                Console.WriteLine("==========================================");
            }
        }
        public void Pelanggan()
        {
            try
            {
                Console.Write("Masukkan Nama Pelanggan = ");
                nama = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Silahkan isi data dengan benar");
            }
        }
        public void Tanggal()
        {
            try
            {
                Console.Write("Masukkan Tanggal Pembelian =");
                tanggal = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Silahkan isi data dengan benar");
            }
        }
        public void Jam()
        {
            try
            {
                Console.Write("Masukkan Jam Pembelian =");
                jam = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Silahkan isi data dengan benar");
            }
        }
        public void Kasir()
        {
            try
            {
                Console.Write("Masukkan kode kasir =");
                kasir = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Silahkan isi data dengan benar");
            }
        }
        public void RestoFlex()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Welcome to RestoFlex");
                    Console.WriteLine("1. Nasi Goreng (Rp.35.000)" +
                        "\n2. Steak Daging (Rp.70.000)" +
                        "\n3. Ayam Lada Hitam (Rp.40.000)" +
                        "\n4. Jus Mangga (Rp.15.000)" +
                        "\n5. Jus Apel (Rp.17.000)" +
                        "\n6. Jus Alpukat (Rp.20.000)" +
                        "\n7. Finish/Exit");
                    Console.Write("Choose : ");
                    choose = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    switch (choose)
                    {
                        case 1:
                            NasiGoreng();
                            break;
                        case 2:
                            SteakDaging();
                            break;
                        case 3:
                            AyamLadaHitam();
                            break;
                        case 4:
                            JusMangga();
                            break;
                        case 5:
                            JusApel();
                            break;
                        case 6:
                            JusAlpukat();
                            break;
                        case 7:
                            if (!price.Any())
                            {
                                return;
                            }
                            else
                            {
                                Console.Clear();
                                data = string.Format(CultureInfo.CreateSpecificCulture("id-id"), "Rp. {0:N}", price.Sum(x => x));
                                Console.WriteLine("Jumlah Pemesanan :" +
                                    "\n {0} Nasi Goreng," +
                                    "\n {1} Steak Daging," +
                                    "\n {2} Ayam Lada Hitam," +
                                    "\n {3} Jus Mangga" +
                                    "\n {4} Jus Apel" +
                                    "\n {5} Jus Alpukat" +
                                    "\n\n------------------------" +
                                    "\nTotal : {6}", nasigoreng, steakdaging, ayamladahitam, jusmangga, jusapel, jusalpukat, data);

                                Console.Write("\nCash : Rp. ");
                                int tunai = int.Parse(Console.ReadLine());
                                int kembalian = (int)(tunai - price.Sum(x => x));
                                Console.WriteLine("\nReturn : Rp. {0:N}", kembalian);
                                Console.WriteLine("===========================");
                                Console.Write("Nama Pelanggan = ");
                                Console.ReadLine();
                                Console.Write(DateTime.Now);
                                Console.ReadLine();
                                Console.Write("Masukkan Kode Kasir = ");
                                Console.ReadLine();
                                Console.WriteLine("===========================");
                                Console.WriteLine("SELAMAT MENIKMATI HIDANGAN ");
                                Console.WriteLine("===========================");
                                Console.ReadKey();
                                return;
                            }
                        default:
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please choose a menu in List ");
                }
            }
        }
    }
    class program
    {

        
        static void Main(string[] args)
        {
            try
            { 
                Resto mp = new Resto();
                Console.WriteLine("Welcome to RestoFlex" +
                    "\n ------------------------------------------------------" +
                    "\nChoose the Food" +
                    "\n-------------------------------------------------------");
                mp.RestoFlex();

            }
            catch (Exception e)
            {
                Console.WriteLine("Except ion: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
    }
}