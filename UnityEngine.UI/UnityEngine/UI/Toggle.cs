namespace UnityEngine.UI;

[AddComponentMenu("UI/Toggle", 30)]
[RequireComponent(typeof(RectTransform))]
public class Toggle : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler, ICanvasElement
{
	internal class ToggleEvent : UnityEvent<Boolean>
	{

		public ToggleEvent() { }

	}

	internal enum ToggleTransition
	{
		None = 0,
		Fade = 1,
	}

	public ToggleTransition toggleTransition; //Field offset: 0xB4
	public Graphic graphic; //Field offset: 0xB8
	[SerializeField]
	private ToggleGroup m_Group; //Field offset: 0xBC
	public ToggleEvent onValueChanged; //Field offset: 0xC0
	[SerializeField]
	[Tooltip("Is the toggle currently on or off?")]
	private bool m_IsOn; //Field offset: 0xC4

	public ToggleGroup group
	{
		 get { } //Length: 14
		 set { } //Length: 41
	}

	public bool isOn
	{
		 get { } //Length: 14
		 set { } //Length: 23
	}

	protected Toggle() { }

	public ToggleGroup get_group() { }

	public bool get_isOn() { }

	public override void GraphicUpdateComplete() { }

	private void InternalToggle() { }

	public override void LayoutComplete() { }

	protected virtual void OnDestroy() { }

	protected virtual void OnDidApplyAnimationProperties() { }

	protected virtual void OnDisable() { }

	protected virtual void OnEnable() { }

	public override void OnPointerClick(PointerEventData eventData) { }

	public override void OnSubmit(BaseEventData eventData) { }

	private void PlayEffect(bool instant) { }

	public override void Rebuild(CanvasUpdate executing) { }

	private void Set(bool value, bool sendCallback = true) { }

	public void set_group(ToggleGroup value) { }

	public void set_isOn(bool value) { }

	public void SetIsOnWithoutNotify(bool value) { }

	private void SetToggleGroup(ToggleGroup newGroup, bool setMemberValue) { }

	protected virtual void Start() { }

	private override Transform UnityEngine.UI.ICanvasElement.get_transform() { }

}

