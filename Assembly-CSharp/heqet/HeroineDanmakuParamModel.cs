namespace Heqet;

public class HeroineDanmakuParamModel : EntityBase<HeroineDanmakuParamModel, Int32>
{
	internal enum eShotType
	{
		Normal = 0,
		Penetrate = 1,
		Other = 2,
	}

	public int ID; //Field offset: 0xC
	public eShotType MainShot; //Field offset: 0x10
	public float MainShotDamageFactor; //Field offset: 0x14
	public eShotType ExtraShot; //Field offset: 0x18
	public float ExtraShotDamageFactor; //Field offset: 0x1C
	public int PlayerLife; //Field offset: 0x20
	public int PlayerStock; //Field offset: 0x24
	public int PlayerPower; //Field offset: 0x28
	public int BombStock; //Field offset: 0x2C
	public int BombPower; //Field offset: 0x30
	public int HeroineSkillID; //Field offset: 0x34
	public float MoveSpeed; //Field offset: 0x38
	public float DeadbombTime; //Field offset: 0x3C

	public HeroineDanmakuParamModel() { }

}

