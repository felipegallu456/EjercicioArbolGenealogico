namespace Library;

public class SumVisitor: IVisitor<int>
{
    private int suma = 0;

    public int Suma
    {
        get
        {
            return this.suma;
        }
    }

    public void Visitar(Node<int> node)
    {
        this.suma += node.Data;
    }
}
