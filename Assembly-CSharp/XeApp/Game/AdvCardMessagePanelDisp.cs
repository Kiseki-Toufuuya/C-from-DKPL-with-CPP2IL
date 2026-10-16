namespace XeApp.Game;

public class AdvCardMessagePanelDisp : UiScrollListPanelBase
{
	private enum eLayerId
	{
		BASE_MES = 0,
		BASE_NUM = 1,
		TEXT_MES = 1,
		TEXT_NUM = 2,
	}

	private static readonly String[] m_LayerIdList; //Field offset: 0x0
	private const int SAMPLE_COUNT = 8; //Field offset: 0x0
	private AdvCardMessageLayer m_Layer; //Field offset: 0x130
	private AdvCardMessageOutlineLayer m_OutLineLayer; //Field offset: 0x134
	private Animator m_RootAnimator; //Field offset: 0x138
	private OneLineData m_NowData; //Field offset: 0x13C
	public bool m_isUpdateBlur; //Field offset: 0x140
	public float m_ShadowPower; //Field offset: 0x144
	public float m_Blur; //Field offset: 0x148

	private static AdvCardMessagePanelDisp() { }

	public AdvCardMessagePanelDisp() { }

	private void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent_layer) { }

	public void EndAnime() { }

	public Vector2 GetNowTextSize(string str = null) { }

	public virtual Vector2 GetPanelSize() { }

	public virtual Vector2 GetPanelSizeByIndex(int a_index) { }

	protected virtual void InitUguiOther() { }

	public bool IsPlayingAnime() { }

	protected virtual void LateUpdate() { }

	private void SetAdvText(string str) { }

	public virtual void SetData(int index, bool active) { }

	public void StartAnime(eALIGN_TAG align) { }

	private void UpdateBlur() { }

	protected virtual void UpdateDispMain() { }

}

