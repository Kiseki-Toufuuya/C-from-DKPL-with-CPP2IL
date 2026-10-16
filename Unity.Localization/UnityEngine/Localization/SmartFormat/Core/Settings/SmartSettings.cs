namespace UnityEngine.Localization.SmartFormat.Core.Settings;

public class SmartSettings
{
	[SerializeField]
	private ErrorAction m_FormatErrorAction; //Field offset: 0x8
	[SerializeField]
	private ErrorAction m_ParseErrorAction; //Field offset: 0xC
	[SerializeField]
	[Tooltip("Determines whether placeholders are case-sensitive or not.")]
	private CaseSensitivityType m_CaseSensitivity; //Field offset: 0x10
	[SerializeField]
	[Tooltip("This setting is relevant for the 'Parsing.LiteralText', If true (the default), character string literals are treated like in normal string.Format: string.Format(\"\t\") will return a \"TAB\" character If false, character string literals are not converted, just like with this string.Format: string.Format(@\"\t\") will return the 2 characters \"\" and \"t\"")]
	private bool m_ConvertCharacterStringLiterals; //Field offset: 0x14

	public CaseSensitivityType CaseSensitivity
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public bool ConvertCharacterStringLiterals
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public ErrorAction FormatErrorAction
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public ErrorAction ParseErrorAction
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	internal SmartSettings() { }

	public CaseSensitivityType get_CaseSensitivity() { }

	public bool get_ConvertCharacterStringLiterals() { }

	public ErrorAction get_FormatErrorAction() { }

	public ErrorAction get_ParseErrorAction() { }

	internal IEqualityComparer<String> GetCaseSensitivityComparer() { }

	internal StringComparison GetCaseSensitivityComparison() { }

	public void set_CaseSensitivity(CaseSensitivityType value) { }

	public void set_ConvertCharacterStringLiterals(bool value) { }

	public void set_FormatErrorAction(ErrorAction value) { }

	public void set_ParseErrorAction(ErrorAction value) { }

}

