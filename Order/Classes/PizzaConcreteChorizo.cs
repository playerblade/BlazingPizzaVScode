namespace BlazingPizzaVScode
{
    public class PizzaConcreteChorizo:PizzaBuilder
    {   
        protected override void buildCosto(){
            pizza.setCosto(5);
        }
        protected override void buildCobertura(){
            pizza.setCobertura("Chrorizo");
        }
    }
}