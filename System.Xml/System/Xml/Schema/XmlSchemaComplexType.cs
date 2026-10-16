namespace System.Xml.Schema;

public class XmlSchemaComplexType : XmlSchemaType
{
	private static XmlSchemaComplexType anyTypeLax; //Field offset: 0x0
	private static XmlSchemaComplexType anyTypeSkip; //Field offset: 0x4
	private static XmlSchemaComplexType untypedAnyType; //Field offset: 0x8
	private XmlSchemaDerivationMethod block; //Field offset: 0x54
	private XmlSchemaContentModel contentModel; //Field offset: 0x58
	private XmlSchemaParticle particle; //Field offset: 0x5C
	private XmlSchemaObjectCollection attributes; //Field offset: 0x60
	private XmlSchemaAnyAttribute anyAttribute; //Field offset: 0x64
	private XmlSchemaParticle contentTypeParticle; //Field offset: 0x68
	private XmlSchemaDerivationMethod blockResolved; //Field offset: 0x6C
	private XmlSchemaObjectTable localElements; //Field offset: 0x70
	private XmlSchemaObjectTable attributeUses; //Field offset: 0x74
	private XmlSchemaAnyAttribute attributeWildcard; //Field offset: 0x78
	private byte pvFlags; //Field offset: 0x7C

	[XmlElement("anyAttribute")]
	public XmlSchemaAnyAttribute AnyAttribute
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	[XmlIgnore]
	internal static XmlSchemaComplexType AnyType
	{
		internal get { } //Length: 60
	}

	internal static ContentValidator AnyTypeContentValidator
	{
		internal get { } //Length: 87
	}

	[XmlElement("attribute", typeof(XmlSchemaAttribute))]
	[XmlElement("attributeGroup", typeof(XmlSchemaAttributeGroupRef))]
	public XmlSchemaObjectCollection Attributes
	{
		 get { } //Length: 87
	}

	[XmlIgnore]
	public XmlSchemaObjectTable AttributeUses
	{
		 get { } //Length: 87
	}

	[XmlIgnore]
	public XmlSchemaAnyAttribute AttributeWildcard
	{
		 get { } //Length: 11
	}

	[DefaultValue(XmlSchemaDerivationMethod::None (256))]
	[XmlAttribute("block")]
	public XmlSchemaDerivationMethod Block
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[XmlIgnore]
	public XmlSchemaDerivationMethod BlockResolved
	{
		 get { } //Length: 11
	}

	[XmlElement("simpleContent", typeof(XmlSchemaSimpleContent))]
	[XmlElement("complexContent", typeof(XmlSchemaComplexContent))]
	public XmlSchemaContentModel ContentModel
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	[XmlIgnore]
	public XmlSchemaContentType ContentType
	{
		 get { } //Length: 11
	}

	[XmlIgnore]
	public XmlSchemaParticle ContentTypeParticle
	{
		 get { } //Length: 11
	}

	internal bool HasWildCard
	{
		internal set { } //Length: 34
	}

	[DefaultValue(False)]
	[XmlAttribute("abstract")]
	public bool IsAbstract
	{
		 get { } //Length: 15
		 set { } //Length: 34
	}

	[DefaultValue(False)]
	[XmlAttribute("mixed")]
	public virtual bool IsMixed
	{
		 get { } //Length: 15
		 set { } //Length: 34
	}

	[XmlIgnore]
	internal XmlSchemaObjectTable LocalElements
	{
		internal get { } //Length: 87
	}

	[XmlElement("all", typeof(XmlSchemaAll))]
	[XmlElement("group", typeof(XmlSchemaGroupRef))]
	[XmlElement("sequence", typeof(XmlSchemaSequence))]
	[XmlElement("choice", typeof(XmlSchemaChoice))]
	public XmlSchemaParticle Particle
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	[XmlIgnore]
	internal static XmlSchemaComplexType UntypedAnyType
	{
		internal get { } //Length: 61
	}

	private static XmlSchemaComplexType() { }

	public XmlSchemaComplexType() { }

	private void ClearCompiledState() { }

	internal XmlSchemaObject Clone(XmlSchema parentSchema) { }

	internal virtual XmlSchemaObject Clone() { }

	internal static XmlSchemaObjectCollection CloneAttributes(XmlSchemaObjectCollection attributes) { }

	private static XmlSchemaObjectCollection CloneGroupBaseParticles(XmlSchemaObjectCollection groupBaseParticles, XmlSchema parentSchema) { }

	internal static XmlSchemaParticle CloneParticle(XmlSchemaParticle particle, XmlSchema parentSchema) { }

	internal bool ContainsIdAttribute(bool findAll) { }

	private static XmlSchemaComplexType CreateAnyType(XmlSchemaContentProcessing processContents) { }

	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	internal static XmlSchemaComplexType get_AnyType() { }

	internal static ContentValidator get_AnyTypeContentValidator() { }

	public XmlSchemaObjectCollection get_Attributes() { }

	public XmlSchemaObjectTable get_AttributeUses() { }

	public XmlSchemaAnyAttribute get_AttributeWildcard() { }

	public XmlSchemaDerivationMethod get_Block() { }

	public XmlSchemaDerivationMethod get_BlockResolved() { }

	public XmlSchemaContentModel get_ContentModel() { }

	public XmlSchemaContentType get_ContentType() { }

	public XmlSchemaParticle get_ContentTypeParticle() { }

	public bool get_IsAbstract() { }

	public virtual bool get_IsMixed() { }

	internal XmlSchemaObjectTable get_LocalElements() { }

	public XmlSchemaParticle get_Particle() { }

	internal static XmlSchemaComplexType get_UntypedAnyType() { }

	private static XmlSchemaForm GetResolvedElementForm(XmlSchema parentSchema, XmlSchemaElement element) { }

	internal static bool HasAttributeQNameRef(XmlSchemaObjectCollection attributes) { }

	internal static bool HasParticleRef(XmlSchemaParticle particle, XmlSchema parentSchema) { }

	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	public void set_Block(XmlSchemaDerivationMethod value) { }

	public void set_ContentModel(XmlSchemaContentModel value) { }

	internal void set_HasWildCard(bool value) { }

	public void set_IsAbstract(bool value) { }

	public virtual void set_IsMixed(bool value) { }

	public void set_Particle(XmlSchemaParticle value) { }

	internal void SetAttributes(XmlSchemaObjectCollection newAttributes) { }

	internal void SetAttributeWildcard(XmlSchemaAnyAttribute value) { }

	internal void SetBlockResolved(XmlSchemaDerivationMethod value) { }

	internal void SetContentTypeParticle(XmlSchemaParticle value) { }

}

