namespace CriWare.CriTimeline.Atom;

public class CriAtomClip : CriAtomClipBase
{
	public string cueSheet; //Field offset: 0x20
	public string cueName; //Field offset: 0x24
	public CriAtomBehaviour templateBehaviour; //Field offset: 0x28

	public virtual string AcbPath
	{
		 get { } //Length: 135
	}

	public virtual string AwbPath
	{
		 get { } //Length: 135
	}

	public virtual string CueName
	{
		 get { } //Length: 11
	}

	public CriAtomClip() { }

	public virtual Playable CreatePlayable(PlayableGraph graph, GameObject owner) { }

	public virtual string get_AcbPath() { }

	public virtual string get_AwbPath() { }

	public virtual string get_CueName() { }

	public virtual CriAtomExAcb GetAcb() { }

	private CriAtomCueSheet GetCueSheet() { }

	public virtual void SetCueFromAtomSource(CriAtomSourceBase atomSource) { }

}

