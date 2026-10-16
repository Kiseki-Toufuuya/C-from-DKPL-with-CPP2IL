namespace System.Xml.Serialization;

internal class TypeData
{
	private static String[] keywords; //Field offset: 0x0
	private Type type; //Field offset: 0x8
	private string elementName; //Field offset: 0xC
	private SchemaTypes sType; //Field offset: 0x10
	private Type listItemType; //Field offset: 0x14
	private string typeName; //Field offset: 0x18
	private string fullTypeName; //Field offset: 0x1C
	private TypeData listItemTypeData; //Field offset: 0x20
	private TypeData mappedType; //Field offset: 0x24
	private XmlSchemaPatternFacet facet; //Field offset: 0x28
	private MethodInfo typeConvertor; //Field offset: 0x2C
	private bool hasPublicConstructor; //Field offset: 0x30
	private bool nullableOverride; //Field offset: 0x31

	public string FullTypeName
	{
		 get { } //Length: 11
	}

	public bool HasPublicConstructor
	{
		 get { } //Length: 11
	}

	public bool IsComplexType
	{
		 get { } //Length: 49
	}

	public bool IsListType
	{
		 get { } //Length: 15
	}

	public bool IsNullable
	{
		 get { } //Length: 299
		 set { } //Length: 14
	}

	public bool IsValueType
	{
		 get { } //Length: 101
	}

	public bool IsXsdType
	{
		 get { } //Length: 15
	}

	public Type ListItemType
	{
		 get { } //Length: 1914
	}

	public TypeData ListItemTypeData
	{
		 get { } //Length: 153
	}

	public SchemaTypes SchemaType
	{
		 get { } //Length: 11
	}

	public Type Type
	{
		 get { } //Length: 11
	}

	public string TypeName
	{
		 get { } //Length: 11
	}

	public string XmlType
	{
		 get { } //Length: 11
	}

	private static TypeData() { }

	public TypeData(Type type, string elementName, bool isPrimitive) { }

	public TypeData(Type type, string elementName, bool isPrimitive, TypeData mappedType, XmlSchemaPatternFacet facet) { }

	internal void ConvertForAssignment(ref object value) { }

	private static InvalidOperationException CreateMissingAddMethodException(Type type, string inheritFrom, Type argumentType) { }

	public string get_FullTypeName() { }

	public bool get_HasPublicConstructor() { }

	public bool get_IsComplexType() { }

	public bool get_IsListType() { }

	public bool get_IsNullable() { }

	public bool get_IsValueType() { }

	public bool get_IsXsdType() { }

	public Type get_ListItemType() { }

	public TypeData get_ListItemTypeData() { }

	public SchemaTypes get_SchemaType() { }

	public Type get_Type() { }

	public string get_TypeName() { }

	public string get_XmlType() { }

	internal static Type GetGenericListItemType(Type type) { }

	public static PropertyInfo GetIndexerProperty(Type collectionType) { }

	private void LookupTypeConvertor() { }

	public void set_IsNullable(bool value) { }

}

