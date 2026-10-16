//Type is in global namespace

public class KeyConfigPreview : MonoBehaviour
{
	[HideInInspector]
	public RawImageEx rawImageEx; //Field offset: 0x10
	[SerializeField]
	private GameObject m_DanmakuBlind; //Field offset: 0x14
	[SerializeField]
	private List<KeyConfigPreviewLane> m_KeyConfigPreviewLanes; //Field offset: 0x18
	private List<InputActionReference> m_KeyLanes; //Field offset: 0x1C

	public KeyConfigPreview() { }

	public void Awake() { }

	public void DispBlind(bool _enable) { }

	public void DispDanmakuLane() { }

	public void DispKaguraLane() { }

	public void DispLaneLight(bool _enable) { }

	public void DispLaneLight(int _id, bool _enable) { }

	public void Release() { }

	public void Setup() { }

	public void SetupRenderTexture() { }

	public void Update() { }

}

