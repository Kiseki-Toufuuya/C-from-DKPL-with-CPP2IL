namespace D4L.TakashoFes.Storage;

public sealed class PKVSStatusEntry
{
	internal sealed class Parser
	{
		public static readonly Parser Default; //Field offset: 0x0

		private static Parser() { }

		public Parser() { }

		public override PKVSStatusEntry Parse(Byte[] source) { }

		public PKVSStatusEntry Parse(PKVSStatusProto source) { }

		public override Byte[] ToBytes(PKVSStatusEntry entry) { }

	}

	[CompilerGenerated]
	private long <ID>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private long <ReceiveDate>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private GuardLong <Delta>k__BackingField; //Field offset: 0x18

	public GuardLong Delta
	{
		[CompilerGenerated]
		 get { } //Length: 18
		[CompilerGenerated]
		 set { } //Length: 16
	}

	public override long ID
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public long ReceiveDate
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public PKVSStatusEntry() { }

	[Preserve]
	public override PKVSStatusEntry Clone() { }

	[CompilerGenerated]
	public GuardLong get_Delta() { }

	[CompilerGenerated]
	public override long get_ID() { }

	[CompilerGenerated]
	public long get_ReceiveDate() { }

	[CompilerGenerated]
	public void set_Delta(GuardLong value) { }

	[CompilerGenerated]
	public override void set_ID(long value) { }

	[CompilerGenerated]
	public void set_ReceiveDate(long value) { }

	[Preserve]
	public IDictionary ToDict() { }

	[Preserve]
	public string ToJson() { }

}

