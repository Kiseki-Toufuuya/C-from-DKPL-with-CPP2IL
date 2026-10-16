namespace Heqet;

[RequireComponent(typeof(RawImageEx))]
public class PlayerBulletRawImage : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass34_0
	{
		public AssetBundleLoadAssetOperation ope; //Field offset: 0x8

		public <>c__DisplayClass34_0() { }

		internal bool <LoadAsync>b__1() { }

	}

	[CompilerGenerated]
	private struct <LoadAsync>d__34 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public PlayerBulletRawImage <>4__this; //Field offset: 0xC
		public CancellationToken ct; //Field offset: 0x10
		private <>c__DisplayClass34_0 <>8__1; //Field offset: 0x14
		private Awaiter <>u__1; //Field offset: 0x18

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private struct LoadingRequest
	{
		public bool IsRequest; //Field offset: 0x0
		public bool IsLoading; //Field offset: 0x1
		public int MainId; //Field offset: 0x4
		public int SubId; //Field offset: 0x8

	}

	private const string PLAYER_PATH = "prefab/danmaku/player/"; //Field offset: 0x0
	private const string DANMAKU_COMMON_XAB = "prefab/danmaku/common.xab"; //Field offset: 0x0
	private const string ENEMY_NAME = "formation_preview_enemy"; //Field offset: 0x0
	private const float PLAYER_SIZE = 1.7; //Field offset: 0x0
	private readonly Vector3 PLAYER_POSITION_OFFSET; //Field offset: 0x10
	private readonly Vector3 ENEMY_POSITION_OFFSET; //Field offset: 0x1C
	private RawImageEx m_RawImage; //Field offset: 0x28
	private Player m_Player; //Field offset: 0x2C
	private GameObject m_PlayerObj; //Field offset: 0x30
	private GameObject m_Enmey; //Field offset: 0x34
	private Tweener m_EnemyTweener; //Field offset: 0x38
	private List<GameObject> m_RawImageCopyList; //Field offset: 0x3C
	private AssetBundleLoadAllAssetOperationBase m_DanmakuCommonOpe; //Field offset: 0x40
	private bool m_IsReady; //Field offset: 0x44
	private int m_MainId; //Field offset: 0x48
	private int m_SubId; //Field offset: 0x4C
	private bool m_IsReleaseRequest; //Field offset: 0x50
	private List<String> m_AssetBundleNameList; //Field offset: 0x54
	private LoadingRequest loadingRequest; //Field offset: 0x58
	private LoadingRequest nextLoadingRequest; //Field offset: 0x64
	private bool initialized; //Field offset: 0x70
	private CancellationTokenSource loadAsynCcancellationTokenSource; //Field offset: 0x74
	public GameObject LoadingObj; //Field offset: 0x78

	public bool IsReady
	{
		 get { } //Length: 11
	}

	public PlayerBulletRawImage() { }

	[CompilerGenerated]
	private bool <LoadAsync>b__34_0() { }

	[CompilerGenerated]
	private bool <LoadAsync>b__34_2() { }

	public bool get_IsReady() { }

	[AsyncStateMachine(typeof(<LoadAsync>d__34))]
	private UniTask LoadAsync(CancellationToken ct) { }

	private void OnDestroy() { }

	private void OnEnable() { }

	private void Release() { }

	public void ReleaseAll() { }

	public void ReleaseRequest() { }

	public void SetPlayer(int mainId, int subId = -1) { }

	private void SetPlayerPosition() { }

	private void SetRawImageCopy() { }

	private void UnloadAssetBundle() { }

	private void Update() { }

}

