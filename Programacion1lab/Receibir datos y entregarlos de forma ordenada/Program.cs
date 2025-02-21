Console.Write("Ingrese su nombre: ");
string Nombre = Console.ReadLine();
Console.Write("Ingrese su apellido: ");
string Apellido = Console.ReadLine();
Console.Write("Ingrese su telefono: ");
string Telefono = Console.ReadLine();
Console.Write("Ingrese su edad: ");
int Edad = int.Parse(Console.ReadLine());
Console.Write("Ingrese su estatura (en metros): ");
double Estatura = double.Parse(Console.ReadLine());

Console.Clear();

Console.WriteLine("---------Datos del usuario---------");
Console.WriteLine("Nombre: " + Nombre);
Console.WriteLine("Apellido: " + Apellido);
Console.WriteLine("Telefono: " + Telefono);
Console.WriteLine("Edad: " + Edad);
Console.WriteLine("Estatura: " + Estatura + " metros.");
