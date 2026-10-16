namespace System.Xml;

internal abstract class Base64Encoder
{
	[CompilerGenerated]
	private struct <EncodeAsync>d__10 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public Byte[] buffer; //Field offset: 0x10
		public int index; //Field offset: 0x14
		public int count; //Field offset: 0x18
		public Base64Encoder <>4__this; //Field offset: 0x1C
		private int <endIndex>5__2; //Field offset: 0x20
		private int <chunkSize>5__3; //Field offset: 0x24
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <FlushAsync>d__11 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public Base64Encoder <>4__this; //Field offset: 0x10
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x14

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private Byte[] leftOverBytes; //Field offset: 0x8
	private int leftOverBytesCount; //Field offset: 0xC
	private Char[] charsLine; //Field offset: 0x10

	internal Base64Encoder() { }

	internal void Encode(Byte[] buffer, int index, int count) { }

	[AsyncStateMachine(typeof(<EncodeAsync>d__10))]
	internal Task EncodeAsync(Byte[] buffer, int index, int count) { }

	internal void Flush() { }

	[AsyncStateMachine(typeof(<FlushAsync>d__11))]
	internal Task FlushAsync() { }

	internal abstract void WriteChars(Char[] chars, int index, int count) { }

	internal abstract Task WriteCharsAsync(Char[] chars, int index, int count) { }

}

