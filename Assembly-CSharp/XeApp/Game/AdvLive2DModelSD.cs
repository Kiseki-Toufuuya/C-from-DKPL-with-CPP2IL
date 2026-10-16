namespace XeApp.Game;

public class AdvLive2DModelSD : AdvLive2DModel
{
	private TYPE RenderTextureType; //Field offset: 0xDC
	private GameObject RootObject; //Field offset: 0xE0
	private GameObject Live2DScreen; //Field offset: 0xE4
	private GameObject RootEmotion; //Field offset: 0xE8
	private MeshFilter cachedScreenFilter; //Field offset: 0xEC
	private MeshRenderer cachedScreenRenderer; //Field offset: 0xF0
	private Direction CurrentDirection; //Field offset: 0xF4
	private List<Emotion> m_emotionList; //Field offset: 0xF8
	private EffectObjectBase CurrentEmotionObject; //Field offset: 0xFC
	private bool IsResumeHideEmotion; //Field offset: 0x100

	public AdvLive2DModelSD() { }

	public virtual void AddPosition(Vector3 pos) { }

	protected virtual float GetOpacity() { }

	public virtual Transform GetTransform() { }

	public virtual void HideEmotion(bool enable) { }

	public virtual void Initialize(int charaId, int skinId, int screenNo, eCanvas canvasType, int priority, int type = 0, int fullId = 0) { }

	private void InitializeEmotion(int sortingOrder) { }

	protected virtual void InitMotionRequest(MotionRequestData request) { }

	private Vector3 MakeEffectPos(Transform target) { }

	public virtual void PlayLive2DAnime(string state, int layer = -1, float frame = 0) { }

	public virtual void PlayLive2DAnime(string state, float transitionDuration, int layer = -1, float frame = 0) { }

	public virtual void PlayLive2DAnime(string state) { }

	public virtual void Release() { }

	private void ReleaseEmotion() { }

	private TYPE ScreenNoToRenderTextureType(int screenNo) { }

	public virtual void SetActive(bool enable) { }

	public virtual void SetDirection(Direction direction) { }

	public virtual void SetOpacity() { }

	public virtual void SetPosition(Vector3 pos) { }

	public virtual void SetPriority(int priority) { }

	public virtual void SetScale(Vector3 scale) { }

	protected virtual void SetupLive2DModel() { }

	public virtual void StartEmotion(int id) { }

	public virtual void StopEmotion() { }

	public virtual void UpDate() { }

}

