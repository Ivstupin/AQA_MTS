using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HW3
{
    internal class Tramcar : PublicTransport
    {
        public override string GetTypeOfTransport()
        {
            return "Трамвай это рельсовый транспорт";
        }

        public Tramcar(string destinationPoint, int id_number, DateTime time, int seat_count)
        {
            DestinationPoint = destinationPoint;
            Id_number = id_number;
            Time = time;
            Seat_count = seat_count;
        }
    }
}
