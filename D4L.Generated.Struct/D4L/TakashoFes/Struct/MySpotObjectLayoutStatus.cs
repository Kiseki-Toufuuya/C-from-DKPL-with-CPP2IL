namespace D4L.TakashoFes.Struct;

public class MySpotObjectLayoutStatus
{
	public long ID; //Field offset: 0x8
	public int ItemID; //Field offset: 0x10
	public string PrefabName; //Field offset: 0x14
	public string PlacementPointName; //Field offset: 0x18
	public int PlacementIndex; //Field offset: 0x1C
	public int ParentObjectIndex; //Field offset: 0x20
	public float PosX; //Field offset: 0x24
	public float PosY; //Field offset: 0x28
	public float PosZ; //Field offset: 0x2C
	public int Step; //Field offset: 0x30
	public int Flip; //Field offset: 0x34
	public long BuildTime; //Field offset: 0x38
	public int PosterCardID; //Field offset: 0x40

	public MySpotObjectLayoutStatus() { }

	public static MySpotObjectLayoutStatus Parse(MySpotObjectLayoutStatusProto source) { }

	public MySpotObjectLayoutStatusProto ToProtobuf() { }

}

