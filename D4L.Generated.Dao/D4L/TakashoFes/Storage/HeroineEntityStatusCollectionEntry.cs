namespace D4L.TakashoFes.Storage;

public sealed class HeroineEntityStatusCollectionEntry
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<HeroineEntityStatus, Dictionary`2<String, Object>> <>9__17_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal Dictionary<String, Object> <ToDict>b__17_0(HeroineEntityStatus ____) { }

	}

	internal sealed class Parser
	{
		public static readonly Parser Default; //Field offset: 0x0

		private static Parser() { }

		public Parser() { }

		public override HeroineEntityStatusCollectionEntry Parse(Byte[] source) { }

		public HeroineEntityStatusCollectionEntry Parse(HeroineEntityStatusCollectionProto source) { }

		public override Byte[] ToBytes(HeroineEntityStatusCollectionEntry entry) { }

	}

	[CompilerGenerated]
	private long <ID>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private HeroineEntityStatus[] <Heroines>k__BackingField; //Field offset: 0x10

	public HeroineEntityStatus[] Heroines
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

	public HeroineEntityStatusCollectionEntry() { }

	[Preserve]
	public override HeroineEntityStatusCollectionEntry Clone() { }

	[CompilerGenerated]
	public HeroineEntityStatus[] get_Heroines() { }

	[CompilerGenerated]
	public override long get_ID() { }

	[CompilerGenerated]
	public void set_Heroines(HeroineEntityStatus[] value) { }

	[CompilerGenerated]
	public override void set_ID(long value) { }

	[Preserve]
	public IDictionary ToDict() { }

	[Preserve]
	public string ToJson() { }

}

