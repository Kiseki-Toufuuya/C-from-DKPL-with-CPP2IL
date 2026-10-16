namespace System.Runtime.Serialization;

[DataContract(Name = "DateTimeOffset", Namespace = "http://schemas.datacontract.org/2004/07/System")]
internal struct DateTimeOffsetAdapter
{
	private DateTime utcDateTime; //Field offset: 0x0
	private short offsetMinutes; //Field offset: 0x8

	[DataMember(Name = "OffsetMinutes", IsRequired = True)]
	public short OffsetMinutes
	{
		 get { } //Length: 12
		 set { } //Length: 16
	}

	[DataMember(Name = "DateTime", IsRequired = True)]
	public DateTime UtcDateTime
	{
		 get { } //Length: 13
		 set { } //Length: 19
	}

	public DateTimeOffsetAdapter(DateTime dateTime, short offsetMinutes) { }

	public short get_OffsetMinutes() { }

	public DateTime get_UtcDateTime() { }

	public static DateTimeOffset GetDateTimeOffset(DateTimeOffsetAdapter value) { }

	public static DateTimeOffsetAdapter GetDateTimeOffsetAdapter(DateTimeOffset value) { }

	public void set_OffsetMinutes(short value) { }

	public void set_UtcDateTime(DateTime value) { }

	public string ToString(IFormatProvider provider) { }

}

