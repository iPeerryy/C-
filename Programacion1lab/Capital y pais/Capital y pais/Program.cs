//Crea un diccionario donde las claves sean nombres de países y los valores sean capitales. Permite al usuario buscar la capital de un país ingresando el nombre del país.

Dictionary<String, String> PaisCapital = new Dictionary<String, String>
{
	
	{"Republica Dominicana", "Santo Domingo" },
	{"Puerto Rico", "San Juan" },
	{"Egipto", "El Cairo" },
	{ "España", "Madrid" },
	{ "Francia", "París" },
	{ "Italia", "Roma" },
	{ "Alemania", "Berlín" },
	{ "Portugal", "Lisboa" },
	{"Haiti", "Puerto Principe" }
};
Console.WriteLine("Ingrese el nombre de un pais para buscar su capital (O 'Salir' para terminar): ");

while (true)
{
    Console.Write("Pais: ");
	string Pais = Console.ReadLine();

	if (Pais.ToLower() == "salir")
	{
		break;

	}
	if (PaisCapital.TryGetValue(Pais, out string Capital))
	{
        Console.WriteLine("La capital de "+ Pais + " es: " + Capital);
	}
	else
	{
        Console.WriteLine("No se encrontro ningun pais con el nombre ingresado ");
	}
}
Console.WriteLine("gracias por utilizar el programa");

