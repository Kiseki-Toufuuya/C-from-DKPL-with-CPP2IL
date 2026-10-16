namespace System.Runtime.Serialization;

[AttributeUsage(12, Inherited = True, AllowMultiple = True)]
public sealed class KnownTypeAttribute : Attribute
{
	private string methodName; //Field offset: 0x8
	private Type type; //Field offset: 0xC

	public string MethodName
	{
		 get { } //Length: 11
	}

	public Type Type
	{
		 get { } //Length: 11
	}

	private KnownTypeAttribute() { }

	public KnownTypeAttribute(Type type) { }

	public KnownTypeAttribute(string methodName) { }

	public string get_MethodName() { }

	public Type get_Type() { }

}

