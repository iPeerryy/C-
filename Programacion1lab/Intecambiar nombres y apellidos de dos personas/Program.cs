String Nombre1, Apellido1, Nombre2, Apellido2;

Console.Write("Introduzca el primer nombre de la primera persona: ");
Nombre1 = Console.ReadLine();
Console.Write("Introduzca el ultimo apellido de la primera persona: ");
Apellido1 = Console.ReadLine();
Console.Write("Introduzca el primer nombre de la segunda persona: ");
Nombre2 = Console.ReadLine();
Console.Write("Introduzca el ultimo apellido de la segunda persona: ");
Apellido2 = Console.ReadLine();

Console.WriteLine("Los nombres  y apellidos intercambiados son: ");
Console.WriteLine(Nombre2 + " " + Apellido1);
Console.WriteLine(Nombre1 + " " + Apellido2);