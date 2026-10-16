namespace UnityEngine.UIElements;

[EventCategory(EventCategory::Keyboard (6))]
internal class IMEEvent : EventBase<IMEEvent>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal IMEEvent <.cctor>b__4_0() { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private string <compositionString>k__BackingField; //Field offset: 0x50

	protected string compositionString
	{
		[CompilerGenerated]
		 set { } //Length: 27
	}

	private static IMEEvent() { }

	public IMEEvent() { }

	public static IMEEvent GetPooled(string compositionString) { }

	protected virtual void Init() { }

	private void LocalInit() { }

	[CompilerGenerated]
	protected void set_compositionString(string value) { }

}

