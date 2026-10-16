namespace CriWare.CriTimeline.Atom;

public class CriAtomTimelinePreviewer : IDisposable
{
	private class PlayerSource : IDisposable
	{
		public readonly CriAtomExPlayer player; //Field offset: 0x8
		public readonly CriAtomEx3dSource source3d; //Field offset: 0xC
		private Nullable<Vector3> lastPos; //Field offset: 0x10
		private bool disposed; //Field offset: 0x20

		public PlayerSource() { }

		public void ClearLastPos() { }

		private void dispose() { }

		public override void Dispose() { }

		protected virtual void Finalize() { }

		public void Set3dTransform(Vector3 pos, Vector3 forward, Vector3 up, float deltaTime) { }

	}

	private class PreviewListener : IDisposable
	{
		public readonly CriAtomEx3dListener listener; //Field offset: 0x8
		public readonly CriAtomListener transformObj; //Field offset: 0xC
		private Nullable<Vector3> lastPos; //Field offset: 0x10
		private bool disposed; //Field offset: 0x20

		public PreviewListener(CriAtomListener listenerObj) { }

		public void ClearLastPos() { }

		private void dispose() { }

		public override void Dispose() { }

		public void Exile() { }

		protected virtual void Finalize() { }

		public void Set3dTransform(float deltaTime) { }

	}

	private static CriAtomTimelinePreviewer instance; //Field offset: 0x0
	private CriAtom atom; //Field offset: 0x8
	private string lastAcfFile; //Field offset: 0xC
	private Dictionary<String, CriAtomExAcb> acbTable; //Field offset: 0x10
	private Dictionary<Guid, PlayerSource> playerTable; //Field offset: 0x14
	private Dictionary<Guid, PreviewListener> listenerTable; //Field offset: 0x18
	private List<KeyValuePair`2<Guid, PreviewListener>> listenerPurgeList; //Field offset: 0x1C
	private Nullable<Guid> trackIdForListenerUpdate; //Field offset: 0x20

	public static CriAtomTimelinePreviewer Instance
	{
		 get { } //Length: 395
	}

	public static bool IsInitialized
	{
		 get { } //Length: 44
	}

	public CriAtomTimelinePreviewer() { }

	private void Dispose(bool disposing) { }

	public override void Dispose() { }

	protected virtual void Finalize() { }

	public static CriAtomTimelinePreviewer get_Instance() { }

	public static bool get_IsInitialized() { }

	public CriAtomExAcb GetAcb(string acbPath, string awbPath) { }

	private PlayerSource GetPlayer(Guid trackId) { }

	public void InitPreviewListenerList(CriAtomListener[] listenerList) { }

	public static void InstanceDispose() { }

	public CriAtomExPlayback Play(Guid trackId) { }

	public void PlayerUpdateParameter(Guid trackId, CriAtomExPlayback atomExPlayback) { }

	public void SetAISAC(Guid trackId, string controlName, float value) { }

	public void SetCue(Guid trackId, CriAtomExAcb acb, string cueName) { }

	public void SetLoop(Guid trackId, bool sw) { }

	public void SetPitch(Guid trackId, float pitch) { }

	public void SetStartTime(Guid trackId, long startTimeMs) { }

	public void SetVolume(Guid trackId, float volume) { }

	public void StopAllTracks(bool stopWithoutRelease = true) { }

	public void StopTrack(Guid trackId, bool stopWithoutRelease = true) { }

	public void Update3dTransform(Guid trackId, Transform transform, float deltaTime) { }

	public void UpdateAllListeners(Guid trackId, float deltaTime, CriAtomListener exclusiveObj) { }

	public void UpdateTimelineExtension(CriAtomSourceBase bindObject, Guid trackGuid) { }

}

