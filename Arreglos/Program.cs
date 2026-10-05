// Arreglos

using System;

// Antes de ejecutar, responde:
// - ¿Cuántos valores contiene inventory?
// - ¿Qué representa [0]?
// - ¿Qué mostrará inventory[2]?
// - ¿Qué cambia en la línea 11?
// - ¿Cuántas veces se ejecutará el for?
// - ¿Qué contiene inventory.Length?


// Después de ejecutar, realiza estos cambios:
// - Reemplaza la declaración de valores por la de longitud
// - Asigna los valores
// - Agrega un nuevo elemento  "Espada" al arreglo
// - Asigna "Linterna" a inventory[inventory.Length - 1]
// - Imprime inventory.Length 
// - Imprime los 4 valores
// - Asigna "Hacha" a inventory[5]
// - Asigna "Casco" a inventory[-1]


string[] inventory =
[
  "Espada",
  "Poción",
  "Llave",
  "Espada"
];

for (var i = 0; i < inventory.Length; ++i) // imprimir/recorrer los valores de cada posicion del arreglo
{
   Console.WriteLine(inventory[i]);
}

Console.WriteLine(inventory[0]); // Imprimir un valor del arreglo
Console.WriteLine(inventory[2]);

inventory[1] = "Escudo"; // Remplazar valores de arreglo especifico
inventory[inventory.Length - 1] = "Linterna"; // Remplazar valores con operaciones y con el largo de inventario
// equivalentee a inventory[´flecha arriba1] = "Linterna"; el sombrero dice que empieze desde atras por eso es 1 posicion 1 desde atras

Console.WriteLine(inventory.Length);

for (var i = 0; i < inventory.Length; ++i)
{
   Console.WriteLine(inventory[i]);
}

// inventory[5] = "Hacha";

// inventory[- 1] = "Casco";



// notas provicionales de clase :v
// listas puede agregar y quitar posiciones (vacia sin capacidad, vacia con capacidad, con valores completa y expresion)
// formas de iniciar una lista
List<string> enemies = new List<string>(5);  // o como en el arreglo

// LSTA.Add(valor); agregar elementos , add va modificando count y eventualmente capacity 
// LISTA.Remove(valor); eliminar valor , si son valores exactament eiguales elimina el primero que encuentra
// LISTA.RemoveAt(idx); elimina desde el count/indice de la lista 
// LISTA.Clear(); limpiar la lista(indices) manteniendo la capacidad

// LISTA {indice} obtener elementos 
//  recorrer igual que un arreglo en lugar de length/count
enemies.Add("Orc");
enemies.Remove("Goblin");
enemies.Count;

//indices para remplazar elementos 
    // no se puede creas posicion remplazanndo con indice que no existe
foreach (string enemy in enemies) { }
// arreglos longitud/length = conteo de listas, capacidad por c#