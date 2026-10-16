namespace Live2D.Cubism.Framework.Motion;

public class CubismMotionState
{
	[CompilerGenerated]
	private AnimationClip <Clip>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private AnimationMixerPlayable <ClipMixer>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	private AnimationClipPlayable <ClipPlayable>k__BackingField; //Field offset: 0x14

	public private AnimationClip Clip
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public private AnimationMixerPlayable ClipMixer
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		private set { } //Length: 20
	}

	public private AnimationClipPlayable ClipPlayable
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		private set { } //Length: 20
	}

	public CubismMotionState() { }

	public void ConnectClipMixer(AnimationMixerPlayable clipMixer) { }

	public static CubismMotionState CreateCubismMotionState(PlayableGraph playableGraph, AnimationClip clip, bool isLoop = true, float speed = 1) { }

	[CompilerGenerated]
	public AnimationClip get_Clip() { }

	[CompilerGenerated]
	public AnimationMixerPlayable get_ClipMixer() { }

	[CompilerGenerated]
	public AnimationClipPlayable get_ClipPlayable() { }

	[CompilerGenerated]
	private void set_Clip(AnimationClip value) { }

	[CompilerGenerated]
	private void set_ClipMixer(AnimationMixerPlayable value) { }

	[CompilerGenerated]
	private void set_ClipPlayable(AnimationClipPlayable value) { }

}

