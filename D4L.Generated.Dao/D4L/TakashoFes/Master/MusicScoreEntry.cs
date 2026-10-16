namespace D4L.TakashoFes.Master;

public sealed class MusicScoreEntry : IFlatbuffersDaoEntry<Int32>
{
	[CompilerGenerated]
	private int <ID>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private int <CreaterNameID>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	private int <MusicLevel>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private int <BarLine>k__BackingField; //Field offset: 0x14

	public int BarLine
	{
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public int CreaterNameID
	{
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public int ID
	{
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public int MusicLevel
	{
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public MusicScoreEntry() { }

	public static MusicScoreEntry Create(MusicScoreRawEntry source) { }

	[CompilerGenerated]
	public void set_BarLine(int value) { }

	[CompilerGenerated]
	public void set_CreaterNameID(int value) { }

	[CompilerGenerated]
	public void set_ID(int value) { }

	[CompilerGenerated]
	public void set_MusicLevel(int value) { }

}

