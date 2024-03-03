using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson5
{
    class Patient : TreatmentPlan
    {
        string name;

        public Patient(string name, int numberOfPlan) : base(numberOfPlan)
        {
            this.name = name;   
        }

        public void Treatment()
        {
            int numberOfPlan = getNumberOfPlan();
            if (numberOfPlan == 1)
            {
                Surgeon surgeon = new Surgeon();
                surgeon.toHeal();
            }
            else if (numberOfPlan == 2)
            {
                Dentist dentist = new Dentist();    
                dentist.toHeal();   
            }
            else
            {
                Therapist therapist = new Therapist();  
                therapist.toHeal(); 
            }
        }
    }
}
