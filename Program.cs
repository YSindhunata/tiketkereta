using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TicketReservation reservation;
            Console.WriteLine("Selamat Datang di KeretaKita!");
            Console.WriteLine("Masukkan Data Diri Anda ");

            Orang orang = new Orang();
            Console.Write("Nama: ");
            orang.Nama = Console.ReadLine();

            Console.Write("Nomor Telepon: ");
            orang.NomorTelpon = Console.ReadLine();
            
            reservation = new TrainTicketReservation();
            reservation.MakeReservation();

            Console.WriteLine("Data Diri Anda: ");
            Console.WriteLine("Nama: " + orang.Nama);
            Console.WriteLine("Nomor Telepon: " + orang.NomorTelpon);

            reservation.DisplayReservationDetails();
        }
    }
}
