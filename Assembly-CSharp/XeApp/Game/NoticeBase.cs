namespace XeApp.Game;

public class NoticeBase : DispBase
{
	private enum eLayerId
	{
		BASE_ROOT = 0,
		BASE_NUM = 1,
		TEXT_NOTICE = 1,
		TEXT_NUM = 2,
	}

	internal enum MenuAnimeType
	{
		In = 0,
		Out = 1,
	}

	internal enum MenuUiState
	{
		Init = 0,
		Wait = 1,
	}

	private static readonly String[] m_LayerIdList; //Field offset: 0x0
	private IHomeLayer m_Layer; //Field offset: 0x114
	private MenuUiState State; //Field offset: 0x118
	private eCanvas m_CanvasSetting; //Field offset: 0x11C
	private Animator RootAnimator; //Field offset: 0x120

	public eCanvas CanvasSetting
	{
		 set { } //Length: 17
	}

	internal MenuUiState UiState
	{
		internal get { } //Length: 14
	}

	private static NoticeBase() { }

	public NoticeBase() { }

	private void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent_layer) { }

	internal MenuUiState get_UiState() { }

	protected virtual void InitUguiOther() { }

	protected virtual void LateUpdate() { }

	public void set_CanvasSetting(eCanvas value) { }

	public void SetNoticeNumText(int num, int num_displimit = 99) { }

	public void SetNoticeText(string text) { }

	protected virtual void UpdateDispMain() { }

}

