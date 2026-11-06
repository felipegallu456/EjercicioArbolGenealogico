using System;
using System.Reflection;

namespace Library;

public class HijoMayorvisitor :IVisitor<Persona>
{
    public Persona hijomayor {get;private set;}
    
    public void Visitar(Node<Persona> node)
    {
        bool esHoja = node.Children.Count == 0;
        if (esHoja)
        {
            if (this.hijomayor == null || node.Data.Edad > this.hijomayor.Edad)
            {
                this.hijomayor = node.Data;
            }
        }
    }
}
