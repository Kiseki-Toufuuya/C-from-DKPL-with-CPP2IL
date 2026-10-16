namespace UnityEngine.Localization.SmartFormat.Core.Extensions;

public interface ISelectorInfo
{

	public object CurrentValue
	{
		 get { } //Length: 0
	}

	[EditorBrowsable(EditorBrowsableState::Advanced (2))]
	public FormatDetails FormatDetails
	{
		 get { } //Length: 0
	}

	[EditorBrowsable(EditorBrowsableState::Advanced (2))]
	public Placeholder Placeholder
	{
		 get { } //Length: 0
	}

	public object Result
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public int SelectorIndex
	{
		 get { } //Length: 0
	}

	public string SelectorOperator
	{
		 get { } //Length: 0
	}

	public string SelectorText
	{
		 get { } //Length: 0
	}

	public object get_CurrentValue() { }

	public FormatDetails get_FormatDetails() { }

	public Placeholder get_Placeholder() { }

	public object get_Result() { }

	public int get_SelectorIndex() { }

	public string get_SelectorOperator() { }

	public string get_SelectorText() { }

	public void set_Result(object value) { }

}

