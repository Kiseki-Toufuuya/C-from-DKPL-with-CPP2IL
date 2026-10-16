namespace CriWare;

public class CriAtomEx3dRegion : CriDisposable
{
	internal struct Config
	{
		public int reserved; //Field offset: 0x0

	}

	private static class UnsafeNativeMethods
	{

		internal static IntPtr criAtomEx3dRegion_Create(ref Config config, IntPtr work, int work_size) { }

		internal static void criAtomEx3dRegion_Destroy(IntPtr ex_3d_region) { }

		internal static bool criAtomEx3dRegion_IsDestroyable(IntPtr ex3dRegion) { }

	}

	private IntPtr handle; //Field offset: 0x18

	public IntPtr nativeHandle
	{
		 get { } //Length: 11
	}

	public CriAtomEx3dRegion() { }

	public virtual void Dispose() { }

	private void Dispose(bool disposing) { }

	protected virtual void Finalize() { }

	public IntPtr get_nativeHandle() { }

	public bool IsDestroyable() { }

}

