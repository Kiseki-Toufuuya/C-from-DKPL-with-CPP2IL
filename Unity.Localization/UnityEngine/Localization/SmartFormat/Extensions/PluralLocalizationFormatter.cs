namespace UnityEngine.Localization.SmartFormat.Extensions;

public class PluralLocalizationFormatter : FormatterBase, IFormatterLiteralExtractor
{
	[SerializeField]
	private string m_DefaultTwoLetterISOLanguageName; //Field offset: 0xC
	private PluralRuleDelegate m_DefaultPluralRule; //Field offset: 0x10

	public virtual String[] DefaultNames
	{
		 get { } //Length: 177
	}

	public string DefaultTwoLetterISOLanguageName
	{
		 get { } //Length: 11
		 set { } //Length: 104
	}

	public PluralLocalizationFormatter() { }

	public virtual String[] get_DefaultNames() { }

	public string get_DefaultTwoLetterISOLanguageName() { }

	protected override PluralRuleDelegate GetPluralRule(IFormattingInfo formattingInfo) { }

	public void set_DefaultTwoLetterISOLanguageName(string value) { }

	public virtual bool TryEvaluateFormat(IFormattingInfo formattingInfo) { }

	public override void WriteAllLiterals(IFormattingInfo formattingInfo) { }

}

