namespace System.Runtime.Diagnostics;

internal class EventTraceActivity
{
	public Guid ActivityId; //Field offset: 0x8

	public EventTraceActivity(Guid guid, bool setOnThread = false) { }

	public static EventTraceActivity GetFromThreadOrCreate(bool clearIdOnThread = false) { }

	private void SetActivityIdOnThread() { }

}

