namespace UnityEngine.Timeline;

public class AudioPlayableAsset : PlayableAsset, ITimelineClipAsset
{
	[CompilerGenerated]
	private sealed class <get_outputs>d__16 : IEnumerable<PlayableBinding>, IEnumerable, IEnumerator<PlayableBinding>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private PlayableBinding <>2__current; //Field offset: 0xC
		private int <>l__initialThreadId; //Field offset: 0x1C
		public AudioPlayableAsset <>4__this; //Field offset: 0x20

		private override PlayableBinding System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 18
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 68
		}

		[DebuggerHidden]
		public <get_outputs>d__16(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<PlayableBinding> System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding>.GetEnumerator() { }

		[DebuggerHidden]
		private override PlayableBinding System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[SerializeField]
	private AudioClip m_Clip; //Field offset: 0xC
	[SerializeField]
	private bool m_Loop; //Field offset: 0x10
	[HideInInspector]
	[SerializeField]
	private float m_bufferingTime; //Field offset: 0x14
	[SerializeField]
	private AudioClipProperties m_ClipProperties; //Field offset: 0x18

	internal float bufferingTime
	{
		internal get { } //Length: 11
		internal set { } //Length: 18
	}

	public AudioClip clip
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public override ClipCaps clipCaps
	{
		 get { } //Length: 19
	}

	public virtual double duration
	{
		 get { } //Length: 174
	}

	public bool loop
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public virtual IEnumerable<PlayableBinding> outputs
	{
		[IteratorStateMachine(typeof(<get_outputs>d__16))]
		 get { } //Length: 95
	}

	public AudioPlayableAsset() { }

	public virtual Playable CreatePlayable(PlayableGraph graph, GameObject go) { }

	internal float get_bufferingTime() { }

	public AudioClip get_clip() { }

	public override ClipCaps get_clipCaps() { }

	public virtual double get_duration() { }

	public bool get_loop() { }

	[IteratorStateMachine(typeof(<get_outputs>d__16))]
	public virtual IEnumerable<PlayableBinding> get_outputs() { }

	internal void set_bufferingTime(float value) { }

	public void set_clip(AudioClip value) { }

	public void set_loop(bool value) { }

}

