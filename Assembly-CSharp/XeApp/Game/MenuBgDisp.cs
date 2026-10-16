namespace XeApp.Game;

public class MenuBgDisp : DispBase
{
	private enum eLayerId
	{
		BASE_BG = 0,
		BASE_NUM = 1,
		TEXT_NUM = 1,
	}

	private static readonly String[] m_LayerIdList; //Field offset: 0x0
	public eCanvas CanvasId; //Field offset: 0x114
	private Animator m_RootAnimator; //Field offset: 0x118

	private static MenuBgDisp() { }

	public MenuBgDisp() { }

	private void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent) { }

	protected virtual void InitUguiOther() { }

	public bool IsClose() { }

	public bool IsDispActive() { }

	public bool IsEnd() { }

	public bool IsOpen() { }

	protected virtual void LateUpdate() { }

	public void SetDispActive(bool enable) { }

	public void StartInAnimation() { }

	public void StartOutAnimation() { }

	protected virtual void UpdateDispMain() { }

}

