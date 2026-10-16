namespace UnityEngine.UIElements;

[MovedFrom(True, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
public class EnumField : BaseField<Enum>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static EventCallback<MouseDownEvent> <>9__31_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal void <.ctor>b__31_0(MouseDownEvent e) { }

	}

	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	internal class UxmlFactory : UxmlFactory<EnumField, UxmlTraits>
	{

		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	internal class UxmlTraits : UxmlTraits<Enum>
	{
		private UxmlTypeAttributeDescription<Enum> m_Type; //Field offset: 0x4C
		private UxmlStringAttributeDescription m_Value; //Field offset: 0x50
		private UxmlBoolAttributeDescription m_IncludeObsoleteValues; //Field offset: 0x54

		public UxmlTraits() { }

		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	internal static readonly BindingId textProperty; //Field offset: 0x0
	public static readonly string ussClassName; //Field offset: 0x4C
	public static readonly string textUssClassName; //Field offset: 0x50
	public static readonly string arrowUssClassName; //Field offset: 0x54
	public static readonly string labelUssClassName; //Field offset: 0x58
	public static readonly string inputUssClassName; //Field offset: 0x5C
	private Type m_EnumType; //Field offset: 0x3B8
	private bool m_IncludeObsoleteValues; //Field offset: 0x3BC
	private TextElement m_TextElement; //Field offset: 0x3C0
	private VisualElement m_ArrowElement; //Field offset: 0x3C4
	private EnumData m_EnumData; //Field offset: 0x3C8
	internal Func<IGenericMenu> createMenuCallback; //Field offset: 0x3E8

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal bool includeObsoleteValues
	{
		internal get { } //Length: 14
	}

	[CreateProperty(ReadOnly = True)]
	public string text
	{
		 get { } //Length: 43
	}

	private static EnumField() { }

	public EnumField() { }

	public EnumField(string label, Enum defaultValue = null) { }

	[CompilerGenerated]
	private void <ShowMenu>b__42_0(object contentView) { }

	private void ChangeValueFromMenu(object menuItem) { }

	private bool ContainsPointer(int pointerId) { }

	internal bool get_includeObsoleteValues() { }

	public string get_text() { }

	public void Init(Enum defaultValue) { }

	public void Init(Enum defaultValue, bool includeObsoleteValues) { }

	private void Initialize(Enum defaultValue) { }

	private void OnNavigationSubmit(NavigationSubmitEvent evt) { }

	private void OnPointerDownEvent(PointerDownEvent evt) { }

	private void OnPointerMoveEvent(PointerMoveEvent evt) { }

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void PopulateDataFromType(Type enumType) { }

	private void ProcessPointerDown(PointerEventBase<T> evt) { }

	public virtual void SetValueWithoutNotify(Enum newValue) { }

	internal void ShowMenu() { }

	protected virtual void UpdateMixedValueContent() { }

	private void UpdateValueLabel(Enum value) { }

}

