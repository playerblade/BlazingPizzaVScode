using System.Collections.Generic;

namespace BlazingPizzaVScode
{
    public class Pizza {
        private string tamanio;
        private string masa;
        public int costo;
        public string cobertura;
        public List<PizzaBuilder> coberturas = new List<PizzaBuilder>();
        public void setCosto(int costo) {
            this.costo = costo;
        }
        public void setTamanio(string tamanio) {
            this.tamanio = tamanio;
        }
        public void setMasa(string masa) {
            this.masa = masa;
        }

        public void setCobertura(string cobertura) {
            this.cobertura = cobertura;
        }

        public void setCoberturas(List<PizzaBuilder> coberturas) {
            this.coberturas = coberturas;
        }

        public string toString() {
            
            return "{" +
                    " costo='" + costo + "'"+ 
                    ", cobertura='" + cobertura +"'"+ 
                    "},";
        }
        public string toStrings() {
            string coverturAux = "Pizza{" +
                    "masa='" + masa+"'"+
                    ", tamanio='" + tamanio+"'"+
                    ", cobertura {";
            foreach (var cobertura in coberturas) 
            { 
                Pizza pizzaAux = cobertura.getPizza();
                coverturAux += pizzaAux.toString();
            }
            coverturAux += ""+  
                "}}";
            return coverturAux;
        }
    }
}