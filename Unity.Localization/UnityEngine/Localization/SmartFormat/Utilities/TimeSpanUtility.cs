namespace UnityEngine.Localization.SmartFormat.Utilities;

[Extension]
public static class TimeSpanUtility
{
	internal const TimeSpanFormatOptions AbbreviateAll = 3; //Field offset: 0x0
	internal const TimeSpanFormatOptions LessThanAll = 12; //Field offset: 0x0
	internal const TimeSpanFormatOptions RangeAll = 16128; //Field offset: 0x0
	internal const TimeSpanFormatOptions TruncateAll = 240; //Field offset: 0x0
	[CompilerGenerated]
	private static TimeSpanFormatOptions <DefaultFormatOptions>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private static readonly TimeSpanFormatOptions <AbsoluteDefaults>k__BackingField; //Field offset: 0x4

	public static TimeSpanFormatOptions AbsoluteDefaults
	{
		[CompilerGenerated]
		 get { } //Length: 61
	}

	public static TimeSpanFormatOptions DefaultFormatOptions
	{
		[CompilerGenerated]
		 get { } //Length: 60
		[CompilerGenerated]
		 set { } //Length: 78
	}

	private static TimeSpanUtility() { }

	[CompilerGenerated]
	public static TimeSpanFormatOptions get_AbsoluteDefaults() { }

	[CompilerGenerated]
	public static TimeSpanFormatOptions get_DefaultFormatOptions() { }

	[Extension]
	public static TimeSpan Round(TimeSpan fromTime, long intervalTicks) { }

	[CompilerGenerated]
	public static void set_DefaultFormatOptions(TimeSpanFormatOptions value) { }

	[Extension]
	public static string ToTimeString(TimeSpan FromTime, TimeSpanFormatOptions options, TimeTextInfo timeTextInfo) { }

}

