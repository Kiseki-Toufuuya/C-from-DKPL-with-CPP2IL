namespace System.Xml.Schema;

internal abstract class DatatypeImplementation : XmlSchemaDatatype
{
	private class SchemaDatatypeMap : IComparable
	{
		private string name; //Field offset: 0x8
		private DatatypeImplementation type; //Field offset: 0xC
		private int parentIndex; //Field offset: 0x10

		public string Name
		{
			 get { } //Length: 11
		}

		public int ParentIndex
		{
			 get { } //Length: 11
		}

		internal SchemaDatatypeMap(string name, DatatypeImplementation type) { }

		internal SchemaDatatypeMap(string name, DatatypeImplementation type, int parentIndex) { }

		public override int CompareTo(object obj) { }

		public string get_Name() { }

		public int get_ParentIndex() { }

		public static DatatypeImplementation op_Explicit(SchemaDatatypeMap sdm) { }

	}

	private static Hashtable builtinTypes; //Field offset: 0x0
	private static XmlSchemaSimpleType[] enumToTypeCode; //Field offset: 0x4
	private static XmlSchemaSimpleType anySimpleType; //Field offset: 0x8
	private static XmlSchemaSimpleType anyAtomicType; //Field offset: 0xC
	private static XmlSchemaSimpleType untypedAtomicType; //Field offset: 0x10
	private static XmlSchemaSimpleType yearMonthDurationType; //Field offset: 0x14
	private static XmlSchemaSimpleType dayTimeDurationType; //Field offset: 0x18
	private static XmlSchemaSimpleType normalizedStringTypeV1Compat; //Field offset: 0x1C
	private static XmlSchemaSimpleType tokenTypeV1Compat; //Field offset: 0x20
	internal static XmlQualifiedName QnAnySimpleType; //Field offset: 0x24
	internal static XmlQualifiedName QnAnyType; //Field offset: 0x28
	internal static FacetsChecker stringFacetsChecker; //Field offset: 0x2C
	internal static FacetsChecker miscFacetsChecker; //Field offset: 0x30
	internal static FacetsChecker numeric2FacetsChecker; //Field offset: 0x34
	internal static FacetsChecker binaryFacetsChecker; //Field offset: 0x38
	internal static FacetsChecker dateTimeFacetsChecker; //Field offset: 0x3C
	internal static FacetsChecker durationFacetsChecker; //Field offset: 0x40
	internal static FacetsChecker listFacetsChecker; //Field offset: 0x44
	internal static FacetsChecker qnameFacetsChecker; //Field offset: 0x48
	internal static FacetsChecker unionFacetsChecker; //Field offset: 0x4C
	private static readonly DatatypeImplementation c_anySimpleType; //Field offset: 0x50
	private static readonly DatatypeImplementation c_anyURI; //Field offset: 0x54
	private static readonly DatatypeImplementation c_base64Binary; //Field offset: 0x58
	private static readonly DatatypeImplementation c_boolean; //Field offset: 0x5C
	private static readonly DatatypeImplementation c_byte; //Field offset: 0x60
	private static readonly DatatypeImplementation c_char; //Field offset: 0x64
	private static readonly DatatypeImplementation c_date; //Field offset: 0x68
	private static readonly DatatypeImplementation c_dateTime; //Field offset: 0x6C
	private static readonly DatatypeImplementation c_dateTimeNoTz; //Field offset: 0x70
	private static readonly DatatypeImplementation c_dateTimeTz; //Field offset: 0x74
	private static readonly DatatypeImplementation c_day; //Field offset: 0x78
	private static readonly DatatypeImplementation c_decimal; //Field offset: 0x7C
	private static readonly DatatypeImplementation c_double; //Field offset: 0x80
	private static readonly DatatypeImplementation c_doubleXdr; //Field offset: 0x84
	private static readonly DatatypeImplementation c_duration; //Field offset: 0x88
	private static readonly DatatypeImplementation c_ENTITY; //Field offset: 0x8C
	private static readonly DatatypeImplementation c_ENTITIES; //Field offset: 0x90
	private static readonly DatatypeImplementation c_ENUMERATION; //Field offset: 0x94
	private static readonly DatatypeImplementation c_fixed; //Field offset: 0x98
	private static readonly DatatypeImplementation c_float; //Field offset: 0x9C
	private static readonly DatatypeImplementation c_floatXdr; //Field offset: 0xA0
	private static readonly DatatypeImplementation c_hexBinary; //Field offset: 0xA4
	private static readonly DatatypeImplementation c_ID; //Field offset: 0xA8
	private static readonly DatatypeImplementation c_IDREF; //Field offset: 0xAC
	private static readonly DatatypeImplementation c_IDREFS; //Field offset: 0xB0
	private static readonly DatatypeImplementation c_int; //Field offset: 0xB4
	private static readonly DatatypeImplementation c_integer; //Field offset: 0xB8
	private static readonly DatatypeImplementation c_language; //Field offset: 0xBC
	private static readonly DatatypeImplementation c_long; //Field offset: 0xC0
	private static readonly DatatypeImplementation c_month; //Field offset: 0xC4
	private static readonly DatatypeImplementation c_monthDay; //Field offset: 0xC8
	private static readonly DatatypeImplementation c_Name; //Field offset: 0xCC
	private static readonly DatatypeImplementation c_NCName; //Field offset: 0xD0
	private static readonly DatatypeImplementation c_negativeInteger; //Field offset: 0xD4
	private static readonly DatatypeImplementation c_NMTOKEN; //Field offset: 0xD8
	private static readonly DatatypeImplementation c_NMTOKENS; //Field offset: 0xDC
	private static readonly DatatypeImplementation c_nonNegativeInteger; //Field offset: 0xE0
	private static readonly DatatypeImplementation c_nonPositiveInteger; //Field offset: 0xE4
	private static readonly DatatypeImplementation c_normalizedString; //Field offset: 0xE8
	private static readonly DatatypeImplementation c_NOTATION; //Field offset: 0xEC
	private static readonly DatatypeImplementation c_positiveInteger; //Field offset: 0xF0
	private static readonly DatatypeImplementation c_QName; //Field offset: 0xF4
	private static readonly DatatypeImplementation c_QNameXdr; //Field offset: 0xF8
	private static readonly DatatypeImplementation c_short; //Field offset: 0xFC
	private static readonly DatatypeImplementation c_string; //Field offset: 0x100
	private static readonly DatatypeImplementation c_time; //Field offset: 0x104
	private static readonly DatatypeImplementation c_timeNoTz; //Field offset: 0x108
	private static readonly DatatypeImplementation c_timeTz; //Field offset: 0x10C
	private static readonly DatatypeImplementation c_token; //Field offset: 0x110
	private static readonly DatatypeImplementation c_unsignedByte; //Field offset: 0x114
	private static readonly DatatypeImplementation c_unsignedInt; //Field offset: 0x118
	private static readonly DatatypeImplementation c_unsignedLong; //Field offset: 0x11C
	private static readonly DatatypeImplementation c_unsignedShort; //Field offset: 0x120
	private static readonly DatatypeImplementation c_uuid; //Field offset: 0x124
	private static readonly DatatypeImplementation c_year; //Field offset: 0x128
	private static readonly DatatypeImplementation c_yearMonth; //Field offset: 0x12C
	internal static readonly DatatypeImplementation c_normalizedStringV1Compat; //Field offset: 0x130
	internal static readonly DatatypeImplementation c_tokenV1Compat; //Field offset: 0x134
	private static readonly DatatypeImplementation c_anyAtomicType; //Field offset: 0x138
	private static readonly DatatypeImplementation c_dayTimeDuration; //Field offset: 0x13C
	private static readonly DatatypeImplementation c_untypedAtomicType; //Field offset: 0x140
	private static readonly DatatypeImplementation c_yearMonthDuration; //Field offset: 0x144
	private static readonly DatatypeImplementation[] c_tokenizedTypes; //Field offset: 0x148
	private static readonly DatatypeImplementation[] c_tokenizedTypesXsd; //Field offset: 0x14C
	private static readonly SchemaDatatypeMap[] c_XdrTypes; //Field offset: 0x150
	private static readonly SchemaDatatypeMap[] c_XsdTypes; //Field offset: 0x154
	private XmlSchemaDatatypeVariety variety; //Field offset: 0x8
	private RestrictionFacets restriction; //Field offset: 0xC
	private DatatypeImplementation baseType; //Field offset: 0x10
	private XmlValueConverter valueConverter; //Field offset: 0x14
	private XmlSchemaType parentSchemaType; //Field offset: 0x18

	internal static XmlSchemaSimpleType AnySimpleType
	{
		internal get { } //Length: 61
	}

	protected DatatypeImplementation Base
	{
		 get { } //Length: 11
	}

	internal virtual XmlSchemaWhiteSpace BuiltInWhitespaceFacet
	{
		internal get { } //Length: 3
	}

	internal virtual FacetsChecker FacetsChecker
	{
		internal get { } //Length: 61
	}

	internal virtual bool HasLexicalFacets
	{
		internal get { } //Length: 36
	}

	internal virtual bool HasValueFacets
	{
		internal get { } //Length: 36
	}

	internal abstract Type ListValueType
	{
		internal get { } //Length: 0
	}

	internal virtual RestrictionFacets Restriction
	{
		internal get { } //Length: 11
	}

	public virtual XmlTokenizedType TokenizedType
	{
		 get { } //Length: 6
	}

	public virtual XmlTypeCode TypeCode
	{
		 get { } //Length: 3
	}

	internal static XmlSchemaSimpleType UntypedAtomicType
	{
		internal get { } //Length: 61
	}

	internal abstract RestrictionFlags ValidRestrictionFlags
	{
		internal get { } //Length: 0
	}

	internal virtual XmlValueConverter ValueConverter
	{
		internal get { } //Length: 55
	}

	public virtual Type ValueType
	{
		 get { } //Length: 43
	}

	public virtual XmlSchemaDatatypeVariety Variety
	{
		 get { } //Length: 11
	}

	private static DatatypeImplementation() { }

	protected DatatypeImplementation() { }

	protected int Compare(Byte[] value1, Byte[] value2) { }

	internal static void CreateBuiltinTypes() { }

	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	internal XmlSchemaDatatype DeriveByList(int minSize, XmlSchemaType schemaType) { }

	internal virtual XmlSchemaDatatype DeriveByList(XmlSchemaType schemaType) { }

	internal virtual XmlSchemaDatatype DeriveByRestriction(XmlSchemaObjectCollection facets, XmlNameTable nameTable, XmlSchemaType schemaType) { }

	internal static DatatypeImplementation DeriveByUnion(XmlSchemaSimpleType[] types, XmlSchemaType schemaType) { }

	internal static void FinishBuiltinType(XmlSchemaSimpleType derivedType, XmlSchemaSimpleType baseType) { }

	private static DatatypeImplementation FromTypeName(string name) { }

	internal static DatatypeImplementation FromXdrName(string name) { }

	internal static DatatypeImplementation FromXmlTokenizedType(XmlTokenizedType token) { }

	internal static DatatypeImplementation FromXmlTokenizedTypeXsd(XmlTokenizedType token) { }

	internal static XmlSchemaSimpleType get_AnySimpleType() { }

	protected DatatypeImplementation get_Base() { }

	internal virtual XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	internal virtual FacetsChecker get_FacetsChecker() { }

	internal virtual bool get_HasLexicalFacets() { }

	internal virtual bool get_HasValueFacets() { }

	internal abstract Type get_ListValueType() { }

	internal virtual RestrictionFacets get_Restriction() { }

	public virtual XmlTokenizedType get_TokenizedType() { }

	public virtual XmlTypeCode get_TypeCode() { }

	internal static XmlSchemaSimpleType get_UntypedAtomicType() { }

	internal abstract RestrictionFlags get_ValidRestrictionFlags() { }

	internal virtual XmlValueConverter get_ValueConverter() { }

	public virtual Type get_ValueType() { }

	public virtual XmlSchemaDatatypeVariety get_Variety() { }

	internal static XmlSchemaSimpleType[] GetBuiltInTypes() { }

	internal static XmlSchemaSimpleType GetNormalizedStringTypeV1Compat() { }

	internal static XmlTypeCode GetPrimitiveTypeCode(XmlTypeCode typeCode) { }

	internal static XmlSchemaSimpleType GetSimpleTypeFromTypeCode(XmlTypeCode typeCode) { }

	internal static XmlSchemaSimpleType GetSimpleTypeFromXsdType(XmlQualifiedName qname) { }

	internal static XmlSchemaSimpleType GetTokenTypeV1Compat() { }

	internal string GetTypeName() { }

	internal virtual bool IsComparable(XmlSchemaDatatype dtype) { }

	public virtual bool IsDerivedFrom(XmlSchemaDatatype datatype) { }

	internal virtual bool IsEqual(object o1, object o2) { }

	public virtual object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	internal virtual object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, bool createAtomicValue) { }

	internal static XmlSchemaSimpleType StartBuiltinType(XmlQualifiedName qname, XmlSchemaDatatype dataType) { }

	internal virtual Exception TryParseValue(object value, XmlNameTable nameTable, IXmlNamespaceResolver namespaceResolver, out object typedValue) { }

	internal virtual void VerifySchemaValid(XmlSchemaObjectTable notations, XmlSchemaObject caller) { }

}

