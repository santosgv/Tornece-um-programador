using System;

namespace Tornece_um_programador
{
    class Program
    {

        static int calcular() 
        {
            int a = 1;
            int b = 2;
            int c = a + b;
            return c;
        }

        static public void Mostrar()
        {
            Console.WriteLine("Este e o mostrador de resultados");
        }


        static public void Tabuada(int numero)
        {
            for(int i =1;i <10; i ++)
            {
                Console.WriteLine(numero + "X" + i + " = " + (numero * i));
            }
        }
        static void Main(string[] args)
        {
            string email, senha, nome;

            Console.WriteLine("Digite seu Eamil");
            email = Console.ReadLine();

            Console.WriteLine("Digite sua Senha");
            senha = Console.ReadLine();

            Console.WriteLine("Digite seu Nome");
            nome = Console.ReadLine();

            Console.WriteLine($"Bem vindo {nome} sua senha e {senha} no email {email}");


            Console.WriteLine(calcular());
            int resultado = calcular();
            Console.WriteLine(resultado);

            Mostrar();

            Console.WriteLine("Digite o valor da taboada");
            int valortabuada = Convert.ToInt32(Console.ReadLine());

            Tabuada(valortabuada);
            
            Console.Read();
        }
        
      
    }
}
