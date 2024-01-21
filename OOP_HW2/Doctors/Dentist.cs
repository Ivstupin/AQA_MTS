using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HW2.Doctors
{
    public class Dentist : Medic
    {
        public override void Cure()
        {
            Console.WriteLine(value: $"Дантист удалил зуб");
        }
    }
}
