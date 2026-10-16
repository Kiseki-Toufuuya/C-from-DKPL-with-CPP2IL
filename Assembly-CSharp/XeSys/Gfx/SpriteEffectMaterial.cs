namespace XeSys.Gfx;

public class SpriteEffectMaterial : IDisposable
{
	private TexUVList m_TexUvList; //Field offset: 0x8
	private Material[] m_Materials; //Field offset: 0xC

	public SpriteEffectMaterial() { }

	public override void Dispose() { }

	public Material GetMaterial(EBlendType blendType) { }

	public void SetMaterial(EBlendType type, Material material) { }

	public void SetTexUvList(TexUVList texuvList) { }

}

