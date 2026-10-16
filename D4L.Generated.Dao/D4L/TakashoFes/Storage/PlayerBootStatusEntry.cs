namespace D4L.TakashoFes.Storage;

public sealed class PlayerBootStatusEntry
{
	internal sealed class Parser
	{
		public static readonly Parser Default; //Field offset: 0x0

		private static Parser() { }

		public Parser() { }

		public override PlayerBootStatusEntry Parse(Byte[] source) { }

		public PlayerBootStatusEntry Parse(PlayerBootStatusProto source) { }

		public override Byte[] ToBytes(PlayerBootStatusEntry entry) { }

	}

	[CompilerGenerated]
	private long <ID>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private string <PresetName>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private int <TutorialEnd>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private int <FormatVersion>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private long <AppealAccountLinkage>k__BackingField; //Field offset: 0x20

	public long AppealAccountLinkage
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public int FormatVersion
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

	public string PresetName
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public int TutorialEnd
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public PlayerBootStatusEntry() { }

	[Preserve]
	public override PlayerBootStatusEntry Clone() { }

	[CompilerGenerated]
	public long get_AppealAccountLinkage() { }

	[CompilerGenerated]
	public int get_FormatVersion() { }

	[CompilerGenerated]
	public override long get_ID() { }

	[CompilerGenerated]
	public string get_PresetName() { }

	[CompilerGenerated]
	public int get_TutorialEnd() { }

	[CompilerGenerated]
	public void set_AppealAccountLinkage(long value) { }

	[CompilerGenerated]
	public void set_FormatVersion(int value) { }

	[CompilerGenerated]
	public override void set_ID(long value) { }

	[CompilerGenerated]
	public void set_PresetName(string value) { }

	[CompilerGenerated]
	public void set_TutorialEnd(int value) { }

	[Preserve]
	public IDictionary ToDict() { }

	[Preserve]
	public string ToJson() { }

}

