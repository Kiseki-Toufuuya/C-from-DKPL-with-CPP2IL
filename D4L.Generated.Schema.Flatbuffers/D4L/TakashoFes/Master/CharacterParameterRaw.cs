namespace D4L.TakashoFes.Master;

public struct CharacterParameterRaw
{
	private Table __p; //Field offset: 0x0

	public int EntriesLength
	{
		 get { } //Length: 42
	}

	public CharacterParameterRaw __assign(int _i, ByteBuffer _bb) { }

	public override void __init(int _i, ByteBuffer _bb) { }

	public Nullable<CharacterParameterRawEntry> Entries(int j) { }

	public int get_EntriesLength() { }

	public static CharacterParameterRaw GetRootAsCharacterParameterRaw(ByteBuffer _bb) { }

	public static CharacterParameterRaw GetRootAsCharacterParameterRaw(ByteBuffer _bb, CharacterParameterRaw obj) { }

}

