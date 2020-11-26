using System;
using System.Collections.Generic;

namespace BlazingPizzaVScode
{
    public abstract class PizzaBuilder
    {   
        public Pizza pizza;

        public Pizza getPizza(){
            return pizza;
        }
        public void createNuevaPizza(){
            pizza = new Pizza();
        }
        protected abstract void buildCosto();
        protected abstract void buildCobertura();
        public void buildCoberturas(List<PizzaBuilder> coberturas){
            pizza.setCoberturas(coberturas);
        }
        public void buildMasa(string masa) {
            pizza.setMasa(masa);
        }
        public void buildTamanio(string tamanio) {
            pizza.setTamanio(tamanio);
        }

        public void buildCostoAux(){ this.buildCosto(); }
        public void buildCoberturaAux(){ this.buildCobertura(); }
    }
}