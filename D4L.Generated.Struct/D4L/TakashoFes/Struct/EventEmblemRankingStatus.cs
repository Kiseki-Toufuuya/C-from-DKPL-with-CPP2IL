namespace D4L.TakashoFes.Struct;

public class EventEmblemRankingStatus
{
	public GuardLong ID; //Field offset: 0x8
	public GuardLong RankingPosition; //Field offset: 0x18

	public EventEmblemRankingStatus() { }

	public static EventEmblemRankingStatus Parse(EventEmblemRankingStatusProto source) { }

	public EventEmblemRankingStatusProto ToProtobuf() { }

}

