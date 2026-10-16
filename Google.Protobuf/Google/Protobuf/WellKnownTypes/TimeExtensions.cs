namespace Google.Protobuf.WellKnownTypes;

[Extension]
public static class TimeExtensions
{

	[Extension]
	public static Duration ToDuration(TimeSpan timeSpan) { }

	[Extension]
	public static Timestamp ToTimestamp(DateTimeOffset dateTimeOffset) { }

	[Extension]
	public static Timestamp ToTimestamp(DateTime dateTime) { }

}

