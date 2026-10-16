namespace CriWare;

public class CriAudioReadStream
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass12_0
	{
		public int bufferSize; //Field offset: 0x8
		public Delegate callback; //Field offset: 0xC
		public int numChannels; //Field offset: 0x10
		public Single[][] buffer; //Field offset: 0x14

		public <>c__DisplayClass12_0() { }

		internal uint <.ctor>b__0(IntPtr cbobj, IntPtr data, uint numSamples) { }

	}

	internal sealed class Delegate : MulticastDelegate
	{

		public Delegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Single[][] buffer, uint numSamples, AsyncCallback callback, object object) { }

		public override uint EndInvoke(IAsyncResult result) { }

		public override uint Invoke(Single[][] buffer, uint numSamples) { }

	}

	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	private sealed class InternalDelegate : MulticastDelegate
	{

		public InternalDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(IntPtr cbobj, IntPtr data, uint numSamples, AsyncCallback callback, object object) { }

		public override uint EndInvoke(IAsyncResult result) { }

		public override uint Invoke(IntPtr cbobj, IntPtr data, uint numSamples) { }

	}

	private InternalDelegate internalDelegate; //Field offset: 0x8
	[CompilerGenerated]
	private IntPtr <callbackFunction>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	private IntPtr <callbackPointer>k__BackingField; //Field offset: 0x10

	public private IntPtr callbackFunction
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	public private IntPtr callbackPointer
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	public CriAudioReadStream(IntPtr callbackFunction, IntPtr callbackPointer) { }

	public CriAudioReadStream(Delegate callback, int numChannels, int bufferSize = 256) { }

	[CompilerGenerated]
	public IntPtr get_callbackFunction() { }

	[CompilerGenerated]
	public IntPtr get_callbackPointer() { }

	[CompilerGenerated]
	private void set_callbackFunction(IntPtr value) { }

	[CompilerGenerated]
	private void set_callbackPointer(IntPtr value) { }

}

