// João Victor Soares Souza - Questão 1 - (Lista10)
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Q1
    {
        static void Main(string[] args)
        {
            imprimirFelinos();
            Console.ReadLine();
        }
        static void imprimirFelinos()
        {
            StreamReader arqL = new StreamReader("arquivo-01.txt", Encoding.UTF8);
            string[] dados;
            string linha;
            int posR = 1; int c = 1;

            linha = arqL.ReadLine();
            while (linha != null)
            { 
                dados = linha.Split(';');
                string raca = dados[posR];
                Console.WriteLine($"Raça do felino {c}: {raca}");
                c++;

                linha = arqL.ReadLine();
            }
            arqL.Close();
        }
    }
}
