// João Victor Soares Souza - Questão 3  - (Lista10)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace Questão3
{
    internal class Q3
    {
        static void Main(string[] args)
        {
            imprimirNomeP();
        }

        static void imprimirNomeP()
        {
            StreamReader arqL = new StreamReader("arquivo-01.txt", Encoding.UTF8);
            string[] dados; int idade; string nomesPop; int posI = 4; int posN = 0;

            string linha = arqL.ReadLine();
            Console.WriteLine($"Gatos com idade em cativeiro entre 10 e 16 anos:");
            while (linha != null)
            {
                dados = linha.Split(';');
                idade = int.Parse(dados[posI]);
                if (idade >= 10 && idade <= 16)
                {
                    nomesPop = dados[posN];
                    Console.WriteLine(nomesPop);
                }
                linha = arqL.ReadLine();
            }
            arqL.Close();
        }
    }
}
