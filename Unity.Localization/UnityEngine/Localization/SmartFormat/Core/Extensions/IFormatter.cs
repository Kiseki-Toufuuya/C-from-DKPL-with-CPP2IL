namespace UnityEngine.Localization.SmartFormat.Core.Extensions;

public interface IFormatter
{

	public String[] Names
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public String[] get_Names() { }

	public void set_Names(String[] value) { }

	public bool TryEvaluateFormat(IFormattingInfo formattingInfo) { }

}

