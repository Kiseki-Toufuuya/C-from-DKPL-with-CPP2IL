namespace UnityEngine.Networking;

[NativeHeader("Modules/UnityWebRequest/Public/CertificateHandler/CertificateHandlerScript.h")]
public class CertificateHandler : IDisposable
{
	public static class BindingsMarshaller
	{

		public static IntPtr ConvertToNative(CertificateHandler handler) { }

	}

	internal IntPtr m_Ptr; //Field offset: 0x8

	protected CertificateHandler() { }

	private static IntPtr Create(CertificateHandler obj) { }

	public override void Dispose() { }

	protected virtual void Finalize() { }

	[NativeMethod(IsThreadSafe = True)]
	private void ReleaseFromScripting() { }

	private static void ReleaseFromScripting_Injected(IntPtr _unity_self) { }

	protected override bool ValidateCertificate(Byte[] certificateData) { }

	[RequiredByNativeCode]
	internal bool ValidateCertificateNative(Byte[] certificateData) { }

}

