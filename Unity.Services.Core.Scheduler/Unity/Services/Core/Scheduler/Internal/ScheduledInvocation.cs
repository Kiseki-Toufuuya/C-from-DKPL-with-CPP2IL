namespace Unity.Services.Core.Scheduler.Internal;

internal class ScheduledInvocation
{
	public Action Action; //Field offset: 0x8
	public DateTime InvocationTime; //Field offset: 0x10
	public long ActionId; //Field offset: 0x18

}

