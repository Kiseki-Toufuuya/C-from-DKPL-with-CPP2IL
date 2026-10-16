namespace UnityEngine.UIElements;

[UxmlElement(null, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(Button)})]
public class ToggleButtonGroup : BaseField<ToggleButtonGroupState>
{
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	internal class UxmlFactory : UxmlFactory<ToggleButtonGroup, UxmlTraits>
	{

		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	internal class UxmlTraits : UxmlTraits<ToggleButtonGroupState>
	{
		private UxmlBoolAttributeDescription m_IsMultipleSelection; //Field offset: 0x4C
		private UxmlBoolAttributeDescription m_AllowEmptySelection; //Field offset: 0x50

		public UxmlTraits() { }

		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	private static readonly string k_MaxToggleButtonGroupMessage; //Field offset: 0x0
	internal static readonly BindingId isMultipleSelectionProperty; //Field offset: 0x4
	internal static readonly BindingId allowEmptySelectionProperty; //Field offset: 0x50
	public static readonly string ussClassName; //Field offset: 0x9C
	public static readonly string containerUssClassName; //Field offset: 0xA0
	public static readonly string buttonGroupClassName; //Field offset: 0xA4
	public static readonly string buttonClassName; //Field offset: 0xA8
	public static readonly string buttonLeftClassName; //Field offset: 0xAC
	public static readonly string buttonMidClassName; //Field offset: 0xB0
	public static readonly string buttonRightClassName; //Field offset: 0xB4
	public static readonly string buttonStandaloneClassName; //Field offset: 0xB8
	public static readonly string emptyStateLabelClassName; //Field offset: 0xBC
	private VisualElement m_ButtonGroupContainer; //Field offset: 0x3C0
	private List<Button> m_Buttons; //Field offset: 0x3C4
	private VisualElement m_EmptyLabel; //Field offset: 0x3C8
	private bool m_IsMultipleSelection; //Field offset: 0x3CC
	private bool m_AllowEmptySelection; //Field offset: 0x3CD

	[CreateProperty]
	public bool allowEmptySelection
	{
		 get { } //Length: 14
		 set { } //Length: 338
	}

	public virtual VisualElement contentContainer
	{
		 get { } //Length: 19
	}

	[CreateProperty]
	public bool isMultipleSelection
	{
		 get { } //Length: 14
		 set { } //Length: 363
	}

	private static ToggleButtonGroup() { }

	public ToggleButtonGroup(string label, ToggleButtonGroupState toggleButtonGroupState) { }

	public ToggleButtonGroup() { }

	public ToggleButtonGroup(string label) { }

	public bool get_allowEmptySelection() { }

	public virtual VisualElement get_contentContainer() { }

	public bool get_isMultipleSelection() { }

	private void OnButtonGroupContainerElementAdded(VisualElement ve, int index) { }

	private void OnButtonGroupContainerElementRemoved(VisualElement ve) { }

	private void OnOptionChange(EventBase evt) { }

	internal virtual void OnViewDataReady() { }

	public void set_allowEmptySelection(bool value) { }

	public void set_isMultipleSelection(bool value) { }

	public virtual void SetValueWithoutNotify(ToggleButtonGroupState newValue) { }

	private void UpdateButtonsStyling() { }

	private void UpdateButtonStates(ToggleButtonGroupState options) { }

	protected virtual void UpdateMixedValueContent() { }

}

