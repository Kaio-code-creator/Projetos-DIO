using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APLICAÇÃO_TESTE
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ola vamos jogar! Vou sortear um número de 0 a 10 e você vai tentar descobrir qual número foi esse.");
            Random random = new Random();
            int numeroSorteado = random.Next(11);

            bool jogadorAcertouNumero = false;
            while (jogadorAcertouNumero == false)
            {
                Console.WriteLine("Digite qual número você acha que foi sorteado. Lembrando que  o número esta de 0 a 10.");
                string numeroDigitadoTexto = Console.ReadLine();
                int numeroDigitado = int.Parse(numeroDigitadoTexto);

                if (numeroDigitado == numeroSorteado)
                {
                    Console.WriteLine("Parabéns você acertou o número soteado foi: " + numeroSorteado);
                    jogadorAcertouNumero = true;
                }
                else
                {
                    Console.WriteLine("Ops... não foi dessa vez.");
                    if (numeroDigitado < numeroSorteado)
                    {
                        Console.WriteLine("o número sorteado foi maior que o numero digitado");
                    }
                    else
                    {
                        Console.WriteLine("o número sorteado foi menor que o numero digitado");
                    }
                }
            }
            Console.ReadKey();
        }

    }
}
