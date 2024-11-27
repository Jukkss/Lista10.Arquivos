// João Victor Soares Souza - Questão 6  - (Lista10)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Runtime.InteropServices;
using System.ComponentModel.Design;

namespace Questão6
{
    class Q6
    {
        static void Main(string[] args)
        {
            StreamReader arqL = new StreamReader("usuarios.txt",Encoding.UTF8);
            StreamWriter arqE = new StreamWriter("relatorio.txt", false, Encoding.UTF8);
            double espacoT = 53687091200, espacoU, percenU, percenT = 0;
            string[] dados;

            string linhaL = arqL.ReadLine();
            while (linhaL != null)
            {
                dados = linhaL.Split('/');
                espacoU = double.Parse(dados[1]);
                percenU = (espacoU/espacoT)*100;
                percenT += percenU;
                string nome = dados[0];
                arqE.WriteLine($"Nome: {nome} / Percentual de espaço: {percenU:F2}");

                linhaL = arqL.ReadLine();
            }
            arqE.WriteLine($"Seu disco está {percenT:F2}% ocupado.");
            arqL.Close();
            arqE.Close();
        }
    }
}
