namespace UnityEngine.UIElements;

internal class VisualElementAnimationSystem : BaseVisualTreeUpdater
{
	private static readonly string s_Description; //Field offset: 0x0
	private static readonly ProfilerMarker s_ProfilerMarker; //Field offset: 0x4
	private static readonly string s_StylePropertyAnimationDescription; //Field offset: 0x8
	private static readonly ProfilerMarker s_StylePropertyAnimationProfilerMarker; //Field offset: 0xC
	private HashSet<IValueAnimationUpdate> m_Animations; //Field offset: 0x18
	private List<IValueAnimationUpdate> m_IterationList; //Field offset: 0x1C
	private bool m_HasNewAnimations; //Field offset: 0x20
	private bool m_IterationListDirty; //Field offset: 0x21
	private long lastUpdate; //Field offset: 0x28

	public virtual ProfilerMarker profilerMarker
	{
		 get { } //Length: 61
	}

	private static ProfilerMarker stylePropertyAnimationProfilerMarker
	{
		private get { } //Length: 61
	}

	private static VisualElementAnimationSystem() { }

	public VisualElementAnimationSystem() { }

	public virtual ProfilerMarker get_profilerMarker() { }

	private static ProfilerMarker get_stylePropertyAnimationProfilerMarker() { }

	public virtual void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	public void RegisterAnimation(IValueAnimationUpdate anim) { }

	public void RegisterAnimations(List<IValueAnimationUpdate> anims) { }

	public void UnregisterAnimation(IValueAnimationUpdate anim) { }

	public void UnregisterAnimations(List<IValueAnimationUpdate> anims) { }

	public virtual void Update() { }

}

