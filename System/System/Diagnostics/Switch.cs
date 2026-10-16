namespace System.Diagnostics;

public abstract class Switch
{
	private static List<WeakReference> switches; //Field offset: 0x0
	private static int s_LastCollectionCount; //Field offset: 0x4
	private object switchSettings; //Field offset: 0x8
	private readonly string description; //Field offset: 0xC
	private readonly string displayName; //Field offset: 0x10
	private int switchSetting; //Field offset: 0x14
	private bool initialized; //Field offset: 0x18
	private bool initializing; //Field offset: 0x19
	private string switchValueString; //Field offset: 0x1C
	private string defaultValue; //Field offset: 0x20
	private object m_intializedLock; //Field offset: 0x24

	private object IntializedLock
	{
		private get { } //Length: 86
	}

	protected int SwitchSetting
	{
		 get { } //Length: 62
		 set { } //Length: 313
	}

	protected string Value
	{
		 get { } //Length: 31
	}

	private static void _pruneCachedSwitches() { }

	private static Switch() { }

	protected Switch(string displayName, string description) { }

	protected Switch(string displayName, string description, string defaultSwitchValue) { }

	private object get_IntializedLock() { }

	protected int get_SwitchSetting() { }

	protected string get_Value() { }

	private void Initialize() { }

	private bool InitializeConfigSettings() { }

	private bool InitializeWithStatus() { }

	protected override void OnSwitchSettingChanged() { }

	protected override void OnValueChanged() { }

	protected void set_SwitchSetting(int value) { }

}

