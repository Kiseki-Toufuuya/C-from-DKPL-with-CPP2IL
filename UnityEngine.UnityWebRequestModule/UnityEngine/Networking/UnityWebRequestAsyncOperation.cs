namespace UnityEngine.Networking;

[NativeHeader("Modules/UnityWebRequest/Public/UnityWebRequestAsyncOperation.h")]
[NativeHeader("UnityWebRequestScriptingClasses.h")]
[UsedByNativeCode]
public class UnityWebRequestAsyncOperation : AsyncOperation
{
	public static class BindingsMarshaller
	{

		public static UnityWebRequestAsyncOperation ConvertToManaged(IntPtr ptr) { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private UnityWebRequest <webRequest>k__BackingField; //Field offset: 0x10

	public internal UnityWebRequest webRequest
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		internal set { } //Length: 27
	}

	private UnityWebRequestAsyncOperation(IntPtr ptr) { }

	[CompilerGenerated]
	public UnityWebRequest get_webRequest() { }

	[CompilerGenerated]
	internal void set_webRequest(UnityWebRequest value) { }

}

