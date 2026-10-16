namespace System.Xml.Schema;

public class XmlSchemaIdentityConstraint : XmlSchemaAnnotated
{
	private string name; //Field offset: 0x2C
	private XmlSchemaXPath selector; //Field offset: 0x30
	private XmlSchemaObjectCollection fields; //Field offset: 0x34
	private XmlQualifiedName qualifiedName; //Field offset: 0x38
	private CompiledIdentityConstraint compiledConstraint; //Field offset: 0x3C

	[XmlIgnore]
	internal CompiledIdentityConstraint CompiledConstraint
	{
		internal get { } //Length: 11
		internal set { } //Length: 27
	}

	[XmlElement("field", typeof(XmlSchemaXPath))]
	public XmlSchemaObjectCollection Fields
	{
		 get { } //Length: 11
	}

	[XmlAttribute("name")]
	public string Name
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	[XmlIgnore]
	internal virtual string NameAttribute
	{
		internal get { } //Length: 11
		internal set { } //Length: 27
	}

	[XmlIgnore]
	public XmlQualifiedName QualifiedName
	{
		 get { } //Length: 11
	}

	[XmlElement("selector", typeof(XmlSchemaXPath))]
	public XmlSchemaXPath Selector
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public XmlSchemaIdentityConstraint() { }

	internal CompiledIdentityConstraint get_CompiledConstraint() { }

	public XmlSchemaObjectCollection get_Fields() { }

	public string get_Name() { }

	internal virtual string get_NameAttribute() { }

	public XmlQualifiedName get_QualifiedName() { }

	public XmlSchemaXPath get_Selector() { }

	internal void set_CompiledConstraint(CompiledIdentityConstraint value) { }

	public void set_Name(string value) { }

	internal virtual void set_NameAttribute(string value) { }

	public void set_Selector(XmlSchemaXPath value) { }

	internal void SetQualifiedName(XmlQualifiedName value) { }

}

