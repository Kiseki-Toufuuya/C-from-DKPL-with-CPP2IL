namespace System.Runtime.Serialization;

internal class FixupHolder
{
	internal long m_id; //Field offset: 0x8
	internal object m_fixupInfo; //Field offset: 0x10
	internal int m_fixupType; //Field offset: 0x14

	internal FixupHolder(long id, object fixupInfo, int fixupType) { }

}

