namespace UnityEngine.Timeline;

internal class RuntimeClip : RuntimeClipBase
{
	private TimelineClip m_Clip; //Field offset: 0xC
	private Playable m_Playable; //Field offset: 0x10
	private Playable m_ParentMixer; //Field offset: 0x18

	public TimelineClip clip
	{
		 get { } //Length: 11
	}

	public virtual double duration
	{
		 get { } //Length: 34
	}

	public virtual bool enable
	{
		 set { } //Length: 337
	}

	public Playable mixer
	{
		 get { } //Length: 14
	}

	public Playable playable
	{
		 get { } //Length: 14
	}

	public virtual double start
	{
		 get { } //Length: 55
	}

	public RuntimeClip(TimelineClip clip, Playable clipPlayable, Playable parentMixer) { }

	private void Create(TimelineClip clip, Playable clipPlayable, Playable parentMixer) { }

	public virtual void DisableAt(double localTime, double rootDuration, FrameData frameData) { }

	public virtual void EvaluateAt(double localTime, FrameData frameData) { }

	public TimelineClip get_clip() { }

	public virtual double get_duration() { }

	public Playable get_mixer() { }

	public Playable get_playable() { }

	public virtual double get_start() { }

	public virtual void set_enable(bool value) { }

	public void SetDuration(double duration) { }

	public void SetTime(double time) { }

}

