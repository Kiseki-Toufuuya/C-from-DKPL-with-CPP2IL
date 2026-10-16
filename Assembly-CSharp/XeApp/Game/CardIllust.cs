namespace XeApp.Game;

[ExecuteInEditMode]
public class CardIllust : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass37_0
	{
		public CardIllustBundleLoader bundleLoader; //Field offset: 0x8
		public Action<IllustInfo> onCreated; //Field offset: 0xC
		public IllustInfo illustInfo; //Field offset: 0x10
		public Action<AssetBundleLoadAssetOperation> <>9__5; //Field offset: 0x14

		public <>c__DisplayClass37_0() { }

		internal void <CreateIllustInfo>b__1(AssetBundleLoadAssetOperation ope) { }

		internal void <CreateIllustInfo>b__2(AssetBundleLoadAssetOperation ope) { }

		internal void <CreateIllustInfo>b__3(EffectObjectBase eff) { }

		internal void <CreateIllustInfo>b__4(AssetBundleLoadAssetOperation ope) { }

		internal void <CreateIllustInfo>b__5(AssetBundleLoadAssetOperation ope) { }

		internal void <CreateIllustInfo>g__LoadComplete|0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass39_0
	{
		public CardIllust <>4__this; //Field offset: 0x8
		public Action onInitialize; //Field offset: 0xC

		public <>c__DisplayClass39_0() { }

		internal void <Initialize>b__0(IllustInfo info) { }

	}

	internal class CardIllustBundleLoader
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass3_0
		{
			public CardIllustBundleLoader <>4__this; //Field offset: 0x8
			public string xabName; //Field offset: 0xC
			public string assetName; //Field offset: 0x10
			public Action<AssetBundleLoadAssetOperation> onLoad; //Field offset: 0x14

			public <>c__DisplayClass3_0() { }

			internal void <LoadRequest>b__0(AssetBundleLoadAssetOperation ope) { }

		}

		private int loadCount; //Field offset: 0x8
		private List<ValueTuple`2<String, String>> m_bundleLoadList; //Field offset: 0xC
		private List<AssetBundleLoadAssetOperation> m_operation; //Field offset: 0x10

		public CardIllustBundleLoader() { }

		public void DecCounter() { }

		public void IncCounter() { }

		public bool IsComplete() { }

		public bool IsDone() { }

		public bool IsError() { }

		public void LoadRequest(string xabName, string assetName, Type type, Action<AssetBundleLoadAssetOperation> onLoad) { }

		public void UnloadAllRequest() { }

		public void UnloadRequest(string xabName, string assetName) { }

	}

	internal enum FIT_MODE
	{
		CANVAS_FIT = 0,
		IMAGE_FIT = 1,
		FREE_FIT = 2,
		LATTER_FIT = 3,
	}

	internal class IllustInfo
	{
		public Material material; //Field offset: 0x8
		public Texture mainTexture; //Field offset: 0xC
		public List<PartsInfo> partsInfoList; //Field offset: 0x10
		public EffectObjectBase effect; //Field offset: 0x14
		public StampInfo stampInfo; //Field offset: 0x18
		public Rect UVRect; //Field offset: 0x1C
		public Vector2 UVOffset; //Field offset: 0x2C
		public bool isAwake; //Field offset: 0x34
		public bool isStamp; //Field offset: 0x35
		public bool isSmall; //Field offset: 0x36
		public CardIllustBundleLoader bundleLoader; //Field offset: 0x38
		public int cardID; //Field offset: 0x3C
		public int cardImageID; //Field offset: 0x40
		public int cardRarity; //Field offset: 0x44
		public int cardElement; //Field offset: 0x48

		public IllustInfo() { }

		public void Release() { }

	}

	internal class IllustSizeInfo
	{
		public float ratioW; //Field offset: 0x8
		public float ratioH; //Field offset: 0xC
		public Vector2 sizeDelta; //Field offset: 0x10

		public IllustSizeInfo() { }

	}

	internal class PartsInfo
	{
		public GameObject partsPrefab; //Field offset: 0x8

		public PartsInfo() { }

	}

	internal enum QUALITY_MODE
	{
		LOW = 0,
		MEDIUM = 1,
		HIGH = 2,
	}

	internal class StampInfo
	{
		public GameObject stampPrefab; //Field offset: 0x8

		public StampInfo() { }

	}

	public static readonly string mainXabBaseName; //Field offset: 0x0
	public static readonly string smallXabBaseName; //Field offset: 0x4
	public static readonly string mainTextureBaseName; //Field offset: 0x8
	public static readonly string smallTextureBaseName; //Field offset: 0xC
	public static readonly float cardWidth; //Field offset: 0x10
	public static readonly float cardHeight; //Field offset: 0x14
	public static readonly float cardMainWidth; //Field offset: 0x18
	public static readonly float cardMainHeight; //Field offset: 0x1C
	public static readonly float fullScreenCardMainWidth; //Field offset: 0x20
	public static readonly float fullScreenCardMainHeight; //Field offset: 0x24
	public QUALITY_MODE quality; //Field offset: 0x10
	public FIT_MODE fitMode; //Field offset: 0x14
	public bool isUVEdit; //Field offset: 0x18
	public bool isUVOffset; //Field offset: 0x19
	private TYPE type; //Field offset: 0x1C
	private bool isStarted; //Field offset: 0x20
	private RawImage image; //Field offset: 0x24
	private IllustInfo illustInfo; //Field offset: 0x28
	private List<CardIllustParts> partsObjects; //Field offset: 0x2C
	private CardIllustStamp stampObject; //Field offset: 0x30
	private EffectObjectBase effect; //Field offset: 0x34
	private CardIllustBundleLoader bundleLoader; //Field offset: 0x38
	private bool isInitialized; //Field offset: 0x3C
	private IllustSizeInfo illustSizeInfo; //Field offset: 0x40

	public IllustInfo info
	{
		 get { } //Length: 11
	}

	public bool IsInitialized
	{
		 get { } //Length: 11
	}

	public TYPE Type
	{
		 get { } //Length: 11
	}

	private static CardIllust() { }

	public CardIllust() { }

	public static IllustInfo CreateIllustInfo(HeqetCardModel cardModel, int isUseAwk, bool isUsePremium, bool isSmall, bool isLatterBox, CardIllustBundleLoader bundleLoader, Action<IllustInfo> onCreated) { }

	public IllustInfo get_info() { }

	public bool get_IsInitialized() { }

	public TYPE get_Type() { }

	public void Initialize(HeqetCardModel cardModel, int isUseAwake, bool isUsePremium, bool isSmall = false, Action onInitialize = null) { }

	public void Initialize(IllustInfo source) { }

	private void OnDestroy() { }

	public void Refresh() { }

	public void Release() { }

	public static IllustSizeInfo ResizeImage(Vector2 cardSize, FIT_MODE fitMode) { }

	public void SetActive(bool isActive) { }

	private void Update() { }

}

