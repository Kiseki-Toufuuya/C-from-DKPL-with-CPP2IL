namespace UnityEngine.Localization.SmartFormat.Extensions;

public class IsMatchFormatter : FormatterBase, IFormatterLiteralExtractor
{
	[CompilerGenerated]
	private RegexOptions <RegexOptions>k__BackingField; //Field offset: 0xC

	public virtual String[] DefaultNames
	{
		 get { } //Length: 103
	}

	public RegexOptions RegexOptions
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public IsMatchFormatter() { }

	public virtual String[] get_DefaultNames() { }

	[CompilerGenerated]
	public RegexOptions get_RegexOptions() { }

	[CompilerGenerated]
	public void set_RegexOptions(RegexOptions value) { }

	public virtual bool TryEvaluateFormat(IFormattingInfo formattingInfo) { }

	public override void WriteAllLiterals(IFormattingInfo formattingInfo) { }

}

