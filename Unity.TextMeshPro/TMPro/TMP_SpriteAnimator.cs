namespace TMPro;

[DisallowMultipleComponent]
public class TMP_SpriteAnimator : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <DoSpriteAnimationInternal>d__7 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public TMP_SpriteAnimator <>4__this; //Field offset: 0x10
		public int start; //Field offset: 0x14
		public int end; //Field offset: 0x18
		public TMP_SpriteAsset spriteAsset; //Field offset: 0x1C
		public int currentCharacter; //Field offset: 0x20
		public int framerate; //Field offset: 0x24
		private int <currentFrame>5__2; //Field offset: 0x28
		private TMP_CharacterInfo <charInfo>5__3; //Field offset: 0x2C
		private int <materialIndex>5__4; //Field offset: 0x190
		private int <vertexIndex>5__5; //Field offset: 0x194
		private TMP_MeshInfo <meshInfo>5__6; //Field offset: 0x198
		private float <baseSpriteScale>5__7; //Field offset: 0x1C0
		private float <elapsedTime>5__8; //Field offset: 0x1C4
		private float <targetTime>5__9; //Field offset: 0x1C8

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
		public <DoSpriteAnimationInternal>d__7(int <>1__state) { }

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

	private Dictionary<Int32, Boolean> m_animations; //Field offset: 0x10
	private TMP_Text m_TextComponent; //Field offset: 0x14

	public TMP_SpriteAnimator() { }

	private void Awake() { }

	public void DoSpriteAnimation(int currentCharacter, TMP_SpriteAsset spriteAsset, int start, int end, int framerate) { }

	[IteratorStateMachine(typeof(<DoSpriteAnimationInternal>d__7))]
	private IEnumerator DoSpriteAnimationInternal(int currentCharacter, TMP_SpriteAsset spriteAsset, int start, int end, int framerate) { }

	private void OnDisable() { }

	private void OnEnable() { }

	public void StopAllAnimations() { }

}

