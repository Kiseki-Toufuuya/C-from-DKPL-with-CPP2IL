namespace Heqet.Danmaku;

public class DanmakuBGCamera : MonoBehaviour
{
	[SerializeField]
	private Camera gameCamera; //Field offset: 0x10
	private Vector2 m_StartPos; //Field offset: 0x14
	private Material m_DeathMaterial; //Field offset: 0x1C
	private float m_Aspect; //Field offset: 0x20
	private float m_Radius; //Field offset: 0x24
	private float m_ImpactRadius; //Field offset: 0x28
	private float m_Speed; //Field offset: 0x2C
	private bool m_IsPlay; //Field offset: 0x30

	public bool IsPlayingPlayerDefeatEffect
	{
		 get { } //Length: 11
	}

	public DanmakuBGCamera() { }

	[CompilerGenerated]
	private void <InitSkillEffect>b__12_0(AssetBundleLoadAssetOperation ope) { }

	public bool get_IsPlayingPlayerDefeatEffect() { }

	private void InitSkillEffect() { }

	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void ResetDeathEffect() { }

	private void Start() { }

	public void StartPlayDeathEffect(GameObject owner) { }

}

