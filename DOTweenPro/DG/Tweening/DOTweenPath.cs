namespace DG.Tweening;

[AddComponentMenu("DOTween/DOTween Path")]
public class DOTweenPath : ABSAnimationComponent
{
	[CompilerGenerated]
	private static Action<DOTweenPath> OnReset; //Field offset: 0x0
	private static MethodInfo _miCreateTween; //Field offset: 0x4
	public float delay; //Field offset: 0x3C
	public float duration; //Field offset: 0x40
	public Ease easeType; //Field offset: 0x44
	public AnimationCurve easeCurve; //Field offset: 0x48
	public int loops; //Field offset: 0x4C
	public string id; //Field offset: 0x50
	public LoopType loopType; //Field offset: 0x54
	public OrientType orientType; //Field offset: 0x58
	public Transform lookAtTransform; //Field offset: 0x5C
	public Vector3 lookAtPosition; //Field offset: 0x60
	public float lookAhead; //Field offset: 0x6C
	public bool autoPlay; //Field offset: 0x70
	public bool autoKill; //Field offset: 0x71
	public bool relative; //Field offset: 0x72
	public bool isLocal; //Field offset: 0x73
	public bool isClosedPath; //Field offset: 0x74
	public int pathResolution; //Field offset: 0x78
	public PathMode pathMode; //Field offset: 0x7C
	public AxisConstraint lockRotation; //Field offset: 0x80
	public bool assignForwardAndUp; //Field offset: 0x84
	public Vector3 forwardDirection; //Field offset: 0x88
	public Vector3 upDirection; //Field offset: 0x94
	public bool tweenRigidbody; //Field offset: 0xA0
	public List<Vector3> wps; //Field offset: 0xA4
	public List<Vector3> fullWps; //Field offset: 0xA8
	public Path path; //Field offset: 0xAC
	public DOTweenInspectorMode inspectorMode; //Field offset: 0xB0
	public PathType pathType; //Field offset: 0xB4
	public HandlesType handlesType; //Field offset: 0xB8
	public bool livePreview; //Field offset: 0xBC
	public HandlesDrawMode handlesDrawMode; //Field offset: 0xC0
	public float perspectiveHandleSize; //Field offset: 0xC4
	public bool showIndexes; //Field offset: 0xC8
	public bool showWpLength; //Field offset: 0xC9
	public Color pathColor; //Field offset: 0xCC
	public Vector3 lastSrcPosition; //Field offset: 0xDC
	public Quaternion lastSrcRotation; //Field offset: 0xE8
	public bool wpsDropdown; //Field offset: 0xF8
	public float dropToFloorOffset; //Field offset: 0xFC

	public static event Action<DOTweenPath> OnReset
	{
		[CompilerGenerated]
		 add { } //Length: 144
		[CompilerGenerated]
		 remove { } //Length: 144
	}

	public DOTweenPath() { }

	[CompilerGenerated]
	private void <Awake>b__44_0() { }

	[CompilerGenerated]
	public static void add_OnReset(Action<DOTweenPath> value) { }

	private void Awake() { }

	private static void Dispatch_OnReset(DOTweenPath path) { }

	public virtual void DOComplete() { }

	public virtual void DOKill() { }

	public void DOKillAllById(string id) { }

	public virtual void DOPause() { }

	public virtual void DOPlay() { }

	public void DOPlayAllById(string id) { }

	public virtual void DOPlayBackwards() { }

	public void DOPlayById(string id) { }

	public virtual void DOPlayForward() { }

	public virtual void DORestart() { }

	public virtual void DORestart(bool fromHere) { }

	public virtual void DORewind() { }

	public virtual void DOTogglePause() { }

	public Vector3[] GetDrawPoints() { }

	internal Vector3[] GetFullWps() { }

	public Tween GetTween() { }

	private void OnDestroy() { }

	private void ReEvaluateRelativeTween() { }

	[CompilerGenerated]
	public static void remove_OnReset(Action<DOTweenPath> value) { }

	private void Reset() { }

}

