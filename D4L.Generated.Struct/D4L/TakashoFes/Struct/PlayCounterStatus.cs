namespace D4L.TakashoFes.Struct;

public class PlayCounterStatus
{
	public int ID; //Field offset: 0x8
	public GuardInt Count; //Field offset: 0xC

	public PlayCounterStatus() { }

	public static PlayCounterStatus Parse(PlayCounterStatusProto source) { }

	public PlayCounterStatusProto ToProtobuf() { }

}

