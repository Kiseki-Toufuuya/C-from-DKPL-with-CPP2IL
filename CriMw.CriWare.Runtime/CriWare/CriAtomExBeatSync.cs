namespace CriWare;

public static class CriAtomExBeatSync
{
	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	internal sealed class CbFunc : MulticastDelegate
	{

		public CbFunc(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ref Info info, AsyncCallback callback, object object) { }

		public override void EndInvoke(ref Info info, IAsyncResult result) { }

		public override void Invoke(ref Info info) { }

	}

	internal struct Info
	{
		public IntPtr playerHn; //Field offset: 0x0
		public uint playbackId; //Field offset: 0x4
		public uint barCount; //Field offset: 0x8
		public uint beatCount; //Field offset: 0xC
		public float beatProgress; //Field offset: 0x10
		public float bpm; //Field offset: 0x14
		public int offset; //Field offset: 0x18
		public uint numBeats; //Field offset: 0x1C
		public IntPtr labelPtr; //Field offset: 0x20

		public string label
		{
			 get { } //Length: 123
		}

		public string get_label() { }

	}


	public static event CbFunc OnCallback
	{
		 add { } //Length: 16
		 remove { } //Length: 16
	}

	public static void add_OnCallback(CbFunc value) { }

	public static void remove_OnCallback(CbFunc value) { }

	[Obsolete("SetCallback is deprecated. Use OnBeatSyncCallback event", False)]
	public static void SetCallback(CbFunc func) { }

}

