namespace D4L.Moment;

[IsReadOnly]
public struct RelativeTimeAxis
{
	public readonly UnixTime BaseTimestamp; //Field offset: 0x0
	public readonly RelativeTime BaseRelativeTime; //Field offset: 0x8
	public readonly double Drift; //Field offset: 0x10
	public readonly double EasedDriftTarget; //Field offset: 0x18
	public readonly double EasedDriftScale; //Field offset: 0x20

	public RelativeTimeAxis EasedTimeAxis
	{
		 get { } //Length: 72
	}

	public RelativeTimeAxis(UnixTime baseTimestamp, RelativeTime baseRelativeTime, double drift, double easedDriftTarget, double easedDriftScale) { }

	public RelativeTimeAxis(UnixTime baseTimestamp, RelativeTime baseRelativeTime, double drift) { }

	private double EasedDrift(RelativeTime now) { }

	public RelativeTimeAxis get_EasedTimeAxis() { }

	public RelativeTimeAxis MoveTo(RelativeTime now, RelativeTimeAxis next, double easedDriftScale) { }

	public UnixTime Resolve(RelativeTime now) { }

	public double ResolveAsDouble(RelativeTime now) { }

	public double TimeGap(RelativeTime now) { }

	public virtual string ToString() { }

}

