using System; 
using System.Collections.Generic;


namespace gerenciador{

    class Carteira
    {
        private double valorPresente;
        
        private List<double> entradas = new List<double>(); 
        private List<double> saidas = new List<double>();
        
        public Carteira(double capitalInicial){
            this.valorPresente = capitalInicial;
        }

        public void adicionarReceita(){
            Console.WriteLine("\n#### Adicionar receita ####");

            while(true){
                double? valor = Utilidades.converterEntradaDouble();

                if(valor != null){
                    entradas.Add((double)valor);
                    valorPresente += (double)valor;
                    break;
                }

                Console.WriteLine("Tente novamente.");
            }

        }

        public void adicionarDespesa(){
            Console.WriteLine("\n#### Adicionar despesa ####");

            while(true){
                double? valor = Utilidades.converterEntradaDouble();

                if(valor != null){
                    saidas.Add((double)valor);
                    valorPresente -= (double)valor;
                    break;
                }

                Console.WriteLine("Tente novamente.");
            }
        }

        public void gerarBalancete(){
            Console.WriteLine("\n#### Gerar balancete ####");

            Console.WriteLine("\nDespesas:\n");
            foreach(double i in saidas){
                Console.WriteLine(i);
            }
            
            
            Console.WriteLine("\nReceitas:\n");
            foreach(int i in entradas){
                Console.WriteLine(i);
            }


            Console.WriteLine("\nSeu saldo é :" + valorPresente + "\n");
        }
    }
}

