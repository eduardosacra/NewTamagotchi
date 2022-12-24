using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTamagotchiLib.View
{
    public class MenuIterativo
    {
        public void BoasVindas()
        {
            Console.WriteLine("      ###########");
            Console.WriteLine("           #         ##    #      #   ##     ####     ####   #######   ####   #    #  #"); 
            Console.WriteLine("           #        #  #   ##    ##  #  #   #    #   #    #     #     #    #  #    #  #");
            Console.WriteLine("           #       #    #  #  ##  # #    #  #        #    #     #     #       ######  #");
            Console.WriteLine("           #       ######  #      # ######  #   ###  #    #     #     #       #    #  #");
            Console.WriteLine("           #       #    #  #      # #    #  #     #  #    #     #     #    #  #    #  #"); 
            Console.WriteLine("           #       #    #  #      # #    #   #####    ####      #      ####   #    #  #");


        }

        public void ExibirChocando()
        {
            Console.WriteLine("       ###");
            Console.WriteLine("      #####");
            Console.WriteLine("     ########");
            Console.WriteLine("     ########");
            Console.WriteLine("     ########");
            Console.WriteLine("      #######");
            Console.WriteLine("       #####");
        }

        public void SeparadorMenu()
        {
            Console.WriteLine("----------------------------------------------------------");
        }

        public void ExibirTitulo(string titulo = "")
        {            
            while(titulo.Length <= 100)
            {
                titulo = "-" + titulo + "-";
            }
            titulo = titulo.ToUpper();
            Console.WriteLine(titulo);
        }
    }
}
