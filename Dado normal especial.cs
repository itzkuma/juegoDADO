using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulacro_tarea
{
    class Program
    {
        static void Main(string[] args)
        {
            string continuar = "s", tirarDadoESP = "d";
            int dado = 0, dadoESP = 0, total = 0, vidas = 3, contadorESP = 2, contadorUno = 0, contador6 = 0;
            Random aleatorio = new Random();
            bool vidaExtra = false;
            
            while (total <= 100 && vidas > 0 && continuar == "s")
            {
                if (contadorESP > 0)
                {
                    Console.WriteLine("Desea tirar un dado especial? solo puedes hacerlo " + contadorESP + "veces (d/n)");
                    tirarDadoESP = Console.ReadLine();
                    if (tirarDadoESP == "d")
                    {
                        if (contadorESP != 0)
                        {
                            dado = 0;
                            dadoESP = aleatorio.Next(1, 13);
                            total = total + dadoESP;
                            contadorESP--;
                            Console.WriteLine("Dado= " + dadoESP);
                            Console.WriteLine(" En Total llevas " + total + " puntos, te quedan " + contadorESP + " Dado especial");
                        }
                    }
                }
                else
                 tirarDadoESP = "n";

                //entonces es dado normal
                if (tirarDadoESP == "n")
                {
                    dadoESP = 0;
                    if (contadorESP == 0)
                    {
                     Console.WriteLine("Deseas  tirar un dado normal? (s/n)");
                     continuar = Console.ReadLine();
                    }   
                    dado = aleatorio.Next(1, 7);
                        total = total + dado;
                        Console.WriteLine("Dado= " + dado);
                        Console.WriteLine(" En Total llevas " + total + " puntos");
                }
                if (dado == 1 || dadoESP == 1)
                {
                    contadorUno++;
                    if (contadorUno % 2 == 0)
                    {
                        Console.WriteLine("perdiste una vida");
                        vidas--;
                        Console.WriteLine("vidas=" + vidas);
                        total = total - 10;
                        Console.WriteLine("se restan 10 puntos del total, total= " + total);
                    }
                }
                
                if (dado == 6 || dadoESP == 6)
                {
                    contador6++;
                    if (contador6 % 2 == 0)
                    {
                        vidaExtra = true;
                        if (vidaExtra && vidas < 3)
                        {
                        vidas = vidas + 1;
                        Console.WriteLine("Ganaste una vida!... vidas=" + vidas);
                        }                                
                    }
                }
                else
                {
                    contador6 = 0;
                }
                if (vidas == 0)
                {
                    Console.WriteLine("No te quedan vidas, perdiste!");
                    break;
                }
            } //termina el while
        }
    }
}
