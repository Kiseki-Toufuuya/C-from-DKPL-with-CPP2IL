namespace UnityEngine.Localization.SmartFormat.Extensions;

public class TimeFormatter : FormatterBase
{
	[SerializeField]
	private TimeSpanFormatOptions m_DefaultFormatOptions; //Field offset: 0xC
	private string m_DefaultTwoLetterIsoLanguageName; //Field offset: 0x10

	public TimeSpanFormatOptions DefaultFormatOptions
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public virtual String[] DefaultNames
	{
		 get { } //Length: 214
	}

	public string DefaultTwoLetterISOLanguageName
	{
		 get { } //Length: 11
		 set { } //Length: 176
	}

	public TimeFormatter() { }

	public TimeSpanFormatOptions get_DefaultFormatOptions() { }

	public virtual String[] get_DefaultNames() { }

	public string get_DefaultTwoLetterISOLanguageName() { }

	private TimeTextInfo GetTimeTextInfo(IFormatProvider provider) { }

	public void set_DefaultFormatOptions(TimeSpanFormatOptions value) { }

	public void set_DefaultTwoLetterISOLanguageName(string value) { }

	public virtual bool TryEvaluateFormat(IFormattingInfo formattingInfo) { }

}

