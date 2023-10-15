using System;

namespace PitagorasReworked
{
    class Menus_Encerramento
    {
        public static void Fim()
        {
            Console.WriteLine("Obrigado por utilizar o meu Software, Artur6768, 2023\n" +
                              "Retornado ao Terminal...");
            Environment.ExitCode = -1;

        }
    }
}