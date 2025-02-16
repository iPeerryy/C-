double GradosC = 0;
double GradosF = 0;
Console.Write("Ingrese el la cantidad de grados Celsius que desea convertir a grados Fahrenheit: ");
GradosC = double.Parse(Console.ReadLine());

GradosF = (GradosC * 9 / 5) + 32;
Console.WriteLine("El valor de grados Celsius en Fahrenheit es de: " + GradosF);

