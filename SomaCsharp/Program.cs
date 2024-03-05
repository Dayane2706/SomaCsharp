using System;

namespace SomaCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 6;
            int numero2 = 2;

            Console.WriteLine("Quanto é " + numero1 + " + " + numero2 + "?");

            int reposta = Convert.ToInt32(Console.ReadLine());

            //Estrutura condicional

            if (reposta == 8)
            {
                Console.WriteLine("Parabéns! Você acertou!");
            }
            else Console.WriteLine("Resposta Errada! Tente Novamente!");
        }
    }
}



