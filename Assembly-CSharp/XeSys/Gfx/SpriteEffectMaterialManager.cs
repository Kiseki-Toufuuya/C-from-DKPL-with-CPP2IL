namespace XeSys.Gfx;

public class SpriteEffectMaterialManager : Singleton<SpriteEffectMaterialManager>, IDisposable
{
	private Material[] m_BaseMaterials; //Field offset: 0x8
	private Dictionary<TexUVList, SpriteEffectMaterial> m_MaterialsDic; //Field offset: 0xC
	private TexUVListManager m_UVListManager; //Field offset: 0x10

	public TexUVListManager UVListManager
	{
		 get { } //Length: 11
	}

	public SpriteEffectMaterialManager() { }

	public void AddUvList(TexUVList uvlist) { }

	public void Clear() { }

	public override void Dispose() { }

	public TexUVListManager get_UVListManager() { }

	public Material GetMaterial(TexUVList uvList, EBlendType blendType) { }

	public void SetBaseMaterial(Material material, EBlendType blendType) { }

	public void SetMaterial(TexUVList uvList, EBlendType blendType, Material material) { }

}

