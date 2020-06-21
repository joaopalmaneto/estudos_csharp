using System; 
using System.Collections.Generic;


namespace gerenciador{

    class Carteira
    {
        double capitalInicial;
        double ValorPresente;
        List<double> entradas = new List<double>(); 
        List<double> saidas = new List<double>();
        
        public Carteira(double capitalInicial){
            this.capitalInicial = capitalInicial;
        }
        public void adicionarReceita(){
            Console.WriteLine("\nAdicionar receita");

            while(true){
                if(Utilidades.converterEntradaDouble() != null){
                    entradas.Add()
                }
            }

        }

        public void adicionarDespesa(){
            Console.WriteLine("adicionar despesa");
        }

        public void gerarBalancete(){
            Console.WriteLine("gerar balancete");
        }
    }
}

