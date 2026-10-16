namespace XeApp.Game;

public class AdvLive2DModel
{
	private enum EasingType
	{
		QuadIn = 0,
		QuadOut = 1,
		CubicIn = 2,
		CubicOut = 3,
		QuartIn = 4,
		QuartOut = 5,
		QuintIn = 6,
		QuintOut = 7,
		SineIn = 8,
		SineOut = 9,
		ExpIn = 10,
		ExpOut = 11,
		CircIn = 12,
		CircOut = 13,
	}

	internal class MotionRequestData
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

	internal enum State
	{
		LoadModel = 0,
		Init = 1,
		InitMotion = 2,
		Wait = 3,
		Move = 4,
		FadeInMove = 5,
		FadeOutMove = 6,
		EasingInMove = 7,
		FadeInEasingInMove = 8,
		FadeOutEasingInMove = 9,
		EasingOutMove = 10,
		FadeInEasingOutMove = 11,
		FadeOutEasingOutMove = 12,
		FadeIn = 13,
		FadeOut = 14,
	}

	private State MainState; //Field offset: 0x8
	protected Live2DModel Live2DModel; //Field offset: 0xC
	private int FullCharaId; //Field offset: 0x10
	private int CharaId; //Field offset: 0x14
	private int SkinId; //Field offset: 0x18
	private int ScreenNo; //Field offset: 0x1C
	protected int FaceLayerIndex; //Field offset: 0x20
	protected int MotionLayerIndex; //Field offset: 0x24
	private int OptionLayerIndex; //Field offset: 0x28
	private int MouthLayerIndex; //Field offset: 0x2C
	protected int EyeLayerIndex; //Field offset: 0x30
	protected int BreathLayerIndex; //Field offset: 0x34
	private int EffectLayerIndex; //Field offset: 0x38
	private int EarLayerIndex; //Field offset: 0x3C
	private int TailLayerIndex; //Field offset: 0x40
	private int WingLayerIndex; //Field offset: 0x44
	private eCanvas Canvas; //Field offset: 0x48
	private int Priority; //Field offset: 0x4C
	protected float Opacity; //Field offset: 0x50
	private float ActionTime; //Field offset: 0x54
	private float CompleteTime; //Field offset: 0x58
	private Vector3 StartPosition; //Field offset: 0x5C
	private Vector3 EndPostion; //Field offset: 0x68
	private string NowMotionName; //Field offset: 0x74
	private string NowFaceName; //Field offset: 0x78
	private string NowOptionName; //Field offset: 0x7C
	private List<MotionRequestData> MotionRequestList; //Field offset: 0x80
	private bool DelayFlg; //Field offset: 0x84
	private float DelayTimeCount; //Field offset: 0x88
	private GameObject LookTarget; //Field offset: 0x8C
	private Vector3 LookPosBak; //Field offset: 0x90
	private float LookDelayTime; //Field offset: 0x9C
	private Vector3 LookPosTarget; //Field offset: 0xA0
	private int LookPosActTime; //Field offset: 0xAC
	private float NowTextureRed; //Field offset: 0xB0
	private float NowTextureBlue; //Field offset: 0xB4
	private float NowTextureGreen; //Field offset: 0xB8
	private int Type; //Field offset: 0xBC
	private Direction DirType; //Field offset: 0xC0
	private Material m_unlit; //Field offset: 0xC4
	private Material m_unlit_mask; //Field offset: 0xC8
	private Texture2D m_ditherTexture; //Field offset: 0xCC
	private float m_shakeDelayTime; //Field offset: 0xD0
	private float m_shakeTime; //Field offset: 0xD4
	private bool m_shakeLoopFlg; //Field offset: 0xD8

	public int CharaID
	{
		 get { } //Length: 11
	}

	public int Id
	{
		 get { } //Length: 11
	}

	public AdvLive2DModel() { }

	[CompilerGenerated]
	private void <Initialize>b__50_0(AssetBundleLoadAssetOperation operation) { }

	[CompilerGenerated]
	private void <Initialize>b__50_1(AssetBundleLoadAssetOperation operation) { }

	public void AddLoadAnimatorController() { }

	public void AddMotionReq(string motionName, float duration, string faceName, string optionName, float delay, string EarName, string TailName) { }

	public override void AddPosition(Vector3 pos) { }

	public void ChangeTextrueColor(float red, float green, float blue) { }

	public bool CheckDelay(bool flg) { }

	public bool CheckStop(bool flg) { }

	public bool ChkLoadLive2D() { }

	public bool ChkWait() { }

	public void ClearLookChara() { }

	public void ClearLookTargetPos() { }

	public void ClearTextrueColor() { }

	private void EasingMove(EasingType move_type) { }

	public int get_CharaID() { }

	public int get_Id() { }

	public List<String> GetAddAnimeStateList() { }

	public static void GetAssetBandleName(int charaId, int skinId, int type, out string modelPathName, out string animePathName, out string commonPathName) { }

	public float GetBreathLayerWeight() { }

	public List<String> GetEarAnimeStateList() { }

	public float GetEyeLayerWeight() { }

	public List<String> GetFaceAnimeStateList() { }

	public static void GetFileName(int charaId, int skinId, int type, out string modelPathName, out string animePathName) { }

	public void GetLayerIndex() { }

	public GameObject GetLookTarget() { }

	public List<String> GetMotionAnimeStateList() { }

	protected override float GetOpacity() { }

	public List<String> GetTailAnimeStateList() { }

	public override Transform GetTransform() { }

	public List<String> GetWingAnimeStateList() { }

	public override void HideEmotion(bool enable) { }

	public void InitEyesTarget() { }

	public override void Initialize(int charaId, int skinId, int screenNo, eCanvas canvasType, int priority, int type = 0, int fullId = 0) { }

	public void Initialize(string fileName, int screenNo, eCanvas canvasType, int priority, int type = 0) { }

	protected override void InitMotionRequest(MotionRequestData request) { }

	public bool IsDisp() { }

	public bool IsPlaying(int layerIndex) { }

	private void Move(float rate) { }

	public void PauseEvent(bool isPause) { }

	public void PlayFaceAnimetion(string state) { }

	public void PlayFaceAnimetion(string state, float duration) { }

	public override void PlayLive2DAnime(string state, float transitionDuration, int layer = -1, float frame = 0) { }

	public override void PlayLive2DAnime(string state, int layer = -1, float frame = 0) { }

	public override void PlayLive2DAnime(string state) { }

	public void PlayMotionAnimetion(string state, float duration) { }

	public void PlayMotionAnimetion(string state) { }

	public override void Release() { }

	public void RequestDownMove(float time) { }

	public void RequestEasingInMove(int pos_no, float time, float opacity) { }

	public void RequestEasingOutMove(int pos_no, float time, float opacity) { }

	public void RequestMove(int pos_no, float time, float opacity) { }

	public void RequestUpDownMove(float ypos, float time, float opacity) { }

	public void RequestUpMove(float time) { }

	public void ResetAnimeReq() { }

	public override void SetActive(bool enable) { }

	public void SetBreathLayerWeight(float weight) { }

	public void SetCharaOptionPriority(bool enable) { }

	public void SetCharaRevers() { }

	public override void SetDirection(Direction direction) { }

	public void SetEffectAnime(bool active) { }

	public void SetEffectEnable(bool active) { }

	public void SetEyeLayerWeight(float weight) { }

	public void SetLive2DCullingLayer(string layerName) { }

	public void SetLive2DSortingLayer(string layerName) { }

	public void SetLookDelay(float delay) { }

	public void SetLookTarget(GameObject target, int delay = 0) { }

	public void SetMouthAnime(bool active) { }

	public override void SetOpacity() { }

	public void SetOverrideController(RuntimeAnimatorController o) { }

	private void SetParent(eCanvas canvasType) { }

	public override void SetPosition(Vector3 pos) { }

	public override void SetPriority(int priority) { }

	public override void SetScale(Vector3 scale) { }

	protected override void SetupLive2DModel() { }

	public void ShakePrepareStop() { }

	public void ShakeStart(int type, float speed, float power, float delayTime, float time) { }

	public void ShakeStop() { }

	public void ShakeUpdate() { }

	public override void StartEmotion(int id) { }

	public void StartFade(State state, float compTime) { }

	public void StartPositionLook(Vector3 target_pos, int time, int delay = 0) { }

	public override void StopEmotion() { }

	public override void UpDate() { }

}

