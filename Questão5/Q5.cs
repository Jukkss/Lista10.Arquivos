// João Victor Soares Souza - Questão 5  - (Lista10)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Runtime.InteropServices;
using System.ComponentModel.Design;

namespace Q4
{
    internal class Q5
    {
        static void Main(string[] args)
        {
            StreamReader arqL2 = new StreamReader("arquivo-02.txt", Encoding.UTF8);
            StreamWriter arqE = new StreamWriter("C:\\Users\\1568660\\Source\\Repos\\Lista10.Arquivos\\Questão5\\bin\\Debug\\arquivo-03.txt", false, Encoding.UTF8);
            string[] dados1; string[] dados2; int menorP, maiorP, peso;

            string linha2 = arqL2.ReadLine();
            while (linha2 != null)
            {
                StreamReader arqL1 = new StreamReader("arquivo-01.txt", Encoding.UTF8);
                dados2 = linha2.Split(';');
                menorP = int.Parse(dados2[0]);
                maiorP = int.Parse(dados2[1]);

                string linha1 = arqL1.ReadLine();
                while (linha1 != null)
                {
                    dados1 = linha1.Split(';');
                    peso = int.Parse(dados1[3]);

                    if (peso >= menorP && peso <= maiorP)
                    {
                        string nome = dados1[0];
                        arqE.WriteLine(nome);
                    }
                    linha1 = arqL1.ReadLine();
                }
                linha2 = arqL2.ReadLine();
                arqL1.Close();
            }
            arqL2.Close();
            arqE.Close();
        }
    }
}

