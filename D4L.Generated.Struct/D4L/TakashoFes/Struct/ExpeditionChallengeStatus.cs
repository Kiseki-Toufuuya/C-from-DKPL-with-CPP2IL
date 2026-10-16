namespace D4L.TakashoFes.Struct;

public class ExpeditionChallengeStatus
{
	public long ID; //Field offset: 0x8
	public GuardInt BonusValue; //Field offset: 0x10
	public GuardInt PowerValue; //Field offset: 0x18

	public ExpeditionChallengeStatus() { }

	public static ExpeditionChallengeStatus Parse(ExpeditionChallengeStatusProto source) { }

	public ExpeditionChallengeStatusProto ToProtobuf() { }

}

