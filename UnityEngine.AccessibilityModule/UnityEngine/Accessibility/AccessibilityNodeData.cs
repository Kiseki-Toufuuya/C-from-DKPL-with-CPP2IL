namespace UnityEngine.Accessibility;

[NativeHeader("Modules/Accessibility/Bindings/AccessibilityNodeData.bindings.h")]
[NativeHeader("Modules/Accessibility/Native/AccessibilityNodeData.h")]
[NativeType(CodegenOptions::Custom (1), "MonoAccessibilityNodeData")]
[RequiredByNativeCode]
internal struct AccessibilityNodeData
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <id>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <isActive>k__BackingField; //Field offset: 0x4
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private string <label>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private string <value>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private string <hint>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private AccessibilityRole <role>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <allowsDirectInteraction>k__BackingField; //Field offset: 0x16
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private AccessibilityState <state>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Rect <frame>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <parentId>k__BackingField; //Field offset: 0x2C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Int32[] <childIds>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly bool <isFocused>k__BackingField; //Field offset: 0x34
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private SystemLanguage <language>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <implementsSelected>k__BackingField; //Field offset: 0x3C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <implementsDismissed>k__BackingField; //Field offset: 0x3D

	public bool allowsDirectInteraction
	{
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public Int32[] childIds
	{
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public Rect frame
	{
		[CompilerGenerated]
		 set { } //Length: 16
	}

	public string hint
	{
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public int id
	{
		[CompilerGenerated]
		 set { } //Length: 13
	}

	public bool implementsDismissed
	{
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public bool implementsSelected
	{
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public bool isActive
	{
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public string label
	{
		[CompilerGenerated]
		 set { } //Length: 27
	}

	internal SystemLanguage language
	{
		[CompilerGenerated]
		internal set { } //Length: 14
	}

	public int parentId
	{
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public AccessibilityRole role
	{
		[CompilerGenerated]
		 set { } //Length: 16
	}

	public AccessibilityState state
	{
		[CompilerGenerated]
		 set { } //Length: 16
	}

	public string value
	{
		[CompilerGenerated]
		 set { } //Length: 27
	}

	[CompilerGenerated]
	public void set_allowsDirectInteraction(bool value) { }

	[CompilerGenerated]
	public void set_childIds(Int32[] value) { }

	[CompilerGenerated]
	public void set_frame(Rect value) { }

	[CompilerGenerated]
	public void set_hint(string value) { }

	[CompilerGenerated]
	public void set_id(int value) { }

	[CompilerGenerated]
	public void set_implementsDismissed(bool value) { }

	[CompilerGenerated]
	public void set_implementsSelected(bool value) { }

	[CompilerGenerated]
	public void set_isActive(bool value) { }

	[CompilerGenerated]
	public void set_label(string value) { }

	[CompilerGenerated]
	internal void set_language(SystemLanguage value) { }

	[CompilerGenerated]
	public void set_parentId(int value) { }

	[CompilerGenerated]
	public void set_role(AccessibilityRole value) { }

	[CompilerGenerated]
	public void set_state(AccessibilityState value) { }

	[CompilerGenerated]
	public void set_value(string value) { }

}

