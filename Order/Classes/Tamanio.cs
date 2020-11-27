using System;
using System.Collections.Generic;

namespace BlazingPizzaVScode
{
    public class Tamanio
    {   
        public int costo { get; set; }
        public string tamanio { get; set; }
        public Tamanio(int costo, string tamanio){
            this.costo = costo;
            this.tamanio = tamanio;
        }
    }
}