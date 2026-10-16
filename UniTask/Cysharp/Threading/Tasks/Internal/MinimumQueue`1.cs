namespace Cysharp.Threading.Tasks.Internal;

internal class MinimumQueue
{
	private T[] array; //Field offset: 0x0
	private int head; //Field offset: 0x0
	private int tail; //Field offset: 0x0
	private int size; //Field offset: 0x0

	public int Count
	{
		 get { } //Length: 11
	}

	public MinimumQueue`1(int capacity) { }

	public T Dequeue() { }

	public void Enqueue(T item) { }

	public int get_Count() { }

	private void Grow() { }

	private void MoveNext(ref int index) { }

	private void SetCapacity(int capacity) { }

	private void ThrowForEmptyQueue() { }

}

