using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W4D1_Training
{
    class simpleinterest_calc
    {

        public event EventHandler<interestEventArgs> CalculateSimpleInterest;
        
        public void StartCalculte()
        {
            Console.WriteLine(CalculateSimpleInterest);
        }
        
        public void Calculate (double Principle, double Interest, double Months)
        {
            double Calculate = (Principle * Interest * Months) / 100;

            interestEventArgs obj = new interestEventArgs(Calculate);

            if (CalculateSimpleInterest != null)                    // raising the event
            { 
                CalculateSimpleInterest(this, obj); 
            } 

            //return Calculate;
        }


    }
}
