using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace tiket
{
    public class TrainTicketReservation : TicketReservation
    {
        public override void MakeReservation()
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Harap masukkan detail berikut untuk melakukan pemesanan tiket");

            Console.Write("Nama: ");
            Nama = Console.ReadLine();

            Console.Write("Nomor Telepon: ");
            NomorTelp = Console.ReadLine();

            Console.Write("Nomor Vaccine: ");
            NomorVaccine = Console.ReadLine();

            Console.Write("Alamat: ");
            Alamat = Console.ReadLine();

            Console.Write("Berangkat dari: ");
            Keberangkatan = Console.ReadLine();

            Console.Write("Tujuan: ");
            Tujuan = Console.ReadLine();

            Random random = new Random();
            HargaTiket = random.Next(50000, 400000);

            Console.WriteLine("\nReservasi Tiket Kereta Berhasil!");
            Console.WriteLine("Terima kasih sudah memilih layanan kami");
        }
        public override void DisplayReservationDetails()
        {
            Console.WriteLine("\nDetail Pemesanan Tiket Kereta:");
            Console.WriteLine("Nama: " + Nama);
            Console.WriteLine("Nomor Telepon: " + NomorTelp);
            Console.WriteLine("Nomor Vaccine: " + NomorVaccine);
            Console.WriteLine("Alamat: " + Alamat);
            Console.WriteLine("Berangkat dari: " + Keberangkatan);
            Console.WriteLine("Tujuan: " + Tujuan);
            Console.WriteLine("Harga: " + HargaTiket);
        }
    }
}
