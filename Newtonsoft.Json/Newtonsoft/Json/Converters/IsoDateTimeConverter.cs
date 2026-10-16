namespace Newtonsoft.Json.Converters;

[Nullable(0)]
[NullableContext(1)]
public class IsoDateTimeConverter : DateTimeConverterBase
{
	private const string DefaultDateTimeFormat = "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK"; //Field offset: 0x0
	private DateTimeStyles _dateTimeStyles; //Field offset: 0x8
	[Nullable(2)]
	private string _dateTimeFormat; //Field offset: 0xC
	[Nullable(2)]
	private CultureInfo _culture; //Field offset: 0x10

	public CultureInfo Culture
	{
		 get { } //Length: 74
		 set { } //Length: 27
	}

	[Nullable(2)]
	public string DateTimeFormat
	{
		[NullableContext(2)]
		 get { } //Length: 25
		[NullableContext(2)]
		 set { } //Length: 54
	}

	public DateTimeStyles DateTimeStyles
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public IsoDateTimeConverter() { }

	public CultureInfo get_Culture() { }

	[NullableContext(2)]
	public string get_DateTimeFormat() { }

	public DateTimeStyles get_DateTimeStyles() { }

	public virtual object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	public void set_Culture(CultureInfo value) { }

	[NullableContext(2)]
	public void set_DateTimeFormat(string value) { }

	public void set_DateTimeStyles(DateTimeStyles value) { }

	public virtual void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

}

