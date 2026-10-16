namespace Unity.Services.Analytics.Internal;

internal class Dispatcher : IDispatcher, IDispatcherDebug
{
	private readonly IWebRequestHelper m_WebRequestHelper; //Field offset: 0x8
	private readonly string m_CollectUrl; //Field offset: 0xC
	private IBuffer m_DataBuffer; //Field offset: 0x10
	private IWebRequest m_FlushRequest; //Field offset: 0x14
	private Byte[] m_LastFlushPayload; //Field offset: 0x18
	private int m_FlushBufferIndex; //Field offset: 0x1C
	[CompilerGenerated]
	private int <ConsecutiveFailedUploadCount>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private bool <FlushInProgress>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	private Action<Byte[]> FlushStarted; //Field offset: 0x28
	[CompilerGenerated]
	private Action<Int32, Boolean, Boolean, Boolean, Boolean, Byte[]> FlushFinished; //Field offset: 0x2C

	public override event Action<Int32, Boolean, Boolean, Boolean, Boolean, Byte[]> FlushFinished
	{
		[CompilerGenerated]
		 add { } //Length: 125
		[CompilerGenerated]
		 remove { } //Length: 125
	}

	public override event Action<Byte[]> FlushStarted
	{
		[CompilerGenerated]
		 add { } //Length: 125
		[CompilerGenerated]
		 remove { } //Length: 125
	}

	public private override int ConsecutiveFailedUploadCount
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	public private override bool FlushInProgress
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	public Dispatcher(IWebRequestHelper webRequestHelper, string collectUrl) { }

	[CompilerGenerated]
	public override void add_FlushFinished(Action<Int32, Boolean, Boolean, Boolean, Boolean, Byte[]> value) { }

	[CompilerGenerated]
	public override void add_FlushStarted(Action<Byte[]> value) { }

	public override void Flush() { }

	private void FlushBufferToService() { }

	[CompilerGenerated]
	public override int get_ConsecutiveFailedUploadCount() { }

	[CompilerGenerated]
	public override bool get_FlushInProgress() { }

	[CompilerGenerated]
	public override void remove_FlushFinished(Action<Int32, Boolean, Boolean, Boolean, Boolean, Byte[]> value) { }

	[CompilerGenerated]
	public override void remove_FlushStarted(Action<Byte[]> value) { }

	[CompilerGenerated]
	private void set_ConsecutiveFailedUploadCount(int value) { }

	[CompilerGenerated]
	private void set_FlushInProgress(bool value) { }

	public override void SetBuffer(IBuffer buffer) { }

	private void UploadCompleted(long responseCode) { }

}

