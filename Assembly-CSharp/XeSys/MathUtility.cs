namespace XeSys;

public class MathUtility
{
	private const int SinCosTblLength = 512; //Field offset: 0x0
	private const int SinCosTblModBit = 511; //Field offset: 0x0
	private static readonly Single[] m_SinTbl; //Field offset: 0x0
	private const float SinCosTblRate = 0.012271847; //Field offset: 0x0
	private const float SinCosTblRateInv = 81.48733; //Field offset: 0x0
	private static readonly Single[] m_CosTbl; //Field offset: 0x4

	private static MathUtility() { }

	public MathUtility() { }

	public static float GetCos(float rad) { }

	public static float GetSin(float rad) { }

	public static void GetSinCos(float rad, out float sin, out float cos) { }

	public static void InitializeClass() { }

}

