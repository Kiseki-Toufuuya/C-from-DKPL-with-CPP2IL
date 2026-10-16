namespace Heqet;

public class HeqetMissionModel : EntityBase<HeqetMissionModel, Int32>
{
	public int ID; //Field offset: 0xC
	public string Name; //Field offset: 0x10
	public int EffectID; //Field offset: 0x14
	public int Param1; //Field offset: 0x18
	public int Param2; //Field offset: 0x1C
	public int Param3; //Field offset: 0x20

	public HeqetMissionModel() { }

}

