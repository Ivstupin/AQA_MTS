using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HW2.Doctors
{
    public class Surgeon : Medic
    {
        public override void Cure()
        {
            Console.WriteLine(value: $"Хирург удалил аппендицит");
        }
    }
}
