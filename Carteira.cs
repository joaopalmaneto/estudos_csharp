using System; 

namespace gerenciador{

    class Carteira
    {
        double capitalInicial;
        
        public Carteira(double capitalInicial){
            this.capitalInicial = capitalInicial;
        }
        public void adicionarReceita(){
            Console.WriteLine("adicionar receita");
        }

        public void adicionarDespesa(){
            Console.WriteLine("adicionar despesa");
        }

        public void gerarBalancete(){
            Console.WriteLine("gerar balancete");
        }
    }
}

