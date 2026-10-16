//Type is in global namespace

public class Live2DScreenParam : MonoBehaviour
{
	[SerializeField]
	public Vector3 ScreenScale; //Field offset: 0x10
	[SerializeField]
	public Vector3 Live2DScaleBase; //Field offset: 0x1C
	[SerializeField]
	public Vector3 SpriteScaleBase; //Field offset: 0x28

	public Live2DScreenParam() { }

}

