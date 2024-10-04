using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream mArchivoEscritor = new FileStream("datos.dat", FileMode.OpenOrCreate, FileAccess.Write);
            using (BinaryWriter escritor = new BinaryWriter(mArchivoEscritor))
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Ingrese el nombre: ");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("Ingrese la edad: ");
                    int edad = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la nota: ");
                    int nota = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el género: ");
                    char genero = char.Parse(Console.ReadLine());

                    escritor.Write(nombre.Length); // Escribimos la longitud del nombre
                    escritor.Write(nombre.ToCharArray()); // Escribimos el nombre como arreglo de caracteres
                    escritor.Write(edad);
                    escritor.Write(nota);
                    escritor.Write(genero);
                }
            }
            // Lectura del archivo binario
            FileStream mArchivoLector = new FileStream("datos.dat", FileMode.Open, FileAccess.Read);
            using (BinaryReader lector = new BinaryReader(mArchivoLector))
            {
                while (mArchivoLector.Position != mArchivoLector.Length)
                {
                    int length = lector.ReadInt32(); // Leemos la longitud del nombre
                    char[] nombreArray = lector.ReadChars(length); // Leemos el nombre
                    string nombre = new string(nombreArray); // Convertimos a string
                    int edad = lector.ReadInt32();
                    int nota = lector.ReadInt32();
                    char genero = lector.ReadChar();

                    Console.WriteLine("Nombre: " + nombre);
                    Console.WriteLine("Edad: " + edad);
                    Console.WriteLine("Nota: " + nota);
                    Console.WriteLine("Género: " + genero);
                    Console.WriteLine("");
                }
            }
            Console.ReadKey();
        }
    }
}
