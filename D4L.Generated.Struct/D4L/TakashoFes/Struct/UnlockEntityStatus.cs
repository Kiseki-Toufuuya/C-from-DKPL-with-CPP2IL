namespace D4L.TakashoFes.Struct;

public class UnlockEntityStatus
{
	public long CreateDate; //Field offset: 0x8
	public long LastUpdate; //Field offset: 0x10
	public int Category; //Field offset: 0x18
	public GuardInt UnlockID; //Field offset: 0x1C
	public GuardInt IntValue; //Field offset: 0x24
	public GuardBool IsNew; //Field offset: 0x2C

	public UnlockEntityStatus() { }

	public static UnlockEntityStatus Parse(UnlockEntityStatusProto source) { }

	public UnlockEntityStatusProto ToProtobuf() { }

}

