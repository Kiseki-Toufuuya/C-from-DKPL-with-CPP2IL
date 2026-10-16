namespace D4L.TakashoFes.Struct;

public class MissionCounterStatus
{
	public long ID; //Field offset: 0x8
	public GuardLong Count; //Field offset: 0x10

	public MissionCounterStatus() { }

	public static MissionCounterStatus Parse(MissionCounterStatusProto source) { }

	public MissionCounterStatusProto ToProtobuf() { }

}

