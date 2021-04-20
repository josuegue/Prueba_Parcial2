using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExamenP02.Clase_Arreglo;
using ExamenP02.Clase_Promedios;

namespace ExamenP02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string[] ArregloNotas;
        //Llamada a las clases
        ClsPromedios objInterfazMatriz = new ClsPromedios();
        ClsArchivo objArchivo = new ClsArchivo();

        //Variable global 
        private string text_seccion;
        private string[,] ArregloDosDimensiones;
        private void buttonCargar_Click(object sender, EventArgs e)
        {
            ClsArchivo ar = new ClsArchivo();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Selecciona tu archivo plano";
            ofd.InitialDirectory = @"C:\Users\Flor\Documents";
            ofd.Filter = "Archivo plano (*.csv)|*.csv";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var archivo = ofd.FileName;
                string resultado = ar.LeerTodoArchivo(archivo);
                ArregloNotas = ar.LeerArchivos(archivo);

                textBoxRuta.Text = archivo;
                textBoxContenido.Text = resultado;
            }
        }

        private void buttonNombres_Click_1(object sender, EventArgs e)
        {
            ArregloDosDimensiones = new string[ArregloNotas.Length - 1, 6];

            int contador = 0;
            string[] CadenaNombres = new string[ArregloNotas.Length - 1];
            // extraccion de columnas del array, o extraer array de un array 
            foreach (string linea in ArregloNotas)
            {
                string[] datos = linea.Split(';');

                if (contador > 0)
                {
                    ArregloDosDimensiones[contador - 1, 0] = datos[0];
                    ArregloDosDimensiones[contador - 1, 1] = datos[1];
                    ArregloDosDimensiones[contador - 1, 2] = datos[2];
                    ArregloDosDimensiones[contador - 1, 3] = datos[3];
                    ArregloDosDimensiones[contador - 1, 4] = datos[4];
                    ArregloDosDimensiones[contador - 1, 5] = datos[5];

                    CadenaNombres[contador - 1] = datos[1];
                }
                contador++;
            }
            //recorrido de los nombres ordenados 
            CadenaNombres = objArchivo.MetodoBurbujaNombre(CadenaNombres);
            foreach (string recorrido in CadenaNombres)
            {
                listBoxResultado.Items.Add(recorrido);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            text_seccion = textBoxDatos.Text;
        }

        private void buttonP_1_Click_1(object sender, EventArgs e)
        {
            listBoxResultado.Items.Clear();
            //promedio una seccion en general / ej "A"
            int promedio_seccion = objInterfazMatriz.promedios_general_seccion(ArregloDosDimensiones, 2, text_seccion);
            listBoxResultado.Items.Add($"El promedio de la seccion {text_seccion} es {promedio_seccion} ");
        }

        private void buttonP_2_Click_1(object sender, EventArgs e)
        {
            listBoxResultado.Items.Clear();
            //promedio una seccion en general / ej "A"
            int promedio_seccion = objInterfazMatriz.promedios_general_seccion(ArregloDosDimensiones,3, text_seccion);
            listBoxResultado.Items.Add($"El promedio de la seccion {text_seccion} es {promedio_seccion} ");
        }

        private void buttonP_3_Click_1(object sender, EventArgs e)
        {
            listBoxResultado.Items.Clear();
            //promedio una seccion en general / ej "A"
            int promedio_seccion = objInterfazMatriz.promedios_general_seccion(ArregloDosDimensiones, 4, text_seccion);
            listBoxResultado.Items.Add($"El promedio de la seccion {text_seccion} es {promedio_seccion} ");
        }

        private void buttonPP1_Click_1(object sender, EventArgs e)
        {
            listBoxResultado.Items.Clear();
            int promedio_parcial = objInterfazMatriz.promedios_por_parcial(ArregloDosDimensiones, 2);
            listBoxResultado.Items.Add("El promedio por el parcial uno es " + promedio_parcial);
        }

        private void buttonPP2_Click_1(object sender, EventArgs e)
        {
            listBoxResultado.Items.Clear();
            int promedio_parcial = objInterfazMatriz.promedios_por_parcial(ArregloDosDimensiones, 3);
            listBoxResultado.Items.Add("El promedio por el parcial dos es " + promedio_parcial);
        }

        private void buttonPP3_Click_1(object sender, EventArgs e)
        {
            listBoxResultado.Items.Clear();
            int promedio_parcial = objInterfazMatriz.promedios_por_parcial(ArregloDosDimensiones, 4);
            listBoxResultado.Items.Add("El promedio por el parcial tres es " + promedio_parcial);
        }

        private void buttonSumatoria_Click_1(object sender, EventArgs e)
        {
            listBoxResultado.Items.Clear();
            //imprime sumatoria general por alumno 
            string[,] suma = objInterfazMatriz.sumatoria_general_por_alumno(ArregloDosDimensiones);
            for (int i = 0; i < suma.GetLength(0); i++)
            {
                listBoxResultado.Items.Add(suma[i, 0] + " sumatoria: " + suma[i, 1]);
            }
        }

        private void buttonClfAlumnos_Click_1(object sender, EventArgs e)
        {
            //imprime la clasificacion de los alumnos
            listBoxResultado.Items.Clear();

            string[,] Nombre_secccion = objInterfazMatriz.Clasificar_Alumnos(ArregloDosDimensiones, text_seccion);
            for (int x = 0; x < Nombre_secccion.GetLength(0); x++)
            {
                listBoxResultado.Items.Add($"{Nombre_secccion[x, 0]} seccion: {Nombre_secccion[x, 1]}");
            }
        }
    }
}
