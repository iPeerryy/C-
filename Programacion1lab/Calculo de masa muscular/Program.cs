double PesoTotal, PorcentajeDeGrasaCorporal, PesoHuesos;

Console.Write("Ingrese el pesos de los total: ");
PesoTotal = double.Parse(Console.ReadLine());
Console.Write("Ingrese el porcentaje de grasa corporal: ");
PorcentajeDeGrasaCorporal = double.Parse(Console.ReadLine());
PorcentajeDeGrasaCorporal = PorcentajeDeGrasaCorporal / 100;
Console.WriteLine("Ingrese el pesos de los huesos y organos");
PesoHuesos = double.Parse(Console.ReadLine());
Console.WriteLine("La masa muscular del paciente es: " + (PesoTotal - (PesoTotal * PorcentajeDeGrasaCorporal) - PesoHuesos));

