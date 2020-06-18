using System;

namespace gerenciador
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double capitalInicial = getCapitalInicial();
            int? opcaoMenu = null;
            Carteira carteira = new Carteira(capitalInicial);

            Console.WriteLine("\nBem vindo ao gerenciador!");

            while(opcaoMenu != 4){
                opcaoMenu = menu(carteira);
            }
        }

        public static int? menu(Carteira carteira){

            Console.WriteLine("");
            
            Console.WriteLine("\n1- Adicionar receita");
            Console.WriteLine("2- Adicionar despesa");
            Console.WriteLine("3- Gerar balancete");
            Console.WriteLine("4- Sair");

            int? opcao = converterEntradaInt();

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

        public static int? converterEntradaInt(){
             int entrada;
            
            if(!int.TryParse(Console.ReadLine(), out entrada) ){ 
                Console.WriteLine("\nVocê não digitou um número.");
                return null; 
            } else{
                return entrada;
            }

        }

        public static double? converterEntradaDouble(){
            double entrada;
            
            if(!double.TryParse(Console.ReadLine(), out entrada) ){  
                Console.WriteLine("\nVocê não digitou um número. "); 
                return null;
            } else {
                return entrada;
            }
            
        }

        public static double getCapitalInicial(){
            double? capitalInicial; 

            while (true){
                Console.WriteLine("\nInsira o seu capital inicial");
                capitalInicial = converterEntradaDouble();

                if(capitalInicial != null){
                    return (double)capitalInicial;
                }

                Console.WriteLine("Valor inválido");
            }
            
        }

    }


}

