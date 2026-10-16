namespace XeSys.Gfx;

public class DebugRaycastTargetMarker : MonoBehaviour
{
	public Color markColor; //Field offset: 0x10
	[SerializeField]
	private GameObject m_rootObject; //Field offset: 0x20

	public DebugRaycastTargetMarker() { }

	private void LateUpdate() { }

	private void OnDisable() { }

	private void Start() { }

}

