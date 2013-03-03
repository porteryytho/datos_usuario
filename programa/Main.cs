using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
	class Programa
	{
		static void Main(string[] args)
		{
			string nombre, face, dir;
			int edad, numero;
			Console.WriteLine("Escribe tu nombre");
			nombre = Console.ReadLine();
			Console.WriteLine("Hola {0}, cual es tu Direccion?", nombre);
			dir = Console.ReadLine();
			Console.WriteLine("Hola {0}, cual es tu numero telefonico?", nombre);
			numero = int.Parse(System.Console.ReadLine());
			Console.WriteLine("Hola {0}, cual es tu FaceBook?", nombre);
			face = Console.ReadLine();
			Console.WriteLine("Hola {0}, cuantos años tienes?", nombre);
			edad = int.Parse(System.Console.ReadLine());
			Console.Clear();
			Console.WriteLine("{0} tienes {1} años y tu direccion es: {2} tu telefono es: {3} y tu facebook es: {4}", nombre, edad, dir, numero, face);
			Console.Read();
		}
	}
}