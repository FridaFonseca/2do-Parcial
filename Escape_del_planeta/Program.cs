//  dudaaaaaaaaa de por pasos cuando quieres añadir
//  uwun´t

const int DISTANCIA_AL_ESPACIO = 70;
const int COMBUSTIBLE_INICIAL = 10000000;
const int COMBUSTIBLE_POR_TURNO = 2;
const int ACENSO_POR_TURNO = 10;
const int ESCUDO_MAX = 50;
const int ESCUDO_POR_TURNO = 5;
const int KM_PERDIDOS_ESPERANDO = 3;

var kmRecorridos = 0; //// shift+f6 o clickderecho renamepara renombrar 
var combActual = COMBUSTIBLE_INICIAL;
var escudoActual = 8;

Console.WriteLine($"Distancia: {kmRecorridos}"); /// ES IGUAL A ("Distancia" + distreco)
Console.WriteLine($"Combustible {combActual}");
Console.WriteLine($"Combustible {escudoActual}");

while (kmRecorridos < DISTANCIA_AL_ESPACIO && combActual > 0)  // EEE al agregar while despues la tabulacion es automatica
{
    var zonaEscombros = false; /// varios escenarios en booleanos excluyentes -_- , se puede con switch??
    var zonaCalma = false;
    var zonaNeutra = !zonaEscombros && !zonaCalma; // true si no es ninguna de las otras dos !- negacion
    
    string opcion; /// var no sin tippo de dato y no se sabe porqe es previ a la entrada
    do
    {
        if (zonaEscombros)
        {
            Console.WriteLine("Estás en zona de Escombros");
        }
        else if (zonaCalma)
        {
            Console.WriteLine("Estás en zona de Calma");
        }
        else if (zonaNeutra)
        {
            Console.WriteLine("Estás en zona Neutra");
        }
        
        Console.WriteLine("Qué acción quieres realizar:");
        Console.WriteLine("1. Ascender");
        Console.WriteLine("2. Esperar");
        opcion = Console.ReadLine() ?? ""; /// Si la entrada es NULA convertirlo a valor valido, vacio porque no es valido como valor ""

        if (opcion != "1" && opcion != "2")
        {
            Console.WriteLine("Ingresa 1 o 2 -_-..."); /// cada validacion requiere mensaje de correccion por convencion
        }
        
    } while (opcion != "1" && opcion != "2"); /// && no ||, siempre probar esos dos dependiendo de la logica

    if (opcion == "1") // con comillas para no convertir y que sea cadena  
    {
        Console.WriteLine("Ascendiendo....");
        kmRecorridos += ACENSO_POR_TURNO; //// DISTRECO = DISTRECO + ACENSO
        combActual -= COMBUSTIBLE_POR_TURNO; /// COMBACTUAL = COMBACTUAL - COMBPORTURNO

    }
    else if (opcion == "2")
    {
        Console.WriteLine("Esperando....");
        escudoActual += ESCUDO_POR_TURNO;
        escudoActual = Math.Min(ESCUDO_MAX, escudoActual + ESCUDO_POR_TURNO); /// agarra el minimo entre dos valores, para valores topes , con constante max/min declarada
        kmRecorridos = Math.Max(0, kmRecorridos + KM_PERDIDOS_ESPERANDO);
    }
    
    Console.WriteLine($"Distancia: {kmRecorridos}");
    Console.WriteLine($"Combustible: {combActual}");
    Console.WriteLine($"Escudo: {escudoActual}");
}

if (kmRecorridos >= DISTANCIA_AL_ESPACIO)
{
    Console.WriteLine("LLegaste al espacio!");
}
else
{
    Console.WriteLine("No llegaste al espacio");
}



