namespace UnityEngine.Localization.SmartFormat.Core.Parsing;

public class Parser
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass24_0
	{
		public Format currentResult; //Field offset: 0x8

		public <>c__DisplayClass24_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass24_1
	{
		public int i; //Field offset: 0x8
		public <>c__DisplayClass24_0 CS$<>8__locals1; //Field offset: 0xC

		public <>c__DisplayClass24_1() { }

		internal bool <HandleParsingErrors>b__0(ParsingIssue errItem) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass24_2
	{
		public int i; //Field offset: 0x8
		public <>c__DisplayClass24_0 CS$<>8__locals2; //Field offset: 0xC

		public <>c__DisplayClass24_2() { }

		internal bool <HandleParsingErrors>b__1(ParsingIssue errItem) { }

	}

	internal enum ParsingError
	{
		TooManyClosingBraces = 1,
		TrailingOperatorsInSelector = 2,
		InvalidCharactersInSelector = 3,
		MissingClosingBrace = 4,
	}

	[DefaultMember("Item")]
	public class ParsingErrorText
	{
		private readonly Dictionary<ParsingError, String> _errors; //Field offset: 0x8

		public string Item
		{
			 get { } //Length: 67
		}

		internal ParsingErrorText() { }

		public string get_Item(ParsingError parsingErrorKey) { }

	}

	[SerializeField]
	[Tooltip("The character literal escape character e.g. for \t (TAB) and others. This is kind of overlapping functionality with `UseAlternativeEscapeChar` Note: In a future release escape characters for placeholders  and character literals should become the same.")]
	internal const char m_CharLiteralEscapeChar = '\u5C'; //Field offset: 0x0
	private static ParsingErrorText s_ParsingErrorText; //Field offset: 0x0
	[SerializeField]
	private char m_OpeningBrace; //Field offset: 0x8
	[SerializeField]
	private char m_ClosingBrace; //Field offset: 0xA
	[HideInInspector]
	[SerializeReference]
	private SmartSettings m_Settings; //Field offset: 0xC
	[SerializeField]
	[Tooltip("If false, only digits are allowed as selectors. If true, selectors can be alpha-numeric. This allows optimized alpha-character detection. Specify any additional selector chars in AllowedSelectorChars.")]
	private bool m_AlphanumericSelectors; //Field offset: 0x10
	[SerializeField]
	[Tooltip("A list of allowable selector characters, to support additional selector syntaxes such as math. Digits are always included, and letters can be included with AlphanumericSelectors.")]
	private string m_AllowedSelectorChars; //Field offset: 0x14
	[SerializeField]
	[Tooltip("A list of characters that come between selectors. This can be \".\" for dot-notation, \"[]\" for arrays, or even math symbols. By default, there are no operators.")]
	private string m_Operators; //Field offset: 0x18
	[SerializeField]
	[Tooltip("If false, double-curly braces are escaped. If true, the AlternativeEscapeChar is used for escaping braces.")]
	private bool m_AlternativeEscaping; //Field offset: 0x1C
	[SerializeField]
	[Tooltip("If AlternativeEscaping is true, then this character is used to escape curly braces.")]
	private char m_AlternativeEscapeChar; //Field offset: 0x1E
	[CompilerGenerated]
	private EventHandler<ParsingErrorEventArgs> OnParsingFailure; //Field offset: 0x20

	public event EventHandler<ParsingErrorEventArgs> OnParsingFailure
	{
		[CompilerGenerated]
		 add { } //Length: 125
		[CompilerGenerated]
		 remove { } //Length: 125
	}

	public SmartSettings Settings
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public Parser(SmartSettings settings) { }

	[CompilerGenerated]
	public void add_OnParsingFailure(EventHandler<ParsingErrorEventArgs> value) { }

	public void AddAdditionalSelectorChars(string chars) { }

	public void AddAlphanumericSelectors() { }

	public void AddOperators(string chars) { }

	private static bool FormatterNameExists(string name, IList<String> formatterExtensionNames) { }

	public SmartSettings get_Settings() { }

	private Format HandleParsingErrors(ParsingErrors parsingErrors, Format currentResult) { }

	public Format ParseFormat(string format, IList<String> formatterExtensionNames) { }

	[CompilerGenerated]
	public void remove_OnParsingFailure(EventHandler<ParsingErrorEventArgs> value) { }

	public void set_Settings(SmartSettings value) { }

	public void UseAlternativeBraces(char opening, char closing) { }

	public void UseAlternativeEscapeChar(char alternativeEscapeChar = \) { }

	public void UseBraceEscaping() { }

}

