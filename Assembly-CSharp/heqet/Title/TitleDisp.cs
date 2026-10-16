namespace Heqet.Title;

public class TitleDisp : DispBase
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass25_0
	{
		public TextMeshProUGUI tmp; //Field offset: 0x8

		public <>c__DisplayClass25_0() { }

		internal void <GetTween>b__0() { }

		internal void <GetTween>b__1() { }

	}

	private enum eCommonLayerId
	{
		DlcNewIcon = 0,
		Max = 1,
	}

	private const float ButtonTweenTime = 0.2; //Field offset: 0x0
	private static readonly string s_MsgText; //Field offset: 0x0
	private static readonly string s_ButtonEFX; //Field offset: 0x4
	private static readonly string s_VersionText; //Field offset: 0x8
	private static readonly String[] m_LayerIdList; //Field offset: 0xC
	public Action<Int32> buttonOnClick; //Field offset: 0x114
	private readonly String[] m_ButtonDataList; //Field offset: 0x118
	private readonly String[] m_ButtonMsgLabel; //Field offset: 0x11C
	private String[] m_ButtonMsg; //Field offset: 0x120
	private TextMeshProUGUI[] m_ButtonTextLabel; //Field offset: 0x124
	private readonly String[] m_ButtonBorderList; //Field offset: 0x128
	private GameObject[] m_ButtonBorder; //Field offset: 0x12C
	private RectTransform m_BtnEFX; //Field offset: 0x130
	private TextMeshProUGUI m_BtnTipsText; //Field offset: 0x134
	private TextMeshProUGUI m_VersionText; //Field offset: 0x138
	private MoviePlayerUI m_moviePlayer; //Field offset: 0x13C
	private Dictionary<Int32, Tween> tweenTemp; //Field offset: 0x140

	private static TitleDisp() { }

	public TitleDisp() { }

	public void CallbackButton(int buttonIndex) { }

	private void CallbackDeselectButton(int buttonIndex, BaseEventData baseData) { }

	private void CallbackInitLayout() { }

	private void CallbackSelectButton(int buttonIndex, BaseEventData baseData) { }

	public virtual void Create(LayerBase parent_layer) { }

	public void FirstSelect(int index) { }

	private Tween GetTween(int index) { }

	protected virtual void InitUguiOther() { }

	public bool IsMovieReady() { }

	public bool IsVisibleExitButton() { }

	protected virtual void LateUpdate() { }

	public void PlayMovie() { }

	public virtual void ReleaseAll() { }

	public void SetContinueEnable(bool enable) { }

	public void SwitchSelectedImage(int prevButtonIndex, int nextButtonIndex) { }

	protected virtual void UpdateDispMain() { }

	public void VisibleExitButton(bool isEnable) { }

	public void VisibleNewDlcIcon(bool isVIsible) { }

}

