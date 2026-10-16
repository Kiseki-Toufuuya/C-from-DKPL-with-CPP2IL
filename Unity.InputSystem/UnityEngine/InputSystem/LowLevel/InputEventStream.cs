namespace UnityEngine.InputSystem.LowLevel;

internal struct InputEventStream
{
	private InputEventBuffer m_NativeBuffer; //Field offset: 0x0
	private InputEvent* m_CurrentNativeEventReadPtr; //Field offset: 0x20
	private InputEvent* m_CurrentNativeEventWritePtr; //Field offset: 0x24
	private int m_RemainingNativeEventCount; //Field offset: 0x28
	private readonly int m_MaxAppendedEvents; //Field offset: 0x2C
	private InputEventBuffer m_AppendBuffer; //Field offset: 0x30
	private InputEvent* m_CurrentAppendEventReadPtr; //Field offset: 0x50
	private InputEvent* m_CurrentAppendEventWritePtr; //Field offset: 0x54
	private int m_RemainingAppendEventCount; //Field offset: 0x58
	private int m_NumEventsRetainedInBuffer; //Field offset: 0x5C
	private bool m_IsOpen; //Field offset: 0x60

	public InputEvent* currentEventPtr
	{
		 get { } //Length: 32
	}

	public bool isOpen
	{
		 get { } //Length: 11
	}

	public uint numBytesRetainedInBuffer
	{
		 get { } //Length: 79
	}

	public int numEventsRetainedInBuffer
	{
		 get { } //Length: 11
	}

	public int remainingEventCount
	{
		 get { } //Length: 14
	}

	public InputEventStream(ref InputEventBuffer eventBuffer, int maxAppendedEvents) { }

	public InputEvent* Advance(bool leaveEventInBuffer) { }

	public void CleanUpAfterException() { }

	public void Close(ref InputEventBuffer eventBuffer) { }

	public InputEvent* get_currentEventPtr() { }

	public bool get_isOpen() { }

	public uint get_numBytesRetainedInBuffer() { }

	public int get_numEventsRetainedInBuffer() { }

	public int get_remainingEventCount() { }

	public InputEvent* Peek() { }

	public void Write(InputEvent* eventPtr) { }

}

