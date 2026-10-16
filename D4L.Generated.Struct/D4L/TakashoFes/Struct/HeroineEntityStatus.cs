namespace D4L.TakashoFes.Struct;

public class HeroineEntityStatus
{
	public long ID; //Field offset: 0x8
	public GuardInt HeroineID; //Field offset: 0x10
	public long CreatedAt; //Field offset: 0x18
	public long LastUpdate; //Field offset: 0x20
	public GuardInt IndividualDiffID; //Field offset: 0x28
	public GuardInt SpecialSkillID; //Field offset: 0x30
	public int Favorite; //Field offset: 0x38
	public GuardInt Exp; //Field offset: 0x3C
	public int New; //Field offset: 0x44

	public HeroineEntityStatus() { }

	public static HeroineEntityStatus Parse(HeroineEntityStatusProto source) { }

	public HeroineEntityStatusProto ToProtobuf() { }

}

