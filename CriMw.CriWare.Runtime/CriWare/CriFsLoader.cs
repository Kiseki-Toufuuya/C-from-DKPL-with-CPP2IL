namespace CriWare;

public class CriFsLoader : CriDisposable
{
	internal enum Status
	{
		Stop = 0,
		Loading = 1,
		Complete = 2,
		Error = 3,
	}

	private IntPtr handle; //Field offset: 0x18
	private GCHandle dstGch; //Field offset: 0x1C
	private GCHandle srcGch; //Field offset: 0x20

	public CriFsLoader() { }

	private static int criFsLoader_Create(out IntPtr loader) { }

	private static int criFsLoader_DecompressData(IntPtr loader, IntPtr src, long src_size, IntPtr dst, long dst_size) { }

	private static int criFsLoader_Destroy(IntPtr loader) { }

	private static int criFsLoader_GetStatus(IntPtr loader, out Status status) { }

	private static int criFsLoader_Load(IntPtr loader, IntPtr binder, string path, long offset, long load_size, IntPtr buffer, long buffer_size) { }

	private static int criFsLoader_LoadById(IntPtr loader, IntPtr binder, int id, long offset, long load_size, IntPtr buffer, long buffer_size) { }

	private static int criFsLoader_LoadWithoutDecompression(IntPtr loader, IntPtr binder, string path, long offset, long load_size, IntPtr buffer, long buffer_size) { }

	private static int criFsLoader_LoadWithoutDecompressionById(IntPtr loader, IntPtr binder, int id, long offset, long load_size, IntPtr buffer, long buffer_size) { }

	private static int criFsLoader_SetReadUnitSize(IntPtr loader, long unit_size) { }

	private static int criFsLoader_Stop(IntPtr loader) { }

	public void DecompressData(long srcSize, Byte[] srcBuffer, long dstSize, Byte[] dstBuffer) { }

	public virtual void Dispose() { }

	private void Dispose(bool disposing) { }

	protected virtual void Finalize() { }

	public Status GetStatus() { }

	public void Load(CriFsBinder binder, string path, long fileOffset, long loadSize, Byte[] buffer) { }

	public void LoadById(CriFsBinder binder, int id, long fileOffset, long loadSize, Byte[] buffer) { }

	public void LoadWithoutDecompression(CriFsBinder binder, string path, long fileOffset, long loadSize, Byte[] buffer) { }

	public void LoadWithoutDecompressionById(CriFsBinder binder, int id, long fileOffset, long loadSize, Byte[] buffer) { }

	public void SetReadUnitSize(int unit_size) { }

	public void Stop() { }

}

