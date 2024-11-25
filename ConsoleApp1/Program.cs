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
        }
        static void imprimirFelinos()
        {
            StreamWriter arqE = new StreamWriter("C:\\ATP\\Lista10_ATP\\cods\\EscritaQ1.txt", false, Encoding.UTF8);
            StreamReader arqL = new StreamReader("C:\\ATP\\Lista10_ATP\\arquivo-01.txt", Encoding.UTF8);
            string[] dados;
            string linha;
            int i = 1; int c = 0;

            linha = arqL.ReadLine();
            while (linha != null)
            { 
                dados = linha.Split(';');
                string raca = dados[i];
                Console.WriteLine($"Raça do felino {c+1}: {raca}");
                i=+2;
                c++;
            }
            arqL.Close();
        }
    }
}
