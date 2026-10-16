namespace Heqet;

public class PostProcessManager : MonoBehaviour
{
	[SerializeField]
	private PostProcessVolume m_spotModePostProcessVolume; //Field offset: 0x10
	[SerializeField]
	private PostProcessVolume m_stageModePostProcessVolume; //Field offset: 0x14
	[SerializeField]
	private SpriteRenderer m_spotlightRenderer; //Field offset: 0x18
	[SerializeField]
	private Vector3 m_spotModeScale; //Field offset: 0x1C
	[SerializeField]
	private Vector3 m_stageModeScale; //Field offset: 0x28
	[SerializeField]
	private Color m_spotModeColor; //Field offset: 0x34
	[SerializeField]
	private Color m_stageModeColor; //Field offset: 0x44
	private Tween m_tween; //Field offset: 0x54

	public PostProcessManager() { }

	[CompilerGenerated]
	private void <SpotMode>b__8_0(float value) { }

	public void SpotMode(bool enable, float duration) { }

}

