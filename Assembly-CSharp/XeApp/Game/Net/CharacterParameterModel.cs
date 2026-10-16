namespace XeApp.Game.Net;

public class CharacterParameterModel : EntityBase<CharacterParameterModel, Int32>
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass42_0
	{
		public int charaId; //Field offset: 0x8
		public int imageId; //Field offset: 0xC

		public <>c__DisplayClass42_0() { }

		internal bool <GetHeroineModelFromCharaIDAndImageID>b__0(CharacterParameterModel e) { }

	}

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
		public bool MouceOff; //Field offset: 0x14

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
	public int Enable; //Field offset: 0x10
	public int DataVersion; //Field offset: 0x14
	public int CharaID; //Field offset: 0x18
	public int ImageID; //Field offset: 0x1C
	public string MenuText1; //Field offset: 0x20
	public string MenuText2; //Field offset: 0x24
	public string MenuText3; //Field offset: 0x28
	public string MenuText4; //Field offset: 0x2C
	public int VoiceID1; //Field offset: 0x30
	public int VoiceID2; //Field offset: 0x34
	public int VoiceID3; //Field offset: 0x38
	public int VoiceID4; //Field offset: 0x3C
	public int MouceOff1; //Field offset: 0x40
	public int MouceOff2; //Field offset: 0x44
	public int MouceOff3; //Field offset: 0x48
	public int MouceOff4; //Field offset: 0x4C
	public String[2] MenuPose1; //Field offset: 0x50
	public String[2] MenuPose2; //Field offset: 0x54
	public String[] MenuSdCharaPose1; //Field offset: 0x58
	public String[] MenuSdCharaPose2; //Field offset: 0x5C
	public int Personality; //Field offset: 0x60
	public int AnimationType; //Field offset: 0x64
	public int PartyWalk; //Field offset: 0x68
	public Int32[] NgEmotion; //Field offset: 0x6C
	public Int32[] NgInteractObject; //Field offset: 0x70
	public string PartyItem; //Field offset: 0x74
	public float SDTalkSpeed; //Field offset: 0x78
	public float SDTalkDispTime; //Field offset: 0x7C
	public float SDFlyUpWaitTime; //Field offset: 0x80
	public float SDFlyDownWaitTime; //Field offset: 0x84
	public float SDMoveSpeed; //Field offset: 0x88
	public float SDPartyMoveSpeed; //Field offset: 0x8C
	public int SDOption; //Field offset: 0x90
	public int SDDisableFlight; //Field offset: 0x94

	public CharacterParameterModel() { }

	public static CharacterParameterModel GetHeroineModelFromCharaIDAndImageID(int charaId, int imageId, bool test = false) { }

	public String[2] GetMenuPose() { }

	public String[2] GetMenuPoseSdChara() { }

	public String[] GetMenuText() { }

	public List<MenuVoiceText> GetMenuVoiceTexts() { }

	public string GetName() { }

	public static string GetSDMotionFileName(int charaId, int imageId, bool test = false) { }

	public string GetShowName() { }

}

