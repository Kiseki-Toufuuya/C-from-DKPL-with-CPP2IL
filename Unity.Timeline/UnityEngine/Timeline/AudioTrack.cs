namespace UnityEngine.Timeline;

[ExcludeFromPreset]
[TrackBindingType(typeof(AudioSource))]
[TrackClipType(typeof(AudioPlayableAsset), False)]
public class AudioTrack : TrackAsset
{
	[CompilerGenerated]
	private sealed class <get_outputs>d__4 : IEnumerable<PlayableBinding>, IEnumerable, IEnumerator<PlayableBinding>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private PlayableBinding <>2__current; //Field offset: 0xC
		private int <>l__initialThreadId; //Field offset: 0x1C
		public AudioTrack <>4__this; //Field offset: 0x20

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
		public <get_outputs>d__4(int <>1__state) { }

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
	private AudioMixerProperties m_TrackProperties; //Field offset: 0x58

	public virtual IEnumerable<PlayableBinding> outputs
	{
		[IteratorStateMachine(typeof(<get_outputs>d__4))]
		 get { } //Length: 95
	}

	public AudioTrack() { }

	internal virtual Playable CompileClips(PlayableGraph graph, GameObject go, IList<TimelineClip> timelineClips, IntervalTree<RuntimeElement> tree) { }

	public TimelineClip CreateClip(AudioClip clip) { }

	[IteratorStateMachine(typeof(<get_outputs>d__4))]
	public virtual IEnumerable<PlayableBinding> get_outputs() { }

	private void OnValidate() { }

}

