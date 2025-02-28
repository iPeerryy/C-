// Define una clase llamada Persona con propiedades como nombre, edad y género. Luego, crea instancias de esta clase y muestra la información de cada persona.

Persona persona1 = new Persona("Juan", 32, "Masculino");
Persona persona2 = new Persona("Daniel", 30, "Masculino");
Persona persona3 = new Persona("Maria", 50, "Femenino");


persona1.MostrarInformacion();
persona2.MostrarInformacion();
persona3.MostrarInformacion();
class Persona
{
	string Nombre { get; set; }
	int Edad { get; set; }
	string Genero { get; set; }

	public Persona (string nombre, int edad, string genero)
	{
		Nombre = nombre;
		this.Edad = edad;
		this.Genero = genero;
	}
	public void MostrarInformacion()
	{
		Console.WriteLine("Nombre: " + Nombre + ", Edad: " + Edad + ", Genero: " + Genero);


	}
}

