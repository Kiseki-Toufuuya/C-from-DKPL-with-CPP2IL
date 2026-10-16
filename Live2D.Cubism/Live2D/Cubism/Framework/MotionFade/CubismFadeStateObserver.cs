namespace Live2D.Cubism.Framework.MotionFade;

public class CubismFadeStateObserver : StateMachineBehaviour, ICubismFadeState
{
	private CubismFadeMotionList _cubismFadeMotionList; //Field offset: 0xC
	private List<CubismFadePlayingMotion> _playingMotions; //Field offset: 0x10
	private bool _isDefaulState; //Field offset: 0x14
	private int _layerIndex; //Field offset: 0x18
	private float _layerWeight; //Field offset: 0x1C
	private bool _isStateTransitionFinished; //Field offset: 0x20

	public CubismFadeStateObserver() { }

	public override float GetLayerWeight() { }

	public override List<CubismFadePlayingMotion> GetPlayingMotions() { }

	public override bool GetStateTransitionFinished() { }

	public override bool IsDefaultState() { }

	private void OnEnable() { }

	public virtual void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) { }

	public virtual void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	public override void SetStateTransitionFinished(bool isFinished) { }

	public override void StopAnimation(int index) { }

}

