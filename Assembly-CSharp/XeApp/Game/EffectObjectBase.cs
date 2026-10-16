namespace XeApp.Game;

public class EffectObjectBase
{
	public static bool IsEnableCreateWarning; //Field offset: 0x0
	public int EffectNo; //Field offset: 0x8
	public EffectCategory Category; //Field offset: 0xC
	public bool IsUse; //Field offset: 0x10
	public bool IsManaged; //Field offset: 0x11
	public bool IsNoDeactive; //Field offset: 0x12
	public GameObject EffectObject; //Field offset: 0x14
	private IEffectModule Particle; //Field offset: 0x18
	private int m_CustomSortingLayerId; //Field offset: 0x1C

	public EffectObjectBase() { }

	public void AddPosition(Vector3 add) { }

	public override void Create(GameObject effectObj, int effNo, EffectCategory category, Transform parent) { }

	public override void Create(string EffectPath, int effNo, EffectCategory category, Transform parent) { }

	public GameObject FindObj(Transform parent, string name) { }

	private IEffectModule GetEffectModule(GameObject obj) { }

	public ParticleSystem GetParticleSystem() { }

	public bool IsPlayingAnime() { }

	public static Vector3 MakeEffectPosition(Camera uiCamera, Camera effectCamera, RectTransform uiRect) { }

	public void MulAlpha(float alpha) { }

	public static void MulAlpha(ParticleSystem particle, float alpha) { }

	public void PauseParticle(bool enable = true) { }

	public void PlayParticle() { }

	public override void Release() { }

	public override void SetActive(bool isActive) { }

	public void SetLayer(string layerName) { }

	public void SetLayer(Transform parent, string layerName) { }

	public void SetParent(Transform parent, bool worldPositionStays = true) { }

	public void SetPosition(Vector3 pos) { }

	public void SetRotation(Quaternion rot) { }

	public void SetScale(Vector3 scale) { }

	public void SetScale(float scale) { }

	public void SetSortingLayer(int sortingLayerId) { }

	public void SetSortingLayer(string layerName) { }

	public void SetUiCanvas(int canvas_id, string layerName) { }

	public void SetUiCanvas(int canvas_id) { }

	private void SetUiCanvas(Transform parent, string layerName, int order) { }

	public void SetWorldPosition(Vector3 pos) { }

	public void SimulateParticle(float elapsedTime) { }

	public void StopParticle() { }

}

