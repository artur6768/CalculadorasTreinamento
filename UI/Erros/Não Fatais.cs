using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PitagorasReworked.UI.Erros
{
    class UI_Erros
    {
        //Ocorre por:
        public static void Erro001()
        {

        }
        //Ocorre por:
        public static void Erro002()
        {
            Console.Clear();
            Console.WriteLine("[ERRO 002]: UM VALOR INVALIDO FOI INSERIDO\n" +
                                    "Pressione enter para continuar.");
            _ = Console.ReadLine();
            Console.Clear();
        }
    }
}
