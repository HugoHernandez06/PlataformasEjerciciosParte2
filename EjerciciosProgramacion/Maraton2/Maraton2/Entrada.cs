using System;

namespace Maraton2
{
    public class Entrada
    {
        string Nombre;
        Valvula Val;
        double Flujo;

        public Entrada()
        {
        }

        public Entrada(double flujo)
        {
            this.Flujo = flujo;
        }

        public Entrada(string nombre, Valvula val, double flujo)
        {
            this.Nombre = nombre;
            this.Val = val;
            this.Flujo = flujo;
        }

        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public Valvula Val1 { get => Val; set => Val = value; }
        public double Flujo1 { get => Flujo; set => Flujo = value; }
    }
}
