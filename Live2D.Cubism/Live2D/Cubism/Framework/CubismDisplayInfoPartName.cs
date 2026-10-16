namespace Live2D.Cubism.Framework;

public class CubismDisplayInfoPartName : MonoBehaviour
{
	[HideInInspector]
	[SerializeField]
	public string Name; //Field offset: 0x10
	[SerializeField]
	public string DisplayName; //Field offset: 0x14

	public CubismDisplayInfoPartName() { }

}

