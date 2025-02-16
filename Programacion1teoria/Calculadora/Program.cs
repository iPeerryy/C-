
int num1=0, num2 = 0;
Console.WriteLine("Que operacion desea realizar?");
Console.WriteLine("1 => Suma");
Console.WriteLine("2 => Resta");
Console.WriteLine("3 => Multiplicacion");
Console.WriteLine("4 => division");
int dato = int.Parse(Console.ReadLine());

switch (dato)
{
	case 1:

		Console.WriteLine("Ingrese el primer valor");
		num1 = int.Parse(Console.ReadLine());
		Console.WriteLine("Ingrese el segundo valor");
		num2 = int.Parse(Console.ReadLine());
		Console.Write("El resultado de la suma de " + num1 + " + " + num2 + " es: " + (num1 + num2));
		break;

	case 2:
		Console.WriteLine("Ingrese el primer valor");
		num1 = int.Parse(Console.ReadLine());
		Console.WriteLine("Ingrese el segundo valor");
		num2 = int.Parse(Console.ReadLine());
		Console.Write("El resultado de la resta de " + num1 + " - " + num2 + " es: " + (num1 - num2));
		
		break;

	case 3:
		Console.WriteLine("Ingrese el primer valor");
		num1 = int.Parse(Console.ReadLine());
		Console.WriteLine("Ingrese el segundo valor");
		num2 = int.Parse(Console.ReadLine());
		Console.Write("El resultado de la multiplicacion entre " + num1 + " * " + num2 + " es: " + (num1 * num2));
		
		break;

	case 4:
		Console.WriteLine("Ingrese el primer valor");
		num1 = int.Parse(Console.ReadLine());
		Console.WriteLine("Ingrese el segundo valor");
		num2 = int.Parse(Console.ReadLine());
		Console.Write("El resultado de la division entre " + num1 + " / " + num2 + " es: " + (num1 * num2));

		break;
}

