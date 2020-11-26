using System.Collections.Generic;
namespace BlazingPizzaVScode
{
    public class Order : ISubject
    {
        public string State { get; set; }
        public List<IObserver> Observers { get; set; }
        public List<Pizza> Pizzas { get; set; }

        public Order()
        {
            this.Observers = new List<IObserver>();
            this.Pizzas = new List<Pizza>();
            this.State = State; 
        }

        public void Attach(IObserver observer, List<Pizza> pizza)
        {
            this.Observers.Add(observer);
            foreach (Pizza item in Pizzas)
            {
                pizza.Add(item);
            }

        }

        public void Detach(IObserver observer, List<Pizza> pizza)
        {
            this.Observers.Remove(observer);
            foreach (Pizza item in Pizzas)
            {
                pizza.Remove(item);
            }
        }

        public void Notify()
        {
            foreach (IObserver observer in Observers)
            {
                observer.Update(this);
            }
        }
    }
}