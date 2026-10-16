namespace D4L.TakashoFes.Storage;

public sealed class ClubSettingStatusEntry
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Int32, Int64> <>9__37_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal long <ToDict>b__37_0(int ____) { }

	}

	internal sealed class Parser
	{
		public static readonly Parser Default; //Field offset: 0x0

		private static Parser() { }

		public Parser() { }

		public override ClubSettingStatusEntry Parse(Byte[] source) { }

		public ClubSettingStatusEntry Parse(ClubSettingStatusProto source) { }

		public override Byte[] ToBytes(ClubSettingStatusEntry entry) { }

	}

	[CompilerGenerated]
	private long <ID>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private bool <IsPostAchievementAll>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private bool <IsPostAchievementSSRDraw>k__BackingField; //Field offset: 0x11
	[CompilerGenerated]
	private bool <IsPostAchievementMaxStrengthen>k__BackingField; //Field offset: 0x12
	[CompilerGenerated]
	private bool <IsPostAchievementMaxAwake>k__BackingField; //Field offset: 0x13
	[CompilerGenerated]
	private bool <IsPostAchievementMaxLimitBreak>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private Int32[] <EmblemID>k__BackingField; //Field offset: 0x18

	public Int32[] EmblemID
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

	public bool IsPostAchievementAll
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public bool IsPostAchievementMaxAwake
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public bool IsPostAchievementMaxLimitBreak
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public bool IsPostAchievementMaxStrengthen
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public bool IsPostAchievementSSRDraw
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public ClubSettingStatusEntry() { }

	[Preserve]
	public override ClubSettingStatusEntry Clone() { }

	[CompilerGenerated]
	public Int32[] get_EmblemID() { }

	[CompilerGenerated]
	public override long get_ID() { }

	[CompilerGenerated]
	public bool get_IsPostAchievementAll() { }

	[CompilerGenerated]
	public bool get_IsPostAchievementMaxAwake() { }

	[CompilerGenerated]
	public bool get_IsPostAchievementMaxLimitBreak() { }

	[CompilerGenerated]
	public bool get_IsPostAchievementMaxStrengthen() { }

	[CompilerGenerated]
	public bool get_IsPostAchievementSSRDraw() { }

	[CompilerGenerated]
	public void set_EmblemID(Int32[] value) { }

	[CompilerGenerated]
	public override void set_ID(long value) { }

	[CompilerGenerated]
	public void set_IsPostAchievementAll(bool value) { }

	[CompilerGenerated]
	public void set_IsPostAchievementMaxAwake(bool value) { }

	[CompilerGenerated]
	public void set_IsPostAchievementMaxLimitBreak(bool value) { }

	[CompilerGenerated]
	public void set_IsPostAchievementMaxStrengthen(bool value) { }

	[CompilerGenerated]
	public void set_IsPostAchievementSSRDraw(bool value) { }

	[Preserve]
	public IDictionary ToDict() { }

	[Preserve]
	public string ToJson() { }

}

