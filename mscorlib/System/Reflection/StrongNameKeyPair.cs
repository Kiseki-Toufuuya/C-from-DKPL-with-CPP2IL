namespace System.Reflection;

[ComVisible(True)]
public class StrongNameKeyPair : ISerializable, IDeserializationCallback
{
	private Byte[] _publicKey; //Field offset: 0x8
	private string _keyPairContainer; //Field offset: 0xC
	private bool _keyPairExported; //Field offset: 0x10
	private Byte[] _keyPairArray; //Field offset: 0x14

	protected StrongNameKeyPair(SerializationInfo info, StreamingContext context) { }

	private override void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

}

