namespace XeApp.Game.Net;

public class HeroineModel : EntityBase<HeroineModel, Int32>
{
	internal enum ANIMATION_TYPE
	{
		TYPE_A = 1,
		TYPE_B = 2,
		TYPE_C = 3,
		TYPE_D = 4,
		TYPE_E = 5,
		TYPE_F = 6,
		TYPE_G = 7,
		TYPE_H = 8,
		TYPE_I = 9,
		TYPE_J = 10,
		TYPE_K = 11,
		TYPE_L = 12,
		TYPE_M = 13,
		TYPE_N = 14,
		TYPE_SPECIAL = 15,
	}

	internal class MenuVoiceText
	{
		public int ID; //Field offset: 0x8
		public string Text; //Field offset: 0xC
		public int VoiceID; //Field offset: 0x10

		public MenuVoiceText() { }

	}

	internal enum PersonalityType
	{
		Calm = 1,
		Classy = 2,
		Personal03 = 3,
		Personal04 = 4,
		Personal05 = 5,
		Personal06 = 6,
		Personal07 = 7,
		Personal08 = 8,
		Personal09 = 9,
		Personal10 = 10,
		Personal11 = 11,
		Personal12 = 12,
		Personal13 = 13,
		Personal14 = 14,
		Special = 15,
	}

	public int ID; //Field offset: 0xC
	public int SortNo; //Field offset: 0x10
	public int Enable; //Field offset: 0x14
	public int DataVersion; //Field offset: 0x18
	public int CharaType; //Field offset: 0x1C
	public int CharaID; //Field offset: 0x20
	public int ImageID; //Field offset: 0x24
	public string IllustratorName; //Field offset: 0x28
	public string AblityName; //Field offset: 0x2C
	public string FlavorText; //Field offset: 0x30
	public string MenuText1; //Field offset: 0x34
	public string MenuText2; //Field offset: 0x38
	public string MenuText3; //Field offset: 0x3C
	public string MenuText4; //Field offset: 0x40
	public int VoiceID1; //Field offset: 0x44
	public int VoiceID2; //Field offset: 0x48
	public int VoiceID3; //Field offset: 0x4C
	public String[2] MenuPose1; //Field offset: 0x50
	public String[2] MenuPose2; //Field offset: 0x54
	public int DecomposeItemID; //Field offset: 0x58
	public int Personality; //Field offset: 0x5C
	public int AnimationType; //Field offset: 0x60
	public int PartyWalk; //Field offset: 0x64
	public Int32[] NgEmotion; //Field offset: 0x68
	public Int32[] NgInteractObject; //Field offset: 0x6C
	public string PartyItem; //Field offset: 0x70
	public float SDTalkSpeed; //Field offset: 0x74
	public float SDTalkDispTime; //Field offset: 0x78
	public float SDFlyUpWaitTime; //Field offset: 0x7C
	public float SDFlyDownWaitTime; //Field offset: 0x80
	public float SDMoveSpeed; //Field offset: 0x84
	public float SDPartyMoveSpeed; //Field offset: 0x88
	public int SDOption; //Field offset: 0x8C

	public HeroineModel() { }

	public int GetExchangeAddExp() { }

	public int GetFragmentId() { }

	public static int GetHeroineModelAllNum(bool test = false) { }

	public static HeroineModel GetHeroineModelFronCharaID(int charaId, bool test = false) { }

}

