namespace Heqet.Danmaku;

[DisplayName("Heqet/STGGimmick/MoveQuickly3")]
public class STGGMoveQuickly3PlayableAsset : DanmakuPlayableAsset<STGGMoveQuickly3PlayableBehaviour>
{
	public STGGMoveQuickly3PlayableBehaviour Behaviour; //Field offset: 0x10
	[CompilerGenerated]
	private TimelineManager <TimelineManager>k__BackingField; //Field offset: 0x14

	public virtual DanmakuPlayableBehaviourBase BehaviourBase
	{
		 get { } //Length: 11
	}

	public private TimelineManager TimelineManager
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public STGGMoveQuickly3PlayableAsset() { }

	public virtual DanmakuPlayableBehaviourBase get_BehaviourBase() { }

	[CompilerGenerated]
	public TimelineManager get_TimelineManager() { }

	protected virtual void OnCreatePlayable(PlayableGraph graph, GameObject owner, IPlayableBehaviour playableBehaviour) { }

	[CompilerGenerated]
	private void set_TimelineManager(TimelineManager value) { }

}

