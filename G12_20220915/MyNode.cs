namespace G12_20220915;

internal class MyNode<T>
{
	public T? Value { get; set; }
	public MyNode<T>? Next { get; set; }

	public override string ToString() => Value?.ToString() ??
		throw new NullReferenceException(nameof(Value));
}
