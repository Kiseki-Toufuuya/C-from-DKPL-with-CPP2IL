namespace Ionic.Zip;

public sealed class SetCompressionCallback : MulticastDelegate
{

	public SetCompressionCallback(object object, IntPtr method) { }

	public override CompressionLevel Invoke(string localFileName, string fileNameInArchive) { }

}

