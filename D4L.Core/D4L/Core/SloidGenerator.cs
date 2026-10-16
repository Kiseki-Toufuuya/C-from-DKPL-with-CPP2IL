namespace D4L.Core;

public class SloidGenerator : ISloidGenerator
{
	[CompilerGenerated]
	private ISloidTimer <Timer>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private readonly ushort <WorkerId>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	private readonly ushort <RoundRobin>k__BackingField; //Field offset: 0xE
	private long lastGeneratedTime; //Field offset: 0x10
	private ushort sequence; //Field offset: 0x18
	private object seqLock; //Field offset: 0x1C

	public ushort RoundRobin
	{
		[CompilerGenerated]
		 get { } //Length: 12
	}

	public ISloidTimer Timer
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public ushort WorkerId
	{
		[CompilerGenerated]
		 get { } //Length: 12
	}

	public SloidGenerator(ISloidTimer timer, long roundRobin, ushort workerId) { }

	private Sloid Generate(long time) { }

	[CompilerGenerated]
	public ushort get_RoundRobin() { }

	[CompilerGenerated]
	public ISloidTimer get_Timer() { }

	[CompilerGenerated]
	public ushort get_WorkerId() { }

	private void IncrementSequence(long time) { }

	public override Sloid Next() { }

	[CompilerGenerated]
	public void set_Timer(ISloidTimer value) { }

	public static ushort TruncatedRoundRobin(long roundRobin) { }

}

