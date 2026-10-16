namespace UnityEngine.UIElements;

internal sealed class DataBindingManager : IDisposable
{
	public class BindingData
	{
		public long version; //Field offset: 0x8
		public BindingTarget target; //Field offset: 0x10
		public Binding binding; //Field offset: 0x60
		private DataSourceContext m_LastContext; //Field offset: 0x64
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private object <localDataSource>k__BackingField; //Field offset: 0xB0
		public Nullable<BindingResult> m_SourceToUILastUpdate; //Field offset: 0xB4
		public Nullable<BindingResult> m_UIToSourceLastUpdate; //Field offset: 0xC0

		public DataSourceContext context
		{
			 set { } //Length: 425
		}

		public object localDataSource
		{
			[CompilerGenerated]
			 get { } //Length: 14
			[CompilerGenerated]
			 set { } //Length: 33
		}

		public BindingData() { }

		[CompilerGenerated]
		public object get_localDataSource() { }

		public void Reset() { }

		public void set_context(DataSourceContext value) { }

		[CompilerGenerated]
		public void set_localDataSource(object value) { }

	}

	private struct BindingDataCollection : IDisposable
	{
		private Dictionary<BindingId, BindingData> m_BindingPerId; //Field offset: 0x0
		private List<BindingData> m_Bindings; //Field offset: 0x4

		public void AddBindingData(BindingData bindingData) { }

		public static BindingDataCollection Create() { }

		public override void Dispose() { }

		public int GetBindingCount() { }

		public List<BindingData> GetBindings() { }

		public bool RemoveBindingData(BindingData bindingData) { }

		public bool TryGetBindingData(in BindingId bindingId, out BindingData data) { }

	}

	[IsReadOnly]
	private struct BindingRequest
	{
		public readonly BindingId bindingId; //Field offset: 0x0
		public readonly Binding binding; //Field offset: 0x4C
		public readonly bool shouldProcess; //Field offset: 0x50

		public BindingRequest(in BindingId bindingId, Binding binding, bool shouldProcess = true) { }

		public BindingRequest CancelRequest() { }

	}

	[IsReadOnly]
	public struct ChangesFromUI
	{
		public readonly long version; //Field offset: 0x0
		public readonly Binding binding; //Field offset: 0x8
		public readonly BindingData bindingData; //Field offset: 0xC

		public bool IsValid
		{
			 get { } //Length: 54
		}

		public ChangesFromUI(BindingData bindingData) { }

		public bool get_IsValid() { }

	}

	private class HierarchyBindingTracker : IDisposable
	{
		private class HierarchicalBindingsSorter : HierarchyTraversal
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			private HashSet<VisualElement> <boundElements>k__BackingField; //Field offset: 0x8
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			private List<VisualElement> <results>k__BackingField; //Field offset: 0xC

			public HashSet<VisualElement> boundElements
			{
				[CompilerGenerated]
				 get { } //Length: 11
				[CompilerGenerated]
				 set { } //Length: 27
			}

			public List<VisualElement> results
			{
				[CompilerGenerated]
				 get { } //Length: 11
				[CompilerGenerated]
				 set { } //Length: 27
			}

			public HierarchicalBindingsSorter() { }

			[CompilerGenerated]
			public HashSet<VisualElement> get_boundElements() { }

			[CompilerGenerated]
			public List<VisualElement> get_results() { }

			[CompilerGenerated]
			public void set_boundElements(HashSet<VisualElement> value) { }

			[CompilerGenerated]
			public void set_results(List<VisualElement> value) { }

			public virtual void TraverseRecursive(VisualElement element, int depth) { }

		}

		private readonly BaseVisualElementPanel m_Panel; //Field offset: 0x8
		private readonly HierarchicalBindingsSorter m_BindingSorter; //Field offset: 0xC
		private readonly Dictionary<VisualElement, BindingDataCollection> m_BindingDataPerElement; //Field offset: 0x10
		private readonly HashSet<VisualElement> m_BoundElements; //Field offset: 0x14
		private readonly List<VisualElement> m_OrderedBindings; //Field offset: 0x18
		private bool m_IsDirty; //Field offset: 0x1C
		private EventCallback<PropertyChangedEvent, Dictionary`2<VisualElement, BindingDataCollection>> m_OnPropertyChanged; //Field offset: 0x20

		public HierarchyBindingTracker(BaseVisualElementPanel panel) { }

		public override void Dispose() { }

		public List<VisualElement> GetBoundElements() { }

		public int GetTrackedElementsCount() { }

		public bool IsTrackingElement(VisualElement element) { }

		private void OnPropertyChanged(PropertyChangedEvent evt, Dictionary<VisualElement, BindingDataCollection> bindingCollection) { }

		private void OrderBindings(VisualElement root) { }

		public void SetDirty() { }

		public void StartTrackingBinding(VisualElement element, BindingData binding) { }

		public void StopTrackingBinding(VisualElement element, BindingData binding) { }

		public void StopTrackingElement(VisualElement element) { }

		public bool TryGetBindingCollection(VisualElement element, out BindingDataCollection collection) { }

	}

	private class HierarchyDataSourceTracker : IDisposable
	{
		private class InvalidateDataSourcesTraversal : HierarchyTraversal
		{
			private readonly HierarchyDataSourceTracker m_DataSourceTracker; //Field offset: 0x8
			private readonly HashSet<VisualElement> m_VisitedElements; //Field offset: 0xC

			public InvalidateDataSourcesTraversal(HierarchyDataSourceTracker dataSourceTracker) { }

			public void Invalidate(List<VisualElement> addedOrMovedElements, HashSet<VisualElement> removedElements) { }

			public virtual void TraverseRecursive(VisualElement element, int depth) { }

		}

		private class ObjectComparer : IEqualityComparer<Object>
		{

			public ObjectComparer() { }

			private override bool System.Collections.Generic.IEqualityComparer<System.Object>.Equals(object x, object y) { }

			private override int System.Collections.Generic.IEqualityComparer<System.Object>.GetHashCode(object obj) { }

		}

		private class SourceInfo
		{
			private HashSet<PropertyPath> m_DetectedChanges; //Field offset: 0x8
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			private long <lastVersion>k__BackingField; //Field offset: 0x10
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			private int <refCount>k__BackingField; //Field offset: 0x18

			public HashSet<PropertyPath> detectedChanges
			{
				 get { } //Length: 101
			}

			public HashSet<PropertyPath> detectedChangesNoAlloc
			{
				 get { } //Length: 11
			}

			public long lastVersion
			{
				[CompilerGenerated]
				 get { } //Length: 14
				[CompilerGenerated]
				 set { } //Length: 20
			}

			public int refCount
			{
				[CompilerGenerated]
				 get { } //Length: 11
				[CompilerGenerated]
				 set { } //Length: 14
			}

			public SourceInfo() { }

			public HashSet<PropertyPath> get_detectedChanges() { }

			public HashSet<PropertyPath> get_detectedChangesNoAlloc() { }

			[CompilerGenerated]
			public long get_lastVersion() { }

			[CompilerGenerated]
			public int get_refCount() { }

			[CompilerGenerated]
			public void set_lastVersion(long value) { }

			[CompilerGenerated]
			public void set_refCount(int value) { }

		}

		private readonly List<SourceInfo> m_SourceInfosPool; //Field offset: 0x8
		private readonly DataBindingManager m_DataBindingManager; //Field offset: 0xC
		private readonly Dictionary<VisualElement, DataSourceContext> m_ResolvedHierarchicalDataSourceContext; //Field offset: 0x10
		private readonly Dictionary<Binding, Int32> m_BindingRefCount; //Field offset: 0x14
		private readonly Dictionary<Object, SourceInfo> m_SourceInfos; //Field offset: 0x18
		private readonly HashSet<Object> m_SourcesToRemove; //Field offset: 0x1C
		private readonly InvalidateDataSourcesTraversal m_InvalidateResolvedDataSources; //Field offset: 0x20
		private readonly EventHandler<BindablePropertyChangedEventArgs> m_Handler; //Field offset: 0x24
		private readonly EventCallback<PropertyChangedEvent, VisualElement> m_VisualElementHandler; //Field offset: 0x28

		public HierarchyDataSourceTracker(DataBindingManager manager) { }

		public void ClearChangesFromSource(object dataSource) { }

		public void ClearSourceCache() { }

		internal void DecreaseBindingRefCount(ref BindingData bindingData) { }

		internal void DecreaseRefCount(object dataSource) { }

		public override void Dispose() { }

		public HashSet<PropertyPath> GetChangesFromSource(object dataSource) { }

		internal DataSourceContext GetHierarchicalDataSourceContext(VisualElement element) { }

		private SourceInfo GetPooledSourceInfo() { }

		public DataSourceContext GetResolvedDataSourceContext(VisualElement element, BindingData bindingData) { }

		public int GetTrackedDataSourcesCount() { }

		internal void IncreaseBindingRefCount(ref BindingData bindingData) { }

		internal void IncreaseRefCount(object dataSource) { }

		public void InvalidateCachedDataSource(HashSet<VisualElement> elements, HashSet<VisualElement> removedElements) { }

		private void OnVisualElementPropertyChanged(PropertyChangedEvent evt, VisualElement element) { }

		private void ReleasePooledSourceInfo(SourceInfo info) { }

		internal void RemoveHierarchyDataSourceContextFromElement(VisualElement element) { }

		private void TrackPropertyChanges(object sender, BindablePropertyChangedEventArgs args) { }

		private void TrackPropertyChanges(object sender, PropertyPath propertyPath) { }

		public bool TryGetLastVersion(object source, out long version) { }

		public void UpdateVersion(object source, long version) { }

	}

	private struct IgnoreUIChangesData
	{
		public VisualElement element; //Field offset: 0x0
		public Binding binding; //Field offset: 0x4
		public BindingId bindingId; //Field offset: 0x8

		public bool ShouldIgnoreChange(VisualElement ve, Binding b, BindingId id) { }

	}

	internal struct IgnoreUIChangesScope : IDisposable
	{
		private IgnoreUIChangesData m_ScopeData; //Field offset: 0x0
		private DataBindingManager manager; //Field offset: 0x54

		internal IgnoreUIChangesScope(DataBindingManager manager, VisualElement target, BindingId bindingId, Binding binding) { }

		public override void Dispose() { }

	}

	private static readonly PropertyName k_RequestBindingPropertyName; //Field offset: 0x0
	private static readonly BindingId k_ClearBindingsToken; //Field offset: 0x4
	internal static BindingLogLevel globalLogLevel; //Field offset: 0x50
	private static readonly List<BindingData> s_Empty; //Field offset: 0x54
	private readonly List<BindingData> m_BindingDataLocalPool; //Field offset: 0x8
	private Nullable<BindingLogLevel> m_LogLevel; //Field offset: 0xC
	private readonly BaseVisualElementPanel m_Panel; //Field offset: 0x14
	private readonly HierarchyDataSourceTracker m_DataSourceTracker; //Field offset: 0x18
	private readonly HierarchyBindingTracker m_BindingsTracker; //Field offset: 0x1C
	private readonly List<ChangesFromUI> m_DetectedChangesFromUI; //Field offset: 0x20
	private IgnoreUIChangesData m_IgnoreUIChangesData; //Field offset: 0x24

	internal BindingLogLevel logLevel
	{
		internal get { } //Length: 99
		internal set { } //Length: 83
	}

	private static DataBindingManager() { }

	internal DataBindingManager(BaseVisualElementPanel panel) { }

	internal static bool AnyPendingBindingRequests(VisualElement element) { }

	internal void CacheSourceBindingResult(BindingData bindingData, BindingResult result) { }

	internal void CacheUIBindingResult(BindingData bindingData, BindingResult result) { }

	private void ClearAllBindings(VisualElement element) { }

	internal void ClearChangesFromSource(object dataSource) { }

	public void ClearSourceCache() { }

	private static void CreateBindingRequest(VisualElement target, in BindingId bindingId, Binding binding, bool isTransferring) { }

	public void DirtyBindingOrder() { }

	public override void Dispose() { }

	internal BindingLogLevel get_logLevel() { }

	internal List<BindingData> GetBindingData(VisualElement element) { }

	internal IEnumerable<VisualElement> GetBoundElements() { }

	internal int GetBoundElementsCount() { }

	internal HashSet<PropertyPath> GetChangedDetectedFromSource(object dataSource) { }

	internal List<ChangesFromUI> GetChangedDetectedFromUI() { }

	public BindingData GetPooledBindingData(BindingTarget target, Binding binding) { }

	internal DataSourceContext GetResolvedDataSourceContext(VisualElement element, BindingData bindingData) { }

	internal int GetTrackedDataSourcesCount() { }

	public IgnoreUIChangesScope IgnoreChangesScope(VisualElement target, BindingId bindingId, Binding binding) { }

	public void InvalidateCachedDataSource(HashSet<VisualElement> addedOrMovedElements, HashSet<VisualElement> removedElements) { }

	public void ProcessBindingRequests(VisualElement element) { }

	internal void RegisterBinding(VisualElement element, in BindingId bindingId, Binding binding) { }

	public void ReleasePoolBindingData(BindingData data) { }

	internal void ResetLogLevel() { }

	internal void set_logLevel(BindingLogLevel value) { }

	public void TrackDataSource(object previous, object current) { }

	internal void TransferBindingRequests(VisualElement element) { }

	internal bool TryGetBindingData(VisualElement element, in BindingId bindingId, out BindingData bindingData) { }

	internal static bool TryGetBindingRequest(VisualElement element, in BindingId bindingId, out Binding binding) { }

	internal bool TryGetLastSourceBindingResult(BindingData bindingData, out BindingResult result) { }

	internal bool TryGetLastUIBindingResult(BindingData bindingData, out BindingResult result) { }

	internal bool TryGetLastVersion(object source, out long version) { }

	internal void UnregisterBinding(VisualElement element, in BindingId bindingId) { }

	internal void UpdateVersion(object source, long version) { }

}

