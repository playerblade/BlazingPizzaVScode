﻿using System;
using System.Collections.Generic;
using System.Threading;

namespace BlazingPizzaVScode
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ObjectPool<Pizza> CapasidadPizzas = new ObjectPool<Pizza>();
            CapasidadPizzas = ObjectPool<Pizza>.GetInstance();
            CapasidadPizzas.SetMaxPoolSize(2);

            List<Pizza> PedidoLista = new List<Pizza>();


            Console.WriteLine("1: Cantidad");
            int quantity = Convert.ToInt32(Console.ReadLine());
            // int quantity = 3;
            for (int i = 0; i < quantity; i++)
            {
                // PedidoLista.Add(new Pizza());
                PedidoLista.Add(CapasidadPizzas.UtilizartPizza());
            }
            
            for (int j = 0; j < PedidoLista.Count; j++)
            {
                
            Console.WriteLine("========================== Pizza "+(j+1)+" =======================");
                Console.WriteLine("2: Tamanio de la pizza:"+(j+1));
                Console.WriteLine("     1: Pequenio");
                Console.WriteLine("     2: Mediano");
                Console.WriteLine("     3: Grande");
                int size = Convert.ToInt32(Console.ReadLine());
                // int size = 2;
                Tamanio tamanio = new Tamanio(0,"");
                switch(size){
                    case 1:
                        tamanio = new Tamanio(10,"Pequeño");
                        break;
                    case 2:
                        tamanio = new Tamanio(15,"Mediano");
                        break;
                    case 3:
                        tamanio = new Tamanio(20,"Grande");
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
                string coverage = Console.ReadLine();
                // string coverage = "2,3";
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
                PedidoLista[j].setTamanio(tamanio);
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
            int option = Convert.ToInt32(Console.ReadLine());

            if (option.Equals(1))
            {

                Console.WriteLine("Insert your Phone");
                int phone = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insert your Location: ");
                Console.WriteLine("Longitude: ");
                string longitude = Console.ReadLine();
                Console.WriteLine("Latitude: ");
                string latitude = Console.ReadLine();

                Delivery delivery = new Delivery();
                Order order = new Order();
                order.Attach(delivery,PedidoLista);
                order.State = "Process";

                Console.WriteLine("See Delivery Location");
                Console.WriteLine("     1. See");
                Console.WriteLine("     0. End Order");
                int see = Convert.ToInt32(Console.ReadLine());

                if (see.Equals(1))
                {
                    Console.WriteLine("Delivery Location:\n" 
                        +"Longitude: "+ delivery.Location[0].ToString()+"\n"
                        +"Longitude: "+ delivery.Location[1].ToString()
                    );

                }else
                {
                    Console.WriteLine("Your Order Detail");
                    foreach (Pizza pedido in PedidoLista)
                    {
                        Console.WriteLine(pedido.toStrings());
                    }

                    Console.WriteLine("Your Phone: " +phone);
                    Console.WriteLine("Your Location: \n" 
                        +"Longitude: "+ longitude +"\n"
                        +"Longitude: "+ latitude);
                    Console.WriteLine("Delivery Location:\n" 
                        +"Longitude: "+ delivery.Location[0].ToString()+"\n"
                        +"Longitude: "+ delivery.Location[1].ToString()
                    );
                }

            }else
            {
                Console.WriteLine(" Order Cancel......");
                Thread.Sleep(2000);
            }
            
        }
    }
}
