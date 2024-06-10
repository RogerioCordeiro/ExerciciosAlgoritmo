namespace Exercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vamos verificar se um ano é bissexto!");
            while (true)
            {
                Console.WriteLine("Digite um ano apartir de 1582 com 4 digitos (Exemplo: 2024) ou 999 para sair!");
                int ano = int.Parse(Console.ReadLine());

                
                if (ano == 999)
                {
                    break;
                }
                if ((ano > 1582)) { 
                    if ((ano % 4) == 0 )
                    {
                        if ((ano % 100) == 0)
                        {
                            if ((ano % 400) == 0)
                            {
                                Console.BackgroundColor = ConsoleColor.Green;
                                Console.WriteLine("O ano " + ano + " é BISSEXTO");
                            }
                            else
                            {
                                Console.BackgroundColor = ConsoleColor.Blue;
                                Console.WriteLine("O ano de " + ano + " não é BISSEXTO!");
                            }
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.WriteLine("O ano de " + ano + " não é BISSEXTO!");
                        }
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine("O ano de " + ano + " não é BISSEXTO!");
                    }
                }else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Este ano não está dentro do período do Calendário Gregoriano!");
                }
                Console.ResetColor();
               
            }
        }
    }
}
