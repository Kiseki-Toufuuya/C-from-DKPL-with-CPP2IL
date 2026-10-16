namespace Unity.Services.Core.Scheduler.Internal;

internal class ActionScheduler : IActionScheduler, IServiceComponent
{
	internal readonly PlayerLoopSystem SchedulerLoopSystem; //Field offset: 0x8
	private readonly ITimeProvider m_TimeProvider; //Field offset: 0x1C
	private readonly object m_Lock; //Field offset: 0x20
	private readonly MinimumBinaryHeap<ScheduledInvocation> m_ScheduledActions; //Field offset: 0x24
	private readonly Dictionary<Int64, ScheduledInvocation> m_IdScheduledInvocationMap; //Field offset: 0x28
	private readonly List<ScheduledInvocation> m_ExpiredActions; //Field offset: 0x2C
	private long m_NextId; //Field offset: 0x30

	public ActionScheduler() { }

	public ActionScheduler(ITimeProvider timeProvider) { }

	internal void ExecuteExpiredActions() { }

	public void JoinPlayerLoopSystem() { }

	internal static void UpdateCurrentPlayerLoopWith(List<PlayerLoopSystem> subSystemList, PlayerLoopSystem currentPlayerLoop) { }

}

