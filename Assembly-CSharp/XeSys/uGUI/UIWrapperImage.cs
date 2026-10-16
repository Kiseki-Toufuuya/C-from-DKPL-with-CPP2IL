namespace XeSys.uGUI;

public class UIWrapperImage : UIWrapperBase
{
	protected IAlphaTexture m_ITexture; //Field offset: 0x14
	protected IChgImageSlice m_ChgTexComponet; //Field offset: 0x18
	protected AtlasImage m_AtlasImage; //Field offset: 0x1C

	public UIWrapperImage() { }

	public void ChgSlice(int idx) { }

	public static UIWrapperImage CreateImage(GameObject root, string imageName) { }

	public ImageEx GetImageEx() { }

	public IAlphaTexture GetITexture() { }

	public void InitImage(GameObject root, string imageName) { }

	public void SetSpriteName(string spriteName) { }

	public void SetTexture(Texture tex) { }

	public void SetUVRect(TexUVData uvData) { }

}

