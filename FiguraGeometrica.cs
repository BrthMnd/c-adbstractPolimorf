namespace Abstract
{
    public abstract class FiguraGeometrica
    {
        public abstract double CalcularArea();
        public abstract double CalcularPerimetro();
    }
    public class Rombo : FiguraGeometrica
    {
        private double diagonalMayor;
        private double diagonalMenor;

        public Rombo(double diagonalMayor, double diagonalMenor)
        {
            this.diagonalMayor = diagonalMayor;
            this.diagonalMenor = diagonalMenor;
        }

        public override double CalcularArea()
        {
            return (diagonalMayor * diagonalMenor) / 2;
        }

        public override double CalcularPerimetro()
        {
            return 4 * Math.Sqrt(Math.Pow(diagonalMayor / 2, 2) + Math.Pow(diagonalMenor / 2, 2));
        }
    }
    public class Triangulo : FiguraGeometrica
    {
        private double lado1;
        private double lado2;
        private double lado3;

        public Triangulo(double lado1, double lado2, double lado3)
        {
            this.lado1 = lado1;
            this.lado2 = lado2;
            this.lado3 = lado3;
        }

        public override double CalcularArea()
        {
            double s = (lado1 + lado2 + lado3) / 2;
            return Math.Sqrt(s * (s - lado1) * (s - lado2) * (s - lado3));
        }

        public override double CalcularPerimetro()
        {
            return lado1 + lado2 + lado3;
        }
    }




}