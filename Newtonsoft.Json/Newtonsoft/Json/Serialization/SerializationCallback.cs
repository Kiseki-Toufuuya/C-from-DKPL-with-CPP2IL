namespace Newtonsoft.Json.Serialization;

public sealed class SerializationCallback : MulticastDelegate
{

	public SerializationCallback(object object, IntPtr method) { }

	[NullableContext(1)]
	public override void Invoke(object o, StreamingContext context) { }

}

