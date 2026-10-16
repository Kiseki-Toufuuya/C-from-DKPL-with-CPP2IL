namespace Heqet.Setting;

public class SettingOther : SettingBase
{
	private const string ROOT_HEARDER_OTHER = "root/header/btn_other"; //Field offset: 0x0
	private SettingOtherDisp m_Disp; //Field offset: 0x20
	private SettingHeaderDisp m_HeaderDisp; //Field offset: 0x24
	private LicenseUIDisp m_LicenseUIDisp; //Field offset: 0x28
	private SetupParam m_SaveData; //Field offset: 0x2C
	[CompilerGenerated]
	private Action<Boolean> <DispLiscenseWindowCallback>k__BackingField; //Field offset: 0x30

	public Action<Boolean> DispLiscenseWindowCallback
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public SettingOther(SettingOtherDisp _other, SettingHeaderDisp _header, LicenseUIDisp _license) { }

	[CompilerGenerated]
	private void <.ctor>b__9_0(AssetBundleLoadAssetOperation ope) { }

	public bool CheckChangeDisplaydata() { }

	private void DisplaymodeValueChange(int _value) { }

	private void FrameRateValueChange(int _value) { }

	[CompilerGenerated]
	public Action<Boolean> get_DispLiscenseWindowCallback() { }

	public void InitUpdateBefore() { }

	public bool IsChangeData() { }

	private void NovelTextSpeedValueChange(float _value) { }

	private void OnChangeDropdownValue(int _id, int _value) { }

	private void OnChangeSliderValue(int _id, float _value) { }

	private void OnPointerClickDropdown(int _id) { }

	private void OnPressButton(int _id) { }

	private void OnPressDisplayPage(bool _value) { }

	private void OnPressLicense() { }

	private void OnPressLicenseBack(int _id) { }

	public void OnUpdateResorution(int _mode, int _width, int _height) { }

	public virtual void Reset(int _tab) { }

	private void ResolutionValueChange(int _value) { }

	public void Save() { }

	[CompilerGenerated]
	public void set_DispLiscenseWindowCallback(Action<Boolean> value) { }

	public virtual void SetupDisp() { }

	public void SetupWindowType() { }

	private void TextSpeedValueChange(float _value) { }

}

