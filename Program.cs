using System;

namespace Doador_Sangue
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade; 

            Console.WriteLine("Digite sua idade: ");
            idade  =  int.Parse(Console.ReadLine());

            if(idade <= 17)
            {
                Console.WriteLine();
                Console.WriteLine("Você não pode ser doador de sangue ");
                Console.WriteLine("Pressione ENTER para sair! ");
                Console.ReadKey();
            }
            if (idade >= 18 && idade <= 67)
            {
                Console.WriteLine();
                Console.WriteLine("Você pode ser doador de sangue");
                Console.WriteLine("Pressione ENTER para sair!");
                Console.ReadKey();
            }
            if (idade >= 68)
            {
                Console.WriteLine();
                Console.WriteLine("Você não pode ser doador de sangue");
                Console.WriteLine("Pressione ENTER para sair!");
                Console.ReadKey();
            }
        }
    }
} 
