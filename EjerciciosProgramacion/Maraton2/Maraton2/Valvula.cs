using System;

namespace Maraton2
{
    public class Valvula
    {
        Valvula R, L; 
        Salida EndR, EndL;
        string Nombre;
        int Num;

        public Valvula()
        {
        }

        public Valvula(string nombre, int num)
        {
            this.Nombre = nombre;
            this.Num = num;
        }

        public Valvula R1 { get => R; set => R = value; }
        public Valvula L1 { get => L; set => L = value; }
        public Salida EndR1 { get => EndR; set => EndR = value; }
        public Salida EndL1 { get => EndL; set => EndL = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public int Num1 { get => Num; set => Num = value; }
    }
}
