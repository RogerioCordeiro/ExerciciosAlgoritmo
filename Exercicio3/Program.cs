namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Elabore	um	programa	que	receba	a	nota	de	um	aluno	e	diga	se	o	mesmo	foi	aprovado	ou	
            // reprovado.O aluno   é aprovado    com nova    maior ou  igual a   6,0(seis).

            while (true)
            {
                Console.WriteLine("Digite a NOTA do aluno ou digite 100 para sair: ");
                int nota = int.Parse(Console.ReadLine());
                
                if (nota == 100)
                {
                    break;
                }

                if (nota >= 6)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Aluno aprovado!");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Aluno reprovado!");
                }
                Console.ResetColor();


            }
        }
    }
}
