namespace D4L.TakashoFes.Master;

public struct CharacterExpRaw
{
	private Table __p; //Field offset: 0x0

	public int EntriesLength
	{
		 get { } //Length: 42
	}

	public CharacterExpRaw __assign(int _i, ByteBuffer _bb) { }

	public override void __init(int _i, ByteBuffer _bb) { }

	public Nullable<CharacterExpRawEntry> Entries(int j) { }

	public int get_EntriesLength() { }

	public static CharacterExpRaw GetRootAsCharacterExpRaw(ByteBuffer _bb) { }

	public static CharacterExpRaw GetRootAsCharacterExpRaw(ByteBuffer _bb, CharacterExpRaw obj) { }

}

