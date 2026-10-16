namespace System.Xml.Serialization;

internal class ClassMap : ObjectMap
{
	private Hashtable _elements; //Field offset: 0x8
	private ArrayList _elementMembers; //Field offset: 0xC
	private Hashtable _attributeMembers; //Field offset: 0x10
	private XmlTypeMapMemberAttribute[] _attributeMembersArray; //Field offset: 0x14
	private ArrayList _flatLists; //Field offset: 0x18
	private ArrayList _allMembers; //Field offset: 0x1C
	private ArrayList _membersWithDefault; //Field offset: 0x20
	private ArrayList _listMembers; //Field offset: 0x24
	private XmlTypeMapMemberAnyElement _defaultAnyElement; //Field offset: 0x28
	private XmlTypeMapMemberAnyAttribute _defaultAnyAttribute; //Field offset: 0x2C
	private XmlTypeMapMemberNamespaces _namespaceDeclarations; //Field offset: 0x30
	private XmlTypeMapMember _xmlTextCollector; //Field offset: 0x34
	private XmlTypeMapMember _returnMember; //Field offset: 0x38
	private bool _ignoreMemberNamespace; //Field offset: 0x3C
	private bool _canBeSimpleType; //Field offset: 0x3D
	private Nullable<Boolean> _isOrderDependentMap; //Field offset: 0x3E

	public ArrayList AllMembers
	{
		 get { } //Length: 11
	}

	public ICollection AttributeMembers
	{
		 get { } //Length: 736
	}

	public XmlTypeMapMemberAnyAttribute DefaultAnyAttributeMember
	{
		 get { } //Length: 11
	}

	public XmlTypeMapMemberAnyElement DefaultAnyElementMember
	{
		 get { } //Length: 11
	}

	public ICollection ElementMembers
	{
		 get { } //Length: 11
	}

	public ArrayList FlatLists
	{
		 get { } //Length: 11
	}

	public bool HasSimpleContent
	{
		 get { } //Length: 85
	}

	public bool IsOrderDependentMap
	{
		 get { } //Length: 598
	}

	public ArrayList ListMembers
	{
		 get { } //Length: 11
	}

	public XmlTypeMapMemberNamespaces NamespaceDeclarations
	{
		 get { } //Length: 11
	}

	public XmlTypeMapMember ReturnMember
	{
		 get { } //Length: 11
	}

	public XmlQualifiedName SimpleContentBaseType
	{
		 get { } //Length: 448
	}

	public XmlTypeMapMember XmlTextCollector
	{
		 get { } //Length: 11
	}

	public ClassMap() { }

	public void AddMember(XmlTypeMapMember member) { }

	private string BuildKey(string name, string ns, int explicitOrder) { }

	public ArrayList get_AllMembers() { }

	public ICollection get_AttributeMembers() { }

	public XmlTypeMapMemberAnyAttribute get_DefaultAnyAttributeMember() { }

	public XmlTypeMapMemberAnyElement get_DefaultAnyElementMember() { }

	public ICollection get_ElementMembers() { }

	public ArrayList get_FlatLists() { }

	public bool get_HasSimpleContent() { }

	public bool get_IsOrderDependentMap() { }

	public ArrayList get_ListMembers() { }

	public XmlTypeMapMemberNamespaces get_NamespaceDeclarations() { }

	public XmlTypeMapMember get_ReturnMember() { }

	public XmlQualifiedName get_SimpleContentBaseType() { }

	public XmlTypeMapMember get_XmlTextCollector() { }

	public XmlTypeMapMemberAttribute GetAttribute(string name, string ns) { }

	public XmlTypeMapElementInfo GetElement(string name, string ns) { }

	public XmlTypeMapElementInfo GetElement(string name, string ns, int minimalOrder) { }

	private void RegisterFlatList(XmlTypeMapMemberExpandable member) { }

	public void SetCanBeSimpleType(bool can) { }

}

