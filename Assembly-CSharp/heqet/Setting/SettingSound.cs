namespace Heqet.Setting;

public class SettingSound : SettingBase
{
	private const string ROOT_HEADER_SOUND = "root/header/btn_sound"; //Field offset: 0x0
	private SettingSoundDisp m_Disp; //Field offset: 0x20
	private SettingHeaderDisp m_HeaderDisp; //Field offset: 0x24
	private SetupParam m_SaveData; //Field offset: 0x28

	public SettingSound(SettingSoundDisp _sound, SettingHeaderDisp _header) { }

	public void InitUpdateBefore() { }

	public bool IsChangeData() { }

	private void OnChangeDropdownValue(int _id, int _value) { }

	private void OnChangeSliderValue(int _id, float _value) { }

	public virtual void Reset(int _tab) { }

	public void ResetSound() { }

	public void Save() { }

	public virtual void SetupDisp() { }

	private void ValueChangeStageSelectMusic(int _value) { }

	private void ValueChangeVolumeDanmakuSe(float _value) { }

	private void ValueChangeVolumeMusic(float _value) { }

	private void ValueChangeVolumeSe(float _value) { }

	private void ValueChangeVolumeSystem(float _value) { }

	private void ValueChangeVolumeTapSe(float _value) { }

}

