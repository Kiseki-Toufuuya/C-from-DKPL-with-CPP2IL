namespace UnityEngine.Networking;

[NativeHeader("Modules/UnityWebRequest/Public/DownloadHandler/DownloadHandlerVFS.h")]
public sealed class DownloadHandlerFile : DownloadHandler
{
	public static class BindingsMarshaller
	{

		public static IntPtr ConvertToNative(DownloadHandlerFile handler) { }

	}


	public bool removeFileOnAbort
	{
		 set { } //Length: 72
	}

	public DownloadHandlerFile(string path) { }

	[NativeThrows]
	private static IntPtr Create(DownloadHandlerFile obj, string path, bool append) { }

	private static IntPtr Create_Injected(DownloadHandlerFile obj, ref ManagedSpanWrapper path, bool append) { }

	protected virtual Byte[] GetData() { }

	protected virtual NativeArray<Byte> GetNativeData() { }

	protected virtual string GetText() { }

	private void InternalCreateVFS(string path, bool append) { }

	public void set_removeFileOnAbort(bool value) { }

	private static void set_removeFileOnAbort_Injected(IntPtr _unity_self, bool value) { }

}

