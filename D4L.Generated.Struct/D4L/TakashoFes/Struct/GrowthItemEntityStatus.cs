namespace D4L.TakashoFes.Struct;

public class GrowthItemEntityStatus
{
	public long ID; //Field offset: 0x8
	public GuardInt Count; //Field offset: 0x10
	public long CreatedAt; //Field offset: 0x18
	public long LastUpdate; //Field offset: 0x20

	public GrowthItemEntityStatus() { }

	public static GrowthItemEntityStatus Parse(GrowthItemEntityStatusProto source) { }

	public GrowthItemEntityStatusProto ToProtobuf() { }

}

