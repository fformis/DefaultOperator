using System;

namespace DefaultOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            //int teste; //Erro de compilação
            //int teste = 0; //Valor hardcode
            int teste = default; // valor padrão da linguagem
            
            string teste2 = default; //null
            Console.WriteLine(teste);
            Console.WriteLine(teste2??"era null");
        }
    }
}
