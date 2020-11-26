using System;

namespace BlazingPizzaVScode
{
    public class PizzaConcreteJamon:PizzaBuilder
    {   
        protected override void buildCosto(){
            pizza.setCosto(10);
        }
        
        protected override void buildCobertura(){
            pizza.setCobertura("Jamon");
        }
    }
}