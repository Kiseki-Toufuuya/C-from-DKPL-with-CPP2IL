namespace XeSys.Gfx;

public class UguiInfoMaskComponent : UguiInfoComponent
{
	private Mask m_mask; //Field offset: 0x34
	private RectTransform m_child; //Field offset: 0x38

	public UguiInfoMaskComponent() { }

	public virtual void Setup(ViewBase view, bool setView = true) { }

	public virtual void UpdateIntended() { }

}

