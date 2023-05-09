namespace Abstract
{
    public abstract class Persona
    {
        private string nombre;
        private int edad;
        private double peso;
        private double estatura;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
        public double Peso { get => peso; set => peso = value; }
        public double Estatura { get => estatura; set => estatura = value; }

        public Persona(string nombre, int edad, double peso, double estatura)
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.Peso = peso;
            this.Estatura = estatura;
        }

        public abstract double CalcularIMC();

        public void Ejercitarse(string tipoEjercicio, int duracion)
        {
            Console.WriteLine("{0} ha realizado {1} durante {2} minutos.", Nombre, tipoEjercicio, duracion);
        }

        public void Comer(string tipoComida, double cantidad)
        {
            Console.WriteLine("{0} ha consumido {1} gramos de {2}.", Nombre, cantidad, tipoComida);
        }

    }
    public class Adulto : Persona
    {
        public Adulto(string nombre, int edad, double peso, double estatura)
            : base(nombre, edad, peso, estatura)
        {
        }

        public override double CalcularIMC()
        {
            return Peso / (Estatura * Estatura);
        }

        public void Ejercitarse(string tipoEjercicio, int duracion)
        {
            Console.WriteLine("{0} ha registrado {1} minutos de {2} en su seguimiento de actividad física.", Nombre, duracion, tipoEjercicio);
        }

        public void Comer(string tipoComida, double cantidad)
        {
            Console.WriteLine("{0} ha registrado {1} gramos de {2} en su registro de alimentación.", Nombre, cantidad, tipoComida);
        }
    }

}