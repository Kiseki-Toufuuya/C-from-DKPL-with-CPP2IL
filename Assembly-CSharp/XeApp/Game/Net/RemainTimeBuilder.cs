namespace XeApp.Game.Net;

public class RemainTimeBuilder
{
	private const int MAX_DAYS = 99; //Field offset: 0x0
	private const int TH_DAY = 86400; //Field offset: 0x0
	private const int TH_HOUR = 3600; //Field offset: 0x0
	private const int TH_MIN = 60; //Field offset: 0x0
	private long m_prevRestTime; //Field offset: 0x8
	private string m_remainString; //Field offset: 0x10
	[CompilerGenerated]
	private long <TargetUnixTime>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private long <CurrentUnixTime>k__BackingField; //Field offset: 0x20

	public long CurrentUnixTime
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public long TargetUnixTime
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public RemainTimeBuilder() { }

	public static string BuildString(long restTime) { }

	public static string BuildString(long expired, long current) { }

	[CompilerGenerated]
	public long get_CurrentUnixTime() { }

	[CompilerGenerated]
	public long get_TargetUnixTime() { }

	public string GetString() { }

	[CompilerGenerated]
	public void set_CurrentUnixTime(long value) { }

	[CompilerGenerated]
	public void set_TargetUnixTime(long value) { }

}

