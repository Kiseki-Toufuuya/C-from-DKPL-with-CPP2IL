namespace Heqet;

public class HeqetCardModel : EntityBase<HeqetCardModel, Int32>
{
	internal enum eAttribute
	{
		Em = 0,
		Co = 1,
		Ro = 2,
		All = 3,
	}

	private enum eGrowthType
	{
		None = 0,
		EarlyMaturity01 = 1,
		EarlyMaturity02 = 2,
		LateMaturity01 = 3,
		LateMaturity02 = 4,
	}

	public static int levelMax; //Field offset: 0x0
	private static int levelMin; //Field offset: 0x4
	private static Single[] factor1Types; //Field offset: 0x8
	private static Single[] factor2Types; //Field offset: 0xC
	public int ID; //Field offset: 0xC
	public int Number; //Field offset: 0x10
	public int HeroineID; //Field offset: 0x14
	public int ImageID; //Field offset: 0x18
	public int Rarity; //Field offset: 0x1C
	public eAttribute Attribute; //Field offset: 0x20
	public int PlayerStock; //Field offset: 0x24
	public int BombStock; //Field offset: 0x28
	public int CardSkilID; //Field offset: 0x2C
	public string SecondName; //Field offset: 0x30
	public string IllustratorName; //Field offset: 0x34
	public string FlavorText; //Field offset: 0x38
	public int SkillType; //Field offset: 0x3C
	public int GrowthType; //Field offset: 0x40
	public int LifeMin; //Field offset: 0x44
	public int LifeMax; //Field offset: 0x48
	public int PowerMin; //Field offset: 0x4C
	public int PowerMax; //Field offset: 0x50
	public HeqetHeroineModel heqetHeroineModel; //Field offset: 0x54

	private static HeqetCardModel() { }

	public HeqetCardModel() { }

	private static float EarlyMaturityFormula(int level, float factor1, int minParam, int maxParam) { }

	public int GetLife(int level) { }

	public int GetPower(int level) { }

	public string GetSkillTypeString() { }

	private static float LateMaturityFormula(int level, float factor1, float factor2, int minParam, int maxParam) { }

}

