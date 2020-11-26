using System;

namespace BlazingPizzaVScode
{
    public class Delivery : IObserver
    {
        
        public double[] Location { get; set; }
        public Delivery()
        {
            Random random = new Random();
            this.Location = new double[] {random.NextDouble() , random.NextDouble()};
        }
        public string Update(ISubject subject)
        {
           string exit = string.Empty;

           if ( (subject as Order).State.Equals("Process"))
           {
               exit = "this order this Process";
           }

           return exit;       
        }
    }
}