namespace D4L.TakashoFes.Struct;

public class SpotVisitRecord
{
	public int SpotID; //Field offset: 0x8
	public Int32[] CharacterIDArray; //Field offset: 0xC
	public int ContactID; //Field offset: 0x10

	public SpotVisitRecord() { }

	public static SpotVisitRecord Parse(SpotVisitRecordProto source) { }

	public SpotVisitRecordProto ToProtobuf() { }

}

