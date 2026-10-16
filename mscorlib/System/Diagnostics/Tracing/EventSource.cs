namespace System.Diagnostics.Tracing;

public class EventSource : IDisposable
{
	private struct EventData
	{
		[CompilerGenerated]
		private IntPtr <DataPointer>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		private int <Size>k__BackingField; //Field offset: 0x4
		[CompilerGenerated]
		private int <Reserved>k__BackingField; //Field offset: 0x8

		public IntPtr DataPointer
		{
			[CompilerGenerated]
			 set { } //Length: 13
		}

		internal int Reserved
		{
			[CompilerGenerated]
			internal set { } //Length: 14
		}

		public int Size
		{
			[CompilerGenerated]
			 set { } //Length: 14
		}

		[CompilerGenerated]
		public void set_DataPointer(IntPtr value) { }

		[CompilerGenerated]
		internal void set_Reserved(int value) { }

		[CompilerGenerated]
		public void set_Size(int value) { }

	}

	[CompilerGenerated]
	private string <Name>k__BackingField; //Field offset: 0x8

	private string Name
	{
		[CompilerGenerated]
		private set { } //Length: 27
	}

	protected EventSource() { }

	public EventSource(string eventSourceName) { }

	internal EventSource(Guid eventSourceGuid, string eventSourceName) { }

	public override void Dispose() { }

	protected override void Dispose(bool disposing) { }

	protected virtual void Finalize() { }

	public bool IsEnabled() { }

	public bool IsEnabled(EventLevel level, EventKeywords keywords) { }

	[CompilerGenerated]
	private void set_Name(string value) { }

	protected void WriteEvent(int eventId, string arg1, string arg2, string arg3) { }

	protected void WriteEvent(int eventId, int arg1) { }

	protected void WriteEvent(int eventId, string arg1) { }

	protected void WriteEvent(int eventId, int arg1, int arg2) { }

	protected void WriteEvent(int eventId, int arg1, int arg2, int arg3) { }

	protected void WriteEvent(int eventId, long arg1) { }

	protected void WriteEvent(int eventId, long arg1, string arg2) { }

	protected void WriteEvent(int eventId, Object[] args) { }

	[CLSCompliant(False)]
	protected void WriteEventCore(int eventId, int eventDataCount, EventData* data) { }

}

