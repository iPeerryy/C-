using System.Formats.Asn1;

double B = 0, A = 0;

Console.Write("Ingrese el valor del la base del triangulo: ");
B = double.Parse(Console.ReadLine());
Console.Write("Ingrese el valor del la altura del triangulo: ");
A = double.Parse(Console.ReadLine());
if (A != 0 || B != 0)
{
	double Area = (B * A) / 2;
    Console.WriteLine("El area del triangulo es de: " + Area + " centimetros cuadrados");

} 
else
{
    Console.WriteLine("Por el momento no podemos multiplicar entre 0, por favor intetelo de nuevo con valores diferentes.");
}