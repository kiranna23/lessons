using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson5
{
    class TreatmentPlan
    {
        int numberOfPlan;

        public TreatmentPlan(int numberOfPlan)
        {
            this.numberOfPlan = numberOfPlan;
        }   

        public int getNumberOfPlan() 
        {
            return numberOfPlan;    
        }
    }
}
