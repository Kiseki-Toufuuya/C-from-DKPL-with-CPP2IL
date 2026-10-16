namespace XeApp.Game;

public class uGuiBaseObject
{
	[CompilerGenerated]
	private sealed class <Co_DelayAction>d__19 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public float time; //Field offset: 0x10
		public UnityAction action; //Field offset: 0x14

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
		public <Co_DelayAction>d__19(int <>1__state) { }

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

	protected GameObject UIObject; //Field offset: 0x8
	protected bool InitFlg; //Field offset: 0xC

	public GameObject Object
	{
		 get { } //Length: 11
	}

	public uGuiBaseObject() { }

	public override bool ChkInitLayout() { }

	[IteratorStateMachine(typeof(<Co_DelayAction>d__19))]
	private static IEnumerator Co_DelayAction(UnityAction action, float time) { }

	public static uGuiBaseObject Create(string path, eCanvas canvasType) { }

	public override void CreateUi(string path, Transform parentTransform) { }

	public override void CreateUi(string path, eCanvas canvasType) { }

	public static void DelayAction(UnityAction action, float time) { }

	public GameObject FindObj(string name) { }

	public GameObject FindObj(Transform parent, string name, string parentName = null) { }

	public GameObject get_Object() { }

	public override bool IsActive() { }

	public override bool IsPlayingAnime() { }

	public override void LateUpDate() { }

	public override void Release() { }

	public override void SetActive(bool isActive) { }

	public override void SetButtonCallbackOnClick() { }

	public void SetCanvas(eCanvas canvasType) { }

	public override void UpDate() { }

}

