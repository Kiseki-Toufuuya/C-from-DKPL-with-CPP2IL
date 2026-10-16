namespace System.Runtime.Serialization;

public sealed class SerializationObjectManager
{
	private readonly Dictionary<Object, Object> _objectSeenTable; //Field offset: 0x8
	private readonly StreamingContext _context; //Field offset: 0xC
	private SerializationEventHandler _onSerializedHandler; //Field offset: 0x14

	public SerializationObjectManager(StreamingContext context) { }

	private void AddOnSerialized(object obj) { }

	public void RaiseOnSerializedEvent() { }

	public void RegisterObject(object obj) { }

}

