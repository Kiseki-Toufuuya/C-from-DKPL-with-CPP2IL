namespace System.Runtime.Serialization;

public class DateTimeFormat
{
	private string formatString; //Field offset: 0x8
	private IFormatProvider formatProvider; //Field offset: 0xC
	private DateTimeStyles dateTimeStyles; //Field offset: 0x10

	public DateTimeStyles DateTimeStyles
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public IFormatProvider FormatProvider
	{
		 get { } //Length: 11
	}

	public string FormatString
	{
		 get { } //Length: 11
	}

	public DateTimeFormat(string formatString) { }

	public DateTimeFormat(string formatString, IFormatProvider formatProvider) { }

	public DateTimeStyles get_DateTimeStyles() { }

	public IFormatProvider get_FormatProvider() { }

	public string get_FormatString() { }

	public void set_DateTimeStyles(DateTimeStyles value) { }

}

