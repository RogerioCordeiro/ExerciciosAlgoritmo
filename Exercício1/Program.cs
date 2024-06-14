namespace ExerciciosAlgoritmo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Escreva um programa para que	sejam informados 10 (dez) números inteiros.
            // O programa deve informar o menor   e o   maior valor   informado.

            int maior = 0; int n = 0; int menor = 0;
            Console.WriteLine("Digite um número interior: ");
            int input = int.Parse(Console.ReadLine());

            maior = input;
            menor = input;

            while (true)
            {

                Console.WriteLine("Digite um número interior: ");
                input = int.Parse(Console.ReadLine());

                if (maior <= input)
                {
                    maior = input;
                }
                if (menor >= input)
                {
                    menor = input;
                }
                n++;
                if (n > 10)
                {
                    break;
                }
            }

            Console.WriteLine("O maior número digitado foi: " + maior);
            Console.WriteLine("O menor número digitado foi: " + menor);
        }
    }
}
