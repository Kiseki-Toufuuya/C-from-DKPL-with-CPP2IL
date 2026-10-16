namespace UnityEngine.Localization.SmartFormat;

internal class SmartFormatterLiteralCharacterExtractor : SmartFormatter
{
	private IEnumerable<Char> m_Characters; //Field offset: 0x20

	public SmartFormatterLiteralCharacterExtractor(SmartFormatter parent) { }

	public IEnumerable<Char> ExtractLiteralsCharacters(string value) { }

	public virtual void Format(FormattingInfo formattingInfo) { }

}

