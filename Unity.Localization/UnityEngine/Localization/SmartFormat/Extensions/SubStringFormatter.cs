namespace UnityEngine.Localization.SmartFormat.Extensions;

public class SubStringFormatter : FormatterBase
{
	internal enum SubStringOutOfRangeBehavior
	{
		ReturnEmptyString = 0,
		ReturnStartIndexToEndOfString = 1,
		ThrowException = 2,
	}

	[SerializeField]
	private char m_ParameterDelimiter; //Field offset: 0xC
	[SerializeField]
	private string m_NullDisplayString; //Field offset: 0x10
	[SerializeField]
	private SubStringOutOfRangeBehavior m_OutOfRangeBehavior; //Field offset: 0x14

	public virtual String[] DefaultNames
	{
		 get { } //Length: 103
	}

	public string NullDisplayString
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public SubStringOutOfRangeBehavior OutOfRangeBehavior
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public char ParameterDelimiter
	{
		 get { } //Length: 12
		 set { } //Length: 16
	}

	public SubStringFormatter() { }

	public virtual String[] get_DefaultNames() { }

	public string get_NullDisplayString() { }

	public SubStringOutOfRangeBehavior get_OutOfRangeBehavior() { }

	public char get_ParameterDelimiter() { }

	public void set_NullDisplayString(string value) { }

	public void set_OutOfRangeBehavior(SubStringOutOfRangeBehavior value) { }

	public void set_ParameterDelimiter(char value) { }

	public virtual bool TryEvaluateFormat(IFormattingInfo formattingInfo) { }

}

