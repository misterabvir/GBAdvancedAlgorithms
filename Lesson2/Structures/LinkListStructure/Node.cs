namespace Lesson2.Structures.LinkListStructure;

public class Node<T> where T : struct 
{
    public T Value { get; set; }
    public Node<T>? Next { get; set; }
    public Node<T>? Previous { get; set; }

    public override string ToString() => Value.ToString() ?? "";
}
