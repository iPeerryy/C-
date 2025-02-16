using System.Runtime.Serialization.Formatters;

try
{
	double num1 = 0, num2 = 0, num3 = 0;


	Console.Write("Ingrese el primer valor: ");
	num1 = double.Parse(Console.ReadLine());
	Console.Write("Ingrese el segundo valor: ");
	num2 = double.Parse(Console.ReadLine());
	Console.Write("Ingrese el tercer valor: ");
	num3 = double.Parse(Console.ReadLine());
	double suma = num1 + num2;
	double division = (num1 + num2) / num3;

	Console.WriteLine("La suma de los dos primeros valores es de: " + suma);
	Console.WriteLine("Y la division entre la suma de los dos primeros valores y el tercer valor es de: " + division);
	
}
catch (FormatException e)
{
	Console.WriteLine("Ingrese un valor legible para esta operacion");
}
catch(Exception e)
{
    Console.WriteLine("Un error inesperado acaba de ocurrir: " + e.Message);
}





