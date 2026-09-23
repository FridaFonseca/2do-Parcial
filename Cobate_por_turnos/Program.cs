/*

ANÁLISIS DEL PROBLEMA:

OBJETIVO:
Crear un programa en el qe el jugador enfrenta a un enemigo en un combate por turnos,
cumpliendo con las siguientes condiciones

ENTRADA:
Que el jugador elija entre curar o atacar

SALIDA:
Que se muestre si el jugador quiere curar o atacar
Vida y ataque de cada jugador
Movimiento de cada turno
*/

/*
 * PSEUDOCÓDIGO
 * Definir jugador 1 y 2, definir enteros y el valor máximo de ambos de vida y ataque
 * Mostrar bool que diga al jugador cúal va primero
 * Usar un do while para los ataques
 *
 *
 */


int jugador1 = 28;
int jugador2 = 28;
int curacion = 5;

Console.WriteLine("El jugador 1 tiene vida de " + jugador1);
Console.WriteLine("El jugador 2 tiene vida de " + jugador2);

Random random = new Random();

bool primerTurno = random.Next(0, 2) == 0;

if (primerTurno == true)
{
    do
    {
        bool respuestaValida1 = false;

        do
        {
            Console.WriteLine("JUGADOR UNO: ¿Deseas atacar o curar?, 1 para atacar, 2 para curar");
            string decision1 = Console.ReadLine();
            bool conversion1 = int.TryParse(decision1, out int decision1Int);

            if (conversion1 == true)
            {
                switch (decision1Int)
                {
                    case 1:
                        int ataque = random.Next(1, 11);

                        jugador2 = jugador2 - ataque;

                        if (jugador2 < 0)
                        {
                            jugador2 = 0;
                        }

                        Console.WriteLine("El jugador1 realizo un ataque de " + ataque + " a el jugador2");
                        Console.WriteLine("Vida del jugador2:" + jugador2);

                        respuestaValida1 = true;
                        break;

                    case 2:
                        if (jugador1 == 28)
                        {
                            Console.WriteLine("El jugador1 permanece con 28 de vida");
                        }
                        else
                        {
                            jugador1 = jugador1 + curacion;

                            if (jugador1 > 28)
                            {
                                jugador1 = 28;
                            }

                            Console.WriteLine("El jugador1 se curo, su vida es de: " + jugador1);
                        }

                        respuestaValida1 = true;
                        break;

                    default:
                        Console.WriteLine("Ingresa un valor numérico");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Ingresa un valor numérico");
            }

        } while (respuestaValida1 == false);
        
        
        bool respuestaValida2 = false;

        do
        {
            Console.WriteLine("JUGADOR DOS: ¿Deseas atacar o curar?, 1 para atacar, 2 para curar");
            string decision2 = Console.ReadLine();
            bool conversion2 = int.TryParse(decision2, out int decision2Int);

            if (conversion2 == true)
            {
                switch (decision2Int)
                {
                    case 1:
                        int ataque = random.Next(1, 11);

                        jugador1 = jugador1 - ataque;

                        if (jugador1 < 0)
                        {
                            jugador1 = 0;
                        }

                        Console.WriteLine("El jugador2 realizo un ataque de " + ataque + " a el jugador1");
                        Console.WriteLine("Vida del jugador1:" + jugador1);

                        respuestaValida2 = true;
                        break;

                    case 2:
                        if (jugador2 == 28)
                        {
                            Console.WriteLine("El jugador2 permanece con 28 de vida");
                        }
                        else
                        {
                            jugador2 = jugador2 + curacion;

                            if (jugador2 > 28)
                            {
                                jugador2 = 28;
                            }

                            Console.WriteLine("El jugador2 se curo, su vida es de: " + jugador2);
                        }

                        respuestaValida2 = true;
                        break;

                    default:
                        Console.WriteLine("Ingresa un valor numérico");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Ingresa un valor numérico");
            }

        } while (respuestaValida2 == false);

    } while (jugador1 > 0 && jugador2 > 0);

    if (jugador1 > jugador2)
    {
        Console.WriteLine("El jugador 1 es el ganador");
    }
    else
    {
        Console.WriteLine("El jugador 2 es el ganador");
    }
}
else
{
    do
    {
        bool respuestaValida2 = false;

        do
        {
            Console.WriteLine("JUGADOR DOS: ¿Deseas atacar o curar?, 1 para atacar, 2 para curar");
            string decision2 = Console.ReadLine();
            bool conversion2 = int.TryParse(decision2, out int decision2Int);

            if (conversion2 == true)
            {
                switch (decision2Int)
                {
                    case 1:
                        int ataque = random.Next(1, 11);

                        jugador1 = jugador1 - ataque;

                        if (jugador1 < 0)
                        {
                            jugador1 = 0;
                        }

                        Console.WriteLine("El jugador2 realizo un ataque de " + ataque + " a el jugador1");
                        Console.WriteLine("Vida del jugador1:" + jugador1);

                        respuestaValida2 = true;
                        break;

                    case 2:
                        if (jugador2 == 28)
                        {
                            Console.WriteLine("El jugador2 permanece con 28 de vida");
                        }
                        else
                        {
                            jugador2 = jugador2 + curacion;

                            if (jugador2 > 28)
                            {
                                jugador2 = 28;
                            }

                            Console.WriteLine("El jugador2 se curo, su vida es de: " + jugador2);
                        }

                        respuestaValida2 = true;
                        break;

                    default:
                        Console.WriteLine("Ingresa un valor numérico");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Ingresa un valor numérico");
            }

        } while (respuestaValida2 == false);
        
        
        bool respuestaValida1 = false;

        do
        {
            Console.WriteLine("JUGADOR UNO: ¿Deseas atacar o curar?, 1 para atacar, 2 para curar");
            string decision1 = Console.ReadLine();
            bool conversion1 = int.TryParse(decision1, out int decision1Int);

            if (conversion1 == true)
            {
                switch (decision1Int)
                {
                    case 1:
                        int ataque = random.Next(1, 11);

                        jugador2 = jugador2 - ataque;

                        if (jugador2 < 0)
                        {
                            jugador2 = 0;
                        }

                        Console.WriteLine("El jugador1 realizo un ataque de " + ataque + " a el jugador2");
                        Console.WriteLine("Vida del jugador2:" + jugador2);

                        respuestaValida1 = true;
                        break;

                    case 2:
                        if (jugador1 == 28)
                        {
                            Console.WriteLine("El jugador1 permanece con 28 de vida");
                        }
                        else
                        {
                            jugador1 = jugador1 + curacion;

                            if (jugador1 > 28)
                            {
                                jugador1 = 28;
                            }

                            Console.WriteLine("El jugador1 se curo, su vida es de: " + jugador1);
                        }

                        respuestaValida1 = true;
                        break;

                    default:
                        Console.WriteLine("Ingresa un valor numérico");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Ingresa un valor numérico");
            }

        } while (respuestaValida1 == false);

    } while (jugador1 > 0 && jugador2 > 0);

    if (jugador1 > jugador2)
    {
        Console.WriteLine("El jugador 1 es el ganador");
    }
    else
    {
        Console.WriteLine("El jugador 2 es el ganador");
    }
}
