using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiket
{
    public abstract class TicketReservation
    {
        public string Nama { get; set; }
        public string NomorTelp { get; set; }
        public string NomorVaccine { get; set;}
        public string Alamat { get; set; }
        public string Keberangkatan { get; set; }
        public string Tujuan { get; set; }
        public static decimal HargaTiket { get; set;}

        public abstract void MakeReservation();
        public abstract void DisplayReservationDetails();
    }
}
