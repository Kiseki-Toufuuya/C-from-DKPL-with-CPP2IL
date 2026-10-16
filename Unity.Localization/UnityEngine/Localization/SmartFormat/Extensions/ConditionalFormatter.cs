namespace UnityEngine.Localization.SmartFormat.Extensions;

public class ConditionalFormatter : FormatterBase, IFormatterLiteralExtractor
{
	private static readonly Regex _complexConditionPattern; //Field offset: 0x0

	public virtual String[] DefaultNames
	{
		 get { } //Length: 177
	}

	private static ConditionalFormatter() { }

	public ConditionalFormatter() { }

	public virtual String[] get_DefaultNames() { }

	private static bool TryEvaluateCondition(Format parameter, decimal value, out bool conditionResult, out Format outputItem) { }

	public virtual bool TryEvaluateFormat(IFormattingInfo formattingInfo) { }

	public override void WriteAllLiterals(IFormattingInfo formattingInfo) { }

}

