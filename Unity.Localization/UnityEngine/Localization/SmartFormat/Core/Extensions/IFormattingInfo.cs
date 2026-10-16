namespace UnityEngine.Localization.SmartFormat.Core.Extensions;

public interface IFormattingInfo
{

	public int Alignment
	{
		 get { } //Length: 0
	}

	public object CurrentValue
	{
		 get { } //Length: 0
	}

	public Format Format
	{
		 get { } //Length: 0
	}

	[EditorBrowsable(EditorBrowsableState::Advanced (2))]
	public FormatDetails FormatDetails
	{
		 get { } //Length: 0
	}

	public string FormatterOptions
	{
		 get { } //Length: 0
	}

	[EditorBrowsable(EditorBrowsableState::Advanced (2))]
	public Placeholder Placeholder
	{
		 get { } //Length: 0
	}

	public FormattingException FormattingException(string issue, FormatItem problemItem = null, int startIndex = -1) { }

	public int get_Alignment() { }

	public object get_CurrentValue() { }

	public Format get_Format() { }

	public FormatDetails get_FormatDetails() { }

	public string get_FormatterOptions() { }

	public Placeholder get_Placeholder() { }

	public void Write(string text) { }

	public void Write(string text, int startIndex, int length) { }

	public void Write(Format format, object value) { }

}

