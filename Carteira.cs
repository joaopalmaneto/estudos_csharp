using System; 
using System.Collections.Generic;
using System.IO;


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
    
        public void salvarCarteira(){
            String path = $@"{Directory.GetCurrentDirectory()}\memoria\carteira.csv"; 

                using(StreamWriter sw = File.CreateText(path)){

                    sw.WriteLine($"{valorPresente}");
                    
                    foreach(int i in entradas){
                        sw.Write($"{i}");

                        if(i != entradas.Count){
                            //adiciona virgula apenas se o iterador não estiver na ultima posição, 
                            //para evitar problemas com o formato csv.
                            sw.Write(",");
                        }
                    }

                    sw.Write(Environment.NewLine);

                    foreach(int i in saidas){
                        sw.Write($"{i}");

                        if(i != saidas.Count - 1){
                            sw.Write(",");
                        }
                    }
                }

        }
    }

}

