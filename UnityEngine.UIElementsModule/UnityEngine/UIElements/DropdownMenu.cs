namespace UnityEngine.UIElements;

public class DropdownMenu
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0
	{
		public Status status; //Field offset: 0x8

		public <>c__DisplayClass10_0() { }

		internal Status <AppendAction>b__0(DropdownMenuAction e) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_0
	{
		public string subMenuPath; //Field offset: 0x8

		public <>c__DisplayClass13_0() { }

		internal bool <AppendSeparator>b__0(DropdownMenuItem item) { }

	}

	private List<DropdownMenuItem> m_MenuItems; //Field offset: 0x8
	private DropdownMenuEventInfo m_DropdownMenuEventInfo; //Field offset: 0xC

	internal int Count
	{
		internal get { } //Length: 52
	}

	public DropdownMenu() { }

	public void AppendAction(string actionName, Action<DropdownMenuAction> action, Func<DropdownMenuAction, Status> actionStatusCallback, object userData = null) { }

	public void AppendAction(string actionName, Action<DropdownMenuAction> action, Status status = 1) { }

	public void AppendSeparator(string subMenuPath = null) { }

	internal int get_Count() { }

	public void InsertSeparator(string subMenuPath, int atIndex) { }

	public List<DropdownMenuItem> MenuItems() { }

	public void PrepareForDisplay(EventBase e) { }

}

