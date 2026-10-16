namespace XeApp.Game.Net;

public class SkillModel : EntityBase<SkillModel, Int32>
{
	internal enum eType
	{
		Barrage = 0,
		Support = 1,
		Score = 2,
		Other = 3,
	}

	public int ID; //Field offset: 0xC
	public string Name; //Field offset: 0x10
	public string Description; //Field offset: 0x14
	public int GimmickID1; //Field offset: 0x18
	public int GimmickID2; //Field offset: 0x1C
	public int GimmickID3; //Field offset: 0x20

	public SkillModel() { }

}

