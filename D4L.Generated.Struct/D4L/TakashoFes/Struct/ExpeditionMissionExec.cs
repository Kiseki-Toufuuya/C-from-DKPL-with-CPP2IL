namespace D4L.TakashoFes.Struct;

public class ExpeditionMissionExec
{
	public long ID; //Field offset: 0x8
	public string SessionID; //Field offset: 0x10
	public GuardInt MissionID; //Field offset: 0x14
	public GuardLong FormationID; //Field offset: 0x20
	public GuardLong CompleteTime; //Field offset: 0x30
	public GuardInt UstBoostID; //Field offset: 0x40
	public GuardBool UseDialyBonus; //Field offset: 0x48
	public long CreatedAt; //Field offset: 0x50
	public long LastUpdate; //Field offset: 0x58
	public GuardByte DailyBonusNo; //Field offset: 0x60
	public string TargetBossID; //Field offset: 0x68

	public ExpeditionMissionExec() { }

	public static ExpeditionMissionExec Parse(ExpeditionMissionExecProto source) { }

	public ExpeditionMissionExecProto ToProtobuf() { }

}

