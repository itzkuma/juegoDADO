﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace validacion
{
    class Program
    {
        static void Main(string[] args)
        {

            Random aleatorio = new Random();

            int oportunidades = 3;
            
            int respuesta = 0;
            int respuestaVerdad = -1;
            while (respuesta != respuestaVerdad && oportunidades != 0)
            {
                int pregunta1 = aleatorio.Next(1, 7);
               
                Console.WriteLine("cuanto es " + pregunta1 + " mas " + pregunta1 + " ?");
                respuesta = int.Parse(Console.ReadLine());
                respuestaVerdad = pregunta1 + pregunta1;
                if (respuesta == respuestaVerdad)
                    break;
                if (respuesta != respuestaVerdad)
                {
                    oportunidades--;
                    if (oportunidades == 0)
                    {
                        Console.WriteLine("No puedes continuar");
                    }
                }
            }
            if (oportunidades != 0)
            {
                string continuar = "s", TirarDado = "d";
                int dado = 0, dado2 = 0, total = 0, vidas = 3, perderVida = 0, dobles = 0, turnos = 0;
                //Random aleatorio = new Random();
                bool vidaExtra = false;

                Console.WriteLine("Tirar un dado? (d/n)");
                TirarDado = Console.ReadLine();


                while (total <= 100 && vidas > 0 && continuar == "s" && TirarDado == "d")
                {

                    dado = aleatorio.Next(1, 7);
                    turnos++;
                    total++;
                    total = +dado;

                    Console.WriteLine("Dado= " + dado);
                    Console.WriteLine("Llevas " + total + " puntos");
                    Console.WriteLine("LLevas " + turnos + " turnos");


                    if (turnos % 2 == 0)
                    {
                        vidas = vidas - 1;
                        Console.WriteLine("perdiste una vida... vidas= " + vidas);
                    }
                    if (turnos % 3 == 0)
                    {
                        Console.WriteLine("Tienes 2 dados");
                        dado = aleatorio.Next(1, 7);
                        dado2 = aleatorio.Next(1, 7);
                        turnos++;
                        total++;
                        total = +dado + dado2;
                        Console.WriteLine("Dado=" + dado);
                        Console.WriteLine("Dado2=" + dado2);
                        Console.WriteLine("Llevas " + total + " puntos");
                        Console.WriteLine("LLevas " + turnos + " turnos");
                        if (dado == dado2)
                        {
                            vidaExtra = true;
                            vidas = vidas + 1;
                            Console.WriteLine("Ganaste una vida!... vidas= " + vidas);
                        }
                    }
                    if (vidas == 0)
                    {
                        Console.WriteLine("No te quedan vidas, perdiste!");
                        break;
                    }
                    if (total >= 100)
                    {
                        Console.WriteLine("Ganaste!");
                        continuar = "n";
                    }
                    Console.WriteLine("Tirar otro dado? (d/n)");
                    TirarDado = Console.ReadLine();
                    //termina el while
                }
            }
        }
    }
}
