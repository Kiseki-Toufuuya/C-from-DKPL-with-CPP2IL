namespace UnityEngine.UIElements;

public abstract class ContextualMenuManager
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <displayMenuHandledOSX>k__BackingField; //Field offset: 0x8

	internal bool displayMenuHandledOSX
	{
		[CompilerGenerated]
		internal get { } //Length: 11
		[CompilerGenerated]
		internal set { } //Length: 14
	}

	protected ContextualMenuManager() { }

	public void DisplayMenu(EventBase triggerEvent, IEventHandler target) { }

	internal void DisplayMenu(EventBase triggerEvent, IEventHandler target, DropdownMenu menu) { }

	public abstract void DisplayMenuIfEventMatches(EventBase evt, IEventHandler eventHandler) { }

	protected private abstract void DoDisplayMenu(DropdownMenu menu, EventBase triggerEvent) { }

	[CompilerGenerated]
	internal bool get_displayMenuHandledOSX() { }

	[CompilerGenerated]
	internal void set_displayMenuHandledOSX(bool value) { }

}

