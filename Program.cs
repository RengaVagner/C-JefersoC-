using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, aux;
            string auxpac, entrada;
            string[] pac = new string[10];
            int[] prio = new int[10];

            Console.WriteLine("Escolha uma ação! 1 para cadastar 2 para atendimento!");
            entrada = Console.ReadLine();

            switch (entrada)
            {
                case "1": //Para cadastar
                    Console.WriteLine("Dig. nome paciente;");
                    pac[i] = Console.ReadLine();
                    Console.WriteLine("Paciente prioritorio?1 para sim 0 para nao!");
                    prio[i] = Convert.ToInt16(Console.ReadLine());
                    while (prio[i] == 1 && prio[i] == 0)
                    {
                        Console.WriteLine("Paciente prioritorio?1 para sim 0 para nao!");
                        prio[i] = Convert.ToInt16(Console.ReadLine());
                    }
                    break;

                case "2": // para atender

                    Console.WriteLine("Dig. nome paciente;");
                    pac[i] = null;
                   

                    break;




            }


                //cadastar pacientes!
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Dig. nome paciente;");
                pac[i] = Console.ReadLine();
                Console.WriteLine("Paciente prioritorio?1 para sim 0 para nao!");
                prio[i] = Convert.ToInt16(Console.ReadLine());
                while (prio[i] == 1 && prio[i] == 0)
                {
                    Console.WriteLine("Paciente prioritorio?1 para sim 0 para nao!");
                    prio[i] = Convert.ToInt16(Console.ReadLine());
                }

                if ( prio[i] != 0) //Validar prioridade!!!
                {
                    aux = prio[i];
                    prio[i] = prio[i + 1];
                    prio[i + 1] = aux;
                    auxpac = pac[i];
                    pac[i + 1] = pac[i];
                    pac[i = 1] = auxpac;

                }



            }
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("teste paciente;",pac[i]);

                Console.WriteLine("teste prioritorio", prio[i]);

            }

        }
    }
}