namespace D4L.TakashoFes.Storage;

public sealed class GpxEntryStatusEntry
{
	internal sealed class Parser
	{
		public static readonly Parser Default; //Field offset: 0x0

		private static Parser() { }

		public Parser() { }

		public override GpxEntryStatusEntry Parse(Byte[] source) { }

		public GpxEntryStatusEntry Parse(GpxEntryStatusProto source) { }

		public override Byte[] ToBytes(GpxEntryStatusEntry entry) { }

	}

	[CompilerGenerated]
	private long <ID>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private GuardInt <GpxEntry>k__BackingField; //Field offset: 0x10

	public GuardInt GpxEntry
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

	public GpxEntryStatusEntry() { }

	[Preserve]
	public override GpxEntryStatusEntry Clone() { }

	[CompilerGenerated]
	public GuardInt get_GpxEntry() { }

	[CompilerGenerated]
	public override long get_ID() { }

	[CompilerGenerated]
	public void set_GpxEntry(GuardInt value) { }

	[CompilerGenerated]
	public override void set_ID(long value) { }

	[Preserve]
	public IDictionary ToDict() { }

	[Preserve]
	public string ToJson() { }

}

