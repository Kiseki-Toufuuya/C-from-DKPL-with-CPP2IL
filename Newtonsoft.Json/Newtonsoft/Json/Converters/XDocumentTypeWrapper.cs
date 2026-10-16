namespace Newtonsoft.Json.Converters;

[Nullable(0)]
[NullableContext(2)]
internal class XDocumentTypeWrapper : XObjectWrapper, IXmlDocumentType, IXmlNode
{
	[Nullable(1)]
	private readonly XDocumentType _documentType; //Field offset: 0xC

	public override string InternalSubset
	{
		 get { } //Length: 23
	}

	public virtual string LocalName
	{
		 get { } //Length: 35
	}

	[Nullable(1)]
	public override string Name
	{
		[NullableContext(1)]
		 get { } //Length: 23
	}

	public override string Public
	{
		 get { } //Length: 23
	}

	public override string System
	{
		 get { } //Length: 23
	}

	[NullableContext(1)]
	public XDocumentTypeWrapper(XDocumentType documentType) { }

	public override string get_InternalSubset() { }

	public virtual string get_LocalName() { }

	[NullableContext(1)]
	public override string get_Name() { }

	public override string get_Public() { }

	public override string get_System() { }

}

