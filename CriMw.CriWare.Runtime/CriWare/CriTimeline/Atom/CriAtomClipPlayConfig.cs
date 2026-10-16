namespace CriWare.CriTimeline.Atom;

public struct CriAtomClipPlayConfig
{
	public readonly CriAtomClipBase clip; //Field offset: 0x0
	public readonly long startTimeMs; //Field offset: 0x8
	public readonly double speedRate; //Field offset: 0x10
	public readonly bool loop; //Field offset: 0x18

	public CriAtomClipPlayConfig(CriAtomClipBase clip, long startTimeMs, double speedRate, bool loop) { }

}

