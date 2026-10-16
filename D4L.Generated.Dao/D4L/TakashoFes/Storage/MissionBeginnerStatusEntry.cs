namespace D4L.TakashoFes.Storage;

public sealed class MissionBeginnerStatusEntry
{
	internal sealed class Parser
	{
		public static readonly Parser Default; //Field offset: 0x0

		private static Parser() { }

		public Parser() { }

		public override MissionBeginnerStatusEntry Parse(Byte[] source) { }

		public MissionBeginnerStatusEntry Parse(MissionBeginnerStatusProto source) { }

		public override Byte[] ToBytes(MissionBeginnerStatusEntry entry) { }

	}

	[CompilerGenerated]
	private long <ID>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private int <ReceiveStatus>k__BackingField; //Field offset: 0x10

	public override long ID
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public int ReceiveStatus
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public MissionBeginnerStatusEntry() { }

	[Preserve]
	public override MissionBeginnerStatusEntry Clone() { }

	[CompilerGenerated]
	public override long get_ID() { }

	[CompilerGenerated]
	public int get_ReceiveStatus() { }

	[CompilerGenerated]
	public override void set_ID(long value) { }

	[CompilerGenerated]
	public void set_ReceiveStatus(int value) { }

	[Preserve]
	public IDictionary ToDict() { }

	[Preserve]
	public string ToJson() { }

}

