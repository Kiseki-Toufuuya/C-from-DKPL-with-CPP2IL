namespace XeApp.Game;

public class AdvMenuUiLayer : LayerBase
{
	private AdvMenuUiDisp m_MesBoxDisp; //Field offset: 0x58
	private int m_LayerTagId; //Field offset: 0x5C
	private bool m_HideFlag; //Field offset: 0x60

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

	public AdvMenuUiLayer() { }

	protected virtual bool EndUpdateAfter() { }

	public virtual bool get_IS_DISP_BACKGROUND() { }

	public virtual bool get_IS_TOUCH_BACKGROUND() { }

	public virtual bool get_IS_UPDATE_BACKGROUND() { }

	protected virtual void InitAll() { }

	protected virtual bool InitUpdateBefore() { }

	protected virtual void LateUpdate(bool is_active) { }

	public virtual void OverDeleteLayer() { }

	protected virtual bool ReleaseLayer() { }

	public void SetDispHideFlag(bool hide) { }

	protected virtual void Update(bool is_active) { }

}

