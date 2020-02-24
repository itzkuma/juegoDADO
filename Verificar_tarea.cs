using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int carta = 0, total = 0;
            int carta2 = 0;
            string continuar = "s";
            string sacarCarta = "c";
            int jugadores = 0;
          



            while (jugadores == 0 || jugadores < 2 || jugadores > 5)
            {
                Console.WriteLine("Ingrese el numero de jugadores (de 2 a 5)");
                jugadores = int.Parse(Console.ReadLine());
                if (jugadores < 2 || jugadores > 5)
                {
                    Console.WriteLine("solo de 2 a 5 jugadores");
                }
                else
                    break;
            }
            //jugador1
            carta = aleatorio.Next(1, 10);
            carta2 = aleatorio.Next(1, 10);
            Console.WriteLine("primera carta:" + carta);
            Console.WriteLine("segunda carta:" + carta2);
            total += carta + carta2;
            Console.WriteLine("total:" + total);

            while (sacarCarta != "c" || sacarCarta != "n"  )
            {
                Console.WriteLine("deseas sacar una carta?(c/n)");
                sacarCarta = Console.ReadLine();
                
                if ( sacarCarta == "c" )
                {
                    break;
                }
                else if (sacarCarta == "n")
                {
                    Console.WriteLine("Juego finalizado");
                    continuar = "n";
                }
                
                else if (sacarCarta != "c" || sacarCarta != "n")
                {
                    Console.WriteLine("c/n");
                }
            }
            
            while (continuar == "s" && sacarCarta == "c" && sacarCarta != "n" && total < 21)
            {
                carta = aleatorio.Next(1, 10);
                Console.WriteLine("carta:" + carta);
                total += carta;
                if (total > 21)

                {
                    Console.WriteLine("perdiste!...ya no puedes continuar... total=" + total);
                }
                else if (total == 21)
                {
                    Console.WriteLine("Ganaste!!");
                    Console.WriteLine("desea continuar?(s/n)");
                    continuar = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("total=" + total);
                    Console.WriteLine("deseas sacar una carta?(c/n)");
                    sacarCarta = Console.ReadLine();
                    while (sacarCarta != "c" || sacarCarta != "n")
                    {
                        Console.WriteLine("deseas sacar una carta?(c/n)");
                        sacarCarta = Console.ReadLine();

                        if (sacarCarta == "c")
                        {
                            break;
                        }
                        else if (sacarCarta == "n")
                        {
                            Console.WriteLine("Juego finalizado");
                            continuar = "n";

                        }

                        else if (sacarCarta != "c" || sacarCarta != "n")
                        {
                            Console.WriteLine("c/n");
                        }
                    }
                }
            }

            //jugador2
            carta = aleatorio.Next(1, 10);
            carta2 = aleatorio.Next(1, 10);
            Console.WriteLine("primera carta:" + carta);
            Console.WriteLine("segunda carta:" + carta2);
            total += carta + carta2;
            Console.WriteLine("total:" + total);


            Console.WriteLine("deseas sacar una carta?(c/n)");
            sacarCarta = Console.ReadLine();
            while (continuar == "s" && sacarCarta == "c" && total < 21)
            {
                carta = aleatorio.Next(1, 10);
                Console.WriteLine("carta:" + carta);
                total += carta;
                if (total > 21)

                {
                    Console.WriteLine("perdiste!...ya no puedes continuar... total=" + total);
                }
                else if (total == 21)
                {
                    Console.WriteLine("Ganaste!!");
                    Console.WriteLine("desea continuar?(s/n)");
                    continuar = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("total=" + total);
                    Console.WriteLine("deseas sacar una carta?(c/n)");
                    sacarCarta = Console.ReadLine();
                }
            }

            //jugador3
            carta = aleatorio.Next(1, 10);
            carta2 = aleatorio.Next(1, 10);
            Console.WriteLine("primera carta:" + carta);
            Console.WriteLine("segunda carta:" + carta2);
            total += carta + carta2;
            Console.WriteLine("total:" + total);


            Console.WriteLine("deseas sacar una carta?(c/n)");
            sacarCarta = Console.ReadLine();
            while (continuar == "s" && sacarCarta == "c" && total < 21)
            {
                carta = aleatorio.Next(1, 10);
                Console.WriteLine("carta:" + carta);
                total += carta;
                if (total > 21)

                {
                    Console.WriteLine("perdiste!...ya no puedes continuar... total=" + total);
                }
                else if (total == 21)
                {
                    Console.WriteLine("Ganaste!!");
                    Console.WriteLine("desea continuar?(s/n)");
                    continuar = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("total=" + total);
                    Console.WriteLine("deseas sacar una carta?(c/n)");
                    sacarCarta = Console.ReadLine();
                }
            }
            //jugador4
            carta = aleatorio.Next(1, 10);
            carta2 = aleatorio.Next(1, 10);
            Console.WriteLine("primera carta:" + carta);
            Console.WriteLine("segunda carta:" + carta2);
            total += carta + carta2;
            Console.WriteLine("total:" + total);


            Console.WriteLine("deseas sacar una carta?(c/n)");
            sacarCarta = Console.ReadLine();
            while (continuar == "s" && sacarCarta == "c" && total < 21)
            {
                carta = aleatorio.Next(1, 10);
                Console.WriteLine("carta:" + carta);
                total += carta;
                if (total > 21)

                {
                    Console.WriteLine("perdiste!...ya no puedes continuar... total=" + total);
                }
                else if (total == 21)
                {
                    Console.WriteLine("Ganaste!!");
                    Console.WriteLine("desea continuar?(s/n)");
                    continuar = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("total=" + total);
                    Console.WriteLine("deseas sacar una carta?(c/n)");
                    sacarCarta = Console.ReadLine();
                }
            }

            //jugador5
            carta = aleatorio.Next(1, 10);
            carta2 = aleatorio.Next(1, 10);
            Console.WriteLine("primera carta:" + carta);
            Console.WriteLine("segunda carta:" + carta2);
            total += carta + carta2;
            Console.WriteLine("total:" + total);


            Console.WriteLine("deseas sacar una carta?(c/n)");
            sacarCarta = Console.ReadLine();
            while (continuar == "s" && sacarCarta == "c" && total < 21)
            {
                carta = aleatorio.Next(1, 10);
                Console.WriteLine("carta:" + carta);
                total += carta;
                if (total > 21)

                {
                    Console.WriteLine("perdiste!...ya no puedes continuar... total=" + total);
                }
                else if (total == 21)
                {
                    Console.WriteLine("Ganaste!!");
                    Console.WriteLine("desea continuar?(s/n)");
                    continuar = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("total=" + total);
                    Console.WriteLine("deseas sacar una carta?(c/n)");
                    sacarCarta = Console.ReadLine();
                }
            }
            Console.WriteLine("Juego finalizado");
        }
    }
}