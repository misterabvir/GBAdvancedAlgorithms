namespace Lesson2.Structures.LinkListStructure;

public class LinkList<T> where T : struct
{
    public Node<T>? First => head;
    public Node<T>? Last => tail;

    private Node<T>? head;
    private Node<T>? tail;
    public int Count { get; private set; } = 0;

    public Node<T> AddLast(T item)
    {
        Node<T> node = new Node<T>() { Value = item };

        if (head == null || tail == null)
        {
            head = tail = node;
            Count = 1;
        }
        else
        {
            tail!.Next = node;
            node.Previous = tail;
            tail = node;
            Count++;
        }
        return node;
    }
    public Node<T> AddFirst(T item)
    {
        Node<T> node = new Node<T>() { Value = item };

        if (head == null || tail == null)
        {
            head = tail = node;
            Count = 1;
        }
        else
        {
            head.Previous = node;
            node.Next = head;
            head = node;
            Count++;
        }
        return node;
    }
    public Node<T>? FindFirst(T item)
    {
        Node<T>? current = head;
        if (current == null) return null;

        while (current != null)
        {
            if (current.Value.Equals(item))
                return current;
            current = current.Next;
        }
        return null;
    }
    public Node<T>? FindLast(T item)
    {
        Node<T>? current = tail;
        if (current == null) return null;

        while (current != null)
        {
            if (current.Value.Equals(item))
                return current;
            current = current.Previous;
        }
        return null;
    }
    public bool Contains(T item)
    {
        Node<T>? current = head;
        if (current == null) return false;
        while (current != null)
        {
            if (current.Value.Equals(item))
                return true;
            current = current.Next;
        }
        return false;
    }
    public Node<T>? AddAfter(Node<T> node, T item)
    {
        Node<T>? current = head;
        if (current == null) return null;
        while (current != null)
        {
            if (ReferenceEquals(current, node))
            {
                Node<T>? newNode = new Node<T>
                {
                    Value = item,
                    Next = node.Next,
                    Previous = node
                };
                Node<T>? next = node.Next;
                node.Next = newNode;
                if (next != null)
                    next.Previous = newNode;
                Count++;
                return newNode;
            }
            current = current.Next;
        }
        return null;
    }
    public Node<T>? AddBefore(Node<T> node, T item)
    {
        Node<T>? current = tail;
        if (current == null) return null;
        while (current != null)
        {
            if (ReferenceEquals(current, node))
            {
                Node<T>? newNode = new Node<T>
                {
                    Value = item,
                    Next = node,
                    Previous = node.Previous
                };
                Node<T>? prev = node.Previous;
                node.Previous = newNode;
                if (prev != null)
                    prev.Next = newNode;
                Count++;
                return newNode;
            }
            current = current.Previous;
        }
        return null;
    }
    public bool Remove(Node<T> node)
    {
        Node<T>? current = head;
        if (current == null) return false;
        while (current != null)
        {
            if (ReferenceEquals(current, node))
            {
                if (node.Previous != null) node.Previous.Next = node.Next;
                if (node.Next != null) node.Next.Previous = node.Previous;
                Count--;
                return true;
            }
            current = current.Next;
        }
        return false;
    }
    public bool Remove(T item)
    {
        Node<T>? node = FindFirst(item);
        if (node == null) return false;
        return Remove(node);
    }
    public Node<T>? RemoveFirst()
    {
        if (head == null) return null;
        Node<T>? node = head;
        head = node.Next;
        if (head != null)
            head.Previous = null;
        Count--;
        return node;
    }
    public Node<T>? RemoveLast()
    {
        if (tail == null) return null;
        Node<T>? node = tail;
        tail = node.Previous;
        if (tail != null)
            tail.Next = null;
        Count--;
        return node;
    }
    public void Clear()
    {
        head = null;
        tail = null;
        Count = 0;
    }

    public LinkList<T> Revert()
    {
        LinkList<T> list = new LinkList<T>();
        Node<T>? current = head;
        if (current == null) return list;
        while (current != null)
        {
            list.AddFirst(current.Value);
            current = current.Next;
        }
        head = list.First;
        tail = list.Last;
        return this;
    }


    public override string ToString()
    {
        string result = "[]";
        Node<T>? current = head;
        if (current == null) return result;
        result = "[ " + current.Value;
        while (current.Next != null)
        {
            current = current.Next;
            result += $" <--> {current.Value}";
        }
        return result + " ]";
    }



}
