using System.Text.RegularExpressions;

namespace Exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Escreva	um	algoritmo	para	ler	uma	temperatura	em	graus	Fahrenheit,	calcular	e	escrever o valor   correspondente em  graus Celsius.
            while (true)
            {
                Console.WriteLine("Conversor de graus Fahrenheit para Celsius");
                Console.WriteLine("Digite a Temperatura que deseja converter ou 999 para sair:");
                float temperatura = float.Parse(Console.ReadLine());

                if (temperatura == 999)
                {
                    break;
                }

                if (temperatura > 84)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }else if (temperatura > 67) {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                }else if (temperatura > 50)
                {
                }else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }

                Console.WriteLine(temperatura + "º em Fahrenheit é " + ((temperatura - 32) * 5 / 9) + "º Celsius");

                Console.ResetColor();
            }

        }
    }
}
