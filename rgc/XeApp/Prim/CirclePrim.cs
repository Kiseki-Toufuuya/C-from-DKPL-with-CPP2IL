namespace XeApp.Prim;

[RequireComponent(typeof(LineRenderer))]
public class CirclePrim : MonoBehaviour
{
	private LineRenderer lineRenderer; //Field offset: 0x10
	public int pointCount; //Field offset: 0x14
	public float radius; //Field offset: 0x18
	public float radius_; //Field offset: 0x1C

	public CirclePrim() { }

	private void Start() { }

	private void Update() { }

	public void UpdatePosition() { }

}

