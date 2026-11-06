using System;

namespace Library;

public class SumaDeEdadesVisitor : IVisitor<Persona>
{
    private int edadTotal = 0;

    public int EdadTotal
    {
        get
        {
            return this.edadTotal;
        }
    }
    public void Visitar(Node<Persona> node)
    {
        this.edadTotal += node.Data.Edad;
    }
}
