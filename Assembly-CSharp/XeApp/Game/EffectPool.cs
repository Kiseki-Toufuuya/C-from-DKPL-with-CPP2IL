namespace XeApp.Game;

public class EffectPool
{
	private const int poolInitialSize = 512; //Field offset: 0x0
	private static Vector3 OUT_OF_SCREEN; //Field offset: 0x0
	private List<EffectObjectBase> pool; //Field offset: 0x8
	private List<EffectObjectBase> freeList; //Field offset: 0xC
	private List<EffectObjectBase> activeList; //Field offset: 0x10
	private string rootName; //Field offset: 0x14
	private Transform EffectRootTransform; //Field offset: 0x18
	private int refCount; //Field offset: 0x1C
	public AssetBundleLoadAllAssetOperationBase AssetData; //Field offset: 0x20

	public int ActiveObjectCount
	{
		 get { } //Length: 52
	}

	public List<EffectObjectBase> ActiveObjectList
	{
		 get { } //Length: 11
	}

	public int FreeObjectCount
	{
		 get { } //Length: 52
	}

	public List<EffectObjectBase> PoolObjectList
	{
		 get { } //Length: 11
	}

	public int PoolSize
	{
		 get { } //Length: 52
	}

	private static EffectPool() { }

	public EffectPool(string rootName) { }

	public void ForcedStopEffect() { }

	public int get_ActiveObjectCount() { }

	public List<EffectObjectBase> get_ActiveObjectList() { }

	public int get_FreeObjectCount() { }

	public List<EffectObjectBase> get_PoolObjectList() { }

	public int get_PoolSize() { }

	public void Initialize() { }

	public bool IsLoadedEffectAssetBundle() { }

	public void LoadEffectAssetBunde(string AssetBundleName) { }

	public void PauseEffect(bool enable) { }

	public void RefreshActiveEffect() { }

	public void RefreshFreeEffect() { }

	public void RefreshPool() { }

	public void ReleaseActiveModel(EffectObjectBase effect) { }

	public void ReleaseEffectAssetBunde(string AssetBundleName) { }

	public void ReleaseFreeModel(EffectObjectBase effect) { }

	public EffectObjectBase RequestFreeEffect(string effectPath, int effNo, EffectCategory category) { }

	public void Reserve(int size) { }

	public EffectObjectBase SearchEffect(GameObject obj, int effNo) { }

	public Transform SearchRootTransform() { }

}

