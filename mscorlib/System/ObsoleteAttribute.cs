namespace System;

[AttributeUsage(6140, Inherited = False)]
public sealed class ObsoleteAttribute : Attribute
{
	private string _message; //Field offset: 0x8
	private bool _error; //Field offset: 0xC

	public bool IsError
	{
		 get { } //Length: 11
	}

	public string Message
	{
		 get { } //Length: 11
	}

	public ObsoleteAttribute() { }

	public ObsoleteAttribute(string message) { }

	public ObsoleteAttribute(string message, bool error) { }

	public bool get_IsError() { }

	public string get_Message() { }

}

