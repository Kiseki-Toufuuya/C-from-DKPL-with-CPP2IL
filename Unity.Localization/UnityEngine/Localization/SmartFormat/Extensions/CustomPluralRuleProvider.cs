namespace UnityEngine.Localization.SmartFormat.Extensions;

public class CustomPluralRuleProvider : IFormatProvider
{
	private readonly PluralRuleDelegate _pluralRule; //Field offset: 0x8

	public CustomPluralRuleProvider(PluralRuleDelegate pluralRule) { }

	public override object GetFormat(Type formatType) { }

	public PluralRuleDelegate GetPluralRule() { }

}

