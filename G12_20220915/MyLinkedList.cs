using System.Collections;

namespace G12_20220915;

internal class MyLinkedList<T>:IEnumerable<T>
{
	private MyNode<T>? _firstNode;
    private MyNode<T>? _lastNode;
    private MyNode<T>? _middleNode;

    public int count { get; set; }

	public void Print()
	{
		MyNode<T>? node = _firstNode;
		while (node != null)
		{
                Console.WriteLine(node);
			node = node.Next;
		}
	}

	public void AddFirst(MyNode<T> node)
	{
		if (_firstNode == null)
		{
			_firstNode = _middleNode = node;
			count++;
			return;
		}

		node.Next = _firstNode;
		_firstNode = node;
        count++;
    }

	public MyNode<T> AddFirst(T value)
	{
		MyNode<T> node = new() { Value = value };
		AddFirst(node);
		return node;
	}

	public void AddLast(MyNode<T> node)
	{
        if (_firstNode == null || _lastNode == null)
        {
            _firstNode = _lastNode = node;
            count++;
            return;
        }

        _lastNode.Next = node;
        _lastNode = node;
		count++;
    }

	public MyNode<T> AddLast(T value)
	{
        MyNode<T> node = new() { Value = value };
        AddLast(node);
        return node;
    }

	public void AddAfter(MyNode<T> node, MyNode<T> newNode)
	{
		MyNode<T>? after = node.Next;

		node.Next = newNode;
		newNode.Next = after;
		count++;
	}

	public MyNode<T>? AddAfter(MyNode<T> node, T value)
	{
		MyNode<T>? myNode = new MyNode<T> { Value = value };

		if(myNode != null)
        AddAfter(node, myNode);
        return myNode;
    }


	public void AddBefore(MyNode<T> node, MyNode<T> newNode)
	{
		if(_firstNode == null || _lastNode == null || node == null)
			return;

		MyNode<T>? beforeNode = _firstNode;

		if (node == _firstNode)
			AddFirst(newNode);

        while (beforeNode.Next != null)
		{
			if (beforeNode.Next == node)
				{
					beforeNode.Next = newNode;
					newNode.Next = node;
					count++;
					return;
				}
            beforeNode = beforeNode.Next;
        }
	}

	public MyNode<T>? AddBefore(MyNode<T> node, T value)
	{
        MyNode<T>? myNode = new MyNode<T> { Value = value };

        if (myNode != null)
            AddBefore(node, myNode);

        return myNode;
    }

	public MyNode<T>? FindNode(T value)
	{
		if (value == null)
			return null;

        MyNode<T>? node = _firstNode;

        while (node != null)
        {
			if(node.Value!=null && node.Value.Equals(value))
				return node;

			node = node.Next;
        }

		return null;
    }

    public IEnumerator<T> GetEnumerator()
    {
        return new MyLinkedListEnumerator<T>(_firstNode);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }
}

class MyLinkedListEnumerator<T> : IEnumerator<T>
{
    private MyNode<T> _firstNode;
    private MyNode<T>? _currentNode;
    

    public MyLinkedListEnumerator(MyNode<T>? firstNode)
    {
        _firstNode = firstNode ?? throw new ArgumentNullException(nameof(firstNode));
        
    }

    public T Current => _currentNode.Value;

    public bool MoveNext()
    {
        if (_currentNode == null)
        {
            _currentNode = _firstNode;
            return true;
        }
        if (_currentNode.Next != null)
        {
            _currentNode = _currentNode.Next;
            return true;
        }

        return false;
    }

    public void Reset()
    {
        _currentNode = null;
    }

    public void Dispose()
    {
        Reset();
    }

    object IEnumerator.Current => throw new NotImplementedException();
}
