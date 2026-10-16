namespace D4L.TakashoFes.Storage;

public sealed class ImageHelpStatusEntry
{
	internal sealed class Parser
	{
		public static readonly Parser Default; //Field offset: 0x0

		private static Parser() { }

		public Parser() { }

		public override ImageHelpStatusEntry Parse(Byte[] source) { }

		public ImageHelpStatusEntry Parse(ImageHelpStatusProto source) { }

		public override Byte[] ToBytes(ImageHelpStatusEntry entry) { }

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

	public ImageHelpStatusEntry() { }

	[Preserve]
	public override ImageHelpStatusEntry Clone() { }

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

