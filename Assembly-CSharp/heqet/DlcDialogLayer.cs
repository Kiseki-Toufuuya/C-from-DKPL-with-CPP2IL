namespace Heqet;

public class DlcDialogLayer : LayerBase
{
	private enum eMainStep
	{
		WAIT_DLC_DIALOG = 0,
		WAIT_SYSTEM_DIALOG = 1,
		CLOSE = 2,
		NONE = 3,
	}

	private eMainStep m_MainStep; //Field offset: 0x58
	public int dlcId; //Field offset: 0x5C

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

	public DlcDialogLayer() { }

	[CompilerGenerated]
	private void <InitUpdateBefore>b__10_0(ButtonType btnId) { }

	protected virtual bool EndUpdateAfter() { }

	public virtual bool get_IS_DISP_BACKGROUND() { }

	public virtual bool get_IS_TOUCH_BACKGROUND() { }

	public virtual bool get_IS_UPDATE_BACKGROUND() { }

	protected virtual void InitAll() { }

	protected virtual bool InitUpdateBefore() { }

	protected virtual void LateUpdate(bool is_active) { }

	public virtual void OverDeleteLayer() { }

	protected virtual bool ReleaseLayer() { }

	protected virtual void Update(bool is_active) { }

}

