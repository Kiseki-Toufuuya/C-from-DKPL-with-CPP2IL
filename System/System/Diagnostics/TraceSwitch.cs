namespace System.Diagnostics;

[SwitchLevel(typeof(TraceLevel))]
public class TraceSwitch : Switch
{

	public TraceSwitch(string displayName, string description) { }

	protected virtual void OnSwitchSettingChanged() { }

	protected virtual void OnValueChanged() { }

}

