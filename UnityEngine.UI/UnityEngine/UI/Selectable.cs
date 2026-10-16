namespace UnityEngine.UI;

[AddComponentMenu("UI/Selectable", 35)]
[DisallowMultipleComponent]
[ExecuteAlways]
[SelectionBase]
public class Selectable : UIBehaviour, IMoveHandler, IEventSystemHandler, IPointerDownHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler, ISelectHandler, IDeselectHandler
{
	internal enum SelectionState
	{
		Normal = 0,
		Highlighted = 1,
		Pressed = 2,
		Selected = 3,
		Disabled = 4,
	}

	internal enum Transition
	{
		None = 0,
		ColorTint = 1,
		SpriteSwap = 2,
		Animation = 3,
	}

	protected static Selectable[] s_Selectables; //Field offset: 0x0
	protected static int s_SelectableCount; //Field offset: 0x4
	private bool m_EnableCalled; //Field offset: 0x10
	[FormerlySerializedAs("navigation")]
	[SerializeField]
	private Navigation m_Navigation; //Field offset: 0x14
	[FormerlySerializedAs("transition")]
	[SerializeField]
	private Transition m_Transition; //Field offset: 0x2C
	[FormerlySerializedAs("colors")]
	[SerializeField]
	private ColorBlock m_Colors; //Field offset: 0x30
	[FormerlySerializedAs("spriteState")]
	[SerializeField]
	private SpriteState m_SpriteState; //Field offset: 0x88
	[FormerlySerializedAs("animationTriggers")]
	[SerializeField]
	private AnimationTriggers m_AnimationTriggers; //Field offset: 0x98
	[SerializeField]
	[Tooltip("Can the Selectable be interacted with?")]
	private bool m_Interactable; //Field offset: 0x9C
	[FormerlySerializedAs("highlightGraphic")]
	[FormerlySerializedAs("m_HighlightGraphic")]
	[SerializeField]
	private Graphic m_TargetGraphic; //Field offset: 0xA0
	private bool m_GroupsAllowInteraction; //Field offset: 0xA4
	protected int m_CurrentIndex; //Field offset: 0xA8
	[CompilerGenerated]
	private bool <isPointerInside>k__BackingField; //Field offset: 0xAC
	[CompilerGenerated]
	private bool <isPointerDown>k__BackingField; //Field offset: 0xAD
	[CompilerGenerated]
	private bool <hasSelection>k__BackingField; //Field offset: 0xAE
	private readonly List<CanvasGroup> m_CanvasGroupCache; //Field offset: 0xB0

	public static int allSelectableCount
	{
		 get { } //Length: 61
	}

	[Obsolete("Replaced with allSelectablesArray to have better performance when disabling a element", False)]
	public static List<Selectable> allSelectables
	{
		 get { } //Length: 210
	}

	public static Selectable[] allSelectablesArray
	{
		 get { } //Length: 113
	}

	public AnimationTriggers animationTriggers
	{
		 get { } //Length: 14
		 set { } //Length: 78
	}

	public Animator animator
	{
		 get { } //Length: 51
	}

	public ColorBlock colors
	{
		 get { } //Length: 63
		 set { } //Length: 126
	}

	protected SelectionState currentSelectionState
	{
		 get { } //Length: 87
	}

	private bool hasSelection
	{
		[CompilerGenerated]
		private get { } //Length: 14
		[CompilerGenerated]
		private set { } //Length: 17
	}

	public Image image
	{
		 get { } //Length: 115
		 set { } //Length: 33
	}

	public bool interactable
	{
		 get { } //Length: 14
		 set { } //Length: 332
	}

	private bool isPointerDown
	{
		[CompilerGenerated]
		private get { } //Length: 14
		[CompilerGenerated]
		private set { } //Length: 17
	}

	private bool isPointerInside
	{
		[CompilerGenerated]
		private get { } //Length: 14
		[CompilerGenerated]
		private set { } //Length: 17
	}

	public Navigation navigation
	{
		 get { } //Length: 28
		 set { } //Length: 94
	}

	public SpriteState spriteState
	{
		 get { } //Length: 21
		 set { } //Length: 87
	}

	public Graphic targetGraphic
	{
		 get { } //Length: 14
		 set { } //Length: 78
	}

	public Transition transition
	{
		 get { } //Length: 11
		 set { } //Length: 75
	}

	private static Selectable() { }

	protected Selectable() { }

	public static int AllSelectablesNoAlloc(Selectable[] selectables) { }

	protected virtual void Awake() { }

	private void DoSpriteSwap(Sprite newSprite) { }

	protected override void DoStateTransition(SelectionState state, bool instant) { }

	private void EvaluateAndTransitionToSelectionState() { }

	public Selectable FindSelectable(Vector3 dir) { }

	public override Selectable FindSelectableOnDown() { }

	public override Selectable FindSelectableOnLeft() { }

	public override Selectable FindSelectableOnRight() { }

	public override Selectable FindSelectableOnUp() { }

	public static int get_allSelectableCount() { }

	public static List<Selectable> get_allSelectables() { }

	public static Selectable[] get_allSelectablesArray() { }

	public AnimationTriggers get_animationTriggers() { }

	public Animator get_animator() { }

	public ColorBlock get_colors() { }

	protected SelectionState get_currentSelectionState() { }

	[CompilerGenerated]
	private bool get_hasSelection() { }

	public Image get_image() { }

	public bool get_interactable() { }

	[CompilerGenerated]
	private bool get_isPointerDown() { }

	[CompilerGenerated]
	private bool get_isPointerInside() { }

	public Navigation get_navigation() { }

	public SpriteState get_spriteState() { }

	public Graphic get_targetGraphic() { }

	public Transition get_transition() { }

	private static Vector3 GetPointOnRectEdge(RectTransform rect, Vector2 dir) { }

	protected override void InstantClearState() { }

	protected bool IsHighlighted() { }

	public override bool IsInteractable() { }

	protected bool IsPressed() { }

	private void Navigate(AxisEventData eventData, Selectable sel) { }

	private void OnApplicationFocus(bool hasFocus) { }

	protected virtual void OnCanvasGroupChanged() { }

	public override void OnDeselect(BaseEventData eventData) { }

	protected virtual void OnDidApplyAnimationProperties() { }

	protected virtual void OnDisable() { }

	protected virtual void OnEnable() { }

	public override void OnMove(AxisEventData eventData) { }

	public override void OnPointerDown(PointerEventData eventData) { }

	public override void OnPointerEnter(PointerEventData eventData) { }

	public override void OnPointerExit(PointerEventData eventData) { }

	public override void OnPointerUp(PointerEventData eventData) { }

	public override void OnSelect(BaseEventData eventData) { }

	private void OnSetProperty() { }

	protected virtual void OnTransformParentChanged() { }

	private bool ParentGroupAllowsInteraction() { }

	public override void Select() { }

	public void set_animationTriggers(AnimationTriggers value) { }

	public void set_colors(ColorBlock value) { }

	[CompilerGenerated]
	private void set_hasSelection(bool value) { }

	public void set_image(Image value) { }

	public void set_interactable(bool value) { }

	[CompilerGenerated]
	private void set_isPointerDown(bool value) { }

	[CompilerGenerated]
	private void set_isPointerInside(bool value) { }

	public void set_navigation(Navigation value) { }

	public void set_spriteState(SpriteState value) { }

	public void set_targetGraphic(Graphic value) { }

	public void set_transition(Transition value) { }

	private void StartColorTween(Color targetColor, bool instant) { }

	private void TriggerAnimation(string triggername) { }

}

