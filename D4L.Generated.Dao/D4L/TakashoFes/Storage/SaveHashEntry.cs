namespace D4L.TakashoFes.Storage;

public sealed class SaveHashEntry
{
	internal sealed class Parser
	{
		public static readonly Parser Default; //Field offset: 0x0

		private static Parser() { }

		public Parser() { }

		public override SaveHashEntry Parse(Byte[] source) { }

		public SaveHashEntry Parse(SaveHashProto source) { }

		public override Byte[] ToBytes(SaveHashEntry entry) { }

	}

	[CompilerGenerated]
	private long <ID>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private string <HashValue>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <Annotation>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private long <Date>k__BackingField; //Field offset: 0x18

	public string Annotation
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public long Date
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public string HashValue
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public override long ID
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public SaveHashEntry() { }

	[Preserve]
	public override SaveHashEntry Clone() { }

	[CompilerGenerated]
	public string get_Annotation() { }

	[CompilerGenerated]
	public long get_Date() { }

	[CompilerGenerated]
	public string get_HashValue() { }

	[CompilerGenerated]
	public override long get_ID() { }

	[CompilerGenerated]
	public void set_Annotation(string value) { }

	[CompilerGenerated]
	public void set_Date(long value) { }

	[CompilerGenerated]
	public void set_HashValue(string value) { }

	[CompilerGenerated]
	public override void set_ID(long value) { }

	[Preserve]
	public IDictionary ToDict() { }

	[Preserve]
	public string ToJson() { }

}

