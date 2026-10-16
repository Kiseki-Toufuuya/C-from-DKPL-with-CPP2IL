namespace Live2D.Cubism.Framework.Motion;

public class CubismMotionLayer : ICubismFadeState
{
	public Action<Int32, Int32> AnimationBeginHandler; //Field offset: 0x8
	public Action<Int32, Int32> AnimationEndHandler; //Field offset: 0xC
	[CompilerGenerated]
	private AnimationMixerPlayable <PlayableOutput>k__BackingField; //Field offset: 0x10
	private PlayableGraph _playableGraph; //Field offset: 0x18
	private List<CubismFadePlayingMotion> _playingMotions; //Field offset: 0x20
	private CubismMotionState _motionState; //Field offset: 0x24
	private CubismFadeMotionList _cubismFadeMotionList; //Field offset: 0x28
	private int _layerIndex; //Field offset: 0x2C
	private float _layerWeight; //Field offset: 0x30
	private bool _isFinished; //Field offset: 0x34

	public bool IsFinished
	{
		 get { } //Length: 11
	}

	public private AnimationMixerPlayable PlayableOutput
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		private set { } //Length: 20
	}

	public CubismMotionLayer() { }

	public static CubismMotionLayer CreateCubismMotionLayer(PlayableGraph playableGraph, CubismFadeMotionList fadeMotionList, int layerIndex, float layerWeight = 1) { }

	private CubismFadePlayingMotion CreateFadePlayingMotion(AnimationClip clip, bool isLooping, float speed = 1) { }

	public bool get_IsFinished() { }

	[CompilerGenerated]
	public AnimationMixerPlayable get_PlayableOutput() { }

	public override float GetLayerWeight() { }

	public override List<CubismFadePlayingMotion> GetPlayingMotions() { }

	public override bool GetStateTransitionFinished() { }

	public override bool IsDefaultState() { }

	public void PlayAnimation(AnimationClip clip, bool isLoop = true, float speed = 1) { }

	[CompilerGenerated]
	private void set_PlayableOutput(AnimationMixerPlayable value) { }

	public void SetLayerWeight(float weight) { }

	public void SetStateIsLoop(int index, bool isLoop) { }

	public void SetStateSpeed(int index, float speed) { }

	public override void SetStateTransitionFinished(bool isFinished) { }

	public void StopAllAnimation() { }

	public override void StopAnimation(int index) { }

	public void StopAnimationClip() { }

	public void Update() { }

}

