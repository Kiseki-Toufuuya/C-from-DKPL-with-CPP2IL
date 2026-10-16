namespace Live2D.Cubism.Framework.Motion;

[RequireComponent(typeof(CubismFadeController))]
public class CubismMotionController : MonoBehaviour
{
	[SerializeField]
	public Action<Int32> AnimationBeginHandler; //Field offset: 0x10
	[SerializeField]
	public Action<Int32> AnimationEndHandler; //Field offset: 0x14
	public int LayerCount; //Field offset: 0x18
	private CubismFadeMotionList _cubismFadeMotionList; //Field offset: 0x1C
	private bool _isActive; //Field offset: 0x20
	private PlayableGraph _playableGrap; //Field offset: 0x24
	private AnimationPlayableOutput _playableOutput; //Field offset: 0x2C
	private AnimationLayerMixerPlayable _layerMixer; //Field offset: 0x34
	private CubismMotionLayer[] _motionLayers; //Field offset: 0x3C
	private Int32[] _motionPriorities; //Field offset: 0x40

	public CubismMotionController() { }

	public ICubismFadeState[] GetFadeStates() { }

	public bool IsPlayingAnimation(int layerIndex = 0) { }

	private void OnAnimationBegin(int layerIndex, int instanceId) { }

	private void OnAnimationEnd(int layerIndex, int instanceId) { }

	private void OnDisable() { }

	private void OnEnable() { }

	public void PlayAnimation(AnimationClip clip, int layerIndex = 0, int priority = 2, bool isLoop = true, float speed = 1) { }

	public void SetAnimationIsLoop(int layerIndex, int index, bool isLoop) { }

	public void SetAnimationSpeed(int layerIndex, int index, float speed) { }

	public void SetLayerAdditive(int layerIndex, bool isAdditive) { }

	public void SetLayerWeight(int layerIndex, float weight) { }

	public void StopAllAnimation() { }

	public void StopAnimation(int animationIndex, int layerIndex = 0) { }

	private void Update() { }

}

