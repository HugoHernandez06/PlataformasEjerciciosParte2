﻿using System;
using System.IO;

namespace Maraton2
{
    class Program
    {
        static void Main(string[] args)
        {
            SistemaIrrigacion[] sistemas = new SistemaIrrigacion[10];
            /*string[] archivo = new string[]{"3 3 7", "200 40 73",
            "W1 V1", "W2 V2", "W3 V3",
            "S1", "S2", "S3",
            "V1 S1 V4", "V2 V4 V5", "V3 V5 V7", "V4 S1 V6",
            "V5 V6 V7", "V6 S1 V7", "V7 S2 S3",
            "R L R L R L R",
            "L R L R L R L",
            "*",
            "2 4 5", "100 200",
            "Entr1 Valv1", "Entr2 Valv2",
            "Sal1", "Sal2", "Sal3", "Sal4",
            "Valv1 Valv3 Valv4",
            "Valv2 Valv4 Valv5",
            "Valv3 Sal1 Sal2",
            "Valv4 Sal2 Sal3",
            "Valv5 Sal3 Sal4",
            "R L R L R",
            "L L L R L",
            "L R L R L",
            "*",
            "9999 9999 9999" };
            */
            StreamReader archivoEntrada = new StreamReader(@"..\..\..\DatosEntrada.txt");
            string lineaLeida;
            string[] sis = new string[100];
            int n = 0, i = 0;
            
            while ((lineaLeida = archivoEntrada.ReadLine()) != null) 
            {
                if (lineaLeida.Equals("9999 9999 9999"))
                {
                    break;
                }
                if (!lineaLeida.Equals("*"))
                {
                    sis[i] = lineaLeida;
                    i++;
                }
                else
                {
                    sistemas[n] = new SistemaIrrigacion(sis, i);
                    n++;
                }
            }
            archivoEntrada.Close();
            
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Sistema de Irrigación # " + (i + 1));
                Console.WriteLine(sistemas[i].CalcularConfiguraciones());
            }
            
            Console.WriteLine("Finalizado ...");
            Console.ReadKey();
        }
    }
}
