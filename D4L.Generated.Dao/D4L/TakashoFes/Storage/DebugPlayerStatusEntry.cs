namespace D4L.TakashoFes.Storage;

public sealed class DebugPlayerStatusEntry
{
	internal sealed class Parser
	{
		public static readonly Parser Default; //Field offset: 0x0

		private static Parser() { }

		public Parser() { }

		public override DebugPlayerStatusEntry Parse(Byte[] source) { }

		public DebugPlayerStatusEntry Parse(DebugPlayerStatusProto source) { }

		public override Byte[] ToBytes(DebugPlayerStatusEntry entry) { }

	}

	[CompilerGenerated]
	private long <ID>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private string <SettinvValue>k__BackingField; //Field offset: 0x10

	public override long ID
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public string SettinvValue
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public DebugPlayerStatusEntry() { }

	[Preserve]
	public override DebugPlayerStatusEntry Clone() { }

	[CompilerGenerated]
	public override long get_ID() { }

	[CompilerGenerated]
	public string get_SettinvValue() { }

	[CompilerGenerated]
	public override void set_ID(long value) { }

	[CompilerGenerated]
	public void set_SettinvValue(string value) { }

	[Preserve]
	public IDictionary ToDict() { }

	[Preserve]
	public string ToJson() { }

}

