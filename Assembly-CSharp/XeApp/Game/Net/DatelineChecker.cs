namespace XeApp.Game.Net;

public class DatelineChecker
{
	private const int secOfDay = 86400; //Field offset: 0x0
	public long Origin; //Field offset: 0x8
	[CompilerGenerated]
	private bool <Enable>k__BackingField; //Field offset: 0x10
	public long Dateline; //Field offset: 0x18
	public long BaseTime; //Field offset: 0x20

	public bool Enable
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public DatelineChecker() { }

	[CompilerGenerated]
	public bool get_Enable() { }

	public long GetAppointDateline(long current) { }

	public bool IsAppointCrossDateline(long current, long appiointDateline) { }

	public bool IsCrossDateline(long current) { }

	[CompilerGenerated]
	public void set_Enable(bool value) { }

	public void SetDateline(long current) { }

}

