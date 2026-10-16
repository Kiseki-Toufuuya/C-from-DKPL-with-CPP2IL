namespace CriWare;

public static class CriWareDecrypter
{
	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	internal sealed class CallbackFromNativeDelegate : MulticastDelegate
	{

		public CallbackFromNativeDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(IntPtr ptr1, AsyncCallback callback, object object) { }

		public override ulong EndInvoke(IAsyncResult result) { }

		public override ulong Invoke(IntPtr ptr1) { }

	}

	internal class Config
	{
		public string key; //Field offset: 0x8
		public bool enableAtomDecryption; //Field offset: 0xC
		public bool enableManaDecryption; //Field offset: 0xD

		public Config() { }

	}

	private static ulong temporalStorage; //Field offset: 0x0

	[MonoPInvokeCallback(typeof(CallbackFromNativeDelegate))]
	private static ulong CallbackFromNative(IntPtr ptr1) { }

	public static int CRIWAREC84058D0(bool enable_atom_decryption, bool enable_mana_decryption, CallbackFromNativeDelegate func, IntPtr obj) { }

	public static bool Initialize(Config config) { }

	public static bool Initialize(string key, bool enableAtomDecryption, bool enableManaDecryption) { }

}

