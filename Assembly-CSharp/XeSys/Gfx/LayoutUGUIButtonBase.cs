namespace XeSys.Gfx;

public abstract class LayoutUGUIButtonBase : MonoBehaviour, ILayoutUGUIInitializeFromLayout, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler, IPointerClickHandler
{
	[HideInInspector]
	[SerializeField]
	private bool m_isValidTouch; //Field offset: 0x10
	[HideInInspector]
	[SerializeField]
	private bool m_isValidDisplay; //Field offset: 0x11
	[HideInInspector]
	[SerializeField]
	private bool m_isPress; //Field offset: 0x12
	public UnityEvent onDown; //Field offset: 0x14
	public UnityEvent onExit; //Field offset: 0x18
	public UnityEvent onEnter; //Field offset: 0x1C
	public UnityEvent onClick; //Field offset: 0x20
	protected AbsoluteLayout m_abs; //Field offset: 0x24
	protected GameObject m_downObject; //Field offset: 0x28

	public bool IsPress
	{
		 get { } //Length: 11
	}

	public bool IsValidDisplay
	{
		 get { } //Length: 11
	}

	public bool IsValidTouch
	{
		 get { } //Length: 11
	}

	protected LayoutUGUIButtonBase() { }

	public bool get_IsPress() { }

	public bool get_IsValidDisplay() { }

	public bool get_IsValidTouch() { }

	public override bool InitializeFromLayout(Layout layout, TexUVListManager[] uvManList) { }

	public void InitializeOnPaste() { }

	public override void OnPointerClick(PointerEventData eventData) { }

	public override void OnPointerDown(PointerEventData eventData) { }

	public override void OnPointerEnter(PointerEventData eventData) { }

	public override void OnPointerExit(PointerEventData eventData) { }

	public void Reset() { }

	public void SetValid(bool valid) { }

	public void SetValid(bool touch, bool display) { }

	protected abstract void StartDecideAnim() { }

	protected abstract void StartDefaultAnim() { }

	protected abstract void StartDisableAnime() { }

	protected abstract void StartPressAnim() { }

	protected abstract void StartReleaseAnim() { }

}

