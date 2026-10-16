namespace Heqet.Kagura;

public class UIController : UIControllerBase
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_0
	{
		public AssetBundleLoadAllAssetOperationBase ope; //Field offset: 0x8

		public <>c__DisplayClass11_0() { }

		internal bool <LoadAsssetAsync>b__0() { }

	}

	[CompilerGenerated]
	private struct <LoadAsssetAsync>d__11 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		private <>c__DisplayClass11_0 <>8__1; //Field offset: 0xC
		public UIController <>4__this; //Field offset: 0x10
		private string <assetBundleName>5__2; //Field offset: 0x14
		private Awaiter <>u__1; //Field offset: 0x18

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private LaneController laneController; //Field offset: 0x24
	[SerializeField]
	private SpriteRenderer frameMain; //Field offset: 0x28
	[SerializeField]
	private SpriteRenderer frameMainBG; //Field offset: 0x2C
	private bool isDone; //Field offset: 0x30
	private RhythmGame rhythmGame; //Field offset: 0x34
	private MusicManager musicManager; //Field offset: 0x38
	private KaguraLayer layer; //Field offset: 0x3C

	public UIController() { }

	private void Awake() { }

	public void Clear() { }

	protected virtual GameObject GetJudgeMessagePintOfLowerBlind() { }

	protected virtual GameObject GetJudgeMessagePintOfUpperBlind() { }

	public void Initialize(RhythmGame rhythmGame, MusicManager musicManager) { }

	public bool IsDone() { }

	[AsyncStateMachine(typeof(<LoadAsssetAsync>d__11))]
	private UniTask LoadAsssetAsync() { }

	private void OnJudge(NoteData noteData, int judge) { }

	private void OnJudgeTimeLag(NoteData noteData, int judge, float timeLag) { }

	public virtual void SetGameParam(LayerBase layerBase, HeqetMusicModel musicModel, SettingData musicSettingData) { }

	public void Terminate() { }

}

