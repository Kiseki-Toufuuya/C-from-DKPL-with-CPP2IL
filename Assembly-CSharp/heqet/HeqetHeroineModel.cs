namespace Heqet;

public class HeqetHeroineModel : EntityBase<HeqetHeroineModel, Int32>
{
	public int ID; //Field offset: 0xC
	public int DlcID; //Field offset: 0x10
	public bool ListDisplay; //Field offset: 0x14
	public int Number; //Field offset: 0x18
	public string SecondName; //Field offset: 0x1C
	public string Name; //Field offset: 0x20
	public string NameYomi; //Field offset: 0x24
	public string ShortName; //Field offset: 0x28
	public string IllustratorName; //Field offset: 0x2C
	public string FlavorText; //Field offset: 0x30
	public int DanmakuID; //Field offset: 0x34
	public int SkillType; //Field offset: 0x38
	public Int32[] SkinArray; //Field offset: 0x3C
	public Int32[] SeriesArray; //Field offset: 0x40
	public HeroineDanmakuParamModel danmakuModel; //Field offset: 0x44

	public HeqetHeroineModel() { }

}

