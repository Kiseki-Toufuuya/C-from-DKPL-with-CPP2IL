namespace CriWare;

public class CriAtomExOutputPort : CriDisposable
{
	internal struct Config
	{
		public string name; //Field offset: 0x0
		public Type type; //Field offset: 0x4
		public uint maxIgnoredCategories; //Field offset: 0x8

		public static Config Default() { }

	}

	private class NativeMethods
	{

		public NativeMethods() { }

		internal static int criAtomExOutputPort_CalculateWorkSize(in Config config) { }

		internal static IntPtr criAtomExOutputPort_Create(ref Config config, IntPtr work, int workSize) { }

		internal static void criAtomExOutputPort_Destroy(IntPtr outputPort) { }

		internal static bool criAtomExOutputPort_IsDestroyable(IntPtr outputPort) { }

		internal static void criAtomExOutputPort_SetAsrRackId(IntPtr outputPort, int rackId) { }

		internal static void criAtomExOutputPort_SetMonauralMix(IntPtr outputPort, bool monauralMix) { }

		internal static void criAtomExOutputPort_SetVibrationChannelLevel(IntPtr outputPort, int channel, float level) { }

	}

	internal enum Type
	{
		Audio = 0,
		Vibration = 1,
	}

	public const uint MaxNameLength = 64; //Field offset: 0x0
	[CompilerGenerated]
	private IntPtr <NativeHandle>k__BackingField; //Field offset: 0x18
	private bool hasExistingNativeHandle; //Field offset: 0x1C

	public bool isAvailable
	{
		 get { } //Length: 15
	}

	internal IntPtr NativeHandle
	{
		[CompilerGenerated]
		internal get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	public CriAtomExOutputPort(Config config) { }

	internal CriAtomExOutputPort(IntPtr existingNativeHandle) { }

	public int CalculateWorkSize(Config config) { }

	public virtual void Dispose() { }

	protected override void Dispose(bool disposing) { }

	protected virtual void Finalize() { }

	public bool get_isAvailable() { }

	[CompilerGenerated]
	internal IntPtr get_NativeHandle() { }

	public bool IsDestroyable() { }

	[CompilerGenerated]
	private void set_NativeHandle(IntPtr value) { }

	public void SetAsrRackId(int rackId) { }

	public void SetMonauralMix(bool monauralMix) { }

	public void SetVibrationChannelLevel(int channel, float level) { }

}

