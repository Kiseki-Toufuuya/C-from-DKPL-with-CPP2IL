namespace XeApp.Game;

public class AdvMessageBoxDisp : DispBase
{
	private enum eLayerId
	{
		BASE_NUM = 0,
		TEXT_NAME = 0,
		TEXT_MESSAGE = 1,
		TEXT_NUM = 2,
	}

	internal enum MessageBoxAnimeType
	{
		In = 0,
		Out = 1,
	}

	internal enum MessageBoxUiState
	{
		Wait = 0,
		MenuOpen = 1,
		MenuClose = 2,
	}

	private static readonly String[] m_LayerIdList; //Field offset: 0x0
	private AdvMessageBoxLayer m_Layer; //Field offset: 0x114
	private MessageBoxUiState State; //Field offset: 0x118
	private GameObject ArrowImage; //Field offset: 0x11C
	private GameObject AutoImage; //Field offset: 0x120
	private Animator RootAnimator; //Field offset: 0x124
	private Animator ArrowAnimator; //Field offset: 0x128
	private eComBgInsertShakeType m_shakeType; //Field offset: 0x12C
	private float m_euler; //Field offset: 0x130
	private float m_shakeSpeed; //Field offset: 0x134
	private float m_shakePower; //Field offset: 0x138
	private float m_shakeDelayTime; //Field offset: 0x13C
	private float m_shakeTime; //Field offset: 0x140
	private bool m_shakeLoopFlg; //Field offset: 0x144
	private bool m_shakeFlg; //Field offset: 0x145
	private Vector3 m_shakePos; //Field offset: 0x148
	private Vector3 m_shakeTargetPos; //Field offset: 0x154
	private Vector3 m_shakeMoveVec; //Field offset: 0x160
	public eCanvas m_Canvas; //Field offset: 0x16C

	private static AdvMessageBoxDisp() { }

	public AdvMessageBoxDisp() { }

	private void CallbackInitLayout() { }

	public bool CheckDelay(bool flg) { }

	public bool CheckStop(bool flg) { }

	public virtual void Create(LayerBase parent_layer) { }

	public bool GetShakeStopFlg() { }

	protected virtual void InitUguiOther() { }

	public bool IsClose() { }

	public bool IsPlayingAnime() { }

	protected virtual void LateUpdate() { }

	public void SetAutoImg(bool enable) { }

	public void SetMessage(string message) { }

	public void SetMessageNextArrow(bool enable) { }

	public void SetTalkName(string name) { }

	public void ShakePrepareStop() { }

	public void ShakeStart(int type, float speed, float power, float delayTime, float time) { }

	public void ShakeStop() { }

	public void ShakeUpdate() { }

	public void StartMessageBoxAnime(MessageBoxAnimeType type) { }

	protected virtual void UpdateDispMain() { }

}

