using System;
using System.IO;

namespace gerenciador
{
    class Gerenciador
    {
        static void Main(string[] args)
        {
            
            double capitalInicial = getCapitalInicial();
            int? opcaoMenu = null;
            Carteira carteira = new Carteira(capitalInicial);

            Console.WriteLine("\nBem vindo ao gerenciador!");

            
            while(opcaoMenu != 6){
                opcaoMenu = menu(carteira);
            }
        }

        public static int? menu(Carteira carteira){

            Console.WriteLine("");
            
            Console.WriteLine("\n1- Adicionar receita");
            Console.WriteLine("2- Adicionar despesa");
            Console.WriteLine("3- Gerar balancete");
            Console.WriteLine("4- Salvar carteira");
            Console.WriteLine("5- Carregar carteira");
            Console.WriteLine("6- Sair");

            int? opcao = Utilidades.converterEntradaInt();

            switch(opcao){
                    case 1: 
                        carteira.adicionarReceita();
                        break;
                    case 2:
                        carteira.adicionarDespesa();
                        break;
                    case 3:
                        carteira.gerarBalancete();
                        break;
                    case 4:
                        carteira.salvarCarteira();
                        break;
                    case 5:
                        break;
                    case 6:
                        Console.WriteLine("Adios!");
                        return opcao; 
                    case null:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break; 
                        
                    default:
                        Console.WriteLine("Opção inválida. Temte novamente"); 
                        break;
                }
            return null;
        }
 
        public static double getCapitalInicial(){
            double? capitalInicial; 

            while (true){
                Console.WriteLine("\nInsira o seu capital inicial");
                capitalInicial = Utilidades.converterEntradaDouble();

                if(capitalInicial != null){
                    return (double)capitalInicial;
                }

                Console.WriteLine("Valor inválido");
            }
            
        }

    }


}

