namespace System.Xml.Schema;

internal class Datatype_union : Datatype_anySimpleType
{
	private static readonly Type atomicValueType; //Field offset: 0x0
	private static readonly Type listValueType; //Field offset: 0x4
	private XmlSchemaSimpleType[] types; //Field offset: 0x1C

	internal XmlSchemaSimpleType[] BaseMemberTypes
	{
		internal get { } //Length: 11
	}

	internal virtual FacetsChecker FacetsChecker
	{
		internal get { } //Length: 61
	}

	internal virtual Type ListValueType
	{
		internal get { } //Length: 61
	}

	public virtual XmlTypeCode TypeCode
	{
		 get { } //Length: 6
	}

	internal virtual RestrictionFlags ValidRestrictionFlags
	{
		internal get { } //Length: 6
	}

	public virtual Type ValueType
	{
		 get { } //Length: 60
	}

	private static Datatype_union() { }

	internal Datatype_union(XmlSchemaSimpleType[] types) { }

	internal virtual int Compare(object value1, object value2) { }

	internal virtual XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	internal XmlSchemaSimpleType[] get_BaseMemberTypes() { }

	internal virtual FacetsChecker get_FacetsChecker() { }

	internal virtual Type get_ListValueType() { }

	public virtual XmlTypeCode get_TypeCode() { }

	internal virtual RestrictionFlags get_ValidRestrictionFlags() { }

	public virtual Type get_ValueType() { }

	internal bool HasAtomicMembers() { }

	internal bool IsUnionBaseOf(DatatypeImplementation derivedType) { }

	internal virtual Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	internal virtual Exception TryParseValue(object value, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

}

