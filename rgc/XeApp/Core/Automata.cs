namespace XeApp.Core;

public class Automata
{
	[CompilerGenerated]
	private sealed class <WaitForArrivedScene>d__5 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public string sceneName; //Field offset: 0x10

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
		public <WaitForArrivedScene>d__5(int <>1__state) { }

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

	internal sealed class OnEventFromAutomata : MulticastDelegate
	{

		public OnEventFromAutomata(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string eventName, object obj, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(string eventName, object obj) { }

	}

	public static OnEventFromAutomata onEventFromAutomata; //Field offset: 0x0
	public static bool IsTestRunner; //Field offset: 0x4
	public static string SceneName; //Field offset: 0x8

	private static Automata() { }

	public Automata() { }

	public static void SetData(string name, object obj) { }

	public static void Start() { }

	[IteratorStateMachine(typeof(<WaitForArrivedScene>d__5))]
	public static IEnumerator WaitForArrivedScene(string sceneName) { }

}

