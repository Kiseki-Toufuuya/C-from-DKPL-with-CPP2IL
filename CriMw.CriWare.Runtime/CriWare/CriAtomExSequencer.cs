namespace CriWare;

public static class CriAtomExSequencer
{
	internal struct CriAtomExSequenceEventInfo
	{
		public ulong position; //Field offset: 0x0
		public IntPtr playerHn; //Field offset: 0x8
		public readonly string tag; //Field offset: 0xC
		public uint playbackId; //Field offset: 0x10
		private int type; //Field offset: 0x14
		public uint id; //Field offset: 0x18
		private uint reserved; //Field offset: 0x1C

	}

	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	internal sealed class EventCallback : MulticastDelegate
	{

		public EventCallback(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ref CriAtomExSequenceEventInfo criAtomExSequenceInfo, AsyncCallback callback, object object) { }

		public override void EndInvoke(ref CriAtomExSequenceEventInfo criAtomExSequenceInfo, IAsyncResult result) { }

		public override void Invoke(ref CriAtomExSequenceEventInfo criAtomExSequenceInfo) { }

	}

	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	internal sealed class EventCbFunc : MulticastDelegate
	{

		public EventCbFunc(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string eventParamsString, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(string eventParamsString) { }

	}


	public static event EventCallback OnCallback
	{
		 add { } //Length: 16
		 remove { } //Length: 224
	}

	public static void add_OnCallback(EventCallback value) { }

	public static void remove_OnCallback(EventCallback value) { }

	[Obsolete("SetEventCallback is deprecated. Use CriAtomExSequencer.OnCallback event", False)]
	public static void SetEventCallback(EventCbFunc func, string separator = "	") { }

}

