namespace UnityEngine.Playables;

public struct FrameData
{
	internal enum EvaluationType
	{
		Evaluate = 0,
		Playback = 1,
	}

	[Flags]
	public enum Flags
	{
		Evaluate = 1,
		SeekOccured = 2,
		Loop = 4,
		Hold = 8,
		EffectivePlayStateDelayed = 16,
		EffectivePlayStatePlaying = 32,
	}

	internal ulong m_FrameID; //Field offset: 0x0
	internal double m_DeltaTime; //Field offset: 0x8
	internal float m_Weight; //Field offset: 0x10
	internal float m_EffectiveWeight; //Field offset: 0x14
	internal double m_EffectiveParentDelay; //Field offset: 0x18
	internal float m_EffectiveParentSpeed; //Field offset: 0x20
	internal float m_EffectiveSpeed; //Field offset: 0x24
	internal Flags m_Flags; //Field offset: 0x28
	internal PlayableOutput m_Output; //Field offset: 0x2C

	public float deltaTime
	{
		 get { } //Length: 17
	}

	public PlayState effectivePlayState
	{
		 get { } //Length: 37
	}

	public float effectiveSpeed
	{
		 get { } //Length: 11
	}

	public EvaluationType evaluationType
	{
		 get { } //Length: 16
	}

	public PlayableOutput output
	{
		 get { } //Length: 14
	}

	public bool seekOccurred
	{
		 get { } //Length: 15
	}

	public bool timeHeld
	{
		 get { } //Length: 16
	}

	public bool timeLooped
	{
		 get { } //Length: 16
	}

	public float get_deltaTime() { }

	public PlayState get_effectivePlayState() { }

	public float get_effectiveSpeed() { }

	public EvaluationType get_evaluationType() { }

	public PlayableOutput get_output() { }

	public bool get_seekOccurred() { }

	public bool get_timeHeld() { }

	public bool get_timeLooped() { }

	private bool HasFlags(Flags flag) { }

}

