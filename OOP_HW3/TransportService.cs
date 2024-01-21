using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HW3
{
    internal class TransportService
    {
        public void PrintTransportType(Transport transport) 
        {
            Console.WriteLine(transport.GetTypeOfTransport());
        }
    }
}
