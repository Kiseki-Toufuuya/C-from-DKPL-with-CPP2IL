namespace UnityEngine.Networking;

[NativeHeader("Modules/UnityWebRequest/Public/DownloadHandler/DownloadHandlerBuffer.h")]
public sealed class DownloadHandlerBuffer : DownloadHandler
{
	private NativeArray<Byte> m_NativeData; //Field offset: 0xC

	public DownloadHandlerBuffer() { }

	private static IntPtr Create(DownloadHandlerBuffer obj) { }

	public virtual void Dispose() { }

	protected virtual NativeArray<Byte> GetNativeData() { }

	private void InternalCreateBuffer() { }

}

