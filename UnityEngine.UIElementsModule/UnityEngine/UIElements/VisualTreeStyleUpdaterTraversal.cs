namespace UnityEngine.UIElements;

[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal class VisualTreeStyleUpdaterTraversal : HierarchyTraversal
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison<SelectorMatchRecord> <>9__28_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal int <ProcessMatchedRules>b__28_0(SelectorMatchRecord a, SelectorMatchRecord b) { }

	}

	private StyleVariableContext m_ProcessVarContext; //Field offset: 0x8
	private HashSet<VisualElement> m_UpdateList; //Field offset: 0xC
	private HashSet<VisualElement> m_ParentList; //Field offset: 0x10
	private List<SelectorMatchRecord> m_TempMatchResults; //Field offset: 0x14
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private float <currentPixelsPerPoint>k__BackingField; //Field offset: 0x18
	private StyleMatchingContext m_StyleMatchingContext; //Field offset: 0x1C
	private StylePropertyReader m_StylePropertyReader; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private BaseVisualElementPanel <currentPanel>k__BackingField; //Field offset: 0x24
	private readonly List<StylePropertyId> m_AnimatedProperties; //Field offset: 0x28

	private BaseVisualElementPanel currentPanel
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	private float currentPixelsPerPoint
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 18
	}

	public VisualTreeStyleUpdaterTraversal() { }

	public void AddChangedElement(VisualElement ve, VersionChangeType versionChangeType) { }

	internal void CancelAnimationsWithNoTransitionProperty(VisualElement element, ref ComputedStyle newStyle) { }

	public void Clear() { }

	private void ForceUpdateTransitions(VisualElement element) { }

	[CompilerGenerated]
	private BaseVisualElementPanel get_currentPanel() { }

	[CompilerGenerated]
	private float get_currentPixelsPerPoint() { }

	private static void OnProcessMatchResult(VisualElement current, MatchResultInfo info) { }

	public void PrepareTraversal(BaseVisualElementPanel panel, float pixelsPerPoint) { }

	private ComputedStyle ProcessMatchedRules(VisualElement element, List<SelectorMatchRecord> matchingSelectors) { }

	private void ProcessMatchedVariables(StyleSheet sheet, StyleRule rule) { }

	private void ProcessTransitions(VisualElement element, ref ComputedStyle oldStyle, ref ComputedStyle newStyle) { }

	private void PropagateToChildren(VisualElement ve) { }

	private void PropagateToParents(VisualElement ve) { }

	[CompilerGenerated]
	private void set_currentPanel(BaseVisualElementPanel value) { }

	[CompilerGenerated]
	private void set_currentPixelsPerPoint(float value) { }

	protected bool ShouldSkipElement(VisualElement element) { }

	public virtual void TraverseRecursive(VisualElement element, int depth) { }

}

