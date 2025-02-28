int[] Numero = new int[5];

for (int i = 0; i < Numero.Length; i++)
{
    Console.Write("Ingrese el numero " + (i + 1) + ": ");
    Numero[i] = Convert.ToInt32(Console.ReadLine());
}

int suma = 0;
for (int i = 0; i < Numero.Length; i++)
{
    suma += Numero[i];
}
Console.WriteLine("La suma de los 5 numeros es de: " + suma);