namespace D4L.TakashoFes.Storage;

public sealed class CharacterEntityStatusCollectionEntry
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<CharacterEntityStatus, Dictionary`2<String, Object>> <>9__17_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal Dictionary<String, Object> <ToDict>b__17_0(CharacterEntityStatus ____) { }

	}

	internal sealed class Parser
	{
		public static readonly Parser Default; //Field offset: 0x0

		private static Parser() { }

		public Parser() { }

		public override CharacterEntityStatusCollectionEntry Parse(Byte[] source) { }

		public CharacterEntityStatusCollectionEntry Parse(CharacterEntityStatusCollectionProto source) { }

		public override Byte[] ToBytes(CharacterEntityStatusCollectionEntry entry) { }

	}

	[CompilerGenerated]
	private long <ID>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private CharacterEntityStatus[] <Characters>k__BackingField; //Field offset: 0x10

	public CharacterEntityStatus[] Characters
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

	public CharacterEntityStatusCollectionEntry() { }

	[Preserve]
	public override CharacterEntityStatusCollectionEntry Clone() { }

	[CompilerGenerated]
	public CharacterEntityStatus[] get_Characters() { }

	[CompilerGenerated]
	public override long get_ID() { }

	[CompilerGenerated]
	public void set_Characters(CharacterEntityStatus[] value) { }

	[CompilerGenerated]
	public override void set_ID(long value) { }

	[Preserve]
	public IDictionary ToDict() { }

	[Preserve]
	public string ToJson() { }

}

