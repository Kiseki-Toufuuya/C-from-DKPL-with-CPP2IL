namespace D4L.TakashoFes.Struct;

public class GpxPhaseStatus
{
	public long ID; //Field offset: 0x8
	public GuardBoolArray IsClear; //Field offset: 0x10
	public GuardLongArray MaxScore; //Field offset: 0x14
	public GuardLongArray Score; //Field offset: 0x18
	public GuardLong MaxTotalScore; //Field offset: 0x20
	public GuardInt ReceiveReward; //Field offset: 0x30

	public GpxPhaseStatus() { }

	public static GpxPhaseStatus Parse(GpxPhaseStatusProto source) { }

	public GpxPhaseStatusProto ToProtobuf() { }

}

