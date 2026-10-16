namespace XeApp.Core;

public interface IIntrusiveListNode
{

	public int ListId
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public T Next
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public T Prev
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public int get_ListId() { }

	public T get_Next() { }

	public T get_Prev() { }

	public void set_ListId(int value) { }

	public void set_Next(T value) { }

	public void set_Prev(T value) { }

}

