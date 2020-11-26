using System.Collections.Generic;
namespace BlazingPizzaVScode
{
    public interface ISubject
    {
        void Attach(IObserver observer, List<Pizza> pizza);

        void Detach(IObserver observer, List<Pizza> pizza);

        void Notify();   
    }
}