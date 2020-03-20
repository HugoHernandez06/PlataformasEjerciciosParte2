using System;
using System.Text.RegularExpressions;

namespace Maraton2
{
    public class SistemaIrrigacion
    {
        Entrada[] Entradas;
        Valvula[] Valvulas;
        Salida[] Salidas;
        string[] Configuraciones = new string[20];
        int numIn, numOut, numVal, numConf;

        public SistemaIrrigacion()
        {
        }

        public SistemaIrrigacion(string[] sis, int numLineas)
        {
            string[] Split;
            int j = 0, k = 0, v = 0, z = 0;

            for (int n = 0; n < numLineas; n++)
            {
                Split = sis[n].Split(' ');

                if (n == 0)
                {
                    numIn = Convert.ToInt32(Split[0]);
                    numOut = Convert.ToInt32(Split[1]);
                    numVal = Convert.ToInt32(Split[2]);
                    Entradas = new Entrada[numIn];
                    Valvulas = new Valvula[numVal];
                    Salidas = new Salida[numOut];
                }
                else if (n == 1)
                {
                    for (int i = 0; i < numIn; i++)
                        Entradas[i] = new Entrada(Convert.ToSingle(Split[i]));
                }
                else if (n < (numIn + 2))
                {
                    Entradas[j].Nombre1 = Split[0];
                    Valvulas[j] = new Valvula(Split[1], j);
                    Entradas[j].Val1 = Valvulas[j];
                    j++;
                }
                else if (n < (numOut + numIn + 2))
                {
                    Salidas[k] = new Salida(sis[n], k);
                    k++;
                }
                else if (n < (numVal + numOut + numIn + 2))
                {

                    int pos;
                    Valvulas[v] = Valvulas[v] ?? new Valvula(Split[0], v);
                    
                    pos = Convert.ToInt32(Regex.Replace(Split[1], @"[^\d]", "")) - 1; 
                    if (Split[1][0] == 'S')
                        Valvulas[v].EndL1 = Salidas[pos];
                    else
                    {
                        Valvulas[pos] = Valvulas[pos] ?? new Valvula(Split[1], pos);
                        Valvulas[v].EndL1 = Valvulas[pos];
                    }
                    
                    pos = Convert.ToInt32(Regex.Replace(Split[2], @"[^\d]", "")) - 1;
                    if (Split[2][0] == 'S')
                        Valvulas[v].EndR1 = Salidas[pos];
                    else
                    {
                        
                        Valvulas[pos] = Valvulas[pos] ?? new Valvula(Split[2], pos); //El operador de fusión nula?? devuelve el valor de su operando izquierdo si no es nulo; de lo contrario, evalúa el operando de la derecha y devuelve su resultado. Los ?? El operador no evalúa su operando de la derecha si el operando de la izquierda se evalúa como no nulo.
                        Valvulas[v].R1 = Valvulas[pos];
                    }
                    v++;
                }
                else
                {
                    Configuraciones[z] = sis[n];
                    z++;
                }
            }
            numConf = z;
        }

        public string CalcularConfiguraciones()
        {
            string salida = "";
            double[] flujos = new double[numOut];
            for (int i = 0; i < numOut; i++)
                flujos[i] = 0;
            for (int n = 0; n < numConf; n++)
            {
                salida += "Configuración de válvulas # " + (n + 1) + "\n";
                for (int i = 0; i < numIn; i++) 
                {
                    Valvula tmp; 
                    Salida sal = new Salida("S", 0); 
                    for (tmp = Entradas[i].Val1; tmp != null; tmp = Configuraciones[n].Split(' ')[tmp.Num1] == "L" ? tmp.L1 : tmp.R1)
                        sal = Configuraciones[n].Split(' ')[tmp.Num1] == "L" ? tmp.EndL1 : tmp.EndR1;

                    flujos[sal.Num1] += Entradas[i].Flujo1;
                }
                for (int i = 0; i < numOut; i++)
                {
                    salida += "Salida # " + (i + 1) + " : flujo " + flujos[i] + " galones/min\n ";
                    flujos[i] = 0;
                }
            }
            return salida;
        }

    }
}
