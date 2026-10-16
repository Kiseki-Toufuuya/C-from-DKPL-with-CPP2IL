namespace CriWare;

public class CriAtomEx3dListener : CriDisposable
{
	internal struct Config
	{
		public int reserved; //Field offset: 0x0

	}

	private IntPtr handle; //Field offset: 0x18

	public IntPtr nativeHandle
	{
		 get { } //Length: 11
	}

	public CriAtomEx3dListener() { }

	private static IntPtr criAtomEx3dListener_Create(ref Config config, IntPtr work, int work_size) { }

	private static void criAtomEx3dListener_Destroy(IntPtr ex_3d_listener) { }

	private static bool criAtomEx3dListener_IsDestroyable(IntPtr ex_3d_listener) { }

	private static void criAtomEx3dListener_ResetParameters(IntPtr ex_3d_listener) { }

	private static void criAtomEx3dListener_Set3dRegionHn(IntPtr ex_3d_listener, IntPtr ex_3d_region) { }

	private static void criAtomEx3dListener_SetDirectionFocusLevel(IntPtr ex_3d_listener, float direction_focus_level) { }

	private static void criAtomEx3dListener_SetDistanceFactor(IntPtr ex_3d_listener, float distance_factor) { }

	private static void criAtomEx3dListener_SetDistanceFocusLevel(IntPtr ex_3d_listener, float distance_focus_level) { }

	private static void criAtomEx3dListener_SetDopplerMultiplier(IntPtr ex_3d_listener, float doppler_multiplier) { }

	private static void criAtomEx3dListener_SetFocusPoint(IntPtr ex_3d_listener, ref NativeVector focus_point) { }

	private static void criAtomEx3dListener_SetOrientation(IntPtr ex_3d_listener, ref NativeVector front, ref NativeVector top) { }

	private static void criAtomEx3dListener_SetPosition(IntPtr ex_3d_listener, ref NativeVector position) { }

	private static void criAtomEx3dListener_SetVelocity(IntPtr ex_3d_listener, ref NativeVector velocity) { }

	private static void criAtomEx3dListener_Update(IntPtr ex_3d_listener) { }

	private void Dispose(bool disposing) { }

	public virtual void Dispose() { }

	protected virtual void Finalize() { }

	public IntPtr get_nativeHandle() { }

	public bool IsDestroyable() { }

	public void ResetParameters() { }

	public void Set3dRegion(CriAtomEx3dRegion region3d) { }

	public void SetDirectionFocusLevel(float directionFocusLevel) { }

	[Obsolete("Use SetDopplerMultiplier instead")]
	public void SetDistanceFactor(float distanceFactor) { }

	public void SetDistanceFocusLevel(float distanceFocusLevel) { }

	public void SetDopplerMultiplier(float dopplerMultiplier) { }

	public void SetFocusPoint(float x, float y, float z) { }

	public void SetOrientation(float fx, float fy, float fz, float ux, float uy, float uz) { }

	public void SetPosition(float x, float y, float z) { }

	public void SetVelocity(float x, float y, float z) { }

	public void Update() { }

}

