using System;
using System.Collections.Generic;

namespace BlazingPizzaVScode
{
    class Program
    {
        static void Main(string[] args)
        {

            // ParaConstruir el pedido

            // Cantidad de pizza como maximo
                        // Pizza obj1 = objPool.Get();
                        // objPool.Release(obj1);
            // ObjectPool<Pizza> CapasidadPizzas = new ObjectPool<Pizza>();
            // Pizza pizza1 = new Pizza();
            // CapasidadPizzas.Release(pizza1);
            
            //Lista de pedido
            List<Pizza> CapasidadPizzas = new List<Pizza>();
            List<Pizza> PedidoLista = new List<Pizza>();


            Console.WriteLine("1: Cantidad");
            // int quantity = Convert.ToInt32(Console.ReadLine());
            int quantity = 3;
            for (int i = 0; i < quantity; i++)
            {
                PedidoLista.Add(new Pizza());
            }
            
            for (int j = 0; j < PedidoLista.Count; j++)
            {
                
            Console.WriteLine("========================== Pizza "+(j+1)+" =======================");
                Console.WriteLine("2: Tamanio de la pizza:"+(j+1));
                Console.WriteLine("     1: Pequenio");
                Console.WriteLine("     2: Mediano");
                Console.WriteLine("     3: Grande");
                // int size = Convert.ToInt32(Console.ReadLine());
                int size = 2;
                string sizeAux = "";
                switch(size){
                    case 1:
                        // PedidoLista[j].setTamanio("Pequeño");
                        sizeAux = "Pequeño";
                        break;
                    case 2:
                        // PedidoLista[j].setTamanio("Mediano");
                        sizeAux = "Mediano";
                        break;
                    case 3:
                        // PedidoLista[j].setTamanio("Grande");
                        sizeAux = "Grande";
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }

                
                List<PizzaBuilder> coberturas = new List<PizzaBuilder>();
                KitchenDirector kitchenDirector = new KitchenDirector();
                PizzaBuilder PizzaBuilder = new PizzaConcreteJamon();

                Console.WriteLine("3: Cobertura de la pizza: "+(j+1));
                Console.WriteLine("     1: Piña");
                Console.WriteLine("     2: Jamon");
                Console.WriteLine("     3: Chorizo");
                // string coverage = Console.ReadLine();
                string coverage = "2,3";
                string[] coverages = coverage.Split(',');
                for (int i = 0; i < coverages.Length; i++)
                {
                    // Console.WriteLine(coverages[i]);
                    switch(coverages[i]){
                        case "1":
                            coberturas.Add(new PizzaConcretePinia());
                            break;
                        case "2":
                            coberturas.Add(new PizzaConcreteJamon());
                            break;
                        case "3":
                            coberturas.Add(new PizzaConcreteChorizo());
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                }
                kitchenDirector.setPizzaBuilder(PizzaBuilder);
                kitchenDirector.setPizzaBuilders(coberturas);
                kitchenDirector.construirPizza();
                PedidoLista[j] = kitchenDirector.getPizza();
                PedidoLista[j].setTamanio(sizeAux);
            }
            
            foreach (Pizza pedido in PedidoLista)
            {
                Console.WriteLine(pedido.toStrings());
            }

            CalcularCosto costo = new CalcularCosto();
            costo.setPedidoLista(PedidoLista);
            costo.CalcularCostoPedido();
            // List<PizzaBuilder> coberturas = new List<PizzaBuilder>();
            // KitchenDirector kitchenDirector = new KitchenDirector();
            // PizzaBuilder PizzaBuilder = new PizzaConcreteJamon();
            // PizzaBuilder pizzaConcreteJamon = new PizzaConcreteJamon();
            // PizzaBuilder pizzaConcretePinia = new PizzaConcretePinia();
            // coberturas.Add(new PizzaConcreteChorizo());
            // coberturas.Add(new PizzaConcreteJamon());
            // coberturas.Add(new PizzaConcretePinia());
            // kitchenDirector.setPizzaBuilder(PizzaBuilder);
            // kitchenDirector.setPizzaBuilders(coberturas);
            // //kitchenDirector.setPizzaBuilder(mozzarellaPizzaBuilder);
            // kitchenDirector.construirPizza();
            // Pizza pizza = kitchenDirector.getPizza();
            // Console.WriteLine(pizza.toStrings());

            // branch delivery by Raul Navarro

            Console.WriteLine("Cofirm Order");
            Console.WriteLine("     1. Confirm");
            Console.WriteLine("     0. Cancel Order");


            if (true)
            {
                Delivery delivery = new Delivery();

                Order order = new Order();
                order.Attach(delivery,PedidoLista);
                order.State = "Process";

            }else
            {
                
            }
            
        }
    }
}
