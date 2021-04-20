using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenP02.Clase_Promedios
{
    class ClsPromedios : Interface_Promedio
    {
        public string[,] Clasificar_Alumnos(string[,] matriz, string seccion)
        {
            int contador = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                if (matriz[i, 5] == seccion)
                {
                    contador++;
                }
            }


            string[,] Clf_alumnos = new string[contador, 2];
            int nuevo_contador = 0;
            for (int r = 0; r < matriz.GetLength(0); r++)
            {
                if (matriz[r, 5] == seccion)
                {
                    Clf_alumnos[nuevo_contador, 0] = matriz[r, 1];
                    Clf_alumnos[nuevo_contador, 1] = matriz[r, 5];

                    nuevo_contador++;
                }
            }
            return Clf_alumnos;


        }

        // promedio 
        public int promedios_general_seccion(string[,] matriz, int columna_parcial, string seccion)
        {
            int promedio = 0;
            int acumulador = 0;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                if (matriz[i, 5] == seccion)
                {
                    acumulador += Convert.ToInt32(matriz[i, columna_parcial]);

                }
                promedio = acumulador / matriz.GetLength(0);
            }
            return promedio;
        }

        public int promedios_por_parcial(string[,] matriz, int columna_parcial)
        {
            int acumulador = 0;
            int promedio = 0;
            for (int fila = 1; fila < matriz.GetLength(0); fila++)
            {
                acumulador += Convert.ToInt32(matriz[fila, columna_parcial]);
            }
            promedio = acumulador / matriz.GetLength(0);

            return promedio;
        }

        public int promedios_por_seccion(string[,] matriz, int columna_parcial, string seccion)
        {
            int promedio = 0;
            int acumulador = 0;

            for (int f = 0; f < matriz.GetLength(0); f++)
            {
                if (matriz[f, 5] == seccion)
                {
                    acumulador += Convert.ToInt32(matriz[f, columna_parcial]);

                }
            }
            promedio = acumulador / matriz.GetLength(0);
            return promedio;
        }


        public string[,] sumatoria_general_por_alumno(string[,] matriz)
        {
            string[,] Datos_Alumno = new string[matriz.GetLength(0), 2];
            for (int j = 0; j < matriz.GetLength(0); j++)
            {
                Datos_Alumno[j, 0] = matriz[j, 1];
                int sumatoria = Convert.ToInt32(matriz[j, 2]) + Convert.ToInt32(matriz[j, 3]) + Convert.ToInt32(matriz[j, 4]);
                Datos_Alumno[j, 1] = Convert.ToString(sumatoria);
            }
            return Datos_Alumno;
        }
    }
}
