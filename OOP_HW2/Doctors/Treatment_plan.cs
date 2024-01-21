using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_HW2;

namespace OOP_HW2.Doctors
{
    public  class Treatment_plan(int treatment_plan)
    {
        public int treatment_plan = treatment_plan;

        public void AppointAdoctor()
        {
            
            switch (treatment_plan)
            {
                case 1:
                Surgeon Surgeon1 = new Surgeon();
                    Surgeon1.Cure();
                    break;
                
                case 2:
                Dentist Dentist1 = new Dentist();
                Dentist1.Cure();
                    break;
                
                default:
                    Сlinicus Сlinicus1 = new();
                    Сlinicus1.Cure();
                    break;
            
            }
        }

    }
}