namespace XeSys.Gfx;

public class MaskEx : Mask
{
	[SerializeField]
	private int m_MaskId; //Field offset: 0x24
	private Texture m_MaskTexture; //Field offset: 0x28
	private bool m_IsSplitTexture; //Field offset: 0x2C

	public MaskEx() { }

	public virtual Material GetModifiedMaterial(Material baseMaterial) { }

	private void Update() { }

}

