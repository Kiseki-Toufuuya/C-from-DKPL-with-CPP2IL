namespace Newtonsoft.Json.Converters;

[Nullable(0)]
[NullableContext(2)]
internal class XTextWrapper : XObjectWrapper
{

	public virtual IXmlNode ParentNode
	{
		 get { } //Length: 88
	}

	[Nullable(1)]
	private XText Text
	{
		[NullableContext(1)]
		private get { } //Length: 101
	}

	public virtual string Value
	{
		 get { } //Length: 30
	}

	[NullableContext(1)]
	public XTextWrapper(XText text) { }

	public virtual IXmlNode get_ParentNode() { }

	[NullableContext(1)]
	private XText get_Text() { }

	public virtual string get_Value() { }

}

