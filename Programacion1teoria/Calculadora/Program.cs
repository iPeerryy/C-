﻿
int num1 = 0, num2 = 0, dato;

Console.WriteLine("Que operacion desea realizar?");
Console.WriteLine("1 => Suma");
Console.WriteLine("2 => Resta");
Console.WriteLine("3 => Multiplicacion");
Console.WriteLine("4 => division");
Console.WriteLine("5 => Salir");
dato = int.Parse(Console.ReadLine());

while (dato != 5)
{
	switch (dato)
	{
		case 1:

			Console.Write("Ingrese el primer valor: ");
			num1 = int.Parse(Console.ReadLine());
			Console.Write("Ingrese el segundo valor: ");
			num2 = int.Parse(Console.ReadLine());
			Console.WriteLine("El resultado de la suma de " + num1 + " + " + num2 + " es: " + (num1 + num2));
			break;

		case 2:
			Console.Write("Ingrese el primer valor: ");
			num1 = int.Parse(Console.ReadLine());
			Console.Write("Ingrese el segundo valor: ");
			num2 = int.Parse(Console.ReadLine());
			Console.WriteLine("El resultado de la resta de " + num1 + " - " + num2 + " es: " + (num1 - num2));

			break;

		case 3:
			Console.Write("Ingrese el primer valor: "); 
			num1 = int.Parse(Console.ReadLine());
			Console.Write("Ingrese el segundo valor: ");
			num2 = int.Parse(Console.ReadLine());
			while (num2 == 0 || num1 == 0)
			{
				Console.WriteLine("Por el momento no es posible multiplicar un numero por cero, intelo de nuevo con otro numero");
				if (num2 == 0)
				{
					num2 = int.Parse(Console.ReadLine());
				}
				if (num1 == 0)
				{
					num1 = int.Parse(Console.ReadLine());
				}
			}
			Console.WriteLine("El resultado de la multiplicacion entre " + num1 + " * " + num2 + " es: " + (num1 * num2));

			break;

		case 4:
			Console.Write("Ingrese el primer valor: ");
			num1 = int.Parse(Console.ReadLine());
			Console.Write("Ingrese el segundo valor: ");
			num2 = int.Parse(Console.ReadLine());
			while (num2 == 0 || num1 == 0)
			{
				Console.WriteLine("Por el momento no es posible dividir un numero entre cero, intelo de nuevo con otro numero");
				if (num2 == 0)
				{
					num2 = int.Parse(Console.ReadLine());
				}
				if (num1 == 0)
				{
					num1 = int.Parse(Console.ReadLine());
				}
			}


			Console.WriteLine("El resultado de la division entre " + num1 + " / " + num2 + " es: " + (num1 / num2));
			break;
		default:
			Console.WriteLine("El digito ingresado no es valido, por favor intente de nuevo");
			break;

	}
    Console.WriteLine("                                  ");
    Console.WriteLine("Que operacion desea realizar?");
    Console.WriteLine("1 => Suma");
    Console.WriteLine("2 => Resta");
    Console.WriteLine("3 => Multiplicacion");
    Console.WriteLine("4 => division");
    Console.WriteLine("5 => Salir");
    dato = int.Parse(Console.ReadLine());
}
Console.WriteLine("Gracias por utilizar la calculadora Jose.");


