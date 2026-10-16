namespace System.Runtime;

internal class IOThreadScheduler
{
	private static class Bits
	{

		public static int Count(int slot) { }

		public static int CountNoIdle(int slot) { }

		public static int IncrementLo(int slot) { }

		public static bool IsComplete(int gate) { }

	}

	private class ScheduledOverlapped
	{
		private readonly NativeOverlapped* nativeOverlapped; //Field offset: 0x8
		private IOThreadScheduler scheduler; //Field offset: 0xC

		public ScheduledOverlapped() { }

		public void Cleanup() { }

		private void IOCallback(uint errorCode, uint numBytes, NativeOverlapped* nativeOverlapped) { }

		public void Post(IOThreadScheduler iots) { }

	}

	private struct Slot
	{
		private int gate; //Field offset: 0x0
		private Action<Object> callback; //Field offset: 0x4
		private object state; //Field offset: 0x8

		public void DequeueWorkItem(out Action<Object>& callback, out object state) { }

		public bool TryEnqueueWorkItem(Action<Object> callback, object state, out bool wrapped) { }

	}

	private static IOThreadScheduler current; //Field offset: 0x0
	private readonly ScheduledOverlapped overlapped; //Field offset: 0x8
	private readonly Slot[] slots; //Field offset: 0xC
	private readonly Slot[] slotsLowPri; //Field offset: 0x10
	private int headTail; //Field offset: 0x14
	private int headTailLowPri; //Field offset: 0x18

	private int SlotMask
	{
		private get { } //Length: 24
	}

	private int SlotMaskLowPri
	{
		private get { } //Length: 24
	}

	private static IOThreadScheduler() { }

	private IOThreadScheduler(int capacity, int capacityLowPri) { }

	private void Cleanup() { }

	private void CompletionCallback(out Action<Object>& callback, out object state) { }

	protected virtual void Finalize() { }

	private int get_SlotMask() { }

	private int get_SlotMaskLowPri() { }

	private bool ScheduleCallbackHelper(Action<Object> callback, object state) { }

	private bool ScheduleCallbackLowPriHelper(Action<Object> callback, object state) { }

	public static void ScheduleCallbackLowPriNoFlow(Action<Object> callback, object state) { }

	public static void ScheduleCallbackNoFlow(Action<Object> callback, object state) { }

	private bool TryCoalesce(out Action<Object>& callback, out object state) { }

}

