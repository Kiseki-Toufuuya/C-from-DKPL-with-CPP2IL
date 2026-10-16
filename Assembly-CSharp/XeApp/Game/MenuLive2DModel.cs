namespace XeApp.Game;

public class MenuLive2DModel
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass130_0
	{
		public MenuLive2DModel <>4__this; //Field offset: 0x8
		public UnityAction callback; //Field offset: 0xC

		public <>c__DisplayClass130_0() { }

		internal void <CreateLive2DButton>b__0(BaseEventData call) { }

	}

	private class MotionRequestData
	{
		public string MotionName; //Field offset: 0x8
		public float DurationTime; //Field offset: 0xC
		public string FaceName; //Field offset: 0x10
		public string OptionName; //Field offset: 0x14
		public string EarName; //Field offset: 0x18
		public string TailName; //Field offset: 0x1C
		public float DelayTime; //Field offset: 0x20

		public MotionRequestData() { }

	}

	internal enum RENDER_TYPE
	{
		HEROINE = 0,
		SD = 1,
		BOSS = 2,
		MENU_CHARA = 3,
	}

	internal enum State
	{
		LoadModel = 0,
		Init = 1,
		InitMotion = 2,
		Wait = 3,
		WaitNext = 4,
		Move = 5,
		FadeInMove = 6,
		FadeOutMove = 7,
		FadeIn = 8,
		FadeOut = 9,
	}

	private static readonly String[] AnimationStateName; //Field offset: 0x0
	private const float DefaultWaitPushTime = 1; //Field offset: 0x0
	public const float DefaultCharaRenderScale = 10; //Field offset: 0x0
	private State MainState; //Field offset: 0x8
	private Live2DModel Live2DModel; //Field offset: 0xC
	private int FullCharaId; //Field offset: 0x10
	private int CharaId; //Field offset: 0x14
	private int SkinId; //Field offset: 0x18
	private int ScreenNo; //Field offset: 0x1C
	private int FaceLayerIndex; //Field offset: 0x20
	private int MotionLayerIndex; //Field offset: 0x24
	private int OptionLayerIndex; //Field offset: 0x28
	private int MouthLayerIndex; //Field offset: 0x2C
	private int EyeLayerIndex; //Field offset: 0x30
	private int BreathLayerIndex; //Field offset: 0x34
	private int EffectLayerIndex; //Field offset: 0x38
	private int EarLayerIndex; //Field offset: 0x3C
	private int TailLayerIndex; //Field offset: 0x40
	private int WingLayerIndex; //Field offset: 0x44
	private float Opacity; //Field offset: 0x48
	private float ActionTime; //Field offset: 0x4C
	private float CompleteTime; //Field offset: 0x50
	private Vector3 StartPosition; //Field offset: 0x54
	private Vector3 EndPostion; //Field offset: 0x60
	private string NowMotionName; //Field offset: 0x6C
	private string NowFaceName; //Field offset: 0x70
	private string NowOptionName; //Field offset: 0x74
	private List<MotionRequestData> MotionRequestList; //Field offset: 0x78
	private bool DelayFlg; //Field offset: 0x7C
	private float DelayTimeCount; //Field offset: 0x80
	private GameObject LookTarget; //Field offset: 0x84
	private Vector3 LookPosBak; //Field offset: 0x88
	private float NowTextureRed; //Field offset: 0x94
	private float NowTextureBlue; //Field offset: 0x98
	private float NowTextureGreen; //Field offset: 0x9C
	private int Type; //Field offset: 0xA0
	private TYPE InitType; //Field offset: 0xA4
	private RawImageEx InitImage; //Field offset: 0xA8
	private float InitScale; //Field offset: 0xAC
	private String[2] PoseMotion; //Field offset: 0xB0
	private int PoseIndex; //Field offset: 0xB4
	private bool IsMouthAnimation; //Field offset: 0xB8
	private float WaitPushTime; //Field offset: 0xBC
	private Material m_unlit; //Field offset: 0xC0
	private Material m_unlit_mask; //Field offset: 0xC4
	private Texture2D m_ditherTexture; //Field offset: 0xC8
	private bool m_isChangeDirectionRequest; //Field offset: 0xCC
	private Direction m_Direction; //Field offset: 0xD0
	private TYPE m_RenderType; //Field offset: 0xD4
	private bool m_MouceAnimeOff; //Field offset: 0xD8

	public int Id
	{
		 get { } //Length: 11
	}

	public bool MouceAnimeOff
	{
		 get { } //Length: 14
		 set { } //Length: 17
	}

	private static MenuLive2DModel() { }

	public MenuLive2DModel() { }

	[CompilerGenerated]
	private void <CreateLive2DModel>b__61_0(AssetBundleLoadAssetOperation operation) { }

	[CompilerGenerated]
	private void <CreateLive2DModel>b__61_1(AssetBundleLoadAssetOperation operation) { }

	public void AddLoadAnimatorController() { }

	public void AddMotionReq(string motionName, float duration, string faceName, string optionName, float delay, string EarName, string TailName) { }

	public void AddPosition(Vector3 pos) { }

	public void Changedirection(Direction dir, RawImageEx image, TYPE type) { }

	public void ChangePose(bool isForce = false) { }

	public void ChangeTextrueColor(float red, float green, float blue) { }

	public bool ChkLoadLive2D() { }

	public bool ChkMotionDisp() { }

	public bool ChkWait() { }

	public void ClearLookChara() { }

	public void ClearTextrueColor() { }

	public void CreateLive2DButton(GameObject parent, UnityAction callback, float waitTime = 1) { }

	public void CreateLive2DModel(int charaId, int skinId, int type) { }

	public void CreateMenuCharaLive2DModel(MenuLive2DModelReciveData view_data) { }

	public static void CreateRenderLive2DModel(out MenuLive2DModel model, int chara_id, int skin_id, RENDER_TYPE type, RawImageEx image, float scale = 2.5, int render_num = 0) { }

	public static void CreateRenderMenuCharaModel(out MenuLive2DModel model, int chara_id, int skin_id, RawImageEx image) { }

	public int get_Id() { }

	public bool get_MouceAnimeOff() { }

	public List<String> GetAddAnimeStateList() { }

	public static void GetAssetBandleName(int charaId, int skinId, RENDER_TYPE type, out string modelPathName, out string animePathName, out string commonPathName) { }

	public List<String> GetEarAnimeStateList() { }

	public List<String> GetFaceAnimeStateList() { }

	public static void GetFileName(int charaId, int skinId, RENDER_TYPE type, out string modelPathName, out string animePathName) { }

	public void GetLayerIndex() { }

	public GameObject GetLookTarget() { }

	public List<String> GetMotionAnimeStateList() { }

	public Vector3 GetPosition() { }

	public List<String> GetTailAnimeStateList() { }

	public List<String> GetWingAnimeStateList() { }

	private void InitDirection(RawImageEx image) { }

	public void InitEyesTarget() { }

	public void Initialize(int charaId, int skinId, int screenNo, eCanvas canvasType, int priority, int type = 0) { }

	public void Initialize(string fileName, int screenNo, eCanvas canvasType, int priority, int type = 0) { }

	public bool IsDisp() { }

	public bool IsEndAttackMotion() { }

	public bool IsEndAttackVoice() { }

	public bool IsLive2DAnimeEnd() { }

	public bool IsLive2DAnimeNowPlayMotion(AnimationState state) { }

	public bool IsLive2DModel() { }

	public bool IsLive2DReady() { }

	public bool IsPlaying(int layerIndex) { }

	public bool IsPlaying(int layerIndex, string motionName) { }

	private void MotionReq(int anim_id, int face_id) { }

	private void Move(float rate) { }

	public void PauseEvent(bool isPause) { }

	public void PlayFaceAnimetion(string state) { }

	public void PlayFaceAnimetion(string state, float duration) { }

	public void PlayLive2DAddAnime(string state, float frame) { }

	public void PlayLive2DAnime(string state, float transitionDuration, int layer = -1, float frame = 0) { }

	public void PlayLive2DAnime(string state, int layer = -1, float frame = 0) { }

	public void PlayLive2DAnime(string state) { }

	public void PlayMotionAnimetion(string state, float duration) { }

	public void PlayMotionAnimetion(string state) { }

	public void Release() { }

	public void RequestMove(int pos_no, float time, float opacity) { }

	public void ResetAnimeReq() { }

	public void set_MouceAnimeOff(bool value) { }

	public void SetActive(bool enable) { }

	public void SetBreathLayerWeight(float weight) { }

	public void SetCharaOptionPriority(bool enable) { }

	private void SetDirection(Direction dir) { }

	public void SetEffectAnime(bool active) { }

	public void SetEyeLayerWeight(float weight) { }

	public void SetLookDelay(float delay) { }

	public void SetLookTarget(GameObject target) { }

	public void SetMouthAnime(bool active) { }

	public void SetMouthAnimeV2(bool active) { }

	public void SetOpacity() { }

	public void SetParent(eCanvas canvasType) { }

	public void SetParent(Transform parent) { }

	public void SetPoseMotion(String[2] pose) { }

	public void SetPosition(Vector3 pos) { }

	public void SetPriority(int priority) { }

	public void SetRenderImage(RawImageEx image, TYPE type, Vector3 scale) { }

	public void SetScale(Vector3 scale) { }

	public void SetScaleRate(float rate) { }

	public void StartAnimation(AnimationState state) { }

	public void StartAttackMotion() { }

	public void StartFade(State state, float compTime) { }

	public void UpDate() { }

	public void UpdateMouthAnime() { }

	protected void WaitUpdate() { }

}

