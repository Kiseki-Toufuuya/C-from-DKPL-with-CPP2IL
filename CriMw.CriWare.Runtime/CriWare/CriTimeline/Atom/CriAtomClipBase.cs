namespace CriWare.CriTimeline.Atom;

public abstract class CriAtomClipBase : PlayableAsset, ITimelineClipAsset
{
	public bool stopWithoutRelease; //Field offset: 0xC
	public bool muted; //Field offset: 0xD
	public bool ignoreBlend; //Field offset: 0xE
	public bool loopWithinClip; //Field offset: 0xF
	public bool stopAtClipEnd; //Field offset: 0x10
	[HideInInspector]
	[SerializeField]
	private double clipDuration; //Field offset: 0x18

	public abstract string AcbPath
	{
		 get { } //Length: 0
	}

	public abstract string AwbPath
	{
		 get { } //Length: 0
	}

	public override ClipCaps clipCaps
	{
		 get { } //Length: 6
	}

	public abstract string CueName
	{
		 get { } //Length: 0
	}

	public virtual double duration
	{
		 get { } //Length: 34
	}

	protected CriAtomClipBase() { }

	public abstract string get_AcbPath() { }

	public abstract string get_AwbPath() { }

	public override ClipCaps get_clipCaps() { }

	public abstract string get_CueName() { }

	public virtual double get_duration() { }

	public abstract CriAtomExAcb GetAcb() { }

	public void SetClipDuration(double clipDuration) { }

	public abstract void SetCueFromAtomSource(CriAtomSourceBase atomSource) { }

}

