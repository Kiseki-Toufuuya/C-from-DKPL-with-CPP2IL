namespace UnityEngine.InputSystem.Utilities;

public sealed class InputActionTrace : IEnumerable<ActionEventPtr>, IEnumerable, IDisposable
{
	internal struct ActionEventPtr
	{
		internal InputActionState m_State; //Field offset: 0x0
		internal ActionEvent* m_Ptr; //Field offset: 0x4

		public InputAction action
		{
			 get { } //Length: 38
		}

		public InputControl control
		{
			 get { } //Length: 46
		}

		public double duration
		{
			 get { } //Length: 39
		}

		public IInputInteraction interaction
		{
			 get { } //Length: 67
		}

		public InputActionPhase phase
		{
			 get { } //Length: 15
		}

		public double startTime
		{
			 get { } //Length: 14
		}

		public double time
		{
			 get { } //Length: 34
		}

		public int valueSizeInBytes
		{
			 get { } //Length: 21
		}

		public InputAction get_action() { }

		public InputControl get_control() { }

		public double get_duration() { }

		public IInputInteraction get_interaction() { }

		public InputActionPhase get_phase() { }

		public double get_startTime() { }

		public double get_time() { }

		public int get_valueSizeInBytes() { }

		public void ReadValue(Void* buffer, int bufferSize) { }

		public TValue ReadValue() { }

		public object ReadValueAsObject() { }

		public virtual string ToString() { }

	}

	private struct Enumerator : IEnumerator<ActionEventPtr>, IEnumerator, IDisposable
	{
		private readonly InputActionTrace m_Trace; //Field offset: 0x0
		private readonly ActionEvent* m_Buffer; //Field offset: 0x4
		private readonly int m_EventCount; //Field offset: 0x8
		private ActionEvent* m_CurrentEvent; //Field offset: 0xC
		private int m_CurrentIndex; //Field offset: 0x10

		public override ActionEventPtr Current
		{
			 get { } //Length: 108
		}

		private override object System.Collections.IEnumerator.Current
		{
			private get { } //Length: 73
		}

		public Enumerator(InputActionTrace trace) { }

		public override void Dispose() { }

		public override ActionEventPtr get_Current() { }

		public override bool MoveNext() { }

		public override void Reset() { }

		private override object System.Collections.IEnumerator.get_Current() { }

	}

	private bool m_SubscribedToAll; //Field offset: 0x8
	private bool m_OnActionChangeHooked; //Field offset: 0x9
	private InlinedArray<InputAction> m_SubscribedActions; //Field offset: 0xC
	private InlinedArray<InputActionMap> m_SubscribedActionMaps; //Field offset: 0x18
	private InputEventBuffer m_EventBuffer; //Field offset: 0x28
	private InlinedArray<InputActionState> m_ActionMapStates; //Field offset: 0x48
	private InlinedArray<InputActionState> m_ActionMapStateClones; //Field offset: 0x54
	private Action<CallbackContext> m_CallbackDelegate; //Field offset: 0x60
	private Action<Object, InputActionChange> m_ActionChangeDelegate; //Field offset: 0x64

	public InputEventBuffer buffer
	{
		 get { } //Length: 26
	}

	public int count
	{
		 get { } //Length: 11
	}

	public InputActionTrace() { }

	public InputActionTrace(InputAction action) { }

	public InputActionTrace(InputActionMap actionMap) { }

	public void Clear() { }

	private void CloneActionStateBeforeBindingsChange(InputActionMap actionMap) { }

	public override void Dispose() { }

	private void DisposeInternal() { }

	protected virtual void Finalize() { }

	public InputEventBuffer get_buffer() { }

	public int get_count() { }

	public override IEnumerator<ActionEventPtr> GetEnumerator() { }

	private void HookOnActionChange() { }

	private void OnActionChange(object actionOrMapOrAsset, InputActionChange change) { }

	public void RecordAction(CallbackContext context) { }

	public void SubscribeTo(InputAction action) { }

	public void SubscribeTo(InputActionMap actionMap) { }

	public void SubscribeToAll() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public virtual string ToString() { }

	private void UnhookOnActionChange() { }

	public void UnsubscribeFrom(InputAction action) { }

	public void UnsubscribeFrom(InputActionMap actionMap) { }

	public void UnsubscribeFromAll() { }

}

