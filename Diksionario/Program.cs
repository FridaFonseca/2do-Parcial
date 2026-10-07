Dictionary<string, int> items = new()
{
    { "Espada", 25 },
    { "Arco", 15 },
    { "Hacha", 35 },
};

Console.WriteLine(items["Hacha"]);
Console.WriteLine(items["Cuchillo"]);

items["Arco"] = 20;
Console.WriteLine(items["Arco"]);

if (items.ContainsKey("Arco") == false)
{
    items.Add("arco",30);
}

if (items.ContainsKey ("cuchillo") == false)
{
    items.Add("cuchillo",26);
}


if (items.TryGetValue("Hoz", out int dmgHoz)) 
{ 
    
    Console.WriteLine("DMG Hoz: + items [dmgHoz]");
}


if(items.ContainsKey("Hacha"))
{
    Console.WriteLine($"DMG hacha: " + items ["Hacha"]);
}


Console.WriteLine(items.Count);

items.Clear();
items.TryAdd("Espada", 15);
    
// comprobar si llave existe if(nombreLista.ContainsKey{"llave"});
// diccionarios siemrpe con claves y valores , los valores son repetibles entre claves epro las clave son unicas
// conteo cantidad de elementos, capacidad se puede crecer y clave, no se puede busscar en base a la posicion, solo sabiendo la clave
// TryGetValue(CLAVE,)
// Clear() nombreDiccionario.Clear();
// recorrer , KeyValuePair<Tkey, Tvalue>
// Podemos utilizar var para simplificar
// Podemos utilizar var para simplificar
// contains si existencia
// si utioizo valor si existe tryvalue
