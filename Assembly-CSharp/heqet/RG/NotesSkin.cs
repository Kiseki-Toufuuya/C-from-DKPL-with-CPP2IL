namespace Heqet.RG;

public class NotesSkin
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public AssetBundleLoadAllAssetOperationBase ope; //Field offset: 0x8

		public <>c__DisplayClass6_0() { }

		internal bool <LoadAsssetAsync>b__0() { }

	}

	[CompilerGenerated]
	private struct <LoadAsssetAsync>d__6 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		private <>c__DisplayClass6_0 <>8__1; //Field offset: 0xC
		public NotesSkin <>4__this; //Field offset: 0x10
		private int <groupId>5__2; //Field offset: 0x14
		private Awaiter <>u__1; //Field offset: 0x18

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public const int NotesPrefabCount = 2; //Field offset: 0x0
	private bool initialized; //Field offset: 0x8
	private bool isDone; //Field offset: 0x9
	private List<GameObject> notesPrefabList; //Field offset: 0xC
	private GameObject barLinePrefab; //Field offset: 0x10

	public NotesSkin() { }

	public GameObject GetBarLinePrefab() { }

	public GameObject GetNotesPrefab(int index) { }

	public void Initialize() { }

	public bool IsDone() { }

	[AsyncStateMachine(typeof(<LoadAsssetAsync>d__6))]
	private UniTask LoadAsssetAsync() { }

}

