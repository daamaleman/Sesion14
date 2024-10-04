using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Archivo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Evento para el botón de escribir datos en el archivo
        private void btnEscribir_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear o abrir el archivo para escritura
                FileStream mArchivoEscritor = new FileStream("datos.dat", FileMode.OpenOrCreate, FileAccess.Write);
                using (BinaryWriter escritor = new BinaryWriter(mArchivoEscritor))
                {
                    // Tomar los valores de los TextBox
                    string nombre = tbName.Text;
                    int edad = int.Parse(dtpAge.Text);
                    int nota = int.Parse(tbGrade.Text);
                    char genero = char.Parse(tbGender.Text);

                    // Escribir los datos en el archivo binario
                    escritor.Write(nombre.Length); // Longitud del nombre
                    escritor.Write(nombre.ToCharArray()); // Nombre
                    escritor.Write(edad); // Edad
                    escritor.Write(nota); // Nota
                    escritor.Write(genero); // Género
                }

                MessageBox.Show("Datos guardados correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Evento para el botón de leer datos desde el archivo
        private void btnLeer_Click(object sender, EventArgs e)
        {
            try
            {
                // Abrir el archivo para lectura
                FileStream mArchivoLector = new FileStream("datos.dat", FileMode.Open, FileAccess.Read);
                using (BinaryReader Lector = new BinaryReader(mArchivoLector))
                {
                    lbResults.Items.Clear(); // Limpiar el ListBox antes de agregar nuevos datos

                    while (mArchivoLector.Position != mArchivoLector.Length)
                    {
                        int length = Lector.ReadInt32(); // Leer la longitud del nombre
                        char[] nombreArray = Lector.ReadChars(length); // Leer el nombre
                        string nombre = new string(nombreArray); // Convertirlo a string
                        int edad = Lector.ReadInt32(); // Leer la edad
                        int nota = Lector.ReadInt32(); // Leer la nota
                        char genero = Lector.ReadChar(); // Leer el género

                        // Mostrar los datos en el ListBox
                        lbResults.Items.Add($"Nombre: {nombre}, Edad: {edad}, Nota: {nota}, Género: {genero}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
