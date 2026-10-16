namespace System.Runtime;

internal abstract class ActionItem
{
	private static class CallbackHelper
	{
		private static Action<Object> invokeWithoutContextCallback; //Field offset: 0x0

		public static Action<Object> InvokeWithoutContextCallback
		{
			 get { } //Length: 133
		}

		public static Action<Object> get_InvokeWithoutContextCallback() { }

		private static void InvokeWithoutContext(object state) { }

	}

	private class DefaultActionItem : ActionItem
	{
		private Action<Object> callback; //Field offset: 0xC
		private object state; //Field offset: 0x10
		private bool flowLegacyActivityId; //Field offset: 0x14
		private Guid activityId; //Field offset: 0x18
		private EventTraceActivity eventTraceActivity; //Field offset: 0x28

		public DefaultActionItem(Action<Object> callback, object state, bool isLowPriority) { }

		protected virtual void Invoke() { }

		private void TraceAndInvoke() { }

	}

	private bool isScheduled; //Field offset: 0x8
	private bool lowPriority; //Field offset: 0x9

	protected bool LowPriority
	{
		 set { } //Length: 14
	}

	protected ActionItem() { }

	protected abstract void Invoke() { }

	public static void Schedule(Action<Object> callback, object state) { }

	public static void Schedule(Action<Object> callback, object state, bool lowPriority) { }

	protected void Schedule() { }

	private static void ScheduleCallback(Action<Object> callback, object state, bool lowPriority) { }

	private void ScheduleCallback(Action<Object> callback) { }

	protected void set_LowPriority(bool value) { }

}

