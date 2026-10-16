namespace Heqet;

public class CueSheetDef
{
	internal enum CueSheetID
	{
		SE_COMMON = 1,
		SE_DIR = 2,
		SE_INGAME = 3,
		SE_OUTGAME = 4,
	}

	public static String[] CueSheetNameList; //Field offset: 0x0
	public const int Denom = 100000; //Field offset: 0x0

	private static CueSheetDef() { }

	public CueSheetDef() { }

}

