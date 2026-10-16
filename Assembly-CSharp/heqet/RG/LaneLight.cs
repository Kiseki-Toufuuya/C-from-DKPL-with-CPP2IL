namespace Heqet.RG;

public class LaneLight : MonoBehaviour
{
	[SerializeField]
	private Lane lane; //Field offset: 0x10
	[SerializeField]
	private float alphaMax; //Field offset: 0x14
	[SerializeField]
	private float speed; //Field offset: 0x18
	private SpriteRenderer renderer; //Field offset: 0x1C
	private float alpha; //Field offset: 0x20
	private Color defaultColor; //Field offset: 0x24

	public LaneLight() { }

	private void Awake() { }

	private void ColorChange() { }

	private Color ColorCheck() { }

	public void DoLateUpdate() { }

	private void LateUpdate() { }

	private void Start() { }

}

