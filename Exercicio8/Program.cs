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
            Console.WriteLine("Quer descobrir seu IMC? Insira seu peso e sua altura nos campos abaixo e compare com os índices da tabela. Importante: siga os exemplos e use pontos como separadores.");
            
            while (true)
            {
                
                Console.WriteLine("Informe o PESO da pessoa:");
                float peso = float.Parse(Console.ReadLine());
                Console.WriteLine("Informe a ALTURA da pessoa:");

            }
        }
    }
}
