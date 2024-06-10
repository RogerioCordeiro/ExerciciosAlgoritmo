namespace Exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// Um caixa precisa de um programa	que	o auxilie no fornecimento de valores com o mínimo	
            /// de cédulas / moedas possíveis.Monte um programa que seja fornecido o valor(inteiro) a
            /// ser fornecido e tenha como saída o total de cédulas utilizadas, nos valores de 100, 50, 20,	
            /// 10, 5, 2 e 1.
            
            int[] cedulas = { 100, 50, 20, 10, 5, 2, 1 };

            while (true) { 
                Console.WriteLine("Digite o valor que deseja fornecer o troco (Valor Inteiro) ou 0 para sair");
                int input = int.Parse(Console.ReadLine());

                if (input == 0)
                {
                    break;
                }

                Console.WriteLine("Para o valor " + input + " será necessario as seguintes notas.");

                foreach (int cedula in cedulas)
                {
                    int quantidade = input / cedula;
                    
                    if (quantidade > 0)
                    {
                        Console.WriteLine(quantidade + " cédula(s) de R$ " + cedula);
                    }
                    input %= cedula;
                }

                
            }
        }
    }
}
