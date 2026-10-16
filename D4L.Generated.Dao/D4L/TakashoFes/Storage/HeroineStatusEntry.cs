namespace D4L.TakashoFes.Storage;

public sealed class HeroineStatusEntry
{
	internal sealed class Parser
	{
		public static readonly Parser Default; //Field offset: 0x0

		private static Parser() { }

		public Parser() { }

		public override HeroineStatusEntry Parse(Byte[] source) { }

		public HeroineStatusEntry Parse(HeroineStatusProto source) { }

		public override Byte[] ToBytes(HeroineStatusEntry entry) { }

	}

	[CompilerGenerated]
	private long <ID>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private GuardInt <HeroineID>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private long <CreatedAt>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private long <LastUpdate>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private GuardInt <IndividualDiffID>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private GuardInt <SpecialSkillID>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private int <Favorite>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private GuardInt <Exp>k__BackingField; //Field offset: 0x3C
	[CompilerGenerated]
	private int <New>k__BackingField; //Field offset: 0x44

	public long CreatedAt
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public GuardInt Exp
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public int Favorite
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public GuardInt HeroineID
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

	public GuardInt IndividualDiffID
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

	public int New
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public GuardInt SpecialSkillID
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public HeroineStatusEntry() { }

	[Preserve]
	public override HeroineStatusEntry Clone() { }

	[CompilerGenerated]
	public long get_CreatedAt() { }

	[CompilerGenerated]
	public GuardInt get_Exp() { }

	[CompilerGenerated]
	public int get_Favorite() { }

	[CompilerGenerated]
	public GuardInt get_HeroineID() { }

	[CompilerGenerated]
	public override long get_ID() { }

	[CompilerGenerated]
	public GuardInt get_IndividualDiffID() { }

	[CompilerGenerated]
	public long get_LastUpdate() { }

	[CompilerGenerated]
	public int get_New() { }

	[CompilerGenerated]
	public GuardInt get_SpecialSkillID() { }

	[CompilerGenerated]
	public void set_CreatedAt(long value) { }

	[CompilerGenerated]
	public void set_Exp(GuardInt value) { }

	[CompilerGenerated]
	public void set_Favorite(int value) { }

	[CompilerGenerated]
	public void set_HeroineID(GuardInt value) { }

	[CompilerGenerated]
	public override void set_ID(long value) { }

	[CompilerGenerated]
	public void set_IndividualDiffID(GuardInt value) { }

	[CompilerGenerated]
	public void set_LastUpdate(long value) { }

	[CompilerGenerated]
	public void set_New(int value) { }

	[CompilerGenerated]
	public void set_SpecialSkillID(GuardInt value) { }

	[Preserve]
	public IDictionary ToDict() { }

	[Preserve]
	public string ToJson() { }

}

