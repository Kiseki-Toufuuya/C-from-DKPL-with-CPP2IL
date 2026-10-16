namespace UnityEngine.Rendering.PostProcessing;

[AddComponentMenu("Rendering/Post-process Debug", 1002)]
[ExecuteAlways]
public sealed class PostProcessDebug : MonoBehaviour
{
	public PostProcessLayer postProcessLayer; //Field offset: 0x10
	private PostProcessLayer m_PreviousPostProcessLayer; //Field offset: 0x14
	public bool lightMeter; //Field offset: 0x18
	public bool histogram; //Field offset: 0x19
	public bool waveform; //Field offset: 0x1A
	public bool vectorscope; //Field offset: 0x1B
	public DebugOverlay debugOverlay; //Field offset: 0x1C
	private Camera m_CurrentCamera; //Field offset: 0x20
	private CommandBuffer m_CmdAfterEverything; //Field offset: 0x24

	public PostProcessDebug() { }

	private void DrawMonitor(ref Rect rect, Monitor monitor, bool enabled) { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void OnGUI() { }

	private void OnPostRender() { }

	private void Reset() { }

	private void Update() { }

	private void UpdateStates() { }

}

