namespace CriWare;

public static class CriAtomExAcbDebug
{
	internal struct AcbInfo
	{
		public string name; //Field offset: 0x0
		public uint size; //Field offset: 0x4
		public uint version; //Field offset: 0x8
		public CharacterEncoding characterEncoding; //Field offset: 0xC
		public float volume; //Field offset: 0x10
		public int numCues; //Field offset: 0x14

	}

	private struct AcbInfoForMarshaling
	{
		public IntPtr namePtr; //Field offset: 0x0
		public uint size; //Field offset: 0x4
		public uint version; //Field offset: 0x8
		public string userData; //Field offset: 0xC
		public string language; //Field offset: 0x10
		public CharacterEncoding characterEncoding; //Field offset: 0x14
		public float volume; //Field offset: 0x18
		public int numCues; //Field offset: 0x1C

		public void Convert(out AcbInfo x) { }

	}


	private static int criAtomExAcb_GetAcbInfo(IntPtr acbHn, out AcbInfoForMarshaling acbInfo) { }

	public static bool GetAcbInfo(CriAtomExAcb acb, out AcbInfo acbInfo) { }

}

