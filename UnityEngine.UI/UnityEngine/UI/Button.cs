namespace UnityEngine.UI;

[AddComponentMenu("UI/Button", 30)]
public class Button : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler
{
	[CompilerGenerated]
	private sealed class <OnFinishSubmit>d__9 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public Button <>4__this; //Field offset: 0x10
		private float <fadeTime>5__2; //Field offset: 0x14
		private float <elapsedTime>5__3; //Field offset: 0x18

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
		public <OnFinishSubmit>d__9(int <>1__state) { }

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

	internal class ButtonClickedEvent : UnityEvent
	{

		public ButtonClickedEvent() { }

	}

	[FormerlySerializedAs("onClick")]
	[SerializeField]
	private ButtonClickedEvent m_OnClick; //Field offset: 0xB4

	public ButtonClickedEvent onClick
	{
		 get { } //Length: 14
		 set { } //Length: 33
	}

	protected Button() { }

	public ButtonClickedEvent get_onClick() { }

	[IteratorStateMachine(typeof(<OnFinishSubmit>d__9))]
	private IEnumerator OnFinishSubmit() { }

	public override void OnPointerClick(PointerEventData eventData) { }

	public override void OnSubmit(BaseEventData eventData) { }

	private void Press() { }

	public void set_onClick(ButtonClickedEvent value) { }

}

