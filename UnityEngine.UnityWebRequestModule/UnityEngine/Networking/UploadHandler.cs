namespace UnityEngine.Networking;

[NativeHeader("Modules/UnityWebRequest/Public/UploadHandler/UploadHandler.h")]
public class UploadHandler : IDisposable
{
	public static class BindingsMarshaller
	{

		public static IntPtr ConvertToNative(UploadHandler uploadHandler) { }

	}

	internal IntPtr m_Ptr; //Field offset: 0x8

	public string contentType
	{
		 set { } //Length: 31
	}

	internal UploadHandler() { }

	public override void Dispose() { }

	protected virtual void Finalize() { }

	[NativeMethod("SetContentType")]
	private void InternalSetContentType(string newContentType) { }

	private static void InternalSetContentType_Injected(IntPtr _unity_self, ref ManagedSpanWrapper newContentType) { }

	[NativeMethod(IsThreadSafe = True)]
	private void ReleaseFromScripting() { }

	private static void ReleaseFromScripting_Injected(IntPtr _unity_self) { }

	public void set_contentType(string value) { }

	internal override void SetContentType(string newContentType) { }

}

