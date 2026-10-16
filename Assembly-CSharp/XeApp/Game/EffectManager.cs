namespace XeApp.Game;

public class EffectManager
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<LoadContext> <>9__12_1; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal void <LoadEffectParam>b__12_1(LoadContext context) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass20_0
	{
		public Action<EffectObjectBase> load_end; //Field offset: 0x8
		public EffectManager <>4__this; //Field offset: 0xC
		public int cardNo; //Field offset: 0x10
		public bool isManage; //Field offset: 0x14

		public <>c__DisplayClass20_0() { }

		internal void <CreateCardEffect>b__0(AssetBundleLoadAssetOperation ope) { }

	}

	internal enum EffectCategory
	{
		Common = 0,
		Card = 1,
		Character = 2,
		RythmGame = 3,
		Spot = 4,
		World = 5,
		Gacha = 6,
		Travel = 7,
		Embedded = 8,
		Login = 9,
		Danmaku = 10,
		HeqetWorld = 11,
		NUM = 12,
	}

	internal class EffectCategoryData
	{
		public EffectPool Pool; //Field offset: 0x8
		public List<EffectDataParam> EffectDataParamList; //Field offset: 0xC

		public EffectCategoryData(string rootName) { }

	}

	internal class EffectDataParam
	{
		public int Id; //Field offset: 0x8
		public string FolderName; //Field offset: 0xC
		public string FileName; //Field offset: 0x10
		public string ResPath; //Field offset: 0x14

		public EffectDataParam() { }

	}

	public static EffectManager instance; //Field offset: 0x0
	public String[] CategoryName; //Field offset: 0x8
	public bool EnableNoteEffect; //Field offset: 0xC
	private List<EffectCategoryData> EffectCategoryList; //Field offset: 0x10
	private bool isLoadedEffectParam; //Field offset: 0x14

	public bool IsLoadedEffectParam
	{
		 get { } //Length: 11
	}

	public EffectManager() { }

	[CompilerGenerated]
	private void <LoadEffectParam>b__12_0(LoadContext context) { }

	public void AllRefresh() { }

	public void AllRefresh(EffectCategory category) { }

	public void Create() { }

	public void CreateCardEffect(int cardNo, bool isSmall, int rarity, int element, Action<EffectObjectBase> load_end = null, bool isManage = true) { }

	public EffectObjectBase CreateEffect(string eff_name, EffectCategory category = 3, bool isManage = true) { }

	public EffectObjectBase CreateEffect(int eff_no, EffectCategory category, bool isManage = true) { }

	public void ForcedStopEffect() { }

	public void ForcedStopEffect(EffectCategory category) { }

	public bool get_IsLoadedEffectParam() { }

	public int GetActiveEffectCount(int effNo, EffectCategory category = 0) { }

	public void GetEffectAssetBundleName(EffectCategory category, out string assetBundle) { }

	public bool IsLoadedEffectAssetBundle(EffectCategory category) { }

	private bool IsNoteEffect(EffectCategory category, int eff_no) { }

	public void LateUpDate() { }

	public void LoadEffectAssetBunde(EffectCategory category) { }

	public void LoadEffectParam() { }

	public void PauseEffect(bool enable) { }

	private void PoolInitialize() { }

	public void RefreshActiveEffect() { }

	public void RefreshActiveEffect(EffectCategory category) { }

	public void ReleaseCardEffectAssetBundle(int cardNo, int rarity, int element) { }

	public void ReleaseCardEffectModel(EffectObjectBase model) { }

	public void ReleaseEffectAssetBunde(EffectCategory category) { }

	public void ReleaseFreeModel(EffectObjectBase model, EffectCategory category = 0) { }

	public void ReleaseModel(EffectObjectBase model, EffectCategory category = 0) { }

	public void ReleaseMostOldEffect(int effNo, EffectCategory category = 0) { }

	public EffectObjectBase SearchEffect(GameObject obj, int effNo, EffectCategory category) { }

	public void StopActiveEffect(EffectCategory category) { }

	public void StopActiveEffect() { }

}

