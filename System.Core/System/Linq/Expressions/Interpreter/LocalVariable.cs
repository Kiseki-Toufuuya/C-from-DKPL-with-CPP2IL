namespace System.Linq.Expressions.Interpreter;

internal sealed class LocalVariable
{
	public readonly int Index; //Field offset: 0x8
	private int _flags; //Field offset: 0xC

	public bool InClosure
	{
		 get { } //Length: 15
	}

	public bool IsBoxed
	{
		 get { } //Length: 15
		 set { } //Length: 29
	}

	internal LocalVariable(int index, bool closure) { }

	public bool get_InClosure() { }

	public bool get_IsBoxed() { }

	public void set_IsBoxed(bool value) { }

	public virtual string ToString() { }

}

