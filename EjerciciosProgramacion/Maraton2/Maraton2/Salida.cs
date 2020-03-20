using System;

namespace Maraton2
{
    public class Salida
    {
        string Nombre;
        int Num;
        public Salida()
        {
        }

        public Salida(string nombre, int num)
        {
            this.Nombre = nombre;
            this.Num = num;
        }

        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public int Num1 { get => Num; set => Num = value; }

        public static implicit operator Salida(Valvula v)
        {
            throw new NotImplementedException();
        }
    }
}
