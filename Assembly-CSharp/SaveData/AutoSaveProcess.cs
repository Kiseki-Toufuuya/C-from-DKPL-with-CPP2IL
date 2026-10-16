namespace SaveData;

public class AutoSaveProcess
{
	[CompilerGenerated]
	private sealed class <StartAutoSaveLoadProcess>d__3 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public int userId; //Field offset: 0x10
		public DirName dirName; //Field offset: 0x14
		public FileOperationRequest fileRequest; //Field offset: 0x18
		public FileOperationResponse fileResponse; //Field offset: 0x1C
		public ErrorHandler errHandler; //Field offset: 0x20
		private SaveState <currentState>5__2; //Field offset: 0x24
		private MountResponse <mountResponse>5__3; //Field offset: 0x28
		private MountPoint <mp>5__4; //Field offset: 0x2C
		private int <errorCode>5__5; //Field offset: 0x30
		private EmptyResponse <unmountResponse>5__6; //Field offset: 0x34

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 11
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 11
		}

		[DebuggerHidden]
		public <StartAutoSaveLoadProcess>d__3(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <StartAutoSaveProcess>d__2 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public DirName autoSaveDirName; //Field offset: 0x10
		public int userId; //Field offset: 0x14
		public ulong newSaveDataBlocks; //Field offset: 0x18
		public FileOperationRequest fileRequest; //Field offset: 0x20
		public FileOperationResponse fileResponse; //Field offset: 0x24
		public NewItem newItem; //Field offset: 0x28
		public SaveDataParams saveDataParams; //Field offset: 0x30
		public bool backup; //Field offset: 0x50
		public ErrorHandler errHandler; //Field offset: 0x54
		private SaveState <currentState>5__2; //Field offset: 0x58
		private MountResponse <mountResponse>5__3; //Field offset: 0x5C
		private MountPoint <mp>5__4; //Field offset: 0x60
		private int <errorCode>5__5; //Field offset: 0x64
		private EmptyResponse <iconResponse>5__6; //Field offset: 0x68
		private EmptyResponse <paramsResponse>5__7; //Field offset: 0x6C

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 11
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 11
		}

		[DebuggerHidden]
		public <StartAutoSaveProcess>d__2(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	internal sealed class ErrorHandler : MulticastDelegate
	{

		public ErrorHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(uint errorCode, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(uint errorCode) { }

	}

	private enum SaveState
	{
		Begin = 0,
		SaveFiles = 1,
		WriteIcon = 2,
		WriteParams = 3,
		Unmount = 4,
		HandleError = 5,
		LoadFiles = 6,
		Exit = 7,
	}


	public AutoSaveProcess() { }

	internal static int MountSaveData(int userId, ulong blocks, MountResponse mountResponse, DirName dirName, MountModeFlags flags) { }

	[IteratorStateMachine(typeof(<StartAutoSaveLoadProcess>d__3))]
	public static IEnumerator StartAutoSaveLoadProcess(int userId, DirName dirName, FileOperationRequest fileRequest, FileOperationResponse fileResponse, ErrorHandler errHandler) { }

	[IteratorStateMachine(typeof(<StartAutoSaveProcess>d__2))]
	public static IEnumerator StartAutoSaveProcess(int userId, NewItem newItem, DirName autoSaveDirName, ulong newSaveDataBlocks, SaveDataParams saveDataParams, FileOperationRequest fileRequest, FileOperationResponse fileResponse, bool backup, ErrorHandler errHandler) { }

	internal static int UnmountSaveData(int userId, EmptyResponse unmountResponse, MountPoint mp, bool backup) { }

	internal static int WriteIcon(int userId, EmptyResponse iconResponse, MountPoint mp, NewItem newItem) { }

	internal static int WriteParams(int userId, EmptyResponse paramsResponse, MountPoint mp, SaveDataParams saveDataParams) { }

}

