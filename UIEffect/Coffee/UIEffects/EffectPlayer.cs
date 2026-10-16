namespace Coffee.UIEffects;

public class EffectPlayer
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static WillRenderCanvases <>9__7_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal void <OnEnable>b__7_0() { }

	}

	private static List<Action> s_UpdateActions; //Field offset: 0x0
	[Header("Effect Player")]
	[Tooltip("Playing.")]
	public bool play; //Field offset: 0x8
	[Range(0, 10)]
	[Tooltip("Initial play delay.")]
	public float initialPlayDelay; //Field offset: 0xC
	[Range(0.01, 10)]
	[Tooltip("Duration.")]
	public float duration; //Field offset: 0x10
	[Tooltip("Loop.")]
	public bool loop; //Field offset: 0x14
	[Range(0, 10)]
	[Tooltip("Delay before looping.")]
	public float loopDelay; //Field offset: 0x18
	[Tooltip("Update mode")]
	public AnimatorUpdateMode updateMode; //Field offset: 0x1C
	private float _time; //Field offset: 0x20
	private Action<Single> _callback; //Field offset: 0x24

	public EffectPlayer() { }

	public void OnDisable() { }

	public void OnEnable(Action<Single> callback = null) { }

	private void OnWillRenderCanvases() { }

	public void Play(bool reset, Action<Single> callback = null) { }

	public void Stop(bool reset) { }

}

