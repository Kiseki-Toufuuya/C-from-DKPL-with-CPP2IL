namespace UnityEngine.UIElements;

public class DropdownMenuAction : DropdownMenuItem
{
	[Flags]
	internal enum Status
	{
		None = 0,
		Normal = 1,
		Disabled = 2,
		Checked = 4,
		Hidden = 8,
	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly string <name>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Status <status>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private DropdownMenuEventInfo <eventInfo>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private object <userData>k__BackingField; //Field offset: 0x14
	private readonly Action<DropdownMenuAction> actionCallback; //Field offset: 0x18
	private readonly Func<DropdownMenuAction, Status> actionStatusCallback; //Field offset: 0x1C

	private DropdownMenuEventInfo eventInfo
	{
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public string name
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	private Status status
	{
		[CompilerGenerated]
		private set { } //Length: 14
	}

	private object userData
	{
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public DropdownMenuAction(string actionName, Action<DropdownMenuAction> actionCallback, Func<DropdownMenuAction, Status> actionStatusCallback, object userData = null) { }

	public static Status AlwaysDisabled(DropdownMenuAction a) { }

	public static Status AlwaysEnabled(DropdownMenuAction a) { }

	[CompilerGenerated]
	public string get_name() { }

	[CompilerGenerated]
	private void set_eventInfo(DropdownMenuEventInfo value) { }

	[CompilerGenerated]
	private void set_status(Status value) { }

	[CompilerGenerated]
	private void set_userData(object value) { }

	public void UpdateActionStatus(DropdownMenuEventInfo eventInfo) { }

}

