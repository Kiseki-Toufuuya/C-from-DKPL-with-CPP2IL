namespace XeApp.Game;

public class LoadingIconSubDisp : DispBase
{
	private enum eLayerId
	{
		BASE_NUM = 0,
		COMMON_BASE = 0,
		COMMON_ICON_MAIN = 0,
		COMMON_NUM = 1,
		IMG_BASE = 1,
		IMG_NUM = 1,
		TEXT_BASE = 1,
		TEXT_NUM = 1,
	}

	private static readonly String[] m_LayerIdList; //Field offset: 0x0
	private Transform m_parent; //Field offset: 0x114
	private bool NextDispState; //Field offset: 0x118
	private bool IsChanged; //Field offset: 0x119

	private static LoadingIconSubDisp() { }

	public LoadingIconSubDisp() { }

	private void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent) { }

	protected virtual void InitUguiOther() { }

	public bool IsDispLoadingIcon() { }

	protected virtual void LateUpdate() { }

	public void MoveIconPosition(Vector3 pos) { }

	public virtual void ReleaseAll() { }

	public void SetDispLoadingIcon(bool a_disp) { }

	public void SetParent(GameObject root, string parent) { }

	protected virtual void UpdateDispMain() { }

}

