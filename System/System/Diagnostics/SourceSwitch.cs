namespace System.Diagnostics;

public class SourceSwitch : Switch
{

	public SourceLevels Level
	{
		 get { } //Length: 62
		 set { } //Length: 16
	}

	public SourceSwitch(string displayName, string defaultSwitchValue) { }

	public SourceLevels get_Level() { }

	protected virtual void OnValueChanged() { }

	public void set_Level(SourceLevels value) { }

}

