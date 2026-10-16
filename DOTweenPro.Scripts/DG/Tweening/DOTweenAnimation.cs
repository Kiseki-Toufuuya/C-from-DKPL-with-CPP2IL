namespace DG.Tweening;

[AddComponentMenu("DOTween/DOTween Animation")]
public class DOTweenAnimation : ABSAnimationComponent
{
	internal enum AnimationType
	{
		None = 0,
		Move = 1,
		LocalMove = 2,
		Rotate = 3,
		LocalRotate = 4,
		Scale = 5,
		Color = 6,
		Fade = 7,
		Text = 8,
		PunchPosition = 9,
		PunchRotation = 10,
		PunchScale = 11,
		ShakePosition = 12,
		ShakeRotation = 13,
		ShakeScale = 14,
		CameraAspect = 15,
		CameraBackgroundColor = 16,
		CameraFieldOfView = 17,
		CameraOrthoSize = 18,
		CameraPixelRect = 19,
		CameraRect = 20,
		UIWidthHeight = 21,
	}

	internal enum TargetType
	{
		Unset = 0,
		Camera = 1,
		CanvasGroup = 2,
		Image = 3,
		Light = 4,
		RectTransform = 5,
		Renderer = 6,
		SpriteRenderer = 7,
		Rigidbody = 8,
		Rigidbody2D = 9,
		Text = 10,
		Transform = 11,
		tk2dBaseSprite = 12,
		tk2dTextMesh = 13,
		TextMeshPro = 14,
		TextMeshProUGUI = 15,
	}

	[CompilerGenerated]
	private static Action<DOTweenAnimation> OnReset; //Field offset: 0x0
	public bool targetIsSelf; //Field offset: 0x3C
	public GameObject targetGO; //Field offset: 0x40
	public bool tweenTargetIsTargetGO; //Field offset: 0x44
	public float delay; //Field offset: 0x48
	public float duration; //Field offset: 0x4C
	public Ease easeType; //Field offset: 0x50
	public AnimationCurve easeCurve; //Field offset: 0x54
	public LoopType loopType; //Field offset: 0x58
	public int loops; //Field offset: 0x5C
	public string id; //Field offset: 0x60
	public bool isRelative; //Field offset: 0x64
	public bool isFrom; //Field offset: 0x65
	public bool isIndependentUpdate; //Field offset: 0x66
	public bool autoKill; //Field offset: 0x67
	public bool autoGenerate; //Field offset: 0x68
	public bool isActive; //Field offset: 0x69
	public bool isValid; //Field offset: 0x6A
	public Component target; //Field offset: 0x6C
	public AnimationType animationType; //Field offset: 0x70
	public TargetType targetType; //Field offset: 0x74
	public TargetType forcedTargetType; //Field offset: 0x78
	public bool autoPlay; //Field offset: 0x7C
	public bool useTargetAsV3; //Field offset: 0x7D
	public float endValueFloat; //Field offset: 0x80
	public Vector3 endValueV3; //Field offset: 0x84
	public Vector2 endValueV2; //Field offset: 0x90
	public Color endValueColor; //Field offset: 0x98
	public string endValueString; //Field offset: 0xA8
	public Rect endValueRect; //Field offset: 0xAC
	public Transform endValueTransform; //Field offset: 0xBC
	public bool optionalBool0; //Field offset: 0xC0
	public bool optionalBool1; //Field offset: 0xC1
	public float optionalFloat0; //Field offset: 0xC4
	public int optionalInt0; //Field offset: 0xC8
	public RotateMode optionalRotationMode; //Field offset: 0xCC
	public ScrambleMode optionalScrambleMode; //Field offset: 0xD0
	public ShakeRandomnessMode optionalShakeRandomnessMode; //Field offset: 0xD4
	public string optionalString; //Field offset: 0xD8
	private bool _tweenAutoGenerationCalled; //Field offset: 0xDC
	private int _playCount; //Field offset: 0xE0

	public static event Action<DOTweenAnimation> OnReset
	{
		[CompilerGenerated]
		 add { } //Length: 144
		[CompilerGenerated]
		 remove { } //Length: 144
	}

	public DOTweenAnimation() { }

	[CompilerGenerated]
	private void <CreateTween>b__54_0() { }

	[CompilerGenerated]
	public static void add_OnReset(Action<DOTweenAnimation> value) { }

	private void Awake() { }

	public Tween CreateEditorPreview() { }

	public void CreateTween(bool regenerateIfExists = false, bool andPlay = true) { }

	private static void Dispatch_OnReset(DOTweenAnimation anim) { }

	public virtual void DOComplete() { }

	public virtual void DOKill() { }

	public void DOKillAllById(string id) { }

	public void DOKillById(string id) { }

	public virtual void DOPause() { }

	public void DOPauseAllById(string id) { }

	public virtual void DOPlay() { }

	public void DOPlayAllById(string id) { }

	public virtual void DOPlayBackwards() { }

	public void DOPlayBackwardsAllById(string id) { }

	public void DOPlayBackwardsById(string id) { }

	public void DOPlayById(string id) { }

	public virtual void DOPlayForward() { }

	public void DOPlayForwardAllById(string id) { }

	public void DOPlayForwardById(string id) { }

	public void DOPlayNext() { }

	public virtual void DORestart() { }

	public virtual void DORestart(bool fromHere) { }

	public void DORestartAllById(string id) { }

	public void DORestartById(string id) { }

	public virtual void DORewind() { }

	public void DORewindAllById(string id) { }

	public void DORewindAndPlayNext() { }

	public virtual void DOTogglePause() { }

	private GameObject GetTweenGO() { }

	public List<Tween> GetTweens() { }

	private GameObject GetTweenTarget() { }

	private void OnDestroy() { }

	public void RecreateTween() { }

	public void RecreateTweenAndPlay() { }

	private void ReEvaluateRelativeTween() { }

	[CompilerGenerated]
	public static void remove_OnReset(Action<DOTweenAnimation> value) { }

	private void Reset() { }

	public void RewindThenRecreateTween() { }

	public void RewindThenRecreateTweenAndPlay() { }

	public void SetAnimationTarget(Component tweenTarget, bool useTweenTargetGameObjectForGroupOperations = true) { }

	private void Start() { }

	public static TargetType TypeToDOTargetType(Type t) { }

}

