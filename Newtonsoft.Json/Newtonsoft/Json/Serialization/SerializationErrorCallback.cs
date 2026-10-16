namespace Newtonsoft.Json.Serialization;

public sealed class SerializationErrorCallback : MulticastDelegate
{

	public SerializationErrorCallback(object object, IntPtr method) { }

	[NullableContext(1)]
	public override void Invoke(object o, StreamingContext context, ErrorContext errorContext) { }

}

