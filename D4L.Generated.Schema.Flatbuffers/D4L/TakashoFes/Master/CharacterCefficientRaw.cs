namespace D4L.TakashoFes.Master;

public struct CharacterCefficientRaw
{
	private Table __p; //Field offset: 0x0

	public int EntriesLength
	{
		 get { } //Length: 42
	}

	public CharacterCefficientRaw __assign(int _i, ByteBuffer _bb) { }

	public override void __init(int _i, ByteBuffer _bb) { }

	public Nullable<CharacterCefficientRawEntry> Entries(int j) { }

	public int get_EntriesLength() { }

	public static CharacterCefficientRaw GetRootAsCharacterCefficientRaw(ByteBuffer _bb) { }

	public static CharacterCefficientRaw GetRootAsCharacterCefficientRaw(ByteBuffer _bb, CharacterCefficientRaw obj) { }

}

