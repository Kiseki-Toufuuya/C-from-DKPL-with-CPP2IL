namespace Mono;

internal struct MonoAssemblyName
{
	[CompilerGenerated]
	[UnsafeValueType]
	internal struct <public_key_token>e__FixedBuffer
	{
		public byte FixedElementField; //Field offset: 0x0

	}

	internal IntPtr name; //Field offset: 0x0
	internal IntPtr culture; //Field offset: 0x4
	internal IntPtr hash_value; //Field offset: 0x8
	internal IntPtr public_key; //Field offset: 0xC
	[FixedBuffer(typeof(byte), 17)]
	internal <public_key_token>e__FixedBuffer public_key_token; //Field offset: 0x10
	internal uint hash_alg; //Field offset: 0x24
	internal uint hash_len; //Field offset: 0x28
	internal uint flags; //Field offset: 0x2C
	internal ushort major; //Field offset: 0x30
	internal ushort minor; //Field offset: 0x32
	internal ushort build; //Field offset: 0x34
	internal ushort revision; //Field offset: 0x36
	internal ushort arch; //Field offset: 0x38

}

