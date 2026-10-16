namespace Live2D.Cubism.Framework.MotionFade;

[RequireComponent(typeof(Animator))]
public class CubismFadeController : MonoBehaviour, ICubismUpdatable
{
	[SerializeField]
	public CubismFadeMotionList CubismFadeMotionList; //Field offset: 0x10
	[CompilerGenerated]
	private CubismParameter[] <DestinationParameters>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private CubismPart[] <DestinationParts>k__BackingField; //Field offset: 0x18
	private CubismMotionController _motionController; //Field offset: 0x1C
	[CompilerGenerated]
	private bool <HasUpdateController>k__BackingField; //Field offset: 0x20
	private ICubismFadeState[] _fadeStates; //Field offset: 0x24
	private Animator _animator; //Field offset: 0x28
	private CubismParameterStore _parameterStore; //Field offset: 0x2C
	private Boolean[] _isFading; //Field offset: 0x30

	private CubismParameter[] DestinationParameters
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	private CubismPart[] DestinationParts
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public override int ExecutionOrder
	{
		 get { } //Length: 61
	}

	[HideInInspector]
	public override bool HasUpdateController
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public override bool NeedsUpdateOnEditing
	{
		 get { } //Length: 3
	}

	public CubismFadeController() { }

	public float Evaluate(AnimationCurve curve, float elapsedTime, float endTime, float fadeInTime, float fadeOutTime, float parameterFadeInTime, float parameterFadeOutTime, float motionWeight, float currentValue) { }

	public float Evaluate(float value, float elapsedTime, float endTime, float fadeInTime, float fadeOutTime, float parameterFadeInTime, float parameterFadeOutTime, float motionWeight, float currentValue) { }

	[CompilerGenerated]
	private CubismParameter[] get_DestinationParameters() { }

	[CompilerGenerated]
	private CubismPart[] get_DestinationParts() { }

	public override int get_ExecutionOrder() { }

	[CompilerGenerated]
	public override bool get_HasUpdateController() { }

	public override bool get_NeedsUpdateOnEditing() { }

	private void LateUpdate() { }

	private void OnEnable() { }

	public override void OnLateUpdate() { }

	public void Refresh() { }

	[CompilerGenerated]
	private void set_DestinationParameters(CubismParameter[] value) { }

	[CompilerGenerated]
	private void set_DestinationParts(CubismPart[] value) { }

	[CompilerGenerated]
	public override void set_HasUpdateController(bool value) { }

	private void UpdateFade(ICubismFadeState fadeState) { }

}

