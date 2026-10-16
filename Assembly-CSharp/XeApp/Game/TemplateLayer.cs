namespace XeApp.Game;

public class TemplateLayer : LayerBase
{
	internal enum TEMPLATE_STATE
	{
		NONE = 0,
		INIT = 1,
		WAIT = 2,
		END = 3,
	}

	private TEMPLATE_STATE MainState; //Field offset: 0x58
	private TEMPLATE_STATE MainStateReq; //Field offset: 0x5C
	private int CntState; //Field offset: 0x60
	private TemplateDisp disp; //Field offset: 0x64

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

	public virtual eLayerType LAYER_TYPE
	{
		 get { } //Length: 3
	}

	public TemplateLayer() { }

	protected virtual bool EndUpdateAfter() { }

	public virtual bool get_IS_DISP_BACKGROUND() { }

	public virtual bool get_IS_TOUCH_BACKGROUND() { }

	public virtual bool get_IS_UPDATE_BACKGROUND() { }

	public virtual eLayerType get_LAYER_TYPE() { }

	protected virtual void InitAll() { }

	protected virtual bool InitResourceWait() { }

	protected virtual bool InitUpdateBefore() { }

	protected virtual void LateUpdate(bool is_active) { }

	protected virtual void OnSetDisp(bool enable) { }

	protected virtual void OnSetTouch(bool enable) { }

	public virtual void OverDeleteLayer() { }

	protected virtual bool ReleaseLayer() { }

	protected virtual void Update(bool is_active) { }

}

