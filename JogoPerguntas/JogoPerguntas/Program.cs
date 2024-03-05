using System;

namespace JogoPerguntas
{
    class Program
    {
        static void Main(string[] args)
        {
            int pontuacao = 0;

            Console.WriteLine("Quanto é 25 + 25? ");
            int pergunta1= Convert.ToInt32(Console.ReadLine());
           
            // Pergunta 1
            if (pergunta1 == 50)
            {
                Console.WriteLine("Você acertou");
                pontuacao++;
            }
            else
            {
                Console.WriteLine("Você errou");
            }

            Console.WriteLine("\n**********************\n");

            // Pergunta 2
            Console.WriteLine("Quanto é 32 * 2? ");
            int pergunta2= Convert.ToInt32(Console.ReadLine());
           
            if (pergunta2== 64)
            {
                Console.WriteLine("Você acertou");
                pontuacao++;
            }
            else
            {
                Console.WriteLine("Você errou");
            }

            Console.WriteLine("\n**********************\n");

            // Pergunta 3
            Console.WriteLine("Quem descobriu o Brasil? ");
            string pergunta3 = Console.ReadLine();
           
            if (pergunta3 == "Pedro Alvares Cabral")
            {
                Console.WriteLine("Você acertou");
                pontuacao++;
            }
            else
            {
                Console.WriteLine("Você errou");
            }

            Console.WriteLine("\n**********************\n");

            // Pergunta 4
            Console.WriteLine("Quanto é 13.5 + 3? ");
            float pergunta4 = float.Parse(Console.ReadLine());

            if (pergunta4 == 16.5)
            {
                Console.WriteLine("Você acertou");
                pontuacao++;
            }
            else
            {
                Console.WriteLine("Você errou");
                
            }

            // Pontuação
            Console.WriteLine("Sua pontuação é:"+pontuacao);


        }
    }

}