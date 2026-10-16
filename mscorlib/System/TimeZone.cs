namespace System;

[Obsolete("System.TimeZone has been deprecated.  Please investigate the use of System.TimeZoneInfo instead.")]
public abstract class TimeZone
{
	private static TimeZone currentTimeZone; //Field offset: 0x0
	private static object s_InternalSyncObject; //Field offset: 0x4

	public static TimeZone CurrentTimeZone
	{
		 get { } //Length: 464
	}

	private static object InternalSyncObject
	{
		private get { } //Length: 112
	}

	protected TimeZone() { }

	internal static TimeSpan CalculateUtcOffset(DateTime time, DaylightTime daylightTimes) { }

	public static TimeZone get_CurrentTimeZone() { }

	private static object get_InternalSyncObject() { }

	public abstract DaylightTime GetDaylightChanges(int year) { }

	public abstract TimeSpan GetUtcOffset(DateTime time) { }

	public override DateTime ToLocalTime(DateTime time) { }

}

