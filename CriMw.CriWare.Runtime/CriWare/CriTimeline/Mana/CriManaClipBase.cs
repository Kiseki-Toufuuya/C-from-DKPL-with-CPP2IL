namespace CriWare.CriTimeline.Mana;

public abstract class CriManaClipBase : PlayableAsset, ITimelineClipAsset
{
	private struct MovieInfoStruct
	{
		public uint width; //Field offset: 0x0
		public uint height; //Field offset: 0x4
		public uint dispWidth; //Field offset: 0x8
		public uint dispHeight; //Field offset: 0xC
		public uint framerateN; //Field offset: 0x10
		public uint framerateD; //Field offset: 0x14
		public uint totalFrames; //Field offset: 0x18
		public CodecType _codecType; //Field offset: 0x1C
		public CodecType _alphaCodecType; //Field offset: 0x20

	}

	public readonly Guid guid; //Field offset: 0xC
	public bool m_loopWithinClip; //Field offset: 0x1C
	public bool m_useOnMemoryPlayback; //Field offset: 0x1D
	public GCHandle gcHandle; //Field offset: 0x20
	[SerializeField]
	private double m_movieFrameRate; //Field offset: 0x28
	[SerializeField]
	private double m_clipDuration; //Field offset: 0x30
	public float m_fadeinDuration; //Field offset: 0x38
	public AnimationCurve m_fadeinCurve; //Field offset: 0x3C
	public float m_fadeoutDuration; //Field offset: 0x40
	public AnimationCurve m_fadeoutCurve; //Field offset: 0x44
	public bool m_fadeAudio; //Field offset: 0x48
	public TimelineClip m_clip; //Field offset: 0x4C
	private Nullable<MovieInfoStruct> m_movieInfoStruct; //Field offset: 0x50

	public override ClipCaps clipCaps
	{
		 get { } //Length: 6
	}

	public abstract int DataId
	{
		 get { } //Length: 0
	}

	public virtual double duration
	{
		 get { } //Length: 34
	}

	public bool IsMovieInfoReady
	{
		 get { } //Length: 40
	}

	public abstract Byte[] MovieData
	{
		 get { } //Length: 0
	}

	public abstract string MovieName
	{
		 get { } //Length: 0
	}

	public abstract string MoviePath
	{
		 get { } //Length: 0
	}

	protected CriManaClipBase() { }

	public override ClipCaps get_clipCaps() { }

	public abstract int get_DataId() { }

	public virtual double get_duration() { }

	public bool get_IsMovieInfoReady() { }

	public abstract Byte[] get_MovieData() { }

	public abstract string get_MovieName() { }

	public abstract string get_MoviePath() { }

	public int GetSeekFrame(double seekTimeSec, bool loop) { }

	public bool IsSameMovie(MovieInfo movieInfo) { }

	public void ReplaceMovieInfo(MovieInfo movieInfo) { }

	private Nullable<MovieInfoStruct> StructToMovieInfo(MovieInfo movieInfo) { }

}

