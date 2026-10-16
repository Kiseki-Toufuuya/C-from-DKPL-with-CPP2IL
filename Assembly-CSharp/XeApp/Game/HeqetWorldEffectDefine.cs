namespace XeApp.Game;

public class HeqetWorldEffectDefine
{
	public const int EFF_SPOT_RECONSTRUCTION = 1; //Field offset: 0x0
	public const int EFF_STAGE_TREASURE_GET = 2; //Field offset: 0x0
	public const int EFF_SPOT_LANDMARK_SELECT = 3; //Field offset: 0x0
	public const int EFF_STAGE_CHARA_PUT = 4; //Field offset: 0x0
	public const int EFF_STAGE_STAGEPANEL_IN = 5; //Field offset: 0x0
	public const int EFF_STAGE_STAGEPANEL_PUT = 6; //Field offset: 0x0
	public const int EFF_STAGE_BONUS_STAGE_IN = 7; //Field offset: 0x0
	public const int EFF_STAGE_EPISODE_STAGE_IN = 8; //Field offset: 0x0
	public static String[] labelName; //Field offset: 0x0

	private static HeqetWorldEffectDefine() { }

	public HeqetWorldEffectDefine() { }

	public static int GetEffectNo(string effectName) { }

}

