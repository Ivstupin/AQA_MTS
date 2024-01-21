using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HW3
{
    public class Transport
    {


        public string? DestinationPoint { get; set; } //Пункт назначения
        public int Id_number { get; set; } // Номер рейса
        public DateTime Time { get; set; } // Время отправления
        public int Seat_count { get; set; }// Число мест
        



        public virtual string  GetTypeOfTransport() 
        { return "Тип транспорта не определён"; }

        public void OnlyTransport()
        {
            Console.WriteLine("Транспорт что-то перевозит из точки А в точку Б");
        }

        public void PrintFieldTransport() 
        {
            Console.WriteLine($"""
                Пункт назначения: {DestinationPoint}
                Номер рейса: {Id_number}
                Время отправления: {Time}
                Число мест: {Seat_count}
                """);
        }

    }
}
