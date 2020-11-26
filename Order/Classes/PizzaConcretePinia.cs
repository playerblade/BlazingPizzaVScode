using System;

namespace BlazingPizzaVScode
{
    public class PizzaConcretePinia:PizzaBuilder
    {   
        protected override void buildCosto(){
            pizza.setCosto(20);
        }
        protected override void buildCobertura(){
            pizza.setCobertura("Piña");
        }
    }
}