namespace D4L.TakashoFes.Struct;

public class EpisodeEntityStatus
{
	public long ID; //Field offset: 0x8
	public long CreatedAt; //Field offset: 0x10
	public long LastUpdate; //Field offset: 0x18
	public GuardInt ReadCount; //Field offset: 0x20
	public GuardByte UnlockStatus; //Field offset: 0x28
	public GuardBool IsNew; //Field offset: 0x30

	public EpisodeEntityStatus() { }

	public static EpisodeEntityStatus Parse(EpisodeEntityStatusProto source) { }

	public EpisodeEntityStatusProto ToProtobuf() { }

}

