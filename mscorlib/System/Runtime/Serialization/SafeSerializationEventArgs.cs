namespace System.Runtime.Serialization;

public sealed class SafeSerializationEventArgs : EventArgs
{
	private StreamingContext m_streamingContext; //Field offset: 0x8
	private List<Object> m_serializedStates; //Field offset: 0x10

	internal IList<Object> SerializedStates
	{
		internal get { } //Length: 11
	}

	internal SafeSerializationEventArgs(StreamingContext streamingContext) { }

	internal IList<Object> get_SerializedStates() { }

}

