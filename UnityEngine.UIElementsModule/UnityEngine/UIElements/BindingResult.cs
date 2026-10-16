namespace UnityEngine.UIElements;

[IsReadOnly]
public struct BindingResult
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly BindingStatus <status>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly string <message>k__BackingField; //Field offset: 0x4

	public string message
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public BindingStatus status
	{
		[CompilerGenerated]
		 get { } //Length: 10
	}

	public BindingResult(BindingStatus status, string message = null) { }

	[CompilerGenerated]
	public string get_message() { }

	[CompilerGenerated]
	public BindingStatus get_status() { }

}

