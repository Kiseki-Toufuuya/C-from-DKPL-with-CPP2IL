namespace System.Diagnostics;

public abstract class TraceListener : MarshalByRefObject, IDisposable
{
	private int indentLevel; //Field offset: 0xC
	private int indentSize; //Field offset: 0x10
	private bool needIndent; //Field offset: 0x14
	private string listenerName; //Field offset: 0x18

	public int IndentLevel
	{
		 set { } //Length: 30
	}

	public int IndentSize
	{
		 set { } //Length: 135
	}

	public override bool IsThreadSafe
	{
		 get { } //Length: 3
	}

	public override string Name
	{
		 get { } //Length: 53
	}

	protected TraceListener(string name) { }

	public override void Dispose() { }

	protected override void Dispose(bool disposing) { }

	public override void Flush() { }

	public override bool get_IsThreadSafe() { }

	public override string get_Name() { }

	public void set_IndentLevel(int value) { }

	public void set_IndentSize(int value) { }

}

