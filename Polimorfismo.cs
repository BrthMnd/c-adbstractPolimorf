
using System;
namespace Abstract
{
    // * Ejercicio 1
    public class Persona1 
    {
        public void Presentarse(){
        }
        
    }
    public class Estudiante: Persona1{
        public void Presentarse(){
            Console.WriteLine("Hola soy un Estudiante");
        }

    }
    public class Profesor: Persona1{
        public void Presentarse(){
            Console.WriteLine("Hola soy un Profesor");
        }

    }
    // * Ejercicio 2
    public class Comida 
    {
        public void Preparar(){}
        
    }
    public class Pizza: Comida{
        public void Preparar(){
            Console.WriteLine("ingredientes de Pizza: Harina de trigo 160 g · Agua templada 100 ml · Sal fina cucharadita 1 · Aceite de oliva virgen extra cucharada 1 · Levadura seca");
        }

    }
    public class Hamburguesa: Comida{
        public void Preparar(){
            Console.WriteLine("Ingredientes de Hamburguesa · 4 Hamburguesas de Res Zenú · 4 panes para hamburguesa · 4 Hamburguesas de Res Zenú · 200 g Tocineta Ahumada Zenú");
        }

    }
    // * Ejercicio 3
    public class Instrumento 
    {
        public void Tocar(){
        }
        
    }
    public class Guitarra: Instrumento{
        public void Tocar(){
            Console.WriteLine("*** Jhon Five -> Noche acosador  ***");
        }

    }
    public class Piano: Instrumento{
        public void Tocar(){
            Console.WriteLine("*** Moonlithg sonata 3° Movimieto.***");
        }

    }
}