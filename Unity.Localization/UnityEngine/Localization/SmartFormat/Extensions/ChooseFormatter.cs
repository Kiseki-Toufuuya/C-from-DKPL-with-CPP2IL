namespace UnityEngine.Localization.SmartFormat.Extensions;

public class ChooseFormatter : FormatterBase, IFormatterLiteralExtractor
{
	[SerializeField]
	private char m_SplitChar; //Field offset: 0xC

	public virtual String[] DefaultNames
	{
		 get { } //Length: 140
	}

	public char SplitChar
	{
		 get { } //Length: 12
		 set { } //Length: 16
	}

	public ChooseFormatter() { }

	private static Format DetermineChosenFormat(IFormattingInfo formattingInfo, IList<Format> choiceFormats, String[] chooseOptions) { }

	public virtual String[] get_DefaultNames() { }

	public char get_SplitChar() { }

	public void set_SplitChar(char value) { }

	public virtual bool TryEvaluateFormat(IFormattingInfo formattingInfo) { }

	public override void WriteAllLiterals(IFormattingInfo formattingInfo) { }

}

