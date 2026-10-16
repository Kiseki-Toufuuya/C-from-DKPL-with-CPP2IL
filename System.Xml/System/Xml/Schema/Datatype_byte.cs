namespace System.Xml.Schema;

internal class Datatype_byte : Datatype_short
{
	private static readonly Type atomicValueType; //Field offset: 0x0
	private static readonly Type listValueType; //Field offset: 0x4
	private static readonly FacetsChecker numeric10FacetsChecker; //Field offset: 0x8

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

	public virtual Type ValueType
	{
		 get { } //Length: 60
	}

	private static Datatype_byte() { }

	public Datatype_byte() { }

	internal virtual int Compare(object value1, object value2) { }

	internal virtual FacetsChecker get_FacetsChecker() { }

	internal virtual Type get_ListValueType() { }

	public virtual XmlTypeCode get_TypeCode() { }

	public virtual Type get_ValueType() { }

	internal virtual Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

}

