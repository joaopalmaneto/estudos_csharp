using System;

namespace gerenciador
{
class Utilidades
{
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

}
        
}

