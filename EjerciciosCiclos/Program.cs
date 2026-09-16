// Genera un programa que muestre un log de
// combate, donde el jugador realiza 5 puntos de daño  al enemigo cada turno.
// Probar con diferentes valores iniciales de vida de enemigo

int vidaEnemigo = 17;

Console.WriteLine ("Log de combate contra enemigo con " + vidaEnemigo + " de vida.");

while (vidaEnemigo > 0)
{
    vidaEnemigo = vidaEnemigo - 5;
    if (vidaEnemigo < 0)
    {
        Console.WriteLine("El jugador realizó 5 de daño, la vida del enemigo es de: 0 ");
    }
    else
    {
        Console.WriteLine("El jugador realizó 5 de daño, la vida del enemigo es de: " + vidaEnemigo);
    }

}

// Genera un programa que pida al usuario un número entero.
// Sigue pidiendo valores hasta que el usuario ingrese un valor correcto
// Mostrando un mensaje de error o éxito según sea el caso.

int valorNum;

do
{
    Console.WriteLine("Adivina el valor: ");
    string valorUsuario = Console.ReadLine();
    bool   conversion   =  int.TryParse(valorUsuario, out valorNum);

    if (conversion == true)
    {
        if (valorNum != 5)
        {
            Console.WriteLine("El valor es incorrecto, intenta de nuevo.");
        }
        else
        {
            Console.WriteLine("El valor es correcto!");
        }
    }
    else
    {
        Console.WriteLine("Ingresa un valor valido, número.");
    }
} while (valorNum != 5);

// Genera un programa que muestre la tabla del 7, del 0 al 100 en forma ordenada

Console.WriteLine("Tabla del 7 hasta el 100:");

for (int rondas = 0; rondas <=100;rondas ++)
{
Console.WriteLine("7 x" + rondas + " = " + (7*rondas));
}