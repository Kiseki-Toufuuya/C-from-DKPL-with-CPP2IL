namespace XeApp.Game;

public class UITestRootLayer : LayerBase
{

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

	public UITestRootLayer() { }

	public T CreateDispBase(Action<DispBase> action = null) { }

	public void DestroyDispBase(DispBase dispBase) { }

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

