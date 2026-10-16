namespace UnityEngine.UIElements;

internal abstract class BaseVisualTreeUpdater : IVisualTreeUpdater, IDisposable
{
	private long frameCount; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action<BaseVisualElementPanel> panelChanged; //Field offset: 0x10
	private BaseVisualElementPanel m_Panel; //Field offset: 0x14

	public event Action<BaseVisualElementPanel> panelChanged
	{
		[CompilerGenerated]
		 add { } //Length: 125
		[CompilerGenerated]
		 remove { } //Length: 125
	}

	public override BaseVisualElementPanel panel
	{
		 get { } //Length: 11
		 set { } //Length: 55
	}

	public abstract ProfilerMarker profilerMarker
	{
		 get { } //Length: 0
	}

	private override long UnityEngine.UIElements.IVisualTreeUpdater.FrameCount
	{
		private get { } //Length: 14
		private set { } //Length: 20
	}

	public VisualElement visualTree
	{
		 get { } //Length: 40
	}

	protected BaseVisualTreeUpdater() { }

	[CompilerGenerated]
	public void add_panelChanged(Action<BaseVisualElementPanel> value) { }

	public override void Dispose() { }

	protected override void Dispose(bool disposing) { }

	public override BaseVisualElementPanel get_panel() { }

	public abstract ProfilerMarker get_profilerMarker() { }

	public VisualElement get_visualTree() { }

	public abstract void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	[CompilerGenerated]
	public void remove_panelChanged(Action<BaseVisualElementPanel> value) { }

	public override void set_panel(BaseVisualElementPanel value) { }

	private override long UnityEngine.UIElements.IVisualTreeUpdater.get_FrameCount() { }

	private override void UnityEngine.UIElements.IVisualTreeUpdater.set_FrameCount(long value) { }

	public abstract void Update() { }

}

