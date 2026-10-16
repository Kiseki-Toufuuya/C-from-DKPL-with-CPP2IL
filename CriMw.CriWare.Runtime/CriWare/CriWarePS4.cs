namespace CriWare;

public class CriWarePS4
{
	internal enum AudioPortAttribute
	{
		Normal = 0,
		Restricted = 65536,
		MixToMain = 131072,
	}

	internal enum AudioPortType
	{
		Main = 0,
		Bgm = 1,
		Voice = 2,
		Personal = 3,
		PadSpeaker = 4,
		Aux = 127,
	}

	public const int systemUserID = 255; //Field offset: 0x0
	public const int bgmRackID = 1; //Field offset: 0x0

	public CriWarePS4() { }

	public static bool IsBgmOverridden() { }

}

