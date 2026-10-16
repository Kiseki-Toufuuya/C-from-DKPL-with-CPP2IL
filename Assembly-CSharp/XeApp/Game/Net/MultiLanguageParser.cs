namespace XeApp.Game.Net;

public class MultiLanguageParser
{
	public bool IsPreparation; //Field offset: 0x8
	public bool IsEndOfService; //Field offset: 0x9
	public string Message; //Field offset: 0xC

	public MultiLanguageParser() { }

	public void Parse(string text, string languageCode) { }

	public void Reset() { }

}

