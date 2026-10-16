namespace CriWare;

[Obsolete("CriFsInstaller is no longer working. Use CriFsWebInstaller instead.")]
public class CriFsInstaller : CriDisposable
{
	private enum CopyPolicy
	{
		Always = 0,
	}

	internal enum Status
	{
		Stop = 0,
		Busy = 1,
		Complete = 2,
		Error = 3,
	}

	private Byte[] installBuffer; //Field offset: 0x18
	private GCHandle installBufferGch; //Field offset: 0x1C
	private IntPtr handle; //Field offset: 0x20

	public CriFsInstaller() { }

	public void Copy(CriFsBinder binder, string srcPath, string dstPath, int installBufferSize) { }

	private static int criFsInstaller_Copy(IntPtr installer, IntPtr binder, string src_path, string dst_path, IntPtr buffer, long buffer_size) { }

	private static int criFsInstaller_Create(out IntPtr installer, CopyPolicy option) { }

	private static int criFsInstaller_Destroy(IntPtr installer) { }

	private static int criFsInstaller_ExecuteMain() { }

	private static int criFsInstaller_GetProgress(IntPtr installer, out float progress) { }

	private static int criFsInstaller_GetStatus(IntPtr installer, out Status status) { }

	private static int criFsInstaller_Stop(IntPtr installer) { }

	public virtual void Dispose() { }

	private void Dispose(bool disposing) { }

	public static void ExecuteMain() { }

	protected virtual void Finalize() { }

	public float GetProgress() { }

	public Status GetStatus() { }

	public void Stop() { }

}

