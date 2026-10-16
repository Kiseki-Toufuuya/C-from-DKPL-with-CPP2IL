namespace CriWare;

public static class CriDisposableObjectManager
{
	internal enum ModuleType
	{
		Atom = 0,
		AtomMic = 1,
		Fs = 2,
		FsWeb = 3,
		Mana = 4,
		Lips = 5,
		Vip = 6,
		Rtc = 7,
	}

	internal struct ObjectRef
	{
		public Guid guid; //Field offset: 0x0
		public ModuleType type; //Field offset: 0x10
		public CriDisposable disposable; //Field offset: 0x14

		public ObjectRef(Guid _guid, CriDisposable _disposable, ModuleType _type) { }

	}

	private static List<ObjectRef> refList; //Field offset: 0x0

	private static CriDisposableObjectManager() { }

	public static void CallOnModuleFinalization(ModuleType type) { }

	public static void DisposeAll(ModuleType type) { }

	private static int GetNextWithType(ModuleType type) { }

	public static bool IsDisposed(CriDisposable disposable) { }

	public static void Register(CriDisposable disposable, ModuleType type) { }

	private static int SearchForDisposable(CriDisposable disposable) { }

	public static bool Unregister(CriDisposable disposable) { }

}

