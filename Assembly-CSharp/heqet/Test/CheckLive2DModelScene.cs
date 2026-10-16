namespace Heqet.Test;

public class CheckLive2DModelScene : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass31_0
	{
		public Live2DModel live2DModel; //Field offset: 0x8

		public <>c__DisplayClass31_0() { }

		internal bool <CreateKaguraLive2D>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass32_0
	{
		public Live2DModel live2DModel; //Field offset: 0x8

		public <>c__DisplayClass32_0() { }

		internal bool <CreateDanmakuLive2D>b__0() { }

	}

	[CompilerGenerated]
	private struct <CreateDanmakuLive2D>d__32 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public int id; //Field offset: 0xC
		public int skinId; //Field offset: 0x10
		public CheckLive2DModelScene <>4__this; //Field offset: 0x14
		private <>c__DisplayClass32_0 <>8__1; //Field offset: 0x18
		private Awaiter <>u__1; //Field offset: 0x1C

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CreateKaguraLive2D>d__31 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public int id; //Field offset: 0xC
		public int skinId; //Field offset: 0x10
		public CheckLive2DModelScene <>4__this; //Field offset: 0x14
		private <>c__DisplayClass31_0 <>8__1; //Field offset: 0x18
		private Awaiter <>u__1; //Field offset: 0x1C

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private enum DanmakuStateName
	{
		Stay = 0,
		Stay_02 = 1,
		Attack = 2,
		Damage = 3,
		Win = 4,
		Win_Loop = 5,
		Destroy = 6,
		Damage_Loop = 7,
		CutinAttack = 8,
		Damage_Return = 9,
	}

	private enum KaguraStateName
	{
		Stay = 0,
		Stay_02 = 1,
		Attack = 2,
		Damage = 3,
		Win = 4,
		Win_Loop = 5,
		Damage_Return = 6,
	}

	private enum ParameterName
	{
		Stay = 0,
		Stay_02 = 1,
		Damage = 2,
		Attack = 3,
		Win = 4,
		Destroy = 5,
		Cutin = 6,
	}

	private readonly String[] KAGURA_STATE_NAME; //Field offset: 0x10
	private readonly String[] DANMAKU_STATE_NAME; //Field offset: 0x14
	private readonly String[] PARAMETERS; //Field offset: 0x18
	private readonly Int32[] KAGURA_CHARACTER_LIST; //Field offset: 0x1C
	private readonly Dictionary<Int32, String> DANMAKU_CHARACTER_DICTIONARY; //Field offset: 0x20
	private readonly Vector2 LIVE2D_SCALE; //Field offset: 0x24
	[SerializeField]
	private TMP_Dropdown m_KaguraDropdown; //Field offset: 0x2C
	[SerializeField]
	private TMP_Dropdown m_DanmakuDropdown; //Field offset: 0x30
	[SerializeField]
	private TMP_Text m_KaguraStateNameText; //Field offset: 0x34
	[SerializeField]
	private TMP_Text m_DanmakuStateNameText; //Field offset: 0x38
	[SerializeField]
	private RawImageEx m_KaguraRawImage; //Field offset: 0x3C
	[SerializeField]
	private RawImageEx m_DanmakuRawImage; //Field offset: 0x40
	[SerializeField]
	private GameObject m_KaguraRoot; //Field offset: 0x44
	[SerializeField]
	private GameObject m_DanmakuRoot; //Field offset: 0x48
	private int m_KaguraIndex; //Field offset: 0x4C
	private int m_DanmakuIndex; //Field offset: 0x50
	private Live2DModel m_KaguraLive2D; //Field offset: 0x54
	private Live2DModel m_DanmakuLive2D; //Field offset: 0x58
	private List<HeqetHeroineModel> m_KaguraCharacterList; //Field offset: 0x5C
	private List<HeqetHeroineModel> m_DanmakuCharacterList; //Field offset: 0x60

	public CheckLive2DModelScene() { }

	[AsyncStateMachine(typeof(<CreateDanmakuLive2D>d__32))]
	private UniTask CreateDanmakuLive2D(int id, int skinId) { }

	[AsyncStateMachine(typeof(<CreateKaguraLive2D>d__31))]
	private UniTask CreateKaguraLive2D(int id, int skinId) { }

	private void LoadDanmakuLive2D(int index) { }

	private void LoadKaguraLive2D(int index) { }

	public void NextDanmakuCharacter() { }

	public void NextKaguraCharacter() { }

	public void PrevDanmakuCharacter() { }

	public void PrevKaguraCharacter() { }

	private void Start() { }

	private void Update() { }

}

