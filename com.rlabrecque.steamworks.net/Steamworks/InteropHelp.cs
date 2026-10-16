namespace Steamworks;

public class InteropHelp
{
	internal class UTF8StringHandle : SafeHandleZeroOrMinusOneIsInvalid
	{

		public UTF8StringHandle(string str) { }

		protected virtual bool ReleaseHandle() { }

	}


	public static string PtrToStringUTF8(IntPtr nativeUtf8) { }

	public static void TestIfAvailableClient() { }

	public static void TestIfPlatformSupported() { }

}

