namespace XeSys.Gfx;

public class SpriteEffectMaterialVal
{
	internal bool m_IsTexUvSet; //Field offset: 0x8
	internal TexUVList m_TexUvList; //Field offset: 0xC
	internal EBlendType m_BlendType; //Field offset: 0x10

	public EBlendType BlendType
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public bool IsTexUvSet
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public TexUVList TexUvList
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public SpriteEffectMaterialVal() { }

	public EBlendType get_BlendType() { }

	public bool get_IsTexUvSet() { }

	public TexUVList get_TexUvList() { }

	public void set_BlendType(EBlendType value) { }

	public void set_IsTexUvSet(bool value) { }

	public void set_TexUvList(TexUVList value) { }

}

