namespace Live2D.Cubism.Framework.LookAt;

public sealed class CubismLookParameter : MonoBehaviour
{
	[SerializeField]
	public CubismLookAxis Axis; //Field offset: 0x10
	[SerializeField]
	public float Factor; //Field offset: 0x14

	public CubismLookParameter() { }

	private void Reset() { }

	internal float TickAndEvaluate(Vector3 targetOffset) { }

}

