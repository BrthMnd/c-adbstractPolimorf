namespace Abstract
{
    public abstract class Especie
    {
        private string _NombreCientifico;
        private string _ReinoTaxonomico;

        public Especie(string nombreCientifico, string reinoTaxonomico)
        {
            this.NombreCientifico = nombreCientifico;
            this.ReinoTaxonomico = reinoTaxonomico;
        }

        public string NombreCientifico { get => _NombreCientifico; set => _NombreCientifico = value; }
        public string ReinoTaxonomico { get => _ReinoTaxonomico; set => _ReinoTaxonomico = value; }

        public abstract void EmitirSonido();
    }

    public class Animal : Especie
    {
        public string NombreComun { get; set; }
        public int NivelInteligencia { get; set; }
        public string HabitatNatural { get; set; }
        public string PaisOrigen { get; set; }

        public Animal(string nombreCientifico, string reinoTaxonomico, string nombreComun,
            int nivelInteligencia, string habitatNatural, string paisOrigen)
            : base(nombreCientifico, reinoTaxonomico)
        {
            this.NombreComun = nombreComun;
            this.NivelInteligencia = nivelInteligencia;
            this.HabitatNatural = habitatNatural;
            this.PaisOrigen = paisOrigen;
        }

        public override void EmitirSonido()
        {
            Console.WriteLine("El animal emite un sonido");
        }
    }

    class Tigre : Animal
    {
        public string GeneroEjemplar { get; set; }
        public Tigre(string nombreCientifico, string reinoTaxonomico, string nombreComun,
            int nivelInteligencia, string habitatNatural, string paisOrigen, string generoEjemplar)
            : base(nombreCientifico, reinoTaxonomico, nombreComun, nivelInteligencia, habitatNatural, paisOrigen)
        {
            this.GeneroEjemplar = generoEjemplar;
        }

        public override void EmitirSonido()
        {
            Console.WriteLine("El tigre emite un rugido");
        }
    }

}