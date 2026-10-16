namespace XeSys.Gfx;

public class UguiInfoComponent : MonoBehaviour
{
	protected ViewBase m_view; //Field offset: 0x10
	protected RectTransform m_rectTrans; //Field offset: 0x14
	protected GameObject m_gameObject; //Field offset: 0x18
	protected Graphic m_graphic; //Field offset: 0x1C
	protected bool m_isMaskChild; //Field offset: 0x20
	protected Transform m_maskInverseTrans; //Field offset: 0x24
	protected Transform m_maskTrans; //Field offset: 0x28
	protected CanvasRenderer m_renderer; //Field offset: 0x2C
	[SerializeField]
	private int m_viewIdHash; //Field offset: 0x30

	public RectTransform RectTrans
	{
		 get { } //Length: 11
	}

	public ViewBase View
	{
		 get { } //Length: 11
	}

	public int ViewIDHash
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public UguiInfoComponent() { }

	public RectTransform get_RectTrans() { }

	public ViewBase get_View() { }

	public int get_ViewIDHash() { }

	public void set_ViewIDHash(int value) { }

	protected static void SetBlendType(ref IAlphaTexture texture, EBlendType blendType) { }

	protected void SetRectTrans() { }

	public override void Setup(ViewBase view, bool setView = true) { }

	public override void UpdateIntended() { }

}

