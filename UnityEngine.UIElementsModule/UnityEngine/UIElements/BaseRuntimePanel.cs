namespace UnityEngine.UIElements;

internal abstract class BaseRuntimePanel : Panel
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal Vector2 <.cctor>b__52_0(Vector2 p) { }

	}

	private static int s_CurrentRuntimePanelCounter; //Field offset: 0x0
	internal static readonly Func<Vector2, Vector2> DefaultScreenToPanelSpace; //Field offset: 0x4
	private GameObject m_SelectableGameObject; //Field offset: 0xF0
	internal readonly int m_RuntimePanelCreationIndex; //Field offset: 0xF4
	private float m_SortingPriority; //Field offset: 0xF8
	internal int resolvedSortingIndex; //Field offset: 0xFC
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action destroyed; //Field offset: 0x100
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action drawsInCamerasChanged; //Field offset: 0x104
	private bool m_DrawsInCameras; //Field offset: 0x108
	private float m_PixelsPerUnit; //Field offset: 0x10C
	internal RenderTexture targetTexture; //Field offset: 0x110
	internal int worldSpaceLayer; //Field offset: 0x114
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <targetDisplay>k__BackingField; //Field offset: 0x118
	private Func<Vector2, Vector2> m_ScreenToPanelSpace; //Field offset: 0x11C

	public event Action destroyed
	{
		[CompilerGenerated]
		 add { } //Length: 118
		[CompilerGenerated]
		 remove { } //Length: 118
	}

	internal event Action drawsInCamerasChanged
	{
		[CompilerGenerated]
		internal add { } //Length: 118
		[CompilerGenerated]
		internal remove { } //Length: 118
	}

	internal bool drawsInCameras
	{
		internal get { } //Length: 14
		internal set { } //Length: 49
	}

	internal float pixelsPerUnit
	{
		internal get { } //Length: 14
		internal set { } //Length: 21
	}

	internal int screenRenderingHeight
	{
		internal get { } //Length: 76
	}

	internal int screenRenderingWidth
	{
		internal get { } //Length: 76
	}

	public Func<Vector2, Vector2> screenToPanelSpace
	{
		 get { } //Length: 14
		 set { } //Length: 106
	}

	public override GameObject selectableGameObject
	{
		 get { } //Length: 14
		 set { } //Length: 129
	}

	public float sortingPriority
	{
		 get { } //Length: 14
		 set { } //Length: 221
	}

	internal int targetDisplay
	{
		[CompilerGenerated]
		internal get { } //Length: 14
		[CompilerGenerated]
		internal set { } //Length: 17
	}

	private static BaseRuntimePanel() { }

	protected BaseRuntimePanel(ScriptableObject ownerObject, EventDispatcher dispatcher = null) { }

	[CompilerGenerated]
	public void add_destroyed(Action value) { }

	[CompilerGenerated]
	internal void add_drawsInCamerasChanged(Action value) { }

	private void AssignPanelToComponents(BaseRuntimePanel panel) { }

	protected virtual void Dispose(bool disposing) { }

	internal bool get_drawsInCameras() { }

	internal float get_pixelsPerUnit() { }

	internal int get_screenRenderingHeight() { }

	internal int get_screenRenderingWidth() { }

	public Func<Vector2, Vector2> get_screenToPanelSpace() { }

	public override GameObject get_selectableGameObject() { }

	public float get_sortingPriority() { }

	[CompilerGenerated]
	internal int get_targetDisplay() { }

	internal static int getScreenRenderingHeight(int display) { }

	internal static int getScreenRenderingWidth(int display) { }

	private void InvokeDrawsInCamerasChanged() { }

	internal void PointerEntersPanel(int pointerId, Vector2 position) { }

	internal void PointerLeavesPanel(int pointerId, Vector2 position) { }

	[CompilerGenerated]
	public void remove_destroyed(Action value) { }

	[CompilerGenerated]
	internal void remove_drawsInCamerasChanged(Action value) { }

	public virtual void Render() { }

	internal Vector2 ScreenToPanel(Vector2 screen) { }

	internal bool ScreenToPanel(Vector2 screenPosition, Vector2 screenDelta, out Vector2 panelPosition, out Vector2 panelDelta, bool allowOutside = false) { }

	internal void set_drawsInCameras(bool value) { }

	internal void set_pixelsPerUnit(float value) { }

	public void set_screenToPanelSpace(Func<Vector2, Vector2> value) { }

	public override void set_selectableGameObject(GameObject value) { }

	public void set_sortingPriority(float value) { }

	[CompilerGenerated]
	internal void set_targetDisplay(int value) { }

	internal override void Update() { }

}

