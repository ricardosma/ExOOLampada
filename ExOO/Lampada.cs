using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExOO
{
    internal class Lampada
    {
        public bool ligada;
        public double potencia;
        public string marca;
        public string cor;
        public void desligaLampada()
        {
            if(!ligada)//if (ligada == false)
            {
                Console.WriteLine("Já está desligada!");
               
            }
            else//if(ligada == true)
            {
                ligada = false;
                Console.WriteLine("Desligando lâmpada!");
            }
        }

        public void ligaLampada()
        {
            if(ligada)//if(ligada == true)
            {
                Console.WriteLine("Já está ligada!");
            }
            else
            {
                ligada = true;
                Console.WriteLine("Ligando Lâmpada!");
            }
        }
        public void mudaCor(string novacor)
        {
            if(cor == novacor)
            {
                Console.WriteLine("A cor "+novacor+" já era a cor configurada!");
            }
            else
            {
                cor = novacor;
                Console.WriteLine("A nova cor da lâmpada é: "+cor);
            }

        }

        public void apresentaDados()
        {
            Console.WriteLine("A lampada de marca " + marca);
            Console.WriteLine("Tem " + potencia + " wats");
            Console.Write("A cor da lampada está: ");
            if (cor == "azul")
            {                
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else if (cor == "verde")
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Green;
            }
            Console.WriteLine(cor);
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;

            if (ligada)
            {
                Console.WriteLine("A mimosa tá ligada!");
            }
            else
            {
                Console.WriteLine("Ta desmaiada!");
            }
        }

        
        //public void 
    }
}
