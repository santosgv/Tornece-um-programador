using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tornece_um_programador
{
    class Tabuada
    {
        static public void tabuada(int numero)
        {
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(numero + "X" + i + " = " + (numero * i));
            }
        }
    }
}
