using System.Timers;

double[] valores = new double[10];
double suma = 0;
double Promedio5 = 0;
for (int i = 0; i < 10; i++)
{

    Console.Write("Ingrese el valor numero " + (i+1) +": ");
    valores[i] = double.Parse( Console.ReadLine() );

    suma += valores[i];

    if ( i == 4)
    {
         Promedio5 = suma / 5;
    }
}
Console.WriteLine(" El promedio de los 5 primeros datos es de: " + Promedio5);
Console.WriteLine("El promedio de los 10 valores es de: " + (suma / 10));
