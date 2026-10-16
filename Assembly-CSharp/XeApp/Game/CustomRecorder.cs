namespace XeApp.Game;

public class CustomRecorder
{
	internal class Data
	{
		public long UpdateCount; //Field offset: 0x8
		public long MaxNs; //Field offset: 0x10
		public double TotalSec; //Field offset: 0x18
		public int Position; //Field offset: 0x20

		public Data() { }

	}

	private const int MAX_HIST = 10800; //Field offset: 0x0
	public List<Data> History; //Field offset: 0x8
	[CompilerGenerated]
	private Recorder <Source>k__BackingField; //Field offset: 0xC
	public double TotalSec; //Field offset: 0x10
	public long UpdateCount; //Field offset: 0x18
	public long MaxNs; //Field offset: 0x20
	private bool IsRunning; //Field offset: 0x28

	public private Recorder Source
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public CustomRecorder() { }

	public void EndCounting() { }

	[CompilerGenerated]
	public Recorder get_Source() { }

	public void Init(string name) { }

	private void Reset() { }

	[CompilerGenerated]
	private void set_Source(Recorder value) { }

	public void StartCounting() { }

	public void Update(int musicTime) { }

	private void UpdateInternal(int cpos) { }

}

