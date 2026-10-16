namespace XeSys.uGUI;

public class UIWrapperDropdown : UIWrapperBase
{
	private Dropdown m_Dropdown; //Field offset: 0x14
	private Action<Int32> m_onValueChanged; //Field offset: 0x18

	public Dropdown dropdown
	{
		 get { } //Length: 11
	}

	public List<OptionData> options
	{
		 get { } //Length: 111
	}

	public int value
	{
		 get { } //Length: 104
		 set { } //Length: 111
	}

	public UIWrapperDropdown() { }

	public void AddOptions(List<OptionData> options) { }

	public void ClearOptions() { }

	public static UIWrapperDropdown CreateDropdown(GameObject root, string dropdownName, Action<Int32> onValueChanged = null) { }

	public Dropdown get_dropdown() { }

	public List<OptionData> get_options() { }

	public int get_value() { }

	public void Hide() { }

	public void InitDropdown(GameObject root, string dropdownName, Action<Int32> onValueChanged = null) { }

	private void onValueChangedProc(int val) { }

	public void set_value(int value) { }

	public void SetOnValueChanged(Action<Int32> onValueChanged) { }

	public void Show() { }

}

