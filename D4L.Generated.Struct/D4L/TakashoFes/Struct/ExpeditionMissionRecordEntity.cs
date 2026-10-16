namespace D4L.TakashoFes.Struct;

public class ExpeditionMissionRecordEntity
{
	public long ID; //Field offset: 0x8
	public GuardInt SuccessCount; //Field offset: 0x10
	public GuardInt GreatSuccessCount; //Field offset: 0x18
	public GuardInt SuperSuccessCount; //Field offset: 0x20
	public long CreatedAt; //Field offset: 0x28
	public long LastUpdate; //Field offset: 0x30
	public Int64[] HeroineIDArray; //Field offset: 0x38
	public Int64[] CardIDArray; //Field offset: 0x3C
	public int New; //Field offset: 0x40
	public long CompleteTime; //Field offset: 0x48

	public ExpeditionMissionRecordEntity() { }

	public static ExpeditionMissionRecordEntity Parse(ExpeditionMissionRecordEntityProto source) { }

	public ExpeditionMissionRecordEntityProto ToProtobuf() { }

}

