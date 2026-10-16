namespace XeApp.Core;

public interface ISecureValue
{

	public bool IsFalsifed
	{
		 get { } //Length: 0
	}

	public T Value
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public bool get_IsFalsifed() { }

	public T get_Value() { }

	public void set_Value(T value) { }

}

