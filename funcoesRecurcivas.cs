using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Tornece_um_programador
{
    class funcoesRecurcivas
    {
        public static void Lerarquivo(int arquivos)
        {
            string caminho = @"C:\Users\Vitor\source\repos\Tornece um programador\arquivos\texto" + arquivos + ".txt";

            if (File.Exists(caminho))
            {
            using (StreamReader arquivo = File.OpenText(caminho))
            {
                string linha;
                while ((linha =arquivo.ReadLine()) != null)
                {
                    Console.WriteLine(linha);
                }
            }

            }
            string caminho2 = @"C:\Users\Vitor\source\repos\Tornece um programador\arquivos\texto" + (arquivos+1) + ".txt";
            if (File.Exists(caminho2))
            {
                Lerarquivo(arquivos + 1);
            }
            else
                
                Console.WriteLine("Nao tem mais arquivo ou arquivo nao existe no diretorio");
        }
    }
}
