namespace UnityEngine.UIElements;

public abstract class BaseBoolField : BaseField<Boolean>
{
	internal static readonly BindingId textProperty; //Field offset: 0x0
	internal static readonly BindingId toggleOnLabelClickProperty; //Field offset: 0x4C
	protected Label m_Label; //Field offset: 0x3B8
	protected private readonly VisualElement m_CheckMark; //Field offset: 0x3BC
	internal readonly Clickable m_Clickable; //Field offset: 0x3C0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <toggleOnLabelClick>k__BackingField; //Field offset: 0x3C4
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <toggleOnTextClick>k__BackingField; //Field offset: 0x3C5
	private string m_OriginalText; //Field offset: 0x3C8

	internal bool acceptClicksIfDisabled
	{
		internal set { } //Length: 108
	}

	[CreateProperty]
	public string text
	{
		 get { } //Length: 42
		 set { } //Length: 232
	}

	[CreateProperty]
	public bool toggleOnLabelClick
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 17
	}

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal bool toggleOnTextClick
	{
		[CompilerGenerated]
		internal get { } //Length: 14
		[CompilerGenerated]
		internal set { } //Length: 17
	}

	private static BaseBoolField() { }

	public BaseBoolField(string label) { }

	public string get_text() { }

	[CompilerGenerated]
	public bool get_toggleOnLabelClick() { }

	[CompilerGenerated]
	internal bool get_toggleOnTextClick() { }

	protected override void InitLabel() { }

	private void OnClickEvent(EventBase evt) { }

	private void OnNavigationSubmit(NavigationSubmitEvent evt) { }

	internal virtual void RegisterEditingCallbacks() { }

	internal void set_acceptClicksIfDisabled(bool value) { }

	public void set_text(string value) { }

	[CompilerGenerated]
	public void set_toggleOnLabelClick(bool value) { }

	[CompilerGenerated]
	internal void set_toggleOnTextClick(bool value) { }

	public virtual void SetValueWithoutNotify(bool newValue) { }

	private bool ShouldIgnoreClick(Vector3 position) { }

	protected override void ToggleValue() { }

	internal virtual void UnregisterEditingCallbacks() { }

	protected virtual void UpdateMixedValueContent() { }

}

