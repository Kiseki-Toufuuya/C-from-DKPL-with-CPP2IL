namespace Heqet.RG;

public class BlindDisp : DispBase
{
	private const float MAX_KAGURA_HEIGHT = 732; //Field offset: 0x0
	private const float MAX_DANMAKU_HEIGHT = 748; //Field offset: 0x0
	private const float MAX_KAGURA_TOUCH_HEIGHT = 506; //Field offset: 0x0
	private const string SUDDEN_SPRITE = "sudden"; //Field offset: 0x0
	private const string SUDDEN_LEFT_SPRITE = "sudden_left"; //Field offset: 0x0
	private const string SUDDEN_RIGHT_SPRITE = "sudden_right"; //Field offset: 0x0
	private const string HIDDEN_SPRITE = "hidden"; //Field offset: 0x0
	private const string HIDDEN_LEFT_SPRITE = "hidden_left"; //Field offset: 0x0
	private const string HIDDEN_RIGHT_SPRITE = "hidden_right"; //Field offset: 0x0
	private bool m_IsKaguraLayer; //Field offset: 0x114

	public BlindDisp() { }

	public virtual void Create(LayerBase parent_layer) { }

	private void InitLayout() { }

	protected virtual void LateUpdate() { }

	public void SetupParam(SettingData settingData) { }

	protected virtual void UpdateDispMain() { }

}

