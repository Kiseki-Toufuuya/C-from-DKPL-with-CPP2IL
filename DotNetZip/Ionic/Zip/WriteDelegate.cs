namespace Ionic.Zip;

public sealed class WriteDelegate : MulticastDelegate
{

	public WriteDelegate(object object, IntPtr method) { }

	public override void Invoke(string entryName, Stream stream) { }

}

