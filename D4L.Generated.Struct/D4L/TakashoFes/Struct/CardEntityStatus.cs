namespace D4L.TakashoFes.Struct;

public class CardEntityStatus
{
	public long ID; //Field offset: 0x8
	public GuardInt CardID; //Field offset: 0x10
	public long CreatedAt; //Field offset: 0x18
	public long LastUpdate; //Field offset: 0x20
	public GuardInt AwakeLv; //Field offset: 0x28
	public GuardInt Exp; //Field offset: 0x30
	public GuardInt DanmakuExp; //Field offset: 0x38
	public int Favorite; //Field offset: 0x40
	public int UseAwkImage; //Field offset: 0x44
	public int New; //Field offset: 0x48
	public int UsePremiumImage; //Field offset: 0x4C

	public CardEntityStatus() { }

	public static CardEntityStatus Parse(CardEntityStatusProto source) { }

	public CardEntityStatusProto ToProtobuf() { }

}

