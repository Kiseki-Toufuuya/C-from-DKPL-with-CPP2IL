namespace Cysharp.Threading.Tasks.Internal;

[IsReadOnly]
internal struct ValueStopwatch
{
	private static readonly double TimestampToTicks; //Field offset: 0x0
	private readonly long startTimestamp; //Field offset: 0x0

	public long ElapsedTicks
	{
		 get { } //Length: 229
	}

	public bool IsInvalid
	{
		 get { } //Length: 21
	}

	private static ValueStopwatch() { }

	private ValueStopwatch(long startTimestamp) { }

	public long get_ElapsedTicks() { }

	public bool get_IsInvalid() { }

	public static ValueStopwatch StartNew() { }

}

