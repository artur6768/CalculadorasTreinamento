using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace Calculadoras
{
    public static class VariaveisGlobais
    {
        //VARS GLOBAL
        public const double Pi = 3.14;
    }
    class UserInterface
    {
        public static void Main(string[] args)
        {
            Splash();
            Selecao();
        }
        static void Splash()
        {
            Console.WindowWidth = 160;
            Console.WindowHeight = 25;
            Console.WriteLine
(@"
===========================================================================================================================================================
 █████╗ ██████╗ ████████╗██╗   ██╗██████╗  ██████╗███████╗ ██████╗  █████╗     ███████╗ ██████╗ ███████╗████████╗██╗    ██╗ █████╗ ██████╗ ███████╗███████╗
██╔══██╗██╔══██╗╚══██╔══╝██║   ██║██╔══██╗██╔════╝╚════██║██╔════╝ ██╔══██╗    ██╔════╝██╔═══██╗██╔════╝╚══██╔══╝██║    ██║██╔══██╗██╔══██╗██╔════╝██╔════╝
███████║██████╔╝   ██║   ██║   ██║██████╔╝███████╗    ██╔╝███████╗ ╚█████╔╝    ███████╗██║   ██║█████╗     ██║   ██║ █╗ ██║███████║██████╔╝█████╗  ███████╗
██╔══██║██╔══██╗   ██║   ██║   ██║██╔══██╗██╔═══██╗  ██╔╝ ██╔═══██╗██╔══██╗    ╚════██║██║   ██║██╔══╝     ██║   ██║███╗██║██╔══██║██╔══██╗██╔══╝  ╚════██║
██║  ██║██║  ██║   ██║   ╚██████╔╝██║  ██║╚██████╔╝  ██║  ╚██████╔╝╚█████╔╝    ███████║╚██████╔╝██║        ██║   ╚███╔███╔╝██║  ██║██║  ██║███████╗███████║
╚═╝  ╚═╝╚═╝  ╚═╝   ╚═╝    ╚═════╝ ╚═╝  ╚═╝ ╚═════╝   ╚═╝   ╚═════╝  ╚════╝     ╚══════╝ ╚═════╝ ╚═╝        ╚═╝    ╚══╝╚══╝ ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚══════╝
===========================================================================================================================================================");
            Console.Beep(800, 500);
            Thread.Sleep(300);
            Console.Clear();
            Console.WindowWidth = 100;
        }
        static void Selecao()
        {
            //VARS LOCAL
            bool verificar;
            int userout;
            //
            Console.WriteLine("==========================================\n" +
                                   "Qual calculadora deseja utiizar?\n" +
                                           "[1] Pitagoras\n" +
                                      "[2] Volume da esfera\n" +
                                          "[3] Area do circulo\n" +
                                      "[4] Comprimento do circulo\n" +
                              "==========================================");
            while (true)
            {
                Console.Write("Sua escolha: ");
                verificar = int.TryParse(Console.ReadLine(), out (userout));
                if (verificar) break;
                Console.Clear();
                Console.WriteLine("Erro, opção invalida.");
            }
            switch (userout)
            {
                case 1:
                    CalcPitagoras.Principal();
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
            }
        }
        public static void Fim()
        {
            Console.WriteLine("Obrigado por utilizar o meu Software, Artur6768, 2022");
            Console.WriteLine("Retornado ao Terminal...");
            Environment.ExitCode = -1;
        }
    }
    class CalcPitagoras
    { 
        public static void Principal()
        {
            //VARS local
            bool verificar;
            double cat1;
            double cat2;
            double catqua1;
            double catqua2;
            double resultado;
            //
            while (true)
            {
                Console.WriteLine("Por favor, insira o valor do primeiro cateto.");
                verificar = double.TryParse(Console.ReadLine(), out (cat1));
                if (verificar) break;
                Console.Clear();
                Console.WriteLine("Erro, valor invalido.");
            }
            while (true)
            {
                Console.WriteLine("Por favor, insira o valor do segundo cateto.");
                verificar = double.TryParse(Console.ReadLine(), out (cat2));
                if (verificar) break;
                Console.Clear();
                Console.WriteLine("Erro, valor invalido.");
            }
            catqua1 = (cat1 * cat1);
            catqua2 = (cat2 * cat2);
            resultado = Math.Sqrt(catqua1 + catqua2);
            Console.WriteLine($"O resultado será: {resultado}");
            Console.WriteLine("Pressione qualquer tecla para continuar (No futuro, será possivel escolher outras opções");
            _ = Console.ReadLine();
            UserInterface.Fim();
        }
    }
}
