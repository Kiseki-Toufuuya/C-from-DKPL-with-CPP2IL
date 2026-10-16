namespace Live2D.Cubism.Framework.Pose;

public sealed class CubismPosePart : MonoBehaviour
{
	[SerializeField]
	public int GroupIndex; //Field offset: 0x10
	[SerializeField]
	public int PartIndex; //Field offset: 0x14
	[SerializeField]
	public String[] Link; //Field offset: 0x18

	public CubismPosePart() { }

}

