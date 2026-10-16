namespace XeSys.Gfx;

public class AlphaMasked : UIBehaviour, IMaterialModifier
{
	[SerializeField]
	private int m_MaskId; //Field offset: 0x10

	public AlphaMasked() { }

	public override Material GetModifiedMaterial(Material baseMaterial) { }

}

