namespace D4L.TakashoFes.Storage;

public sealed class MySpotStatusEntry
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Int32, Int64> <>9__45_0; //Field offset: 0x4
		public static Func<Byte, Int64> <>9__45_1; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal long <ToDict>b__45_0(int ____) { }

		internal long <ToDict>b__45_1(byte ____) { }

	}

	internal sealed class Parser
	{
		public static readonly Parser Default; //Field offset: 0x0

		private static Parser() { }

		public Parser() { }

		public override MySpotStatusEntry Parse(Byte[] source) { }

		public MySpotStatusEntry Parse(MySpotStatusProto source) { }

		public override Byte[] ToBytes(MySpotStatusEntry entry) { }

	}

	[CompilerGenerated]
	private long <ID>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private string <PresetName>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private int <StageID>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private int <ThemeID>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private Int32[] <SpotCharacterIDs>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	private long <CreatedAt>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private long <LastUpdate>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private Byte[] <ThumbnailData>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private int <MusicID>k__BackingField; //Field offset: 0x34

	public long CreatedAt
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

	public int MusicID
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public string PresetName
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public Int32[] SpotCharacterIDs
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public int StageID
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public int ThemeID
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public Byte[] ThumbnailData
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public MySpotStatusEntry() { }

	[Preserve]
	public override MySpotStatusEntry Clone() { }

	[CompilerGenerated]
	public long get_CreatedAt() { }

	[CompilerGenerated]
	public override long get_ID() { }

	[CompilerGenerated]
	public long get_LastUpdate() { }

	[CompilerGenerated]
	public int get_MusicID() { }

	[CompilerGenerated]
	public string get_PresetName() { }

	[CompilerGenerated]
	public Int32[] get_SpotCharacterIDs() { }

	[CompilerGenerated]
	public int get_StageID() { }

	[CompilerGenerated]
	public int get_ThemeID() { }

	[CompilerGenerated]
	public Byte[] get_ThumbnailData() { }

	[CompilerGenerated]
	public void set_CreatedAt(long value) { }

	[CompilerGenerated]
	public override void set_ID(long value) { }

	[CompilerGenerated]
	public void set_LastUpdate(long value) { }

	[CompilerGenerated]
	public void set_MusicID(int value) { }

	[CompilerGenerated]
	public void set_PresetName(string value) { }

	[CompilerGenerated]
	public void set_SpotCharacterIDs(Int32[] value) { }

	[CompilerGenerated]
	public void set_StageID(int value) { }

	[CompilerGenerated]
	public void set_ThemeID(int value) { }

	[CompilerGenerated]
	public void set_ThumbnailData(Byte[] value) { }

	[Preserve]
	public IDictionary ToDict() { }

	[Preserve]
	public string ToJson() { }

}

