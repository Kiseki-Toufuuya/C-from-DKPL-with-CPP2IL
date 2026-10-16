namespace D4L.TakashoFes.Storage;

public sealed class CharacterStatusEntry
{
	internal sealed class Parser
	{
		public static readonly Parser Default; //Field offset: 0x0

		private static Parser() { }

		public Parser() { }

		public override CharacterStatusEntry Parse(Byte[] source) { }

		public CharacterStatusEntry Parse(CharacterStatusProto source) { }

		public override Byte[] ToBytes(CharacterStatusEntry entry) { }

	}

	[CompilerGenerated]
	private long <ID>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private long <CreatedAt>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private long <LastUpdate>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private GuardInt <Exp>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private GuardInt <ManzokuPt>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private GuardInt <ExchangeCount>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private GuardInt <SkinID>k__BackingField; //Field offset: 0x38

	public long CreatedAt
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public GuardInt ExchangeCount
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

	public GuardInt ManzokuPt
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public GuardInt SkinID
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public CharacterStatusEntry() { }

	[Preserve]
	public override CharacterStatusEntry Clone() { }

	[CompilerGenerated]
	public long get_CreatedAt() { }

	[CompilerGenerated]
	public GuardInt get_ExchangeCount() { }

	[CompilerGenerated]
	public GuardInt get_Exp() { }

	[CompilerGenerated]
	public override long get_ID() { }

	[CompilerGenerated]
	public long get_LastUpdate() { }

	[CompilerGenerated]
	public GuardInt get_ManzokuPt() { }

	[CompilerGenerated]
	public GuardInt get_SkinID() { }

	[CompilerGenerated]
	public void set_CreatedAt(long value) { }

	[CompilerGenerated]
	public void set_ExchangeCount(GuardInt value) { }

	[CompilerGenerated]
	public void set_Exp(GuardInt value) { }

	[CompilerGenerated]
	public override void set_ID(long value) { }

	[CompilerGenerated]
	public void set_LastUpdate(long value) { }

	[CompilerGenerated]
	public void set_ManzokuPt(GuardInt value) { }

	[CompilerGenerated]
	public void set_SkinID(GuardInt value) { }

	[Preserve]
	public IDictionary ToDict() { }

	[Preserve]
	public string ToJson() { }

}

