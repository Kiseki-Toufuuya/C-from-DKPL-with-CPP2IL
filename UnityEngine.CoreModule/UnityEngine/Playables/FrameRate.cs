namespace UnityEngine.Playables;

[NativeHeader("Runtime/Director/Core/FrameRate.h")]
[UsedByNativeCode("FrameRate")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.DirectorModule"})]
internal struct FrameRate : IEquatable<FrameRate>
{
	[Ignore]
	public static readonly FrameRate k_24Fps; //Field offset: 0x0
	[Ignore]
	public static readonly FrameRate k_23_976Fps; //Field offset: 0x4
	[Ignore]
	public static readonly FrameRate k_25Fps; //Field offset: 0x8
	[Ignore]
	public static readonly FrameRate k_30Fps; //Field offset: 0xC
	[Ignore]
	public static readonly FrameRate k_29_97Fps; //Field offset: 0x10
	[Ignore]
	public static readonly FrameRate k_50Fps; //Field offset: 0x14
	[Ignore]
	public static readonly FrameRate k_60Fps; //Field offset: 0x18
	[Ignore]
	public static readonly FrameRate k_59_94Fps; //Field offset: 0x1C
	[SerializeField]
	private int m_Rate; //Field offset: 0x0

	public bool dropFrame
	{
		 get { } //Length: 13
	}

	public double rate
	{
		 get { } //Length: 114
	}

	private static FrameRate() { }

	public FrameRate(uint frameRate = 0, bool drop = false) { }

	internal static FrameRate DoubleToFrameRate(double framerate) { }

	public override bool Equals(FrameRate other) { }

	public virtual bool Equals(object obj) { }

	public bool get_dropFrame() { }

	public double get_rate() { }

	public virtual int GetHashCode() { }

	public bool IsValid() { }

	public static bool op_Equality(FrameRate a, FrameRate b) { }

	public virtual string ToString() { }

	public string ToString(string format, IFormatProvider formatProvider) { }

}

