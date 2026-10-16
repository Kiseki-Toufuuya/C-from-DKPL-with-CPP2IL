namespace System.Xml.Serialization;

[AttributeUsage(1036)]
public sealed class XmlSchemaProviderAttribute : Attribute
{
	private string _methodName; //Field offset: 0x8
	private bool _isAny; //Field offset: 0xC

	public bool IsAny
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public string MethodName
	{
		 get { } //Length: 11
	}

	public XmlSchemaProviderAttribute(string methodName) { }

	public bool get_IsAny() { }

	public string get_MethodName() { }

	public void set_IsAny(bool value) { }

}

