namespace D4L.TakashoFes.Storage;

public sealed class TutorialAdvStatusEntry
{
	internal sealed class Parser
	{
		public static readonly Parser Default; //Field offset: 0x0

		private static Parser() { }

		public Parser() { }

		public override TutorialAdvStatusEntry Parse(Byte[] source) { }

		public TutorialAdvStatusEntry Parse(TutorialAdvStatusProto source) { }

		public override Byte[] ToBytes(TutorialAdvStatusEntry entry) { }

	}

	[CompilerGenerated]
	private long <ID>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private long <CheckTime>k__BackingField; //Field offset: 0x10

	public long CheckTime
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public override long ID
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public TutorialAdvStatusEntry() { }

	[Preserve]
	public override TutorialAdvStatusEntry Clone() { }

	[CompilerGenerated]
	public long get_CheckTime() { }

	[CompilerGenerated]
	public override long get_ID() { }

	[CompilerGenerated]
	public void set_CheckTime(long value) { }

	[CompilerGenerated]
	public override void set_ID(long value) { }

	[Preserve]
	public IDictionary ToDict() { }

	[Preserve]
	public string ToJson() { }

}

