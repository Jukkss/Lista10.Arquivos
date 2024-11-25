// João Victor Soares Souza - Questão 2  - (Lista10)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Questão2
{
    class Program
    {
        static void Main(string[] args)
        {
            imprimirPesos();
            Console.ReadLine();
        }

        static void imprimirPesos()
        {
            StreamReader arqL = new StreamReader("C:\\ATP\\Lista10_ATP\\arquivo-01.txt", Encoding.UTF8);
            string[] dados;
            int maiorP = int.MinValue; int menorP = int.MaxValue; int i = 0;
            double media, somapeso = 0;

            string linha = arqL.ReadLine();
            int posP = 3;
            while (linha != null)
            {
                dados = linha.Split(';');
                string peso = dados[posP];
                if (int.Parse(peso) > maiorP)
                {
                    maiorP = int.Parse(peso);
                }
                if (int.Parse(peso) < menorP)
                {
                    menorP = int.Parse(peso);
                }
                i++;
                somapeso += int.Parse(peso);
                linha = arqL.ReadLine();
            }
            arqL.Close();
            media = somapeso / i;

            Console.WriteLine($"O maior peso foi: {maiorP}");
            Console.WriteLine($"O menos peso foi: {menorP}");
            Console.WriteLine($"A média dos pesos foi: {media}");
        }
    }
}
