namespace XeSys.Gfx;

public class UguiInfoScrollbarComponent : UguiInfoImageComponent
{
	[SerializeField]
	protected bool m_isHorizontal; //Field offset: 0x40
	protected IAlphaTexture[] m_images; //Field offset: 0x44
	private Scrollbar m_scrollbar; //Field offset: 0x48

	public bool IsHorizontal
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public UguiInfoScrollbarComponent() { }

	public bool get_IsHorizontal() { }

	public void set_IsHorizontal(bool value) { }

	public virtual void Setup(ViewBase view, bool setView = true) { }

	public virtual void UpdateIntended() { }

}

