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
            Console.WindowWidth = 80;
        }
        public static void Selecao()
        {
            //VARS LOCAL
            bool verificar;
            int userout;
            //
            while (true)
            {
                Console.WriteLine("==========================================\n" +
                                   "Qual calculadora deseja utiizar?\n" +
                                           "[1] Pitagoras\n" +
                                      "[2] Volume da esfera\n" +
                                          "[3] Area do circulo\n" +
                                      "[4] Comprimento do circulo\n" +
                              "==========================================");

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
                    AreaCirc.Principal();
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
        public static void Escolha()
        {
            //VARIAVEL LOCAL
            bool miniverificar = true;
            //
            while (miniverificar)
            {
                Console.WriteLine("Pressione enter para continuar.");
                _ = Console.ReadLine();
                Console.WriteLine("Deseja usar outra calculadora? (S/n)");
                string retornar = Console.ReadLine();
                switch (retornar)
                {
                    case "y" or "Y" or "S" or "s":
                        miniverificar = false;
                        UserInterface.Selecao();
                        break;
                    case "n" or "N":
                        miniverificar = false;
                        UserInterface.Fim();
                        break;
                    default:
                        break;
                }
                Console.Clear();
                Console.WriteLine("Erro, opção invalida, use S para sim e N para não.");
            }
        }
    }
    class CalcPitagoras
    { 
        public static void Principal()
        {
            //VARS LOCAL
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
            Console.WriteLine($"O resultado da hipotenusa é: {resultado}");
            UserInterface.Escolha();
        }
    }
    class CalcEsfera
    { }
    class AreaCirc
    {
        //RECEBER GLOBAL
        readonly double pi = VariaveisGlobais.Pi;
        //
        //VARIAVEIS DA CLASSE
        double resultado;
        bool verificar;
        double userout;
        //
        public static void Principal()
        {
            //VARS LOCAL
            bool verificar;
            int userout;
            //
            Console.WriteLine("==========================================\n" +
                                        "O que deseja fazer ?\n" +
                                        "[1] Usar diâmetro\n" +
                                        "[2]  Usar raio\n" +
                                        "[3]   Voltar \n" +
                              "==========================================");
            while (true)
            {
                Console.Write("Sua escolha: ");
                verificar = int.TryParse(Console.ReadLine(), out (userout));
                if (verificar) break;
                Console.Clear();
                Console.WriteLine("Erro, opção invalida.");
            }
            verificar = false;
            switch (userout)
                {
                    case 1:
                        var instanciadiametro = new AreaCirc();
                        instanciadiametro.Diametro();
                        break;
                    case 2:
                        var instanciaraio = new AreaCirc();
                        instanciaraio.Raio();
                        break;
                    case 3:
                        UserInterface.Selecao();
                        break;
                }
        }
        public void Diametro()
        {
            //VARS LOCAL
            double ra1;
            double ra2;
            //
            while (true)
            {
                Console.WriteLine("Por favor, insira o valor do diametro em centímetros: ");
                verificar = double.TryParse(Console.ReadLine(), out (userout));
                if (verificar) break;
                Console.Clear();
                Console.WriteLine("Erro, valor invalido.");
            }
            ra1 = (userout/2);
            ra2 = (ra1 * ra1);
            resultado = (pi*ra2);
            Console.WriteLine($"A área deste circulo é {resultado} CM²");
            UserInterface.Escolha();
        }
        public void Raio()
        {
            //VARS LOCAL
            //
            while (true)
            {
                Console.WriteLine("Por favor, insira o valor do raio em centímetros: ");
                verificar = double.TryParse(Console.ReadLine(), out (userout));
                if (verificar) break;
                Console.Clear();
                Console.WriteLine("Erro, valor invalido.");
            }
            resultado = (pi)*(userout*userout);
            Console.WriteLine($"A área deste circulo é {resultado} CM²");
            UserInterface.Escolha();
        }
    }
}
