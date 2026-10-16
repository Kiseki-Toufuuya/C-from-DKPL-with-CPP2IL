namespace System.Xml.Schema;

public abstract class XmlSchemaFacet : XmlSchemaAnnotated
{
	private string value; //Field offset: 0x2C
	private bool isFixed; //Field offset: 0x30
	private FacetType facetType; //Field offset: 0x34

	internal FacetType FacetType
	{
		internal get { } //Length: 11
		internal set { } //Length: 14
	}

	[DefaultValue(False)]
	[XmlAttribute("fixed")]
	public override bool IsFixed
	{
		 get { } //Length: 11
		 set { } //Length: 135
	}

	[XmlAttribute("value")]
	public string Value
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	protected XmlSchemaFacet() { }

	internal FacetType get_FacetType() { }

	public override bool get_IsFixed() { }

	public string get_Value() { }

	internal void set_FacetType(FacetType value) { }

	public override void set_IsFixed(bool value) { }

	public void set_Value(string value) { }

}

