namespace UnityEngine.UIElements;

public abstract class BaseField : BindableElement, INotifyValueChanged<TValueType>, IEditableElement
{
	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	internal class UxmlTraits : UxmlTraits
	{
		private UxmlStringAttributeDescription m_Label; //Field offset: 0x0

		public UxmlTraits() { }

		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	internal static readonly BindingId valueProperty; //Field offset: 0x0
	private static CustomStyleProperty<Single> s_LabelBaseMinWidthProperty; //Field offset: 0x0
	private static CustomStyleProperty<Single> s_LabelExtraPaddingProperty; //Field offset: 0x0
	private static CustomStyleProperty<Single> s_LabelWidthRatioProperty; //Field offset: 0x0
	protected private static readonly PropertyName serializedPropertyCopyName; //Field offset: 0x0
	private static readonly string inspectorFieldUssClassName; //Field offset: 0x0
	public static readonly string alignedFieldUssClassName; //Field offset: 0x0
	public static readonly string mixedValueLabelUssClassName; //Field offset: 0x0
	protected private static readonly string mixedValueString; //Field offset: 0x0
	public static readonly string noLabelVariantUssClassName; //Field offset: 0x0
	public static readonly string inputUssClassName; //Field offset: 0x0
	public static readonly string labelUssClassName; //Field offset: 0x0
	public static readonly string ussClassName; //Field offset: 0x0
	internal static readonly BindingId showMixedValueProperty; //Field offset: 0x0
	internal static readonly BindingId labelProperty; //Field offset: 0x0
	public static readonly string labelDraggerVariantUssClassName; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Label <labelElement>k__BackingField; //Field offset: 0x0
	private VisualElement m_CachedInspectorElement; //Field offset: 0x0
	private VisualElement m_CachedContextWidthElement; //Field offset: 0x0
	private bool m_SkipValidation; //Field offset: 0x0
	private Label m_MixedValueLabel; //Field offset: 0x0
	private bool m_ShowMixedValue; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private DispatchMode <dispatchMode>k__BackingField; //Field offset: 0x0
	private float m_LabelWidthRatio; //Field offset: 0x0
	[DontCreateProperty]
	[SerializeField]
	private TValueType m_Value; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action viewDataRestored; //Field offset: 0x0
	internal Action<Expression> expressionEvaluated; //Field offset: 0x0
	private VisualElement m_VisualInput; //Field offset: 0x0
	private float m_LabelBaseMinWidth; //Field offset: 0x0
	private float m_LabelExtraPadding; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action <UnityEngine.UIElements.IEditableElement.editingStarted>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Func<TValueType, TValueType> onValidateValue; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action <UnityEngine.UIElements.IEditableElement.editingEnded>k__BackingField; //Field offset: 0x0

	internal event Func<TValueType, TValueType> onValidateValue
	{
		[CompilerGenerated]
		internal add { } //Length: 131
		[CompilerGenerated]
		internal remove { } //Length: 131
	}

	internal event Action viewDataRestored
	{
		[CompilerGenerated]
		internal add { } //Length: 118
		[CompilerGenerated]
		internal remove { } //Length: 118
	}

	override bool canSwitchToMixedValue
	{
		 get { } //Length: 3
	}

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal DispatchMode dispatchMode
	{
		[CompilerGenerated]
		internal get { } //Length: 14
		[CompilerGenerated]
		internal set { } //Length: 17
	}

	[CreateProperty]
	public override string label
	{
		 get { } //Length: 43
		 set { } //Length: 513
	}

	public private override Label labelElement
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		private set { } //Length: 33
	}

	protected Label mixedValueLabel
	{
		 get { } //Length: 349
	}

	protected TValueType rawValue
	{
		 get { } //Length: 14
		 set { } //Length: 17
	}

	[CreateProperty]
	public override bool showMixedValue
	{
		 get { } //Length: 14
		 set { } //Length: 175
	}

	private override Action UnityEngine.UIElements.IEditableElement.editingEnded
	{
		[CompilerGenerated]
		private get { } //Length: 14
	}

	private override Action UnityEngine.UIElements.IEditableElement.editingStarted
	{
		[CompilerGenerated]
		private get { } //Length: 14
	}

	[CreateProperty]
	public override TValueType value
	{
		 get { } //Length: 14
		 set { } //Length: 642
	}

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal VisualElement visualInput
	{
		internal get { } //Length: 14
		internal set { } //Length: 357
	}

	private static BaseField`1() { }

	protected BaseField`1(string label, VisualElement visualInput) { }

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal BaseField`1(string label) { }

	[CompilerGenerated]
	internal void add_onValidateValue(Func<TValueType, TValueType> value) { }

	[CompilerGenerated]
	internal void add_viewDataRestored(Action value) { }

	private void AlignLabel() { }

	private Rect ComputeTooltipRect() { }

	internal void EndEditing(EventBase e) { }

	internal override bool EqualsCurrentValue(TValueType value) { }

	override bool get_canSwitchToMixedValue() { }

	[CompilerGenerated]
	internal DispatchMode get_dispatchMode() { }

	public override string get_label() { }

	[CompilerGenerated]
	public override Label get_labelElement() { }

	protected Label get_mixedValueLabel() { }

	protected TValueType get_rawValue() { }

	public override bool get_showMixedValue() { }

	public override TValueType get_value() { }

	internal VisualElement get_visualInput() { }

	internal virtual Rect GetTooltipRect() { }

	[EventInterest(new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(TooltipEvent)})]
	protected virtual void HandleEventBubbleUp(EventBase evt) { }

	private void OnAttachToPanel(AttachToPanelEvent e) { }

	private void OnCustomStyleResolved(CustomStyleResolvedEvent evt) { }

	private void OnDetachFromPanel(DetachFromPanelEvent e) { }

	private void OnInspectorFieldGeometryChanged(GeometryChangedEvent e) { }

	internal virtual void OnViewDataReady() { }

	internal override void RegisterEditingCallbacks() { }

	[CompilerGenerated]
	internal void remove_onValidateValue(Func<TValueType, TValueType> value) { }

	[CompilerGenerated]
	internal void remove_viewDataRestored(Action value) { }

	[CompilerGenerated]
	internal void set_dispatchMode(DispatchMode value) { }

	public void set_label(string value) { }

	[CompilerGenerated]
	private void set_labelElement(Label value) { }

	protected void set_rawValue(TValueType value) { }

	public override void set_showMixedValue(bool value) { }

	public override void set_value(TValueType value) { }

	internal void set_visualInput(VisualElement value) { }

	public override void SetValueWithoutNotify(TValueType newValue) { }

	internal void StartEditing(EventBase e) { }

	[CompilerGenerated]
	private override Action UnityEngine.UIElements.IEditableElement.get_editingEnded() { }

	[CompilerGenerated]
	private override Action UnityEngine.UIElements.IEditableElement.get_editingStarted() { }

	internal override void UnregisterEditingCallbacks() { }

	protected override void UpdateMixedValueContent() { }

	internal TValueType ValidatedValue(TValueType value) { }

}

