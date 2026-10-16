namespace XeApp.Game;

public class AdvBgUiLayer : LayerBase
{
	private AdvBgUiDisp m_Disp; //Field offset: 0x58
	private CharacterCardIllustDisp m_CardDisp; //Field offset: 0x5C
	private int m_LayerTagId; //Field offset: 0x60

	public CharacterCardIllustDisp AdvBgCardDisp
	{
		 get { } //Length: 11
	}

	public AdvBgUiDisp AdvBgDisp
	{
		 get { } //Length: 11
	}

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

	public AdvBgUiLayer() { }

	protected virtual bool EndUpdateAfter() { }

	public CharacterCardIllustDisp get_AdvBgCardDisp() { }

	public AdvBgUiDisp get_AdvBgDisp() { }

	public virtual bool get_IS_DISP_BACKGROUND() { }

	public virtual bool get_IS_TOUCH_BACKGROUND() { }

	public virtual bool get_IS_UPDATE_BACKGROUND() { }

	protected virtual void InitAll() { }

	protected virtual bool InitResourceWait() { }

	protected virtual bool InitUpdateBefore() { }

	protected virtual void LateUpdate(bool is_active) { }

	public virtual void OverDeleteLayer() { }

	protected virtual bool ReleaseLayer() { }

	protected virtual void Update(bool is_active) { }

}

