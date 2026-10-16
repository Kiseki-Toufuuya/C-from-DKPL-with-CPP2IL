namespace CriWare;

public class CriAtomExOutputAnalyzer : CriDisposable
{
	internal struct Config
	{
		public bool enableLevelmeter; //Field offset: 0x0
		public bool enableSpectrumAnalyzer; //Field offset: 0x1
		public bool enablePcmCapture; //Field offset: 0x2
		public bool enablePcmCaptureCallback; //Field offset: 0x3
		public int numSpectrumAnalyzerBands; //Field offset: 0x4
		public int numCapturedPcmSamples; //Field offset: 0x8

	}

	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	internal sealed class InternalPcmCaptureCallback : MulticastDelegate
	{

		public InternalPcmCaptureCallback(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(IntPtr dataL, IntPtr dataR, int numChannels, int numData, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(IntPtr dataL, IntPtr dataR, int numChannels, int numData) { }

	}

	internal sealed class PcmCaptureCallback : MulticastDelegate
	{

		public PcmCaptureCallback(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Single[] dataL, Single[] dataR, int numChannels, int numData, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Single[] dataL, Single[] dataR, int numChannels, int numData) { }

	}

	public const int MaximumSpectrumBands = 512; //Field offset: 0x0
	protected const int pcmCapturerNumMaxData = 512; //Field offset: 0x0
	protected static IntPtr InternalCallbackFunctionPointer; //Field offset: 0x0
	protected static InternalPcmCaptureCallback DelegateObject; //Field offset: 0x4
	protected static Single[] DataL; //Field offset: 0x8
	protected static Single[] DataR; //Field offset: 0xC
	protected static PcmCaptureCallback UserPcmCaptureCallback; //Field offset: 0x10
	protected IntPtr handle; //Field offset: 0x18
	protected CriAtomExPlayer player; //Field offset: 0x1C
	protected string busName; //Field offset: 0x20
	protected int numBands; //Field offset: 0x24
	protected int numCapturedPcmSamples; //Field offset: 0x28
	protected PcmCaptureCallback userPcmCaptureCallback; //Field offset: 0x2C
	protected Single[] dataL; //Field offset: 0x30
	protected Single[] dataR; //Field offset: 0x34

	public IntPtr nativeHandle
	{
		 get { } //Length: 11
	}

	private static CriAtomExOutputAnalyzer() { }

	protected CriAtomExOutputAnalyzer() { }

	public CriAtomExOutputAnalyzer(Config config) { }

	public bool AttachDspBus(string busName) { }

	public bool AttachExPlayer(CriAtomExPlayer player) { }

	[MonoPInvokeCallback(typeof(InternalPcmCaptureCallback))]
	private static void Callback(IntPtr ptrL, IntPtr ptrR, int numChannels, int numData) { }

	protected static void criAtomExOutputAnalyzer_AttachDspBusByName(IntPtr analyzer, string busName) { }

	protected static void criAtomExOutputAnalyzer_AttachExPlayer(IntPtr analyzer, IntPtr player) { }

	protected static IntPtr criAtomExOutputAnalyzer_Create(in Config config) { }

	protected static void criAtomExOutputAnalyzer_Destroy(IntPtr analyzer) { }

	protected static void criAtomExOutputAnalyzer_DetachDspBusByName(IntPtr analyzer, string busName) { }

	protected static void criAtomExOutputAnalyzer_DetachExPlayer(IntPtr analyzer, IntPtr player) { }

	protected static void criAtomExOutputAnalyzer_ExecuteQueuedPcmCapturerCallbacks(IntPtr analyzer, IntPtr callback) { }

	protected static IntPtr criAtomExOutputAnalyzer_GetPcmData(IntPtr analyzer, int ch) { }

	protected static float criAtomExOutputAnalyzer_GetRms(IntPtr analyzer, int channel) { }

	protected static IntPtr criAtomExOutputAnalyzer_GetSpectrumLevels(IntPtr analyzer) { }

	public void DetachDspBus() { }

	public void DetachExPlayer() { }

	protected void Dispose(bool disposing) { }

	public virtual void Dispose() { }

	public void ExecutePcmCaptureCallback() { }

	[Obsolete("Use SetPcmCaptureCallback(PcmCaptureCallback) and ExecutePcmCaptureCallback()")]
	public void ExecutePcmCaptureCallback(PcmCaptureCallback callback) { }

	protected virtual void Finalize() { }

	public IntPtr get_nativeHandle() { }

	public void GetPcmData(ref Single[] data, int ch) { }

	public float GetRms(int channel) { }

	public void GetSpectrumLevels(ref Single[] levels) { }

	protected void InitializeWithConfig(Config config) { }

	public void SetPcmCaptureCallback(PcmCaptureCallback callback) { }

}

