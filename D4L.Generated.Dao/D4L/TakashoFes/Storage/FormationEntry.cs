namespace D4L.TakashoFes.Storage;

public sealed class FormationEntry
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Int64, Int64> <>9__37_0; //Field offset: 0x4
		public static Func<Int64, Int64> <>9__37_1; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal long <ToDict>b__37_0(long ____) { }

		internal long <ToDict>b__37_1(long ____) { }

	}

	internal sealed class Parser
	{
		public static readonly Parser Default; //Field offset: 0x0

		private static Parser() { }

		public Parser() { }

		public override FormationEntry Parse(Byte[] source) { }

		public FormationEntry Parse(FormationProto source) { }

		public override Byte[] ToBytes(FormationEntry entry) { }

	}

	[CompilerGenerated]
	private long <ID>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private Int64[] <HeroineIDArray>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private Int64[] <CardIDArray>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private string <Name>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private int <UseType>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	private long <CreatedAt>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private long <LastUpdate>k__BackingField; //Field offset: 0x28

	public Int64[] CardIDArray
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public long CreatedAt
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public Int64[] HeroineIDArray
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

	public long LastUpdate
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public string Name
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public int UseType
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public FormationEntry() { }

	[Preserve]
	public override FormationEntry Clone() { }

	[CompilerGenerated]
	public Int64[] get_CardIDArray() { }

	[CompilerGenerated]
	public long get_CreatedAt() { }

	[CompilerGenerated]
	public Int64[] get_HeroineIDArray() { }

	[CompilerGenerated]
	public override long get_ID() { }

	[CompilerGenerated]
	public long get_LastUpdate() { }

	[CompilerGenerated]
	public string get_Name() { }

	[CompilerGenerated]
	public int get_UseType() { }

	[CompilerGenerated]
	public void set_CardIDArray(Int64[] value) { }

	[CompilerGenerated]
	public void set_CreatedAt(long value) { }

	[CompilerGenerated]
	public void set_HeroineIDArray(Int64[] value) { }

	[CompilerGenerated]
	public override void set_ID(long value) { }

	[CompilerGenerated]
	public void set_LastUpdate(long value) { }

	[CompilerGenerated]
	public void set_Name(string value) { }

	[CompilerGenerated]
	public void set_UseType(int value) { }

	[Preserve]
	public IDictionary ToDict() { }

	[Preserve]
	public string ToJson() { }

}

