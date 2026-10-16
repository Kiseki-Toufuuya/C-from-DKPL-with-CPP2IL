namespace XeApp.Game;

public class EventProfiler
{
	internal class Record
	{
		public long BaseTick; //Field offset: 0x8
		public long Duration; //Field offset: 0x10
		public string Label; //Field offset: 0x18

		public Record() { }

	}

	private Stopwatch stopwatch; //Field offset: 0x8
	private int m_capacity; //Field offset: 0xC
	private List<Record> Records; //Field offset: 0x10
	private int Index; //Field offset: 0x14
	[CompilerGenerated]
	private string <StartLabel>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private int <Status>k__BackingField; //Field offset: 0x1C

	public private string StartLabel
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public int Status
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public EventProfiler(string label, int capacity) { }

	[CompilerGenerated]
	public string get_StartLabel() { }

	[CompilerGenerated]
	public int get_Status() { }

	public void Lap(string label) { }

	[CompilerGenerated]
	private void set_StartLabel(string value) { }

	[CompilerGenerated]
	public void set_Status(int value) { }

	public void Start(string label) { }

	public void Stop(string label) { }

	public string ToDebugString() { }

}

