namespace Newtonsoft.Json.Converters;

[Nullable(0)]
[NullableContext(2)]
internal class XAttributeWrapper : XObjectWrapper
{

	[Nullable(1)]
	private XAttribute Attribute
	{
		[NullableContext(1)]
		private get { } //Length: 101
	}

	public virtual string LocalName
	{
		 get { } //Length: 37
	}

	public virtual string NamespaceUri
	{
		 get { } //Length: 48
	}

	public virtual IXmlNode ParentNode
	{
		 get { } //Length: 88
	}

	public virtual string Value
	{
		 get { } //Length: 30
	}

	[NullableContext(1)]
	public XAttributeWrapper(XAttribute attribute) { }

	[NullableContext(1)]
	private XAttribute get_Attribute() { }

	public virtual string get_LocalName() { }

	public virtual string get_NamespaceUri() { }

	public virtual IXmlNode get_ParentNode() { }

	public virtual string get_Value() { }

}

