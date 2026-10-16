namespace XeApp.Core;

public class IntrusiveList
{
	internal interface IOrder
	{

		public void Order(T t) { }

	}

	public T Head; //Field offset: 0x0
	public T Tail; //Field offset: 0x0
	[CompilerGenerated]
	private int <ListId>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private int <Count>k__BackingField; //Field offset: 0x0

	public private int Count
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	public bool IsEmpty
	{
		 get { } //Length: 15
	}

	public private int ListId
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	public IntrusiveList`1(int listId) { }

	public void Add(T t) { }

	public void DoOrder(IOrder<T, T> handle) { }

	[CompilerGenerated]
	public int get_Count() { }

	public bool get_IsEmpty() { }

	[CompilerGenerated]
	public int get_ListId() { }

	public T PopFront() { }

	public void PushFront(T t) { }

	public void Remove(T t) { }

	[CompilerGenerated]
	private void set_Count(int value) { }

	[CompilerGenerated]
	private void set_ListId(int value) { }

}

