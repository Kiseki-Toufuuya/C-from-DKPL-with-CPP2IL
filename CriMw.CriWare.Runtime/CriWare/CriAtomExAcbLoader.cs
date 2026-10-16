namespace CriWare;

public class CriAtomExAcbLoader : CriDisposable
{
	private struct LoaderConfig
	{
		public bool shouldLoadAwbOnMemory; //Field offset: 0x0

	}

	internal enum Status
	{
		Stop = 0,
		Loading = 1,
		Complete = 2,
		Error = 3,
	}

	private IntPtr handle; //Field offset: 0x18
	private Nullable<GCHandle> gch; //Field offset: 0x1C

	private CriAtomExAcbLoader(IntPtr handle, Nullable<GCHandle> dataHandle) { }

	private static IntPtr criAtomExAcbLoader_Create(in LoaderConfig config) { }

	private static void criAtomExAcbLoader_Destroy(IntPtr acb_loader) { }

	private static Status criAtomExAcbLoader_GetStatus(IntPtr acb_loader) { }

	private static bool criAtomExAcbLoader_LoadAcbDataAsync(IntPtr acb_loader, IntPtr acb_data, int acb_size, IntPtr awb_binder, string awb_path) { }

	private static bool criAtomExAcbLoader_LoadAcbFileAsync(IntPtr acb_loader, IntPtr acb_binder, string acb_path, IntPtr awb_binder, string awb_path) { }

	private static IntPtr criAtomExAcbLoader_MoveAcbHandle(IntPtr acb_loader) { }

	private static bool criAtomExAcbLoader_WaitForCompletion(IntPtr acb_loader) { }

	public virtual void Dispose() { }

	private void Dispose(bool disposing) { }

	protected virtual void Finalize() { }

	public Status GetStatus() { }

	public static CriAtomExAcbLoader LoadAcbDataAsync(Byte[] acbData, CriFsBinder awbBinder, string awbPath, bool loadAwbOnMemory = false) { }

	public static CriAtomExAcbLoader LoadAcbDataAsync(IntPtr acbData, int dataSize, CriFsBinder awbBinder, string awbPath, bool loadAwbOnMemory = false) { }

	public static CriAtomExAcbLoader LoadAcbFileAsync(CriFsBinder binder, string acbPath, string awbPath, bool loadAwbOnMemory = false) { }

	public CriAtomExAcb MoveAcb() { }

}

