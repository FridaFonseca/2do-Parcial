// Genera un log de batalla y muestra el resultado

List<string> acciones = new List<string>();
acciones.Add("El jugador hace un ataque de ");
acciones.Add("El jugador hace un ataque critico de ");
acciones.Add("El enemigo esquiva el ataque...");
acciones.Add("El jugador esquiva el ataque...");
acciones.Add("El enemigo hace un ataque de ");
acciones.Add("El enemigo ha muerto...");

Console.WriteLine("Log de batalla: ");
Console.WriteLine( acciones[0] + "5");
Console.WriteLine( acciones[2]);
Console.WriteLine( acciones[4] + "5");
Console.WriteLine( acciones[3]);
Console.WriteLine( acciones[2] + "20");
Console.WriteLine( acciones[5]);

// Genera un programa que administre los enemigos activos de paso:

string[] enemigos =
[
    " Goblin",
    " Orco",
    " Slime",
    " Esqueleto"
];

Console.WriteLine("\n\n");

Console.WriteLine("Spawn de enemigos en el mapa: ");
Console.WriteLine("Aparecio..." + enemigos[0] + enemigos[2]);
Console.WriteLine("Muere..." + enemigos[0]);
Console.WriteLine("Aparecio..." + enemigos[3]);
Console.WriteLine("Muere..."+ enemigos[3]);
Console.WriteLine("Aparecio..." + enemigos[1]);
Console.WriteLine("Muere..." + enemigos[2]);
