namespace Heqet.Danmaku;

public class STGGMoveQuicklyMixerBehaviour : PlayableBehaviour
{
	[CompilerGenerated]
	private TimelineClip[] <Clips>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private PlayableDirector <Director>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	private TimelineManager <TimelineManager>k__BackingField; //Field offset: 0x10

	public TimelineClip[] Clips
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public PlayableDirector Director
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public TimelineManager TimelineManager
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public STGGMoveQuicklyMixerBehaviour() { }

	[CompilerGenerated]
	public TimelineClip[] get_Clips() { }

	[CompilerGenerated]
	public PlayableDirector get_Director() { }

	[CompilerGenerated]
	public TimelineManager get_TimelineManager() { }

	public virtual void OnGraphStop(Playable playable) { }

	public virtual void OnPlayableDestroy(Playable playable) { }

	public virtual void ProcessFrame(Playable playable, FrameData info, object playerData) { }

	[CompilerGenerated]
	public void set_Clips(TimelineClip[] value) { }

	[CompilerGenerated]
	public void set_Director(PlayableDirector value) { }

	[CompilerGenerated]
	public void set_TimelineManager(TimelineManager value) { }

}

