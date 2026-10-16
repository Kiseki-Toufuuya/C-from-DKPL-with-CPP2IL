namespace XeSys;

public class DebugGameLoopProfiler
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public CounterID id; //Field offset: 0x8
		public UpdateFunction <>9__0; //Field offset: 0xC
		public UpdateFunction <>9__1; //Field offset: 0x10

		public <>c__DisplayClass6_0() { }

		internal void <AddProfileSubSystem>b__0() { }

		internal void <AddProfileSubSystem>b__1() { }

	}

	internal enum CounterID
	{
		FrameStart = 0,
		ScriptRunBehaviourUpdate = 1,
		PlayerUpdateCanvases = 2,
		FinishFrameRendering = 3,
		MemoryFrameMaintenance = 4,
		NUM = 5,
	}

	private struct PostEvent
	{

	}

	private struct PrevEvent
	{

	}

	internal struct Recored
	{
		public float StartTime; //Field offset: 0x0
		public float EndTime; //Field offset: 0x4
		public float StartLap; //Field offset: 0x8
		public float EndLap; //Field offset: 0xC
		public float Duration; //Field offset: 0x10
		public long Counter; //Field offset: 0x18

	}

	private static Recored[] LastRecoreds; //Field offset: 0x0
	public static Recored[] PrevLastRecoreds; //Field offset: 0x4

	private static DebugGameLoopProfiler() { }

	public DebugGameLoopProfiler() { }

	private static void AddProfileSubSystem(string headerName, string subName, CounterID id) { }

	private static void Backup() { }

	public static void Dump() { }

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::BeforeSceneLoad (1))]
	private static void Init() { }

}

