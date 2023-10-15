using PitagorasReworked.UI.Erros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PitagorasReworked
{
    class EhValdio
    {
        public double UmDouble(string Entrada)
        {
            bool Verificar;
            double Saída;
            while (true)
            {
                Verificar = double.TryParse(Entrada, out Saída);  
                if (Verificar) break;
                Console.Clear();

            }
            Verificar = false;
            return Saída;
        }
        public static int UmInt(string TextoVindoDOMenu)
        {
            string Entrada;
            bool Verificar;
            int Saída;
            while (true)
            {
                Console.WriteLine(TextoVindoDOMenu);
                Console.WriteLine(TextosGenericos.SuaEsch);
                Entrada = Console.ReadLine();
                Verificar = int.TryParse(Entrada, out Saída);
                if (Verificar) break;
                Console.Clear();
                UI_Erros.Erro002();
            }
            Verificar = false;
            return Saída;
        }
    }
}
