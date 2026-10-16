namespace CriWare;

public abstract class CriAtomSourceBase : CriMonoBehaviour
{
	internal enum Status
	{
		Stop = 0,
		Prep = 1,
		Playing = 2,
		PlayEnd = 3,
		Error = 4,
	}

	[CompilerGenerated]
	private CriAtomExPlayer <player>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private CriAtomEx3dSource <source>k__BackingField; //Field offset: 0x24
	protected bool initialized; //Field offset: 0x28
	protected Vector3 lastPosition; //Field offset: 0x2C
	protected bool hasValidPosition; //Field offset: 0x38
	private CriAtomRegion currentRegion; //Field offset: 0x3C
	private CriAtomListener currentListener; //Field offset: 0x40
	[SerializeField]
	private bool _playOnStart; //Field offset: 0x44
	[SerializeField]
	private CriAtomRegion _regionOnStart; //Field offset: 0x48
	[SerializeField]
	private CriAtomListener _listenerOnStart; //Field offset: 0x4C
	[SerializeField]
	private bool _use3dPositioning; //Field offset: 0x50
	[SerializeField]
	private bool _freezeOrientation; //Field offset: 0x51
	[SerializeField]
	private bool _loop; //Field offset: 0x52
	[SerializeField]
	private float _volume; //Field offset: 0x54
	[SerializeField]
	private float _pitch; //Field offset: 0x58
	[SerializeField]
	private bool _androidUseLowLatencyVoicePool; //Field offset: 0x5C
	[SerializeField]
	private bool need_to_player_update_all; //Field offset: 0x5D
	[SerializeField]
	private bool _use3dRandomization; //Field offset: 0x5E
	[SerializeField]
	private uint _randomPositionListMaxLength; //Field offset: 0x60
	[SerializeField]
	private Randomize3dConfig randomize3dConfig; //Field offset: 0x64

	public bool androidUseLowLatencyVoicePool
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public bool attenuationDistanceSetting
	{
		 get { } //Length: 122
		 set { } //Length: 141
	}

	public bool freezeOrientation
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public CriAtomListener listener
	{
		 get { } //Length: 11
		 set { } //Length: 197
	}

	public CriAtomListener listenerOnStart
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public bool loop
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public float pan3dAngle
	{
		 get { } //Length: 33
		 set { } //Length: 44
	}

	public float pan3dDistance
	{
		 get { } //Length: 33
		 set { } //Length: 44
	}

	public float pitch
	{
		 get { } //Length: 11
		 set { } //Length: 49
	}

	public CriAtomExPlayer player
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public bool playOnStart
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public uint randomPositionListMaxLength
	{
		 get { } //Length: 11
		 set { } //Length: 101
	}

	public CriAtomRegion region3d
	{
		 get { } //Length: 11
		 set { } //Length: 618
	}

	public CriAtomRegion regionOnStart
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public CriAtomEx3dSource source
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public int startTime
	{
		 get { } //Length: 33
		 set { } //Length: 39
	}

	public Status status
	{
		 get { } //Length: 34
	}

	public long time
	{
		 get { } //Length: 33
	}

	public bool use3dPositioning
	{
		 get { } //Length: 11
		 set { } //Length: 51
	}

	public bool use3dRandomization
	{
		 get { } //Length: 11
		 set { } //Length: 146
	}

	public float volume
	{
		 get { } //Length: 11
		 set { } //Length: 49
	}

	protected CriAtomSourceBase() { }

	public void AttachToAnalyzer(CriAtomExOutputAnalyzer analyzer) { }

	private void Awake() { }

	public virtual void CriInternalLateUpdate() { }

	public virtual void CriInternalUpdate() { }

	public void DetachFromAnalyzer(CriAtomExOutputAnalyzer analyzer) { }

	public bool get_androidUseLowLatencyVoicePool() { }

	public bool get_attenuationDistanceSetting() { }

	public bool get_freezeOrientation() { }

	public CriAtomListener get_listener() { }

	public CriAtomListener get_listenerOnStart() { }

	public bool get_loop() { }

	public float get_pan3dAngle() { }

	public float get_pan3dDistance() { }

	public float get_pitch() { }

	[CompilerGenerated]
	public CriAtomExPlayer get_player() { }

	public bool get_playOnStart() { }

	public uint get_randomPositionListMaxLength() { }

	public CriAtomRegion get_region3d() { }

	public CriAtomRegion get_regionOnStart() { }

	[CompilerGenerated]
	public CriAtomEx3dSource get_source() { }

	public int get_startTime() { }

	public Status get_status() { }

	public long get_time() { }

	public bool get_use3dPositioning() { }

	public bool get_use3dRandomization() { }

	public float get_volume() { }

	protected abstract CriAtomExAcb GetAcb() { }

	protected override void InternalFinalize() { }

	protected override void InternalInitialize() { }

	protected CriAtomExPlayback InternalPlayCue() { }

	public bool IsPaused() { }

	private void OnDestroy() { }

	protected virtual void OnEnable() { }

	public void Pause(bool sw) { }

	public CriAtomExPlayback Play(string cueName) { }

	public abstract CriAtomExPlayback Play() { }

	public CriAtomExPlayback Play(int cueId) { }

	protected abstract void PlayOnStart() { }

	public void set_androidUseLowLatencyVoicePool(bool value) { }

	public void set_attenuationDistanceSetting(bool value) { }

	public void set_freezeOrientation(bool value) { }

	public void set_listener(CriAtomListener value) { }

	public void set_listenerOnStart(CriAtomListener value) { }

	public void set_loop(bool value) { }

	public void set_pan3dAngle(float value) { }

	public void set_pan3dDistance(float value) { }

	public void set_pitch(float value) { }

	[CompilerGenerated]
	protected void set_player(CriAtomExPlayer value) { }

	public void set_playOnStart(bool value) { }

	public void set_randomPositionListMaxLength(uint value) { }

	public void set_region3d(CriAtomRegion value) { }

	public void set_regionOnStart(CriAtomRegion value) { }

	[CompilerGenerated]
	protected void set_source(CriAtomEx3dSource value) { }

	public void set_startTime(int value) { }

	public void set_use3dPositioning(bool value) { }

	public void set_use3dRandomization(bool value) { }

	public void set_volume(float value) { }

	[Obsolete("Use CriAtomSource.SetAisacControl")]
	public void SetAisac(uint controlId, float value) { }

	[Obsolete("Use CriAtomSource.SetAisacControl")]
	public void SetAisac(string controlName, float value) { }

	public void SetAisacControl(uint controlId, float value) { }

	public void SetAisacControl(string controlName, float value) { }

	public void SetBusSendLevel(string busName, float level) { }

	[Obsolete("Use CriAtomSource.SetBusSendLevel(string, float)")]
	public void SetBusSendLevel(int busId, float level) { }

	public void SetBusSendLevelOffset(string busName, float levelOffset) { }

	[Obsolete("Use CriAtomSource.SetBusSendLevelOffset(string, float)")]
	public void SetBusSendLevelOffset(int busId, float levelOffset) { }

	protected override void SetInitialParameters() { }

	protected bool SetInitialSourcePosition() { }

	protected void SetNeedToPlayerUpdateAll() { }

	private void Start() { }

	public void Stop() { }

	protected override void UpdatePosition() { }

}

