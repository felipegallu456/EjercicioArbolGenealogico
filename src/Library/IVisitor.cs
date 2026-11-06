namespace Library;

public interface IVisitor<T>
{
    void Visitar(Node<T> node);


}
