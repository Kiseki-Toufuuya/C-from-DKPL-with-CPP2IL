namespace D4L.TakashoFes.Storage;

public sealed class CardStatusEntry
{
	internal sealed class Parser
	{
		public static readonly Parser Default; //Field offset: 0x0

		private static Parser() { }

		public Parser() { }

		public override CardStatusEntry Parse(Byte[] source) { }

		public CardStatusEntry Parse(CardStatusProto source) { }

		public override Byte[] ToBytes(CardStatusEntry entry) { }

	}

	[CompilerGenerated]
	private long <ID>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private GuardInt <CardID>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private long <CreatedAt>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private long <LastUpdate>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private GuardInt <AwakeLv>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private GuardInt <Exp>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private GuardInt <DanmakuExp>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private int <Favorite>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private int <UseAwkImage>k__BackingField; //Field offset: 0x44
	[CompilerGenerated]
	private int <New>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private int <UsePremiumImage>k__BackingField; //Field offset: 0x4C

	public GuardInt AwakeLv
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public GuardInt CardID
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public long CreatedAt
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public GuardInt DanmakuExp
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

	public int New
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public int UseAwkImage
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public int UsePremiumImage
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public CardStatusEntry() { }

	[Preserve]
	public override CardStatusEntry Clone() { }

	[CompilerGenerated]
	public GuardInt get_AwakeLv() { }

	[CompilerGenerated]
	public GuardInt get_CardID() { }

	[CompilerGenerated]
	public long get_CreatedAt() { }

	[CompilerGenerated]
	public GuardInt get_DanmakuExp() { }

	[CompilerGenerated]
	public GuardInt get_Exp() { }

	[CompilerGenerated]
	public int get_Favorite() { }

	[CompilerGenerated]
	public override long get_ID() { }

	[CompilerGenerated]
	public long get_LastUpdate() { }

	[CompilerGenerated]
	public int get_New() { }

	[CompilerGenerated]
	public int get_UseAwkImage() { }

	[CompilerGenerated]
	public int get_UsePremiumImage() { }

	[CompilerGenerated]
	public void set_AwakeLv(GuardInt value) { }

	[CompilerGenerated]
	public void set_CardID(GuardInt value) { }

	[CompilerGenerated]
	public void set_CreatedAt(long value) { }

	[CompilerGenerated]
	public void set_DanmakuExp(GuardInt value) { }

	[CompilerGenerated]
	public void set_Exp(GuardInt value) { }

	[CompilerGenerated]
	public void set_Favorite(int value) { }

	[CompilerGenerated]
	public override void set_ID(long value) { }

	[CompilerGenerated]
	public void set_LastUpdate(long value) { }

	[CompilerGenerated]
	public void set_New(int value) { }

	[CompilerGenerated]
	public void set_UseAwkImage(int value) { }

	[CompilerGenerated]
	public void set_UsePremiumImage(int value) { }

	[Preserve]
	public IDictionary ToDict() { }

	[Preserve]
	public string ToJson() { }

}

