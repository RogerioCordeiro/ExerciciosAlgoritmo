namespace Exercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Monte um programa que calcule o IMC (Índice de Massa Corporal) de uma pessoa.
            //Deve ser fornecido como entrada o peso em kg, a altura em metros e o sexo.
            //Como saída, deve ser exibido o IMC e mostrar em qual faixa de risco a pessoa se encontra.

            // VEJA A INTERPRETAÇÃO DO IMC
            // IMC CLASSIFICAÇÃO   OBESIDADE(GRAU)
            // MENOR QUE 18,5  MAGREZA 0
            // ENTRE 18,5 E 24,9   NORMAL  0
            // ENTRE 25,0 E 29,9   SOBREPESO I
            // ENTRE 30,0 E 39,9   OBESIDADE II
            // MAIOR QUE 40,0  OBESIDADE GRAVE III

            Console.WriteLine("Cálculo IMC");
            Console.WriteLine("IMC é a sigla para Índice de Massa Corpórea, parâmetro adotado pela Organização Mundial de Saúde para calcular o peso ideal de cada pessoa.");
            Console.WriteLine("O índice é calculado da seguinte maneira: divide-se o peso do paciente pela sua altura elevada ao quadrado. Diz-se que o indivíduo tem peso normal quando o resultado do IMC está entre 18,5 e 24,9.");
            Console.WriteLine("Quer descobrir seu IMC? Insira seu peso e sua altura. Importante: use pontos como separadores.");
            Console.WriteLine();
            while (true)
            {
                Console.WriteLine("Digite 999 em qualquer opção para sair");

                Console.WriteLine("Informe o GENERO da pessoa:");
                string sexo = Console.ReadLine();
                if (sexo == "999")
                {
                    break;
                }

                Console.WriteLine("Informe o PESO da pessoa em Kg. Exemplo: 69.2:");
                double peso = double.Parse(Console.ReadLine());
                if (peso == 999)
                {
                    break;
                }

                Console.WriteLine("Informe a ALTURA da pessoa em metros. Exemplo: 1.72 :");
                double altura = double.Parse(Console.ReadLine());
                if (altura == 999)
                {
                    break;
                }
                Console.WriteLine();

                double IMC = Math.Round(peso / (Math.Pow(altura, 2)), 1);
                
                Console.WriteLine("A pessoa do Genero " + sexo + " tem o IMC de " + IMC);

                if (IMC <= 18.5 )
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("IMC Classificado como MAGREZA 0");
                }else if(IMC < 25)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("IMC Classificado como NORMAL 0");
                }else if(IMC < 30)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("IMC Classificado como SOBREPESSO I");
                }else if(IMC < 40)
                {
                    // ENTRE 30,0 E 39,9   OBESIDADE II
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("IMC Classificado como OBESIDADE II");
                }else if(IMC > 40 )
                {
                    // MAIOR QUE 40,0  OBESIDADE GRAVE III
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("IMC Classificado como OBESIDADE GRAVE III");
                }

                Console.ResetColor();
                Console.WriteLine();
            }
        }
    }
}
