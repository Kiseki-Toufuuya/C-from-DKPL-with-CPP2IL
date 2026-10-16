namespace System.Xml.Serialization;

internal class EnumMap : ObjectMap
{
	internal class EnumMapMember
	{
		private readonly string _xmlName; //Field offset: 0x8
		private readonly string _enumName; //Field offset: 0xC
		private readonly long _value; //Field offset: 0x10

		public string EnumName
		{
			 get { } //Length: 11
		}

		public long Value
		{
			 get { } //Length: 14
		}

		public string XmlName
		{
			 get { } //Length: 11
		}

		public EnumMapMember(string xmlName, string enumName, long value) { }

		public string get_EnumName() { }

		public long get_Value() { }

		public string get_XmlName() { }

	}

	private readonly EnumMapMember[] _members; //Field offset: 0x8
	private readonly bool _isFlags; //Field offset: 0xC
	private readonly String[] _enumNames; //Field offset: 0x10
	private readonly String[] _xmlNames; //Field offset: 0x14
	private readonly Int64[] _values; //Field offset: 0x18

	public String[] EnumNames
	{
		 get { } //Length: 11
	}

	public bool IsFlags
	{
		 get { } //Length: 11
	}

	public Int64[] Values
	{
		 get { } //Length: 11
	}

	public String[] XmlNames
	{
		 get { } //Length: 11
	}

	public EnumMap(EnumMapMember[] members, bool isFlags) { }

	public String[] get_EnumNames() { }

	public bool get_IsFlags() { }

	public Int64[] get_Values() { }

	public String[] get_XmlNames() { }

	public string GetEnumName(string typeName, string xmlName) { }

	public string GetXmlName(string typeName, object enumValue) { }

}

