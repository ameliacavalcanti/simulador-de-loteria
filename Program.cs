using System;
using System.Linq;

namespace loteria
{
    class Program
    {
        static void Main()
        {
            const int qtdeNumeros = 6;
            const int maxNumero = 60;

            int[] aposta = new int[qtdeNumeros];
            int[] sorteio = new int[qtdeNumeros];

            Console.WriteLine("===========LOTERIA==========\nEscolha 6 numeros de 1 a 60");

            for (int i = 0; i < qtdeNumeros; i++)
            {
                while (true)
                {
                    Console.WriteLine($"Numero{i + 1}");
                    if (int.TryParse(Console.ReadLine(), out int num) &&
                        num >= 1 && num <= maxNumero &&
                        !aposta.Contains(num))
                    {
                        aposta[i] = num;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Numero invalido ou repetido. Tente novamente.");

                    }
                }
            }
            Random rand = new Random();
            int contador = 0;
            while (contador < qtdeNumeros)
            {
                int num = rand.Next(1, maxNumero + 1);
                if (!sorteio.Contains(num))
                {
                    sorteio[contador] = num;
                    contador++;
                }
            }
            int acertos = aposta.Intersect(sorteio).Count();

            Console.WriteLine("\nSua aposta: " + string.Join(", ", aposta));
            Console.WriteLine("Numero sorteados: " + string.Join(",", sorteio));
            Console.WriteLine($"\nVocê acertou {acertos} numero(s)!");

            if (acertos == 6)
                Console.WriteLine("Parabens, voce ganhou na loteria!");
            else if (acertos >= 4)
                Console.WriteLine("Muito bem! Voce fez uma boa pontuação.");
            else
                Console.WriteLine("Não foi dessa vez. Tente novamente");
        }
    }
}
