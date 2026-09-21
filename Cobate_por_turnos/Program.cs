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

Console.WriteLine("El jugador 1 tiene vida de " + jugador1);
Console.WriteLine("El jugador 2 tiene vida de " + jugador2);

// true es que va el 1
bool turno;

if (turno == true)
{
    do
    {
        int ataque1 = 7;
        
        Console.WriteLine("JUGADOR UNO: ¿Deseas atacar o curar?, 1 para atacar, 2 para curar");
        string decision1 = Console.ReadLine();
        bool conversion = int.TryParse(decision1, out int decision1Int);

        if (decision1Int == 1) ;
        {
            Console.WriteLine("El jugador 1 atacó al jugador 2 con una vida restante de: " + (jugador2 - ataque1));
        }
        else
        {
            Console.WriteLine("Escribe un valor valido"); 
        }
        
        if (decision1Int == 2) ;
        {
            bool curacionVal = jugador2 < 28;
            int curacion = 7;
            Console.WriteLine("La vida del jugador es: " + (jugador1 + curacion));
        }
        
        int ataque2 = 7;
        
        
    } while (jugador1 > 0 || jugador2 > 0);
}
else (turno == false)

do
{
      

}while (jugador1 > 0 || jugador2 > 0);