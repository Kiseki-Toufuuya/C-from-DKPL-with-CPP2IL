namespace System.Xml.Serialization;

public class XmlReflectionMember
{
	private bool isReturnValue; //Field offset: 0x8
	private string memberName; //Field offset: 0xC
	private Type memberType; //Field offset: 0x10
	private XmlAttributes xmlAttributes; //Field offset: 0x14
	private Type declaringType; //Field offset: 0x18

	internal Type DeclaringType
	{
		internal get { } //Length: 11
		internal set { } //Length: 27
	}

	public bool IsReturnValue
	{
		 get { } //Length: 11
	}

	public string MemberName
	{
		 get { } //Length: 11
	}

	public Type MemberType
	{
		 get { } //Length: 11
	}

	public XmlAttributes XmlAttributes
	{
		 get { } //Length: 87
	}

	internal XmlReflectionMember(string name, Type type, XmlAttributes attributes) { }

	internal Type get_DeclaringType() { }

	public bool get_IsReturnValue() { }

	public string get_MemberName() { }

	public Type get_MemberType() { }

	public XmlAttributes get_XmlAttributes() { }

	internal void set_DeclaringType(Type value) { }

}

