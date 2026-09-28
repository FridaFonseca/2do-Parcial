//  dudaaaaaaaaa de por pasos cuando quieres añadir
//  uwun´t

const int DISTANCIA_AL_ESPACIO = 70;
const int COMBUSTIBLE_INICIAL = 5;
const int COMBUSTIBLE_POR_TURNO = 2;
const int ACENSO_POR_TURNO = 10;
const float ZONA_CALMA_BONO_ESCUDO = 1.5f;
const int ESCUDO_MAX = 5;
const int ESCUDO_POR_TURNO = 50;
const int KM_PERDIDOS_ESPERANDO = 3;
const int DMG_ESCOMBROS = 5;
const int COMBUSTIBLE_PARA_ESQUIVAR = 2;

var kmRecorridos = 0; //// shift+f6 o clickderecho renamepara renombrar 
var combActual = COMBUSTIBLE_INICIAL;
var escudoActual = 8f;

Console.WriteLine($"Distancia: {kmRecorridos}"); /// ES IGUAL A ("Distancia" + distreco)
Console.WriteLine($"Combustible {combActual}");
Console.WriteLine($"Combustible {escudoActual}");

while (kmRecorridos < DISTANCIA_AL_ESPACIO && combActual > 0)  // EEE al agregar while despues la tabulacion es automatica
{
    var zonaEscombros = true; /// varios escenarios en booleanos excluyentes -_- , se puede con switch??
    var zonaCalma = false;
    var zonaNeutra = !zonaEscombros && !zonaCalma; // true si no es ninguna de las otras dos !- negacion
    
    string opcion; /// var no sin tippo de dato y no se sabe porqe es previ a la entrada
    do
    {
        if (zonaEscombros)
        {
            Console.WriteLine("Estás en zona de Escombros");
            Console.WriteLine("Qué acción quieres realizar:");
            Console.WriteLine("1. Ascender");
            Console.WriteLine("2. Esperar (Bono de recuperación)");
            if combActual == COMBUSTIBLE_PARA_ESQUIVAR
            {
             
                Console.WriteLine("3. Esquivar");   
            }
            else
            {
                
                Console.WriteLine("3. Esquivar (sin combustible");
            }

        }
        else if (zonaCalma)
        {
            Console.WriteLine("Estás en zona de Calma");
            Console.WriteLine("Qué acción quieres realizar:");
            Console.WriteLine("1. Ascender");
            Console.WriteLine("2. Esperar (Bono de recuperación)");
        }
        else if (zonaNeutra)
        {
            Console.WriteLine("Estás en zona Neutra");
            Console.WriteLine("Qué acción quieres realizar:");
            Console.WriteLine("1. Ascender");
            Console.WriteLine("2. Esperar");
        }
        
        opcion = Console.ReadLine() ?? ""; /// Si la entrada es NULA convertirlo a valor valido, vacio porque no es valido como valor ""

        if (opcion != "1" && opcion != "2" && (opcion == 3 && zonaEscombros)) // el && funciona como o Bv
        {
            Console.WriteLine("Ingresa 1 o 2 -_-..."); /// cada validacion requiere mensaje de correccion por convencion
        }
        
    } while (opcion != "1" && opcion != "2") && (opcion == 3 && zonaEscombros); /// && no ||, siempre probar esos dos dependiendo de la logica

    if (opcion == "1") // con comillas para no convertir y que sea cadena  
    {
        if (zonaEscombros)
        {
            escudoActual = Math.Max(0, escudoActual - DMG_ESCOMBROS);

            if (escudoActual == 0) /// float.epsilon, numero muy pequeño casi cero
            {
                break; /// if(escudoActual == 0) break; -> lo demas (manera alternativa de if)
            }
            else
            {
                Console.WriteLine("Recibiste daño de los escombros...");
            }
        }
        
        Console.WriteLine("Ascendiendo....");
        kmRecorridos += ACENSO_POR_TURNO; //// DISTRECO = DISTRECO + ACENSO
        combActual -= COMBUSTIBLE_POR_TURNO; /// COMBACTUAL = COMBACTUAL - COMBPORTURNO

    }
    else if (opcion == "2")
    {
        Console.WriteLine("Esperando....");
        
        var bonoTurno = zonaCalma ? ZONA_CALMA_BONO_ESCUDO : 1f; /// igual a if :-> es else --3--
                                                                 /// if (zonaCalma) {bonoTurno = ZONA; }
                                                                 /// else {bonoTurno = 1f}
        var escudoTurno = escudoActual + ESCUDO_POR_TURNO * bonoTurno;
        
        
        
        escudoActual = Math.Min(ESCUDO_MAX, escudoActual + ESCUDO_POR_TURNO); /// agarra el minimo entre dos valores, para valores topes , con constante max/min declarada
        
        if (zonaEscombros)
        {
            escudoActual = Math.Max(0, escudoActual - DMG_ESCOMBROS);

            if (escudoActual == 0) 
            {
                break; 
            }
            else
            {
                Console.WriteLine("Recibiste daño de los escombros...");
            }
        }
        
        kmRecorridos = Math.Max(0, kmRecorridos + KM_PERDIDOS_ESPERANDO);
    }
    else if (opcion == "3")
    {
        
        if (combActual >= COMBUSTIBLE_PARA_ESQUIVAR)
            Console.WriteLine("Haz esquivado los escombros");
        combActual -= COMBUSTIBLE_PARA_ESQUIVAR
        else
        {
            escudoActual = Math.Max(0, escudoActual - DMG_ESCOMBROS);

            if (escudoActual == 0) 
            {
                break; 
            }
            else
            {
                Console.WriteLine("Recibiste daño de los escombros...");
            }
        }
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



