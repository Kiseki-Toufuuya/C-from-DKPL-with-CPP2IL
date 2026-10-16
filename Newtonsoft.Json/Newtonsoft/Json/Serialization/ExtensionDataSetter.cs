namespace Newtonsoft.Json.Serialization;

public sealed class ExtensionDataSetter : MulticastDelegate
{

	public ExtensionDataSetter(object object, IntPtr method) { }

	[NullableContext(1)]
	public override void Invoke(object o, string key, object value) { }

}

