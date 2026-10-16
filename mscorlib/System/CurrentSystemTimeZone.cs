namespace System;

[Obsolete("System.CurrentSystemTimeZone has been deprecated.  Please investigate the use of System.TimeZoneInfo.Local instead.")]
internal class CurrentSystemTimeZone : TimeZone
{
	private long m_ticksOffset; //Field offset: 0x8
	private string m_standardName; //Field offset: 0x10
	private string m_daylightName; //Field offset: 0x14
	private readonly Hashtable m_CachedDaylightChanges; //Field offset: 0x18

	internal CurrentSystemTimeZone() { }

	private static DaylightTime CreateDaylightChanges(int year) { }

	private DaylightTime GetCachedDaylightChanges(int year) { }

	public virtual DaylightTime GetDaylightChanges(int year) { }

	public virtual TimeSpan GetUtcOffset(DateTime time) { }

	internal long GetUtcOffsetFromUniversalTime(DateTime time, ref bool isAmbiguousLocalDst) { }

	public virtual DateTime ToLocalTime(DateTime time) { }

}

