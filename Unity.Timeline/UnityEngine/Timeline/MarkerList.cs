namespace UnityEngine.Timeline;

[DefaultMember("Item")]
internal struct MarkerList : ISerializationCallbackReceiver
{
	[HideInInspector]
	[SerializeField]
	private List<ScriptableObject> m_Objects; //Field offset: 0x0
	[HideInInspector]
	private List<IMarker> m_Cache; //Field offset: 0x4
	private bool m_CacheDirty; //Field offset: 0x8
	private bool m_HasNotifications; //Field offset: 0x9

	public int Count
	{
		 get { } //Length: 65
	}

	public IMarker Item
	{
		 get { } //Length: 80
	}

	public List<IMarker> markers
	{
		 get { } //Length: 24
	}

	public MarkerList(int capacity) { }

	public void Add(ScriptableObject item) { }

	private void BuildCache() { }

	public void Clear() { }

	public bool Contains(ScriptableObject item) { }

	public IMarker CreateMarker(Type type, double time, TrackAsset owner) { }

	public int get_Count() { }

	public IMarker get_Item(int idx) { }

	public List<IMarker> get_markers() { }

	public IEnumerable<IMarker> GetMarkers() { }

	public List<ScriptableObject> GetRawMarkerList() { }

	public bool HasNotifications() { }

	public bool Remove(IMarker item) { }

	public bool Remove(ScriptableObject item, TimelineAsset timelineAsset, PlayableAsset thingToDirty) { }

	private override void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	private override void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

}

