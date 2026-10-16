namespace UnityEngine.Timeline;

public class TimelineClip : ICurvesOwner, ISerializationCallbackReceiver
{
	internal enum BlendCurveMode
	{
		Auto = 0,
		Manual = 1,
	}

	internal enum ClipExtrapolation
	{
		None = 0,
		Hold = 1,
		Loop = 2,
		PingPong = 3,
		Continue = 4,
	}

	private static class TimelineClipUpgrade
	{

		public static void UpgradeClipInFromGlobalToLocal(TimelineClip clip) { }

	}

	private enum Versions
	{
		Initial = 0,
		ClipInFromGlobalToLocal = 1,
	}

	private const int k_LatestVersion = 1; //Field offset: 0x0
	public static readonly ClipCaps kDefaultClipCaps; //Field offset: 0x0
	public static readonly float kDefaultClipDurationInSeconds; //Field offset: 0x4
	public static readonly double kTimeScaleMin; //Field offset: 0x8
	public static readonly double kTimeScaleMax; //Field offset: 0x10
	internal static readonly string kDefaultCurvesName; //Field offset: 0x18
	internal static readonly double kMinDuration; //Field offset: 0x20
	internal static readonly double kMaxTimeValue; //Field offset: 0x28
	[HideInInspector]
	[SerializeField]
	private int m_Version; //Field offset: 0x8
	[SerializeField]
	private double m_Start; //Field offset: 0x10
	[SerializeField]
	private double m_ClipIn; //Field offset: 0x18
	[SerializeField]
	private object m_Asset; //Field offset: 0x20
	[FormerlySerializedAs("m_HackDuration")]
	[SerializeField]
	private double m_Duration; //Field offset: 0x28
	[SerializeField]
	private double m_TimeScale; //Field offset: 0x30
	[SerializeField]
	private TrackAsset m_ParentTrack; //Field offset: 0x38
	[SerializeField]
	private double m_EaseInDuration; //Field offset: 0x40
	[SerializeField]
	private double m_EaseOutDuration; //Field offset: 0x48
	[SerializeField]
	private double m_BlendInDuration; //Field offset: 0x50
	[SerializeField]
	private double m_BlendOutDuration; //Field offset: 0x58
	[SerializeField]
	private AnimationCurve m_MixInCurve; //Field offset: 0x60
	[SerializeField]
	private AnimationCurve m_MixOutCurve; //Field offset: 0x64
	[SerializeField]
	private BlendCurveMode m_BlendInCurveMode; //Field offset: 0x68
	[SerializeField]
	private BlendCurveMode m_BlendOutCurveMode; //Field offset: 0x6C
	[SerializeField]
	private List<String> m_ExposedParameterNames; //Field offset: 0x70
	[SerializeField]
	private AnimationClip m_AnimationCurves; //Field offset: 0x74
	[SerializeField]
	private bool m_Recordable; //Field offset: 0x78
	[SerializeField]
	private ClipExtrapolation m_PostExtrapolationMode; //Field offset: 0x7C
	[SerializeField]
	private ClipExtrapolation m_PreExtrapolationMode; //Field offset: 0x80
	[SerializeField]
	private double m_PostExtrapolationTime; //Field offset: 0x88
	[SerializeField]
	private double m_PreExtrapolationTime; //Field offset: 0x90
	[SerializeField]
	private string m_DisplayName; //Field offset: 0x98

	public AnimationClip animationClip
	{
		 get { } //Length: 208
	}

	public override object asset
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public BlendCurveMode blendInCurveMode
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public double blendInDuration
	{
		 get { } //Length: 33
		 set { } //Length: 150
	}

	public BlendCurveMode blendOutCurveMode
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public double blendOutDuration
	{
		 get { } //Length: 33
		 set { } //Length: 150
	}

	public double clipAssetDuration
	{
		 get { } //Length: 83
	}

	public ClipCaps clipCaps
	{
		 get { } //Length: 117
	}

	public double clipIn
	{
		 get { } //Length: 33
		 set { } //Length: 274
	}

	public internal override AnimationClip curves
	{
		 get { } //Length: 11
		internal set { } //Length: 27
	}

	public string displayName
	{
		 get { } //Length: 14
		 set { } //Length: 33
	}

	public override double duration
	{
		 get { } //Length: 11
		 set { } //Length: 181
	}

	public double easeInDuration
	{
		 get { } //Length: 222
		 set { } //Length: 313
	}

	public double easeOutDuration
	{
		 get { } //Length: 222
		 set { } //Length: 313
	}

	public double easeOutTime
	{
		 get { } //Length: 42
	}

	[Obsolete("Use easeOutTime instead (UnityUpgradable) -> easeOutTime", True)]
	public double eastOutTime
	{
		 get { } //Length: 42
	}

	public double end
	{
		 get { } //Length: 14
	}

	[Obsolete("exposedParameter is deprecated and will be removed in a future release", True)]
	public List<String> exposedParameters
	{
		 get { } //Length: 101
	}

	public double extrapolatedDuration
	{
		 get { } //Length: 218
	}

	public double extrapolatedStart
	{
		 get { } //Length: 41
	}

	public bool hasBlendIn
	{
		 get { } //Length: 46
	}

	public bool hasBlendOut
	{
		 get { } //Length: 46
	}

	public override bool hasCurves
	{
		 get { } //Length: 110
	}

	public bool hasPostExtrapolation
	{
		 get { } //Length: 37
	}

	public bool hasPreExtrapolation
	{
		 get { } //Length: 40
	}

	public AnimationCurve mixInCurve
	{
		 get { } //Length: 143
		 set { } //Length: 27
	}

	public double mixInDuration
	{
		 get { } //Length: 315
	}

	public float mixInPercentage
	{
		 get { } //Length: 30
	}

	public AnimationCurve mixOutCurve
	{
		 get { } //Length: 143
		 set { } //Length: 27
	}

	public double mixOutDuration
	{
		 get { } //Length: 110
	}

	public float mixOutPercentage
	{
		 get { } //Length: 137
	}

	public double mixOutTime
	{
		 get { } //Length: 138
	}

	[Obsolete("parentTrack is deprecated and will be removed in a future release. Use GetParentTrack() and TimelineClipExtensions::MoveToTrack() or TimelineClipExtensions::TryMoveToTrack() instead.", False)]
	public TrackAsset parentTrack
	{
		 get { } //Length: 11
		 set { } //Length: 16
	}

	public internal ClipExtrapolation postExtrapolationMode
	{
		 get { } //Length: 33
		internal set { } //Length: 45
	}

	public internal ClipExtrapolation preExtrapolationMode
	{
		 get { } //Length: 36
		internal set { } //Length: 48
	}

	public internal bool recordable
	{
		 get { } //Length: 11
		internal set { } //Length: 14
	}

	public double start
	{
		 get { } //Length: 11
		 set { } //Length: 269
	}

	public double timeScale
	{
		 get { } //Length: 231
		 set { } //Length: 246
	}

	[Obsolete("underlyingAsset property is obsolete. Use asset property instead", True)]
	public object underlyingAsset
	{
		 get { } //Length: 3
		 set { } //Length: 3
	}

	private override object UnityEngine.Timeline.ICurvesOwner.assetOwner
	{
		private get { } //Length: 11
	}

	private override string UnityEngine.Timeline.ICurvesOwner.defaultCurvesName
	{
		private get { } //Length: 61
	}

	private override TrackAsset UnityEngine.Timeline.ICurvesOwner.targetTrack
	{
		private get { } //Length: 11
	}

	private static TimelineClip() { }

	internal TimelineClip(TrackAsset parent) { }

	private static double CalculateEasingRatio(double easeIn, double easeOut) { }

	public void ConformEaseValues() { }

	public override void CreateCurves(string curvesClipName) { }

	public float EvaluateMixIn(double time) { }

	public float EvaluateMixOut(double time) { }

	internal double FromLocalTimeUnbound(double time) { }

	public AnimationClip get_animationClip() { }

	public override object get_asset() { }

	public BlendCurveMode get_blendInCurveMode() { }

	public double get_blendInDuration() { }

	public BlendCurveMode get_blendOutCurveMode() { }

	public double get_blendOutDuration() { }

	public double get_clipAssetDuration() { }

	public ClipCaps get_clipCaps() { }

	public double get_clipIn() { }

	public override AnimationClip get_curves() { }

	public string get_displayName() { }

	public override double get_duration() { }

	public double get_easeInDuration() { }

	public double get_easeOutDuration() { }

	public double get_easeOutTime() { }

	public double get_eastOutTime() { }

	public double get_end() { }

	public List<String> get_exposedParameters() { }

	public double get_extrapolatedDuration() { }

	public double get_extrapolatedStart() { }

	public bool get_hasBlendIn() { }

	public bool get_hasBlendOut() { }

	public override bool get_hasCurves() { }

	public bool get_hasPostExtrapolation() { }

	public bool get_hasPreExtrapolation() { }

	public AnimationCurve get_mixInCurve() { }

	public double get_mixInDuration() { }

	public float get_mixInPercentage() { }

	public AnimationCurve get_mixOutCurve() { }

	public double get_mixOutDuration() { }

	public float get_mixOutPercentage() { }

	public double get_mixOutTime() { }

	public TrackAsset get_parentTrack() { }

	public ClipExtrapolation get_postExtrapolationMode() { }

	public ClipExtrapolation get_preExtrapolationMode() { }

	public bool get_recordable() { }

	public double get_start() { }

	public double get_timeScale() { }

	public object get_underlyingAsset() { }

	private static AnimationCurve GetDefaultMixInCurve() { }

	private static AnimationCurve GetDefaultMixOutCurve() { }

	private static double GetExtrapolatedTime(double time, ClipExtrapolation mode, double duration) { }

	public TrackAsset GetParentTrack() { }

	internal int Hash() { }

	public bool IsExtrapolatedTime(double sequenceTime) { }

	public bool IsPostExtrapolatedTime(double sequenceTime) { }

	public bool IsPreExtrapolatedTime(double sequenceTime) { }

	private static double SanitizeTimeValue(double value, double defaultValue) { }

	public void set_asset(object value) { }

	public void set_blendInCurveMode(BlendCurveMode value) { }

	public void set_blendInDuration(double value) { }

	public void set_blendOutCurveMode(BlendCurveMode value) { }

	public void set_blendOutDuration(double value) { }

	public void set_clipIn(double value) { }

	internal void set_curves(AnimationClip value) { }

	public void set_displayName(string value) { }

	public void set_duration(double value) { }

	public void set_easeInDuration(double value) { }

	public void set_easeOutDuration(double value) { }

	public void set_mixInCurve(AnimationCurve value) { }

	public void set_mixOutCurve(AnimationCurve value) { }

	public void set_parentTrack(TrackAsset value) { }

	internal void set_postExtrapolationMode(ClipExtrapolation value) { }

	internal void set_preExtrapolationMode(ClipExtrapolation value) { }

	internal void set_recordable(bool value) { }

	public void set_start(double value) { }

	public void set_timeScale(double value) { }

	public void set_underlyingAsset(object value) { }

	internal void SetParentTrack_Internal(TrackAsset newParentTrack) { }

	internal void SetPostExtrapolationTime(double time) { }

	internal void SetPreExtrapolationTime(double time) { }

	public double ToLocalTime(double time) { }

	public double ToLocalTimeUnbound(double time) { }

	public virtual string ToString() { }

	private override void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	private override void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	private override object UnityEngine.Timeline.ICurvesOwner.get_assetOwner() { }

	private override string UnityEngine.Timeline.ICurvesOwner.get_defaultCurvesName() { }

	private override TrackAsset UnityEngine.Timeline.ICurvesOwner.get_targetTrack() { }

	private void UpdateDirty(double oldValue, double newValue) { }

	private void UpgradeToLatestVersion() { }

}

