namespace XeApp.Game;

public class LoginEffectDefine
{
	public const int EFF_LOGINBONUS_OMIKUJI = 1; //Field offset: 0x0
	public const int EFF_LOGINBONUS_BINGO_01 = 2; //Field offset: 0x0
	public const int EFF_LOGINBONUS_BINGO_02 = 3; //Field offset: 0x0
	public const int EFF_LOGINBONUS_BINGO_03 = 4; //Field offset: 0x0
	public static String[] labelName; //Field offset: 0x0

	private static LoginEffectDefine() { }

	public LoginEffectDefine() { }

	public static int GetEffectNo(string effectName) { }

}

