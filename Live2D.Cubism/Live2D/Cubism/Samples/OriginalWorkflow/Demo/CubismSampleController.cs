namespace Live2D.Cubism.Samples.OriginalWorkflow.Demo;

[RequireComponent(typeof(CubismMotionController))]
[RequireComponent(typeof(CubismRaycaster))]
public class CubismSampleController : MonoBehaviour
{
	private enum HitArea
	{
		Head = 0,
		Body = 1,
	}

	private struct HitDrawableInfomation
	{
		public CubismDrawable drawable; //Field offset: 0x0
		public HitArea hitArea; //Field offset: 0x4

	}

	private CubismMotionController _motionController; //Field offset: 0x10
	private CubismExpressionController _expressionController; //Field offset: 0x14
	[SerializeField]
	private AnimationClip _bodyAnimation; //Field offset: 0x18
	[SerializeField]
	private AnimationClip[] _tapBodyMotions; //Field offset: 0x1C
	private AnimationClip _loopMotion; //Field offset: 0x20
	private List<HitDrawableInfomation> _hasHitDrawables; //Field offset: 0x24
	private CubismRaycaster _raycaster; //Field offset: 0x28
	private CubismRaycastHit[] _raycastResults; //Field offset: 0x2C

	public CubismSampleController() { }

	private void AnimationEnded(int instanceId) { }

	private void SpecifiedAnimationCheck() { }

	private void Start() { }

	private void Update() { }

}

