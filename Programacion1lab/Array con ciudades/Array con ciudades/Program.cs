List<String> ciudades = new List<string> { "Madrid", "Santiago", "Santo Domingo", "New Yersey" };

Console.WriteLine("Ingrese nombre de ciudades. Escriba 'Fin' para terminar" );

while (true)
{
    Console.Write("Ciudad: ");
    string ciudad = Console.ReadLine();

    if (ciudad.ToLower() == "fin")
    {
        break;
    }
    ciudades.Add(ciudad);
}

Console.WriteLine("Ciudades Ingresadas: ");
foreach (string ciudad in ciudades)
{
	Console.WriteLine(ciudad);
}