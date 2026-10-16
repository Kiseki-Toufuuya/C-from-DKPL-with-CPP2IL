namespace UnityEngine.UIElements;

public abstract class Focusable : CallbackEventHandler
{
	internal static readonly BindingId focusableProperty; //Field offset: 0x0
	internal static readonly BindingId tabIndexProperty; //Field offset: 0x4C
	internal static readonly BindingId delegatesFocusProperty; //Field offset: 0x98
	internal static readonly BindingId canGrabFocusProperty; //Field offset: 0xE4
	private bool m_Focusable; //Field offset: 0x10
	private int m_TabIndex; //Field offset: 0x14
	private bool m_DelegatesFocus; //Field offset: 0x18
	private bool m_ExcludeFromFocusRing; //Field offset: 0x19
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <isEligibleToReceiveFocusFromDisabledChild>k__BackingField; //Field offset: 0x1A

	[CreateProperty(ReadOnly = True)]
	public override bool canGrabFocus
	{
		 get { } //Length: 28
	}

	[CreateProperty]
	public bool delegatesFocus
	{
		 get { } //Length: 11
		 set { } //Length: 95
	}

	internal bool excludeFromFocusRing
	{
		internal get { } //Length: 11
		internal set { } //Length: 179
	}

	[CreateProperty]
	public override bool focusable
	{
		 get { } //Length: 11
		 set { } //Length: 89
	}

	public abstract FocusController focusController
	{
		 get { } //Length: 0
	}

	internal bool isEligibleToReceiveFocusFromDisabledChild
	{
		[CompilerGenerated]
		internal get { } //Length: 11
		[CompilerGenerated]
		internal set { } //Length: 14
	}

	[CreateProperty]
	public int tabIndex
	{
		 get { } //Length: 11
		 set { } //Length: 93
	}

	private static Focusable() { }

	protected Focusable() { }

	public override void Blur() { }

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void BlurImmediately() { }

	public override void Focus() { }

	public override bool get_canGrabFocus() { }

	public bool get_delegatesFocus() { }

	internal bool get_excludeFromFocusRing() { }

	public override bool get_focusable() { }

	public abstract FocusController get_focusController() { }

	[CompilerGenerated]
	internal bool get_isEligibleToReceiveFocusFromDisabledChild() { }

	public int get_tabIndex() { }

	private static Focusable GetFirstFocusableChild(VisualElement ve) { }

	internal Focusable GetFocusDelegate() { }

	public void set_delegatesFocus(bool value) { }

	internal void set_excludeFromFocusRing(bool value) { }

	public override void set_focusable(bool value) { }

	[CompilerGenerated]
	internal void set_isEligibleToReceiveFocusFromDisabledChild(bool value) { }

	public void set_tabIndex(int value) { }

}

