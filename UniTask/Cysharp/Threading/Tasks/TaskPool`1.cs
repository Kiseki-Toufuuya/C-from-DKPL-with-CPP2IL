namespace Cysharp.Threading.Tasks;

public struct TaskPool
{
	private int gate; //Field offset: 0x0
	private int size; //Field offset: 0x0
	private T root; //Field offset: 0x0

	public int Size
	{
		 get { } //Length: 11
	}

	public int get_Size() { }

	public bool TryPop(out T result) { }

	public bool TryPush(T item) { }

}

