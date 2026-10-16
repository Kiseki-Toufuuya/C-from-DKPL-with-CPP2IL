namespace Live2D.Cubism.Samples.OriginalWorkflow.Motion;

[RequireComponent(typeof(CubismMotionController))]
public class CubismMotionPreview : MonoBehaviour
{
	public AnimationClip Animation; //Field offset: 0x10
	private CubismMotionController _motionController; //Field offset: 0x14

	public CubismMotionPreview() { }

	public void PlayAnimation(AnimationClip animation) { }

	private void PlayIdleAnimation(int index = 0) { }

	private void Start() { }

}

