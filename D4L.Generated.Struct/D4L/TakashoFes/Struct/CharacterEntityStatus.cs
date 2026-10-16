namespace D4L.TakashoFes.Struct;

public class CharacterEntityStatus
{
	public long ID; //Field offset: 0x8
	public long CreatedAt; //Field offset: 0x10
	public long LastUpdate; //Field offset: 0x18
	public GuardInt Exp; //Field offset: 0x20
	public GuardInt ManzokuPt; //Field offset: 0x28
	public GuardInt ExchangeCount; //Field offset: 0x30

	public CharacterEntityStatus() { }

	public static CharacterEntityStatus Parse(CharacterEntityStatusProto source) { }

	public CharacterEntityStatusProto ToProtobuf() { }

}

