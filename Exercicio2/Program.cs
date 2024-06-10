using static System.Net.Mime.MediaTypeNames;
using System.Net;

namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// Um	 município	 deseja	 saber	 a	 porcentagem	 de	 votos	 de	 três	 candidatos,	 além	 da	
            /// porcentagem de  votos brancos e nulos.	Monte um  programa que receba como    entrada o
            /// número de  votos de  cada um  dos três    candidatos e   também os  votos nulos   e brancos.	Ao
            /// final, o   programa deve    apresentar o   total de  votos e   a porcentagem, em  relação a   todos
            /// os  eleitores que votaram,	de votos   de cada    candidato,	votos nulos   e votos   em branco. 
            
            int candidato1 = 0; 
            int candidato2 = 0;
            int candidato3 = 0;
            int nulos =0;
            int brancos = 0;
            int totalVotos = 0;

            Console.WriteLine("Digite o total de votos do CANDITADO 1: ");
            candidato1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o total de votos do CANDITADO 2: ");
            candidato2 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o total de votos do CANDITADO 3: ");
            candidato3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o total de votos BRANCOS: ");
            brancos = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o total de votos NULOS: ");
            nulos = int.Parse(Console.ReadLine());

            totalVotos = candidato1 + candidato2 + candidato3 + brancos + nulos;

            Console.WriteLine("Total de votos foram: " + totalVotos);
            Console.WriteLine("Total de votos Nulos: " + nulos + " Representa " + (nulos / (double)totalVotos * 100).ToString("F2") + "%");
            Console.WriteLine("Total de votos Brancos: " + brancos + " Representa " + (brancos / (double)totalVotos * 100).ToString("F2") + "%");
            Console.WriteLine("Total de votos Candidato 1: " + candidato1 + " Representa " + (candidato1 / (double)totalVotos * 100).ToString("F2") + "%");
            Console.WriteLine("Total de votos Candidato 2: " + candidato2 + " Representa " + (candidato2 / (double)totalVotos * 100).ToString("F2") + "%");
            Console.WriteLine("Total de votos Candidato 3: " + candidato3 + " Representa " + (candidato3 / (double)totalVotos * 100).ToString("F2") + "%");

        }
    }
}
