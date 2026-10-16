namespace System.Globalization;

public class DaylightTime
{
	private readonly DateTime _start; //Field offset: 0x8
	private readonly DateTime _end; //Field offset: 0x10
	private readonly TimeSpan _delta; //Field offset: 0x18

	public TimeSpan Delta
	{
		 get { } //Length: 14
	}

	public DateTime End
	{
		 get { } //Length: 14
	}

	public DateTime Start
	{
		 get { } //Length: 14
	}

	public DaylightTime(DateTime start, DateTime end, TimeSpan delta) { }

	public TimeSpan get_Delta() { }

	public DateTime get_End() { }

	public DateTime get_Start() { }

}

