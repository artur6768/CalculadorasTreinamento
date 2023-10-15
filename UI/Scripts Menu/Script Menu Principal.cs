using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PitagorasReworked
{
    class Script_Menu
    {
        public static void Principal()
        {
            Console.Clear();
            int Saída = 0;
            // MENU PRINCIPAL DO MAIN
                Saída = EhValdio.UmInt($"{Menus_Principal.MenuPrincipal}");
                Console.WriteLine($"DEBUG:{Saída}");
                Console.ReadLine();
            /*
            switch (Saída)
            {
                case 1:
                    CalcPitagoras.Principal();
                    break;
                case 2:
                    CalcEsfera.Principal();
                    break;
                case 3:
                    AreaCirc.Principal();
                    break;
                case 4:
                    CumprCirc.Principal();
                    break;
                case 5:
                    break;
                case 7:
                    CalculadoraETS2.Principal();
                    break;
                case 8:
                    UIMeteo.Principal();
                    break;
                default:
                    UIErros.Erro002();
                    Selecao();
                    break;
            }
            */
        }
    }
}


