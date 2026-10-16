namespace XeApp.Game;

public class NewNoticeBase : DispBase
{
	private enum eLayerId
	{
		BASE_NUM = 0,
		TEXT_NUM = 0,
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

	private String[] m_LayerIdList; //Field offset: 0x114
	private IHomeLayer m_Layer; //Field offset: 0x118
	private MenuUiState State; //Field offset: 0x11C
	private eCanvas m_CanvasSetting; //Field offset: 0x120
	private Animator RootAnimator; //Field offset: 0x124

	public eCanvas CanvasSetting
	{
		 set { } //Length: 17
	}

	internal MenuUiState UiState
	{
		internal get { } //Length: 14
	}

	public NewNoticeBase() { }

	private void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent_layer) { }

	internal MenuUiState get_UiState() { }

	protected virtual void InitUguiOther() { }

	protected virtual void LateUpdate() { }

	public void set_CanvasSetting(eCanvas value) { }

	protected virtual void UpdateDispMain() { }

}

