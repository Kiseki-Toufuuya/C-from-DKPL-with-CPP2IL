namespace Cysharp.Threading.Tasks;

public static class PlayerLoopHelper
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<PlayerLoopSystem, Boolean> <>9__21_0; //Field offset: 0x4
		public static Predicate<PlayerLoopSystem> <>9__21_1; //Field offset: 0x8
		public static Predicate<PlayerLoopSystem> <>9__21_2; //Field offset: 0xC

		private static <>c() { }

		public <>c() { }

		internal bool <InsertUniTaskSynchronizationContext>b__21_0(PlayerLoopSystem ls) { }

		internal bool <InsertUniTaskSynchronizationContext>b__21_1(PlayerLoopSystem x) { }

		internal bool <InsertUniTaskSynchronizationContext>b__21_2(PlayerLoopSystem x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass20_0
	{
		public Type loopRunnerYieldType; //Field offset: 0x8
		public Type loopRunnerType; //Field offset: 0xC

		public <>c__DisplayClass20_0() { }

		internal bool <RemoveRunner>b__0(PlayerLoopSystem ls) { }

	}

	private static readonly ContinuationQueue ThrowMarkerContinuationQueue; //Field offset: 0x0
	private static readonly PlayerLoopRunner ThrowMarkerPlayerLoopRunner; //Field offset: 0x4
	private static int mainThreadId; //Field offset: 0x8
	private static string applicationDataPath; //Field offset: 0xC
	private static SynchronizationContext unitySynchronizationContext; //Field offset: 0x10
	private static ContinuationQueue[] yielders; //Field offset: 0x14
	private static PlayerLoopRunner[] runners; //Field offset: 0x18

	public static bool IsMainThread
	{
		 get { } //Length: 98
	}

	public static int MainThreadId
	{
		 get { } //Length: 61
	}

	public static SynchronizationContext UnitySynchronizationContext
	{
		 get { } //Length: 61
	}

	private static PlayerLoopHelper() { }

	public static void AddAction(PlayerLoopTiming timing, IPlayerLoopItem action) { }

	public static void AddContinuation(PlayerLoopTiming timing, Action continuation) { }

	private static int FindLoopSystemIndex(PlayerLoopSystem[] playerLoopList, Type systemType) { }

	public static bool get_IsMainThread() { }

	public static int get_MainThreadId() { }

	public static SynchronizationContext get_UnitySynchronizationContext() { }

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::BeforeSceneLoad (1))]
	private static void Init() { }

	public static void Initialize(ref PlayerLoopSystem playerLoop, InjectPlayerLoopTimings injectTimings = 65535) { }

	private static void InsertLoop(PlayerLoopSystem[] copyList, InjectPlayerLoopTimings injectTimings, Type loopType, InjectPlayerLoopTimings targetTimings, int index, bool injectOnFirst, Type loopRunnerYieldType, Type loopRunnerType, PlayerLoopTiming playerLoopTiming) { }

	private static PlayerLoopSystem[] InsertRunner(PlayerLoopSystem loopSystem, bool injectOnFirst, Type loopRunnerYieldType, ContinuationQueue cq, Type loopRunnerType, PlayerLoopRunner runner) { }

	private static PlayerLoopSystem[] InsertUniTaskSynchronizationContext(PlayerLoopSystem loopSystem) { }

	private static PlayerLoopSystem[] RemoveRunner(PlayerLoopSystem loopSystem, Type loopRunnerYieldType, Type loopRunnerType) { }

	private static void ThrowInvalidLoopTiming(PlayerLoopTiming playerLoopTiming) { }

}

