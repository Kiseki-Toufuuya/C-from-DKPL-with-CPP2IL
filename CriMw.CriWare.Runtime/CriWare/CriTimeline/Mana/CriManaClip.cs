namespace CriWare.CriTimeline.Mana;

public class CriManaClip : CriManaClipBase
{
	public string m_moviePath; //Field offset: 0x78
	public TextAsset m_movieData; //Field offset: 0x7C
	public CriManaBehaviour m_manaBehaviour; //Field offset: 0x80

	public virtual int DataId
	{
		 get { } //Length: 169
	}

	public virtual Byte[] MovieData
	{
		 get { } //Length: 113
	}

	public virtual string MovieName
	{
		 get { } //Length: 155
	}

	public virtual string MoviePath
	{
		 get { } //Length: 11
	}

	public CriManaClip() { }

	public virtual Playable CreatePlayable(PlayableGraph graph, GameObject owner) { }

	public virtual int get_DataId() { }

	public virtual Byte[] get_MovieData() { }

	public virtual string get_MovieName() { }

	public virtual string get_MoviePath() { }

}

