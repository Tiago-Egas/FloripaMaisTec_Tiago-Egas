using AulasSemana04.Interfaces;

namespace AulasSemana04.Classes
{
    public class Quadrado : IFiguraGeometrica
    {
        public double Lado { get; set; }
        public double Area()
        {
            return Lado * Lado;
        }

        public double Perimetro()
        {
            return Lado * 4;
        }
    }
}
