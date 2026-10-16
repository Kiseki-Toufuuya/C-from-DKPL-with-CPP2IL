namespace XeApp.Game;

public class CommonEffectDefine
{
	public const int EFF_TAP_EFFECT = 1; //Field offset: 0x0
	public const int EFF_TAP_NORMAL_FLASH_01 = 2; //Field offset: 0x0
	public const int EFF_TAP_SLIDE_EFFECT = 3; //Field offset: 0x0
	public const int EFF_EFF_RECONSTRUCT_UP_09_01 = 4; //Field offset: 0x0
	public const int EFF_SCORE_PLAYER_LV_01 = 5; //Field offset: 0x0
	public const int EFF_SETTING_TAP_01 = 6; //Field offset: 0x0
	public static String[] labelName; //Field offset: 0x0

	private static CommonEffectDefine() { }

	public CommonEffectDefine() { }

	public static int GetEffectNo(string effectName) { }

}

