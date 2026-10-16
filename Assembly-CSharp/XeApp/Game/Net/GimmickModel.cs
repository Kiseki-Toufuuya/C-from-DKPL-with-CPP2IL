namespace XeApp.Game.Net;

public class GimmickModel : EntityBase<GimmickModel, Int32>
{
	public int ID; //Field offset: 0xC
	public int ImageID; //Field offset: 0x10
	public string Name; //Field offset: 0x14
	public int EffectID; //Field offset: 0x18
	public float Param1; //Field offset: 0x1C
	public float Param2; //Field offset: 0x20
	public float Param3; //Field offset: 0x24

	public GimmickModel() { }

}

