namespace Heqet.Title;

public class TitleLayer : LayerBase
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<ButtonType> <>9__39_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal void <OnExitClick>b__39_0(ButtonType btnId) { }

	}

	private enum eMainStep
	{
		FADE_IN = 0,
		MAIN = 1,
		RESET_DATA_DIALOG = 2,
		SELECT_LAYOUT_DIALOG = 3,
		WAIT_GALLERY = 4,
		WAIT_CREDIT = 5,
		WAIT_OPTION = 6,
		WAIT_DLC_DIALOG = 7,
		WAIT_EXIT_DIALOG = 8,
		GO_TO_PROLOGUE = 9,
		GO_TO_STORY_MODE = 10,
		GO_TO_FREE_MODE = 11,
		NONE = 12,
	}

	private TitleDisp m_TitleDisp; //Field offset: 0x58
	private InputActionReference m_InputActionNavigate; //Field offset: 0x5C
	private InputActionReference m_InputActionSubmit; //Field offset: 0x60
	private InputActionReference m_InputActionCancel; //Field offset: 0x64
	private InputActionReference m_InputActionTabLeft; //Field offset: 0x68
	private InputActionReference m_InputActionTabRight; //Field offset: 0x6C
	private int m_CurSelectedIndex; //Field offset: 0x70
	private bool m_CancelSelectLayout; //Field offset: 0x74
	private eMainStep m_MainStep; //Field offset: 0x78

	public virtual bool IS_DISP_BACKGROUND
	{
		 get { } //Length: 3
	}

	public virtual bool IS_TOUCH_BACKGROUND
	{
		 get { } //Length: 3
	}

	public virtual bool IS_UPDATE_BACKGROUND
	{
		 get { } //Length: 3
	}

	public TitleLayer() { }

	[CompilerGenerated]
	private void <OpenLayoutSelectDialog>b__40_0(int button_id) { }

	private void ButtonOnClick(int buttonIndex) { }

	public bool CanContinue() { }

	private bool CheckEnableButton(int selectIndex) { }

	protected virtual bool EndUpdateAfter() { }

	public virtual bool get_IS_DISP_BACKGROUND() { }

	public virtual bool get_IS_TOUCH_BACKGROUND() { }

	public virtual bool get_IS_UPDATE_BACKGROUND() { }

	private void GotoPrologue() { }

	protected virtual void InitAll() { }

	protected virtual bool InitResourceWait() { }

	protected virtual bool InitSubResourceWait() { }

	protected virtual bool InitUpdateBefore() { }

	protected virtual void LateUpdate(bool is_active) { }

	private void OnContinueClick() { }

	private void OnCreditClick() { }

	private void OnDLCClickClick() { }

	private void OnExitClick() { }

	private void OnFreeModeClick() { }

	private void OnGalleryClick() { }

	private void OnOptionClick() { }

	private void OnStartClick() { }

	private void OpenLayoutSelectDialog() { }

	public virtual void OverDeleteLayer() { }

	protected virtual bool ReleaseLayer() { }

	private void SelectLeftButton() { }

	private void SelectRightButton() { }

	public void SequentialButton(int offset) { }

	protected virtual void Update(bool is_active) { }

}

