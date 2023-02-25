using AulasSemana04.Interfaces;

namespace AulasSemana04.Classes
{
    public class Circulo : IFiguraGeometrica
    {
        public double Raio { get; set; }
        public double Area()
        {
            return 3.14 * (Raio * Raio);
        }

        public double Perimetro()
        {
            return 2 * 3.14 * Raio;
        }
    }
}
