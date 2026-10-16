namespace D4L.Moment;

public static class ServerTime
{
	public static double DriftScale; //Field offset: 0x0
	[CompilerGenerated]
	private static Nullable<RelativeTimeAxis> <CurrentAxis>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private static Nullable<RelativeTimeAxis> <OverwriteAxis>k__BackingField; //Field offset: 0x38

	public private static Nullable<RelativeTimeAxis> CurrentAxis
	{
		[CompilerGenerated]
		 get { } //Length: 90
		[CompilerGenerated]
		private set { } //Length: 86
	}

	public static UnixTime Now
	{
		 get { } //Length: 516
	}

	public static Nullable<RelativeTimeAxis> OverwriteAxis
	{
		[CompilerGenerated]
		 get { } //Length: 90
	}

	private static ServerTime() { }

	public static void Adjust() { }

	private static double CalculateRtt(RelativeTime requestedUptime, RelativeTime responseUptime, UnixTime requestTime, UnixTime responseTime) { }

	public static RelativeTimeAxis CreateServerTimeAxis(RelativeTime responseUptime, UnixTime responseTime, double rtt) { }

	[CompilerGenerated]
	public static Nullable<RelativeTimeAxis> get_CurrentAxis() { }

	public static UnixTime get_Now() { }

	[CompilerGenerated]
	public static Nullable<RelativeTimeAxis> get_OverwriteAxis() { }

	public static bool Requested(RelativeTime requestedUptime, RelativeTime responseUptime, UnixTime requestTime, UnixTime responseTime) { }

	[CompilerGenerated]
	private static void set_CurrentAxis(Nullable<RelativeTimeAxis> value) { }

}

