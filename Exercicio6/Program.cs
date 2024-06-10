using System.Reflection.Metadata.Ecma335;

namespace Exercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ler o ano atual e o ano de nascimento de uma pessoa.
            // Escrever uma mensagem que diga se ela poderá ou não votar este ano (não é necessário considerar o mês em que a pessoa nasceu).

            Console.WriteLine("SERÁ QUE POSSO VOTAR?");

            while (true)
            {
                Console.WriteLine("Digite o ano de nascimento ou 999 para sair!");
                int ano = int.Parse(Console.ReadLine());
                
                if (ano == 999)
                {
                    break;
                }

                if (ano < 1900 || ano > 2024)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Digite um ano valido entre 1900 e 2024");
                    Console.ResetColor();
                    continue;
                }

                int idade = 2024 - ano;


                switch (idade)
                {
                    case >= 70:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Seu voto é facultativo! Obrigado por exercer sua cidadania durante todos estes anos!");
                        break;
                    case >=18:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Seu voto é obrigatório, exerça sua cidadania!");
                        break;
                    case < 18 and >= 16:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Seu voto é facultativo, que tal exercer sua cidadania!");
                        break;
                    case < 16:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Para votar é preciso ter de mais de 16 anos.");
                        break;

                    default:
                        Console.WriteLine("Você digitou algum valor invalido!");
                        break;
                }
                Console.ResetColor();
            }
        }
    }
}
