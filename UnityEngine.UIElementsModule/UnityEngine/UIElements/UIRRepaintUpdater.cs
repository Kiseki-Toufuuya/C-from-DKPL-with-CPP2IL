namespace UnityEngine.UIElements;

internal class UIRRepaintUpdater : BaseVisualTreeUpdater, IPanelRenderer
{
	private static readonly string s_Description; //Field offset: 0x0
	private static readonly ProfilerMarker s_ProfilerMarker; //Field offset: 0x4
	private BaseVisualElementPanel attachedPanel; //Field offset: 0x18
	internal RenderChain renderChain; //Field offset: 0x1C
	private bool m_ForceGammaRendering; //Field offset: 0x20
	private uint m_VertexBudget; //Field offset: 0x24
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <drawStats>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <breakBatches>k__BackingField; //Field offset: 0x29
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <disposed>k__BackingField; //Field offset: 0x2A

	public bool breakBatches
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	protected private bool disposed
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	public bool drawStats
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public override bool forceGammaRendering
	{
		 get { } //Length: 11
		 set { } //Length: 30
	}

	public virtual ProfilerMarker profilerMarker
	{
		 get { } //Length: 61
	}

	public override uint vertexBudget
	{
		 get { } //Length: 11
		 set { } //Length: 30
	}

	private static UIRRepaintUpdater() { }

	public UIRRepaintUpdater() { }

	private void AttachToPanel() { }

	protected override RenderChain CreateRenderChain() { }

	private void DestroyRenderChain() { }

	private void DetachFromPanel() { }

	protected virtual void Dispose(bool disposing) { }

	[CompilerGenerated]
	public bool get_breakBatches() { }

	[CompilerGenerated]
	protected bool get_disposed() { }

	[CompilerGenerated]
	public bool get_drawStats() { }

	public override bool get_forceGammaRendering() { }

	public virtual ProfilerMarker get_profilerMarker() { }

	public override uint get_vertexBudget() { }

	private void InitRenderChain() { }

	private static void OnGraphicsResourcesRecreate(bool recreate) { }

	private void OnPanelAtlasChanged() { }

	private void OnPanelChanged(BaseVisualElementPanel obj) { }

	private void OnPanelDrawsInCamerasChanged() { }

	private void OnPanelHierarchyChanged(VisualElement ve, HierarchyChangeType changeType, IReadOnlyList<VisualElement> additionalContext = null) { }

	private void OnPanelIsFlatChanged() { }

	public virtual void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	public override void Render() { }

	public override void Reset() { }

	private void ResetAllElementsDataRecursive(VisualElement ve) { }

	[CompilerGenerated]
	private void set_disposed(bool value) { }

	public override void set_forceGammaRendering(bool value) { }

	public override void set_vertexBudget(uint value) { }

	public virtual void Update() { }

}

