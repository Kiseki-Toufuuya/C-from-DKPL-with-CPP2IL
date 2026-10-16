namespace XeApp.Game;

public class AdvBgUiDisp : DispBase
{
	private enum eLayerId
	{
		BASE_NUM = 0,
		TEXT_NUM = 1,
	}

	private static readonly String[] m_LayerIdList; //Field offset: 0x0
	private AdvScrBtnLayer m_Layer; //Field offset: 0x114
	private Image BgImag; //Field offset: 0x118
	private eComBgInsertShakeType m_shakeType; //Field offset: 0x11C
	private float m_euler; //Field offset: 0x120
	private float m_shakeSpeed; //Field offset: 0x124
	private float m_shakePower; //Field offset: 0x128
	private float m_shakeDelayTime; //Field offset: 0x12C
	private float m_shakeTime; //Field offset: 0x130
	private bool m_shakeLoopFlg; //Field offset: 0x134
	private bool m_shakeFlg; //Field offset: 0x135
	private Vector3 m_shakePos; //Field offset: 0x138
	private Vector3 m_shakeTargetPos; //Field offset: 0x144
	private Vector3 m_shakeMoveVec; //Field offset: 0x150

	private static AdvBgUiDisp() { }

	public AdvBgUiDisp() { }

	private void CallbackInitLayout() { }

	public void ChangeBackGroundColor(Color color) { }

	public bool CheckDelay(bool flg) { }

	public bool CheckStop(bool flg) { }

	public virtual void Create(LayerBase parent_layer) { }

	public bool GetShakeStopFlg() { }

	protected virtual void InitUguiOther() { }

	protected virtual void LateUpdate() { }

	public void SetBackGround(Sprite bgSprite) { }

	public void ShakePrepareStop() { }

	public void ShakeStart(int type, float speed, float power, float delayTime, float time) { }

	public void ShakeStop() { }

	public void ShakeUpdate() { }

	protected virtual void UpdateDispMain() { }

}

