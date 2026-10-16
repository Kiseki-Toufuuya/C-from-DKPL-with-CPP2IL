namespace System.Diagnostics;

[AttributeUsage(4509, AllowMultiple = True)]
[ComVisible(True)]
public sealed class DebuggerDisplayAttribute : Attribute
{
	private string name; //Field offset: 0x8
	private string value; //Field offset: 0xC
	private string type; //Field offset: 0x10

	public string Name
	{
		 set { } //Length: 27
	}

	public string Type
	{
		 set { } //Length: 27
	}

	public DebuggerDisplayAttribute(string value) { }

	public void set_Name(string value) { }

	public void set_Type(string value) { }

}

