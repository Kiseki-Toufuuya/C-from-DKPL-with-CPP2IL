namespace XeApp.Game;

public class Live2DModel
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass52_0
	{
		public AssetBundleLoadAllAssetOperationBase reqModel; //Field offset: 0x8

		public <>c__DisplayClass52_0() { }

		internal object <Co_LoadModel>b__0(Type assetType, string absolutePath) { }

	}

	[CompilerGenerated]
	private sealed class <Co_LoadModel>d__52 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public Live2DModel <>4__this; //Field offset: 0x10
		public string modelName; //Field offset: 0x14
		public string animePath; //Field offset: 0x18
		private <>c__DisplayClass52_0 <>8__1; //Field offset: 0x1C
		private AssetBundleLoadAllAssetOperationBase <reqAnim>5__2; //Field offset: 0x20

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 11
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 11
		}

		[DebuggerHidden]
		public <Co_LoadModel>d__52(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	internal enum AnimationState
	{
		BS_Stay = 0,
		BS_Attack = 1,
		BS_Damage_big = 2,
		BS_Damage_small = 3,
		BS_Destroy = 4,
		BS_Win = 5,
		SD_Idle01 = 6,
		SD_Sitting01 = 7,
		SD_Walk01 = 8,
	}

	internal enum AttachNode
	{
		None = 0,
		LeftHand = 1,
		RightHand = 2,
		Max = 3,
	}

	internal enum Direction
	{
		Left = 0,
		Right = 1,
	}

	internal enum RenderType
	{
		Render3D = 0,
		Render2D = 1,
	}

	private static readonly String[] AnimationStateName; //Field offset: 0x0
	public Direction NowDirection; //Field offset: 0x8
	private CubismModel model; //Field offset: 0xC
	private string modelAssetPath; //Field offset: 0x10
	private string animeAssetPath; //Field offset: 0x14
	private Animator animator; //Field offset: 0x18
	private RuntimeAnimatorController animeController; //Field offset: 0x1C
	private Dictionary<Int32, Int32> resumeAnimationHash; //Field offset: 0x20
	private Dictionary<Int32, Single> resumeTime; //Field offset: 0x24
	private TYPE RtType; //Field offset: 0x28
	private List<RuntimeAnimatorController> AddAnimeController; //Field offset: 0x2C
	private AnimatorOverrideController overrideController; //Field offset: 0x30
	private Transform ParametersTransform; //Field offset: 0x34
	private Transform DrawablesTransform; //Field offset: 0x38
	private Transform PartsTransform; //Field offset: 0x3C
	private List<GameObject> LeftDispObject; //Field offset: 0x40
	private List<GameObject> RightDispObject; //Field offset: 0x44
	private GameObject LeftItemAttachObject; //Field offset: 0x48
	private MeshFilter LeftItemAttachObjectMesh; //Field offset: 0x4C
	private List<GameObject> LeftItemObjectList; //Field offset: 0x50
	private GameObject RightItemAttachObject; //Field offset: 0x54
	private MeshFilter RightItemAttachObjectMesh; //Field offset: 0x58
	private List<GameObject> RightItemObjectList; //Field offset: 0x5C
	private GameObject EyesTarget; //Field offset: 0x60
	private CubismLookController LookController; //Field offset: 0x64
	private GameObject TargetObject; //Field offset: 0x68
	public bool IsReady; //Field offset: 0x6C
	private string modelBundlePath; //Field offset: 0x70
	private string commonBundlePath; //Field offset: 0x74
	private string animBundlePath; //Field offset: 0x78
	private bool LookUpdateFlag; //Field offset: 0x7C
	private Vector3 LookActionSubPos; //Field offset: 0x80
	private Vector3 LookActionAddPos; //Field offset: 0x8C
	private float LookActionTime; //Field offset: 0x98
	private float LookCompleteTime; //Field offset: 0x9C
	private CubismParameter SDCharaAngleZParam; //Field offset: 0xA0
	private GameObject m_drawables; //Field offset: 0xA4
	private bool m_shakeFlg; //Field offset: 0xA8
	private Vector3 m_shakePos; //Field offset: 0xAC
	private Vector3 m_shakeTargetPos; //Field offset: 0xB8
	private Vector3 m_shakeMoveVec; //Field offset: 0xC4
	private eComBgInsertShakeType m_shakeType; //Field offset: 0xD0
	private float m_shakeSpeed; //Field offset: 0xD4
	private float m_shakePower; //Field offset: 0xD8
	private float m_shakeTime; //Field offset: 0xDC
	private float m_shakeDelayTime; //Field offset: 0xE0
	private float m_euler; //Field offset: 0xE4

	public string AnimeAssetPath
	{
		 get { } //Length: 11
	}

	public GameObject gameObject
	{
		 get { } //Length: 113
	}

	public CubismModel Model
	{
		 get { } //Length: 11
	}

	public string ModelAssetPath
	{
		 get { } //Length: 11
	}

	private static Live2DModel() { }

	public Live2DModel() { }

	[CompilerGenerated]
	internal static void <CreateOrderedDitherTexture>g__CreateDissolveTextureSub|124_0(ref Byte[2] retArray, int offsetX, int offsetY, int texSize, int baseIndex, int indexStep) { }

	public void AddLoadAnimatorController(string animePath) { }

	public void AttachObject(AttachNode node, GameObject obj) { }

	private object BuiltinLoadAssetAtPath(Type assetType, string absolutePath) { }

	public void ChangeAnimatorController(int index) { }

	public void Changedirection(Direction dir, MeshFilter filter, TYPE type) { }

	public void Changedirection(Direction dir, RawImageEx image, TYPE type) { }

	public void Changedirection(Direction dir) { }

	public void ChangeEffectSortingOrder(int localOrder) { }

	public void ChangeMeshColor(float red, float green, float blue) { }

	public void ChangeObject() { }

	public void ClearLookTargetPos() { }

	[IteratorStateMachine(typeof(<Co_LoadModel>d__52))]
	private IEnumerator Co_LoadModel(string modelName, string animePath) { }

	public static string CreateAnimeBundlePath(string animePath) { }

	public static string CreateAnimeCommonBundlePath(string animePath) { }

	public static string CreateModelBundlePath(string modelName) { }

	public static Texture2D CreateOrderedDitherTexture(int textureSize) { }

	private bool CulcLookActionRate(out float rate) { }

	public void DetachObject(AttachNode node, GameObject obj) { }

	public string get_AnimeAssetPath() { }

	public GameObject get_gameObject() { }

	public CubismModel get_Model() { }

	public string get_ModelAssetPath() { }

	public List<String> GetAnimeStateList(string layerName) { }

	public AnimatorStateInfo GetCurrentAnimatorStateInfo(int layerNo = 0) { }

	public int GetLayerIndex(string layerName) { }

	public float GetLayerWeight(int layerIndex) { }

	public float GetLive2DOpacity() { }

	public GameObject GetLookTarget() { }

	public RuntimeAnimatorController GetRuntimeAnimatorController() { }

	public bool GetShakeStopFlg() { }

	public void InitEyesTarget() { }

	public bool IsEnableCharacterAngleZ() { }

	public bool IsPlaying(int layerIndex, AnimationState state) { }

	public bool IsPlaying(int layerIndex) { }

	public bool IsPlaying(int layerIndex, string motionName, bool loop = false) { }

	public void LoadModel(string modelPath, string animePath) { }

	public void LoadModelStart(string modelName, string animePath) { }

	private void LookUpdate() { }

	public void PauseAnimation(int layer = 0) { }

	public void ReleaseModel() { }

	public void ResumeAnimation(int layer = -1) { }

	public void SetActive(bool active) { }

	public void SetAnimationBool(string name, bool value) { }

	public void SetAnimationFloat(string name, float value) { }

	public void SetAnimationTrigger(string name) { }

	public void SetCharacterAngleZ(float angle) { }

	public void SetDitherFade(Material unlit, Material unlit_mask) { }

	public static void SetLayer(GameObject gameObject, int layerNo, bool needSetChildrens = true) { }

	public void SetLayerWeight(int layerIndex, float weight) { }

	public void SetLive2DOpacity(float opacity) { }

	public void SetLive2DRenderMode(RenderType renderType) { }

	public void SetLive2DSortingLayer(string layer) { }

	public void SetLive2DSortingOrder(int orderNo) { }

	public void SetLookDelay(float delay) { }

	private void SetLookPosition(Vector3 target_pos) { }

	public void SetLookTarget() { }

	public void SetLookTarget(GameObject target) { }

	public void SetOverrideController(RuntimeAnimatorController o) { }

	public void SetParent(Transform parent) { }

	public void SetPartValue(string paramName, int value) { }

	public void SetPosition(Vector3 pos) { }

	public void SetRenderImage(RawImageEx image, TYPE type) { }

	public void SetRenderMesh(MeshFilter filter, MeshRenderer render, TYPE type) { }

	public void SetScale(Vector3 scale) { }

	public void SetUpLook() { }

	public void ShakeStart(int type, float speed, float power, float delayTime, float time) { }

	public void ShakeStop() { }

	public void ShakeUpdate() { }

	public void StartAnimation(string state) { }

	public void StartAnimation(string state, float transitionDuration, int layer = -1, float frame = 0) { }

	public void StartAnimation(string state, int layer = -1, float frame = 0) { }

	public void StartAnimation(AnimationState state, int layer = -1, float frame = 0) { }

	public void StartLookAction(Vector3 target_pos, int time) { }

	public void StopAnimation() { }

	public void Update() { }

}

