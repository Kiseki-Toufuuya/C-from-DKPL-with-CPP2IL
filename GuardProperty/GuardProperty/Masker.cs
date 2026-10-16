namespace GuardProperty;

public struct Masker
{
	private static readonly Random _rnd; //Field offset: 0x0
	private static Int32[] PrimeTable; //Field offset: 0x4
	public float SingleValue; //Field offset: 0x0
	public double DoubleValue; //Field offset: 0x0
	public ushort UShortValue; //Field offset: 0x0
	public char CharValue; //Field offset: 0x0
	public short ShortValue; //Field offset: 0x0
	public uint UIntValue; //Field offset: 0x0
	public int IntValue; //Field offset: 0x0
	public ulong ULongValue; //Field offset: 0x0
	public long LongValue; //Field offset: 0x0
	public byte Byte0; //Field offset: 0x0
	public byte Byte1; //Field offset: 0x1
	public byte Byte2; //Field offset: 0x2
	public byte Byte3; //Field offset: 0x3
	public byte Byte4; //Field offset: 0x4
	public byte Byte5; //Field offset: 0x5
	public byte Byte6; //Field offset: 0x6
	public byte Byte7; //Field offset: 0x7

	private static Masker() { }

	public static Masker Create(long value) { }

	public static Masker Create(int value) { }

	public static Masker Create(float value) { }

	public static bool GetMaskBool() { }

	public static byte GetMaskByte() { }

	public static int GetMaskInt() { }

	public static long GetMaskLong() { }

	public static uint GetMaskUnsignedInt() { }

	public static int GetPrimeInt() { }

	public static long Mask(long mask, long maskedValue) { }

	public static int Mask(int mask, int maskedValue) { }

	public Masker Masked32(ref Masker val) { }

	public Masker Masked64(ref Masker val) { }

	public static int MaskSingle(int mask, float targetValue) { }

	public static float UnmaskSingle(int mask, int maskedValue) { }

}

