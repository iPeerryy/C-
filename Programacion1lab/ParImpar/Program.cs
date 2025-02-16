int num1 = 0;

Console.Write("Ingrese un numero: ");
num1 = int.Parse(Console.ReadLine());
if (num1 % 2 == 0)
{
    Console.WriteLine("El numero ingresado es par");
}
else
{
    Console.WriteLine("El numero ingresado es impar");
}
