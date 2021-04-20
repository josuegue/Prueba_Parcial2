using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExamenP02.Clase_Arreglo
{
    class ClsArchivo
    {
        //Me lee el archivo 
        public string[] LeerArchivos(string archivo)
        {
            string[] Lineas = File.ReadAllLines(archivo, Encoding.Default);
            return Lineas;
        }
        // me lee todo el contenido del archivo plano 
        public string LeerTodoArchivo(string archivo)
        {
            string contenidoArchivo;
            using (StreamReader reader = new StreamReader(archivo))
            {
                contenidoArchivo = reader.ReadToEnd();
            }
            return contenidoArchivo;
        }
        //Metodo de burbuja
        public string[] MetodoBurbujaNombre(string[] OrdBurbuja)
        {

            string[] TamArreglo = OrdBurbuja;
            string[] ArregloOrd = TamArreglo;
            string datosTemporal;

            for (int i = 0; i < TamArreglo.Length - 1; i++)
            {
                for (int j = i + 1; j < TamArreglo.Length; j++)
                {
                    if (ArregloOrd[i].CompareTo(ArregloOrd[j]) > 0)
                    {
                        datosTemporal = ArregloOrd[i];
                        ArregloOrd[i] = ArregloOrd[j];
                        ArregloOrd[j] = datosTemporal;
                    }
                }
            }
            return ArregloOrd;
        }
    }
}
