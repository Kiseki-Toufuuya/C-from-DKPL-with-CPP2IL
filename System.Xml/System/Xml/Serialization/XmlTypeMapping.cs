namespace System.Xml.Serialization;

public class XmlTypeMapping : XmlMapping
{
	private string xmlType; //Field offset: 0x24
	private string xmlTypeNamespace; //Field offset: 0x28
	private TypeData type; //Field offset: 0x2C
	private XmlTypeMapping baseMap; //Field offset: 0x30
	private bool multiReferenceType; //Field offset: 0x34
	private bool includeInSchema; //Field offset: 0x35
	private bool isNullable; //Field offset: 0x36
	private bool isAny; //Field offset: 0x37
	private ArrayList _derivedTypes; //Field offset: 0x38

	internal XmlTypeMapping BaseMap
	{
		internal get { } //Length: 11
		internal set { } //Length: 27
	}

	internal ArrayList DerivedTypes
	{
		internal get { } //Length: 11
	}

	internal bool HasXmlTypeNamespace
	{
		internal get { } //Length: 15
	}

	internal bool IncludeInSchema
	{
		internal set { } //Length: 14
	}

	internal bool IsAny
	{
		internal get { } //Length: 11
		internal set { } //Length: 14
	}

	internal bool IsNullable
	{
		internal get { } //Length: 11
		internal set { } //Length: 140
	}

	internal bool MultiReferenceType
	{
		internal get { } //Length: 11
	}

	internal TypeData TypeData
	{
		internal get { } //Length: 11
	}

	public string TypeFullName
	{
		 get { } //Length: 23
	}

	internal string XmlType
	{
		internal get { } //Length: 11
		internal set { } //Length: 27
	}

	internal string XmlTypeNamespace
	{
		internal get { } //Length: 25
		internal set { } //Length: 27
	}

	internal XmlTypeMapping(string elementName, string ns, TypeData typeData, string xmlType, string xmlTypeNamespace) { }

	internal XmlTypeMapping get_BaseMap() { }

	internal ArrayList get_DerivedTypes() { }

	internal bool get_HasXmlTypeNamespace() { }

	internal bool get_IsAny() { }

	internal bool get_IsNullable() { }

	internal bool get_MultiReferenceType() { }

	internal TypeData get_TypeData() { }

	public string get_TypeFullName() { }

	internal string get_XmlType() { }

	internal string get_XmlTypeNamespace() { }

	internal XmlTypeMapping GetRealElementMap(string name, string ens) { }

	internal XmlTypeMapping GetRealTypeMap(Type objectType) { }

	internal void set_BaseMap(XmlTypeMapping value) { }

	internal void set_IncludeInSchema(bool value) { }

	internal void set_IsAny(bool value) { }

	internal void set_IsNullable(bool value) { }

	internal void set_XmlType(string value) { }

	internal void set_XmlTypeNamespace(string value) { }

	internal void UpdateRoot(XmlQualifiedName qname) { }

}

