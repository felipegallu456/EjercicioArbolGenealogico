using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Node<Persona> Ana = new Node<Persona>(new Persona("Ana", 78));
            Node<Persona> Carlos = new Node<Persona>(new Persona("Carlos", 52));
            Node<Persona> Laura = new Node<Persona>(new Persona("Laura", 49));
            Node<Persona> Mateo= new Node<Persona>(new Persona("Mateo", 24));
            Node<Persona> Sofia = new Node<Persona>(new Persona("Sofia", 20));
            Node<Persona> Diego = new Node<Persona>(new Persona("Diego", 18));
            Node<Persona> Valentina = new Node<Persona>(new Persona("Valentina", 15));
            Ana.AddChildren(Carlos);
            Ana.AddChildren(Laura);
            Laura.AddChildren(Diego);
            Laura.AddChildren(Valentina);
            Carlos.AddChildren(Mateo);
            Carlos.AddChildren(Sofia);


            // visitar el árbol aquí
            SumaDeEdadesVisitor edadVisitor = new SumaDeEdadesVisitor();
            Ana.Aceptar(edadVisitor);
            Console.WriteLine($"Suma de edades: {edadVisitor.EdadTotal}");
            HijoMayorvisitor visitorMayor = new HijoMayorvisitor();
            Ana.Aceptar(visitorMayor);
            Console.WriteLine($"hijo mayor: " + $"{visitorMayor.hijomayor.Nombre} de "  + $"{visitorMayor.hijomayor.Edad} años");
            VisitorConNombreMasLargo visitorconNombreMasLargo = new VisitorConNombreMasLargo();
            Ana.Aceptar(visitorconNombreMasLargo);
            Console.WriteLine("Nombre más largo: " + visitorconNombreMasLargo.Persona.Nombre);
        }
    }
}
