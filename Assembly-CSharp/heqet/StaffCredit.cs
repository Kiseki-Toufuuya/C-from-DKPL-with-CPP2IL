namespace Heqet;

public class StaffCredit : MonoBehaviour
{
	[CompilerGenerated]
	private struct <<Update>b__29_0>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x4
		public StaffCredit <>4__this; //Field offset: 0x8
		private CancellationToken <ct>5__2; //Field offset: 0xC
		private Awaiter <>u__1; //Field offset: 0x10

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DoDisplay>d__34 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public Data data; //Field offset: 0xC
		public StaffCredit <>4__this; //Field offset: 0x10
		public CancellationToken ct; //Field offset: 0x14
		private GameObject <text>5__2; //Field offset: 0x18
		private CancellationToken <textCt>5__3; //Field offset: 0x1C
		private Awaiter <>u__1; //Field offset: 0x20

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private enum Layer
	{
		Default = 0,
		PostProcessing = 23,
		Sprite = 8,
	}

	private enum Phase
	{
		Init = 0,
		None = 1,
		PlayBgm = 2,
		WaitBgm = 3,
		Pause = 4,
		Finish = 5,
	}

	private static float _StartY; //Field offset: 0x0
	private static float _EndY; //Field offset: 0x4
	private static float _parLineDistance; //Field offset: 0x8
	[SerializeField]
	private GameObject PersonNamePrefab; //Field offset: 0x10
	[SerializeField]
	private CreditScriptableObject creditScriptableObject; //Field offset: 0x14
	[SerializeField]
	private TextMeshPro timeLabel; //Field offset: 0x18
	[SerializeField]
	private Image bgImage; //Field offset: 0x1C
	[SerializeField]
	private RawImage bloomImage; //Field offset: 0x20
	[SerializeField]
	private Camera bloomCamera; //Field offset: 0x24
	[CompilerGenerated]
	private bool <IsSkipFade>k__BackingField; //Field offset: 0x28
	private Stack<GameObject> _pool; //Field offset: 0x2C
	private float _speed; //Field offset: 0x30
	private float _parDelay; //Field offset: 0x34
	private float _totalBgmSec; //Field offset: 0x38
	[SerializeField]
	private Int32[] soundIDs; //Field offset: 0x3C
	private Queue<Int32> _bgmQueue; //Field offset: 0x40
	private Phase _phase; //Field offset: 0x44
	private float _playTime; //Field offset: 0x48
	private RenderTexture renderTexture; //Field offset: 0x4C

	public bool IsSkipFade
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	private static StaffCredit() { }

	public StaffCredit() { }

	[AsyncStateMachine(typeof(<<Update>b__29_0>d))]
	[CompilerGenerated]
	private UniTaskVoid <Update>b__29_0() { }

	private void Awake() { }

	[AsyncStateMachine(typeof(<DoDisplay>d__34))]
	private UniTask DoDisplay(CancellationToken ct, Data data) { }

	[CompilerGenerated]
	public bool get_IsSkipFade() { }

	private float GetBGMLength(int fileId) { }

	private GameObject GetObj() { }

	public bool IsFInish() { }

	private void OnApplicationPause(bool pauseStatus) { }

	private void OnDestroy() { }

	private void PlayCredit(CancellationToken ct) { }

	private void Preload() { }

	private void ReleaseObj(GameObject obj) { }

	[CompilerGenerated]
	public void set_IsSkipFade(bool value) { }

	public void SetBgTexture(Sprite sprite) { }

	private void Start() { }

	private void Update() { }

}

