namespace CriWare;

public class CriAtomExSoundObject : CriDisposable
{
	private struct Config
	{
		public bool enableVoiceLimitScope; //Field offset: 0x0
		public bool enableCategoryCueLimitScope; //Field offset: 0x1

	}

	private IntPtr handle; //Field offset: 0x18

	public IntPtr nativeHandle
	{
		 get { } //Length: 11
	}

	public CriAtomExSoundObject(bool enableVoiceLimitScope, bool enableCategoryCueLimitScope) { }

	public void AddPlayer(CriAtomExPlayer player) { }

	private static void criAtomExSoundObject_AddPlayer(IntPtr soundObject, IntPtr player) { }

	private static IntPtr criAtomExSoundObject_Create(ref Config config, IntPtr work, int work_size) { }

	private static void criAtomExSoundObject_DeleteAllPlayers(IntPtr soundObject) { }

	private static void criAtomExSoundObject_DeletePlayer(IntPtr soundObject, IntPtr player) { }

	private static void criAtomExSoundObject_Destroy(IntPtr soundObject) { }

	public void DeleteAllPlayers() { }

	public void DeletePlayer(CriAtomExPlayer player) { }

	public virtual void Dispose() { }

	protected virtual void Finalize() { }

	public IntPtr get_nativeHandle() { }

}

