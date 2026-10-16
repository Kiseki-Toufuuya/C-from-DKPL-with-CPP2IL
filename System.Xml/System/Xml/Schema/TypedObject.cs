namespace System.Xml.Schema;

internal class TypedObject
{
	private class DecimalStruct
	{
		private bool isDecimal; //Field offset: 0x8
		private Decimal[] dvalue; //Field offset: 0xC

		public Decimal[] Dvalue
		{
			 get { } //Length: 11
		}

		public bool IsDecimal
		{
			 get { } //Length: 11
			 set { } //Length: 14
		}

		public DecimalStruct() { }

		public DecimalStruct(int dim) { }

		public Decimal[] get_Dvalue() { }

		public bool get_IsDecimal() { }

		public void set_IsDecimal(bool value) { }

	}

	private DecimalStruct dstruct; //Field offset: 0x8
	private object ovalue; //Field offset: 0xC
	private string svalue; //Field offset: 0x10
	private XmlSchemaDatatype xsdtype; //Field offset: 0x14
	private int dim; //Field offset: 0x18
	private bool isList; //Field offset: 0x1C

	public int Dim
	{
		 get { } //Length: 11
	}

	public Decimal[] Dvalue
	{
		 get { } //Length: 23
	}

	public bool IsDecimal
	{
		 get { } //Length: 23
	}

	public bool IsList
	{
		 get { } //Length: 11
	}

	public XmlSchemaDatatype Type
	{
		 get { } //Length: 11
	}

	public object Value
	{
		 get { } //Length: 11
	}

	public TypedObject(object obj, string svalue, XmlSchemaDatatype xsdtype) { }

	public bool Equals(TypedObject other) { }

	public int get_Dim() { }

	public Decimal[] get_Dvalue() { }

	public bool get_IsDecimal() { }

	public bool get_IsList() { }

	public XmlSchemaDatatype get_Type() { }

	public object get_Value() { }

	private bool ListDValueEquals(TypedObject other) { }

	public void SetDecimal() { }

	public virtual string ToString() { }

}

