namespace UnityEngine.UIElements;

public class Foldout : BindableElement, INotifyValueChanged<Boolean>
{
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	internal class UxmlFactory : UxmlFactory<Foldout, UxmlTraits>
	{

		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	internal class UxmlTraits : UxmlTraits
	{
		private UxmlStringAttributeDescription m_Text; //Field offset: 0x48
		private UxmlBoolAttributeDescription m_Value; //Field offset: 0x4C

		public UxmlTraits() { }

		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	internal static readonly BindingId textProperty; //Field offset: 0x0
	internal static readonly BindingId toggleOnLabelClickProperty; //Field offset: 0x4C
	internal static readonly BindingId valueProperty; //Field offset: 0x98
	public static readonly string ussClassName; //Field offset: 0xE4
	public static readonly string toggleUssClassName; //Field offset: 0xE8
	public static readonly string contentUssClassName; //Field offset: 0xEC
	public static readonly string inputUssClassName; //Field offset: 0xF0
	public static readonly string checkmarkUssClassName; //Field offset: 0xF4
	public static readonly string textUssClassName; //Field offset: 0xF8
	internal static readonly string toggleInspectorUssClassName; //Field offset: 0xFC
	internal static readonly string ussFoldoutDepthClassName; //Field offset: 0x100
	internal static readonly int ussFoldoutMaxDepth; //Field offset: 0x104
	private readonly Toggle m_Toggle; //Field offset: 0x370
	private VisualElement m_Container; //Field offset: 0x374
	[DontCreateProperty]
	[SerializeField]
	private bool m_Value; //Field offset: 0x378
	private KeyboardNavigationManipulator m_NavigationManipulator; //Field offset: 0x37C

	public virtual VisualElement contentContainer
	{
		 get { } //Length: 14
	}

	public virtual bool focusable
	{
		 get { } //Length: 11
		 set { } //Length: 62
	}

	[CreateProperty]
	public string text
	{
		 get { } //Length: 37
		 set { } //Length: 356
	}

	internal Toggle toggle
	{
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal get { } //Length: 14
	}

	[CreateProperty]
	public bool toggleOnLabelClick
	{
		 get { } //Length: 29
		 set { } //Length: 114
	}

	[CreateProperty]
	public override bool value
	{
		 get { } //Length: 14
		 set { } //Length: 397
	}

	private static Foldout() { }

	public Foldout() { }

	[CompilerGenerated]
	private void <.ctor>b__39_0(ChangeEvent<Boolean> evt) { }

	private bool Apply(KeyboardNavigationOperation op) { }

	private void Apply(KeyboardNavigationOperation op, EventBase sourceEvent) { }

	public virtual VisualElement get_contentContainer() { }

	public virtual bool get_focusable() { }

	public string get_text() { }

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal Toggle get_toggle() { }

	public bool get_toggleOnLabelClick() { }

	public override bool get_value() { }

	private void OnAttachToPanel(AttachToPanelEvent evt) { }

	internal virtual void OnViewDataReady() { }

	public virtual void set_focusable(bool value) { }

	public void set_text(string value) { }

	public void set_toggleOnLabelClick(bool value) { }

	public override void set_value(bool value) { }

	public override void SetValueWithoutNotify(bool newValue) { }

}

