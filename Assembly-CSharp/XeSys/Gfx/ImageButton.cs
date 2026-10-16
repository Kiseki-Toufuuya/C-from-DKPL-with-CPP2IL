namespace XeSys.Gfx;

public class ImageButton : ImageView
{
	internal enum State
	{
		touch = 0,
		untouch = 1,
	}

	public static string PushTexStr; //Field offset: 0x0
	private State m_State; //Field offset: 0x78
	private TexUVList m_PushTex; //Field offset: 0x7C
	private TexUVData m_PushUVData; //Field offset: 0x80

	public TexUVList PushTex
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public TexUVData PushUVData
	{
		 get { } //Length: 14
		 set { } //Length: 33
	}

	public State sta
	{
		 get { } //Length: 11
	}

	private static ImageButton() { }

	public ImageButton() { }

	public virtual void Clear() { }

	public virtual void CopyTo(ViewBase view) { }

	public virtual ViewBase DeepClone() { }

	public TexUVList get_PushTex() { }

	public TexUVData get_PushUVData() { }

	public State get_sta() { }

	public virtual void Serialize(List<SerializableView> list, int parent) { }

	public void set_PushTex(TexUVList value) { }

	public void set_PushUVData(TexUVData value) { }

	public void SetPushTexture(TexUVList tex, TexUVData uvdata) { }

	public void SetState(State state) { }

}

