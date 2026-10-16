namespace System.Xml.Serialization;

[AttributeUsage(1100, AllowMultiple = True)]
public class XmlIncludeAttribute : Attribute
{
	private Type type; //Field offset: 0x8

	public Type Type
	{
		 get { } //Length: 11
	}

	public Type get_Type() { }

}

