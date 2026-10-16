namespace UnityEngine.Timeline;

internal class ScheduleRuntimeClip : RuntimeClipBase
{
	private TimelineClip m_Clip; //Field offset: 0xC
	private Playable m_Playable; //Field offset: 0x10
	private Playable m_ParentMixer; //Field offset: 0x18
	private double m_StartDelay; //Field offset: 0x20
	private double m_FinishTail; //Field offset: 0x28
	private bool m_Started; //Field offset: 0x30

	public TimelineClip clip
	{
		 get { } //Length: 11
	}

	public virtual double duration
	{
		 get { } //Length: 84
	}

	public virtual bool enable
	{
		 set { } //Length: 222
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
		 get { } //Length: 135
	}

	public ScheduleRuntimeClip(TimelineClip clip, Playable clipPlayable, Playable parentMixer, double startDelay = 0.2, double finishTail = 0.1) { }

	private void Create(TimelineClip clip, Playable clipPlayable, Playable parentMixer, double startDelay, double finishTail) { }

	public virtual void DisableAt(double localTime, double rootDuration, FrameData frameData) { }

	public virtual void EvaluateAt(double localTime, FrameData frameData) { }

	public TimelineClip get_clip() { }

	public virtual double get_duration() { }

	public Playable get_mixer() { }

	public Playable get_playable() { }

	public virtual double get_start() { }

	public virtual void set_enable(bool value) { }

	public void SetTime(double time) { }

}

