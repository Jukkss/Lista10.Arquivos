// João Victor Soares Souza - Questão 1 - (Lista10)
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            imprimirFelinos();
            Console.ReadLine();
        }
        static void imprimirFelinos()
        {
            StreamReader arqL = new StreamReader("C:\\ATP\\Lista10_ATP\\arquivo-01.txt", Encoding.UTF8);
            string[] dados;
            string linha;
            int i = 1; int c = 1;

            linha = arqL.ReadLine();
            while (linha != null)
            { 
                dados = linha.Split(';');
                string raca = dados[i];
                Console.WriteLine($"Raça do felino {c}: {raca}");
                i=+1;
                c++;

                linha = arqL.ReadLine();
            }
            arqL.Close();
        }
    }
}
