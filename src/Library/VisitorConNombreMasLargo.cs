using System;

namespace Library;

public class VisitorConNombreMasLargo : IVisitor<Persona>
{
    public Persona Persona {get;private set;}

    public void Visitar(Node<Persona> node)
    {
        if (this.Persona == null || node.Data.Nombre.Length > this.Persona.Nombre.Length)
        {
            this.Persona = node.Data;
        }
    }
}
