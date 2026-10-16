namespace XeApp.Game;

public class EmbeddedEffectDefine
{
	public const int EFF_TITLE_FLASH_01 = 1; //Field offset: 0x0
	public const int EFF_TITLE_FLASH_02 = 2; //Field offset: 0x0
	public const int EFF_TITLE_LOADING_01 = 3; //Field offset: 0x0
	public const int EFF_TITLE_KOKUTI_01 = 4; //Field offset: 0x0
	public const int EFF_TITLE_KOKUTI_02 = 5; //Field offset: 0x0
	public const int EFF_TITLE_KOKUTI_03 = 6; //Field offset: 0x0
	public const int EFF_TITLE_FLASH_01_01 = 7; //Field offset: 0x0
	public static String[] labelName; //Field offset: 0x0

	private static EmbeddedEffectDefine() { }

	public EmbeddedEffectDefine() { }

	public static int GetEffectNo(string effectName) { }

}

