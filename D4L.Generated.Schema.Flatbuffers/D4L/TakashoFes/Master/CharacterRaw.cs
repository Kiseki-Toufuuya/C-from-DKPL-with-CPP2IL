namespace D4L.TakashoFes.Master;

public struct CharacterRaw
{
	private Table __p; //Field offset: 0x0

	public int EntriesLength
	{
		 get { } //Length: 42
	}

	public CharacterRaw __assign(int _i, ByteBuffer _bb) { }

	public override void __init(int _i, ByteBuffer _bb) { }

	public Nullable<CharacterRawEntry> Entries(int j) { }

	public int get_EntriesLength() { }

	public static CharacterRaw GetRootAsCharacterRaw(ByteBuffer _bb) { }

	public static CharacterRaw GetRootAsCharacterRaw(ByteBuffer _bb, CharacterRaw obj) { }

}

